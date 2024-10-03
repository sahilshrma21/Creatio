namespace Terrasoft.Configuration
{
	using Terrasoft.Core;
	using Terrasoft.Core.Factories;

	#region Class: MatomoTrackingWebhookEventHandler

	/// <summary>
	/// Class to represent matomo tracking webhook event handler.
	/// </summary>
	[TrackingWebhookEventHandler]
	public class MatomoTrackingWebhookEventHandler : BaseTrackingWebhookEventHandler
	{

		#region Methods: Public

		/// <inheritdoc/>
		protected override void InternalHandle(UserConnection userConnection,
				TrackingImportByWebhookMessage sourceMessage) {
			var message = new MatomoTrackingImportByWebhookMessage(sourceMessage);
			var queueManager = ClassFactory.Get<TouchQueueManager>(
				new ConstructorArgument("userConnection", userConnection)
			);
			queueManager.Enqueue(new TouchQueueMessage[] { message });
		}

		#endregion

	}

	#endregion

}


