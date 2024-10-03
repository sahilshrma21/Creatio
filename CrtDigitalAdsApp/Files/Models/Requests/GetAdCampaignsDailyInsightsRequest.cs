namespace CrtDigitalAdsApp.Models.Requests
{
	using System;
	using System.Runtime.Serialization;
	using Newtonsoft.Json;

	public class GetAdCampaignsDailyInsightsRequest : BaseDigitalAdsRequest
	{

		#region Properties: Public

		/// <summary>
		/// Ad account identifier
		/// </summary>
		[JsonProperty("adAccountId")]
		[DataMember(Name = "adAccountId")]
		public string AdAccountId { get; set; }

		/// <summary>
		/// Ad campaign identifier.
		/// </summary>
		[DataMember(Name = "adCampaignId")]
		[JsonProperty("adCampaignId")]
		public string AdCampaignId { get; set; }

		/// <summary>
		/// Date from which daily insights will be requested.
		/// </summary>
		[DataMember(Name = "dateFrom")]
		[JsonProperty("dateFrom")]
		public DateTime DateFrom { get; set; }

		/// <summary>
		/// Date till which daily insights will be requested.
		/// </summary>
		[DataMember(Name = "dateTo")]
		[JsonProperty("dateTo")]
		public DateTime DateTo { get; set; }

		#endregion

	}
}