namespace CrtDigitalAdsApp.Models.Responses
{
	using System;

	/// <summary>
	/// Contains information on the ad campaign.
	/// </summary>
	public sealed class AdCampaignInfoResponse
	{

		#region Properties: Public

		/// <summary>
		/// Gets or sets the ad account identifier.
		/// </summary>
		public Guid AdAccountId { get; set; }

		/// <summary>
		/// Ad campaign identifier
		/// </summary>
		public string Id { get; set; }

		/// <summary>
		/// Ad campaign name
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// The id of external platform
		/// </summary>
		public Guid PlatformId { get; set; }

		/// <summary>
		/// Ad campaign status
		/// </summary>
		public string Status { get; set; }

		#endregion

	}
}