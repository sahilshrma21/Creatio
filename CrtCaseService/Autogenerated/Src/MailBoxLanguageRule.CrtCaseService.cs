﻿namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities;

	#region Class: MailBoxLanguageRule

	/// <summary>
	/// Provides language from support mailboxes, that are included into case recipients.
	/// </summary>
	public class MailBoxLanguageRule : BaseLanguageRule
	{
		#region Constants: Private

		private const string CaseSchemaName = "Case";
		private const string ActivitySchemaName = "Activity";
		private const string ParentActivityColumnName = "ParentActivity.Id";
		private const string RecipientColumnName = "Recepient";
		private const string CopyRecipientColumnName = "CopyRecepient";
		private const string MailBoxForIncidentRegistrationSchemaName = "MailboxForIncidentRegistration";
		private const string MailBoxLanguageColumnName = "MailboxSyncSettings.MessageLanguage.Id";
		private const string SenderEmailAddressColumnName = "MailboxSyncSettings.SenderEmailAddress";

		#endregion

		#region Properties: Protected

		protected Dictionary<string, string> AlliasColumnMap {
			get;
		}

		#endregion

		#region Constructors: Public

		/// <summary>
		/// Creates instance of <see cref="MailBoxLanguageRule"/>.
		/// </summary>
		/// <param name="userConnection">User connection.</param>
		public MailBoxLanguageRule(UserConnection userConnection)
			:base(userConnection) {
			AlliasColumnMap = new Dictionary<string, string>();
		}

		#endregion

		#region Methods: Private

		private void AddColumns(EntitySchemaQuery esq, IEnumerable<string> columns) {
			foreach (string column in columns) {
				AlliasColumnMap[column] = esq.AddColumn(column).Name;
			}
		}

		private string[] GetActivityRecipients(Guid caseEntityRecordId) {
			Guid parentActivityId = GetParentActivityId(caseEntityRecordId);
			if (parentActivityId == Guid.Empty) {
				return null;
			}
			if (TryGetActivityEntity(parentActivityId, out var activityEntity)) {
				string recipient = activityEntity.GetTypedColumnValue<string>(RecipientColumnName);
				string copyRecepient = activityEntity.GetTypedColumnValue<string>(CopyRecipientColumnName);
				string[] recipients = string.Join(";", recipient, copyRecepient).ParseEmailAddress().ToArray();
				return recipients;
			}
			return null;
		}

		private Guid GetParentActivityId(Guid caseEntityRecordId) {
			EntitySchemaQuery esq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, CaseSchemaName);
			esq.UseAdminRights = false;
			AddColumns(esq, new[] { ParentActivityColumnName });
			Entity parentActivity = esq.GetEntity(UserConnection, caseEntityRecordId);
			Guid parentActivityId = parentActivity.GetTypedColumnValue<Guid>(AlliasColumnMap[ParentActivityColumnName]);
			return parentActivityId;
		}

		private bool TryGetActivityEntity(Guid activityId, out Entity activityEntity) {
			EntitySchema activitySchema = UserConnection.EntitySchemaManager.FindInstanceByName(ActivitySchemaName);
			activityEntity = activitySchema.CreateEntity(UserConnection);
			activityEntity.UseAdminRights = false;
			return activityEntity.FetchFromDB(activityId);
		}

		private EntityCollection GetIncidentRegistrationEmails(string[] recipients) {
			EntitySchemaQuery esq = new EntitySchemaQuery(UserConnection.EntitySchemaManager,
				MailBoxForIncidentRegistrationSchemaName);
			AddColumns(esq, new[] { MailBoxLanguageColumnName });
			esq.Filters.Add(esq.CreateFilterWithParameters(FilterComparisonType.Equal, SenderEmailAddressColumnName,
				recipients.Cast<object>()));
			return esq.GetEntityCollection(UserConnection);
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Provides language identifier from mailboxes for incident registration.
		/// </summary>
		/// <param name="caseEntityRecordId">Case entity identifier.</param>
		/// <inheritdoc />
		public override Guid GetLanguageId(Guid caseEntityRecordId) {
			string[] recipients = GetActivityRecipients(caseEntityRecordId);
			if (recipients?.Length > 0) {
				var mailboxCollection = GetIncidentRegistrationEmails(recipients);
				foreach (Entity mailBox in mailboxCollection) {
					var mailboxLanguageId = 
						mailBox.GetTypedColumnValue<Guid>(AlliasColumnMap[MailBoxLanguageColumnName]);
					if (mailboxLanguageId != Guid.Empty) {
						return mailboxLanguageId;
					}
				}
			}
			return Guid.Empty;
		}

		#endregion

	}

	#endregion

}

