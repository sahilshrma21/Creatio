namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MatomoSyncVisitorsMessageSchema

	/// <exclude/>
	public class MatomoSyncVisitorsMessageSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MatomoSyncVisitorsMessageSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MatomoSyncVisitorsMessageSchema(MatomoSyncVisitorsMessageSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("72210611-e9cf-47ba-b0c3-465f09cb4cdd");
			Name = "MatomoSyncVisitorsMessage";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("992bffc1-0ec1-4459-b82e-3bbf78f3508e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,85,193,110,219,48,12,61,183,192,254,129,200,46,9,80,216,183,29,154,196,151,182,232,58,32,67,135,100,189,20,61,168,50,109,11,176,37,131,146,210,101,65,255,125,146,44,199,105,154,96,61,246,34,216,20,249,248,40,62,74,146,53,168,91,198,17,86,72,196,180,42,76,114,165,100,33,74,75,204,8,37,191,156,111,191,156,159,89,45,100,9,203,141,54,216,76,15,254,157,127,93,35,247,206,58,185,69,137,36,248,224,243,19,95,140,219,240,184,63,180,146,195,198,126,62,66,103,119,59,95,9,75,7,3,87,53,211,250,18,22,204,168,70,45,55,146,63,8,45,140,34,189,64,173,89,137,193,57,77,83,152,105,219,52,140,54,89,252,15,129,96,20,16,182,132,26,165,129,38,128,128,118,40,144,51,195,128,5,170,208,116,80,80,40,130,117,132,7,221,34,23,133,192,60,233,19,164,123,25,30,87,202,242,234,151,69,139,145,200,147,179,182,246,185,22,28,120,72,125,146,50,244,229,188,195,112,16,219,80,208,80,190,59,48,67,150,251,240,75,184,15,248,157,199,97,205,93,209,131,123,168,102,166,17,129,19,22,243,209,73,58,163,52,75,118,128,233,33,226,172,101,196,26,144,78,28,243,81,127,56,163,108,161,114,172,53,168,98,56,48,211,157,108,50,75,67,200,113,4,109,24,153,107,102,112,148,249,181,15,130,130,84,243,159,72,97,240,46,119,169,221,226,243,246,205,116,230,227,185,99,51,78,214,61,190,187,145,182,65,98,207,53,206,66,43,66,81,217,174,162,11,240,20,87,162,65,216,209,190,240,200,103,103,251,161,66,154,12,34,187,9,108,131,195,106,211,34,204,225,93,131,189,61,241,92,166,193,173,103,228,92,251,164,221,198,178,131,115,246,8,28,205,61,13,191,209,127,135,173,215,40,27,148,121,167,156,183,50,186,39,213,34,25,129,31,17,209,113,49,60,250,153,141,56,155,241,53,22,204,214,230,129,213,22,191,51,153,215,126,142,231,112,204,156,220,149,210,141,245,228,105,175,41,167,142,126,119,32,91,40,209,76,65,251,229,245,243,112,13,189,238,155,243,137,56,238,132,58,40,228,8,187,83,234,88,160,169,84,254,17,105,56,62,66,186,121,107,73,40,18,102,227,7,145,91,162,112,187,118,18,79,32,106,93,195,139,48,21,84,162,172,80,155,33,228,69,212,53,60,163,51,40,238,60,49,135,66,144,54,39,238,160,88,160,90,187,55,66,228,8,174,3,112,139,230,62,162,141,39,48,207,224,219,116,143,179,144,149,123,119,76,174,120,122,20,97,173,68,14,55,127,144,91,131,227,223,26,201,93,154,178,123,180,192,190,249,237,167,121,205,40,92,47,11,38,93,93,228,250,226,24,44,7,195,248,32,172,27,214,189,136,48,242,21,41,41,254,226,248,97,119,189,68,33,93,12,93,155,156,26,230,104,123,219,193,96,251,7,100,27,202,205,183,7,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateLogEventNameLocalizableString());
			LocalizableStrings.Add(CreateLogEventDescriptionLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateLogEventNameLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("c1d5437e-f888-dc21-3319-d6a9fbfb09e1"),
				Name = "LogEventName",
				CreatedInPackageId = new Guid("992bffc1-0ec1-4459-b82e-3bbf78f3508e"),
				CreatedInSchemaUId = new Guid("72210611-e9cf-47ba-b0c3-465f09cb4cdd"),
				ModifiedInSchemaUId = new Guid("72210611-e9cf-47ba-b0c3-465f09cb4cdd")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateLogEventDescriptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("9fe6ebe2-99ee-3a5c-c1c6-952230c33d0a"),
				Name = "LogEventDescription",
				CreatedInPackageId = new Guid("992bffc1-0ec1-4459-b82e-3bbf78f3508e"),
				CreatedInSchemaUId = new Guid("72210611-e9cf-47ba-b0c3-465f09cb4cdd"),
				ModifiedInSchemaUId = new Guid("72210611-e9cf-47ba-b0c3-465f09cb4cdd")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("72210611-e9cf-47ba-b0c3-465f09cb4cdd"));
		}

		#endregion

	}

	#endregion

}

