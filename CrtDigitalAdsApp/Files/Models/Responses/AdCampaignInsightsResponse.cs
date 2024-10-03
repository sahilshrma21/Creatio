namespace CrtDigitalAdsApp.Models.Responses
{
	using System;

	/// <summary>
	/// Model of ad campaign insights.
	/// </summary>
	public sealed class AdCampaignInsightsResponse
	{

		#region Properties: Public

		/// <summary>
		/// Campaign identifier.
		/// </summary>
		public string CampaignId { get; set; }

		/// <summary>
		/// Campaign name.
		/// </summary>
		public string CampaignName { get; set; }

		/// <summary>
		/// Amount of clicks.
		/// </summary>
		public int Clicks { get; set; }

		/// <summary>
		/// The average cost for each click.
		/// </summary>
		public double Cpc { get; set; }

		/// <summary>
		/// The average cost for 1,000 impressions.
		/// </summary>
		public double Cpm { get; set; }

		/// <summary>
		/// Date of campaign creation.
		/// </summary>
		public DateTime CreatedDate { get; set; }

		/// <summary>
		/// The percentage of times people saw an ad and performed a click.
		/// </summary>
		public double Ctr { get; set; }

		/// <summary>
		/// Currency that is used by ad account.
		/// </summary>
		public string Currency { get; set; }

		/// <summary>
		/// Date, when campaign was paused.
		/// </summary>
		public DateTime EndDate { get; set; }

		/// <summary>
		/// The average number of times each person saw an ad.
		/// </summary>
		public double Frequency { get; set; }

		/// <summary>
		/// The number of times ads were on screen.
		/// </summary>
		public int Impressions { get; set; }

		/// <summary>
		/// Last time when campaign was synced.
		/// </summary>
		public DateTime LastSync { get; set; }

		/// <summary>
		/// The number of people who saw ads at least once.
		/// </summary>
		public double Reach { get; set; }

		/// <summary>
		/// The estimated total amount of money spent on campaign.
		/// </summary>
		public double Spend { get; set; }

		/// <summary>
		/// Date, when campaign was started.
		/// </summary>
		public DateTime StartDate { get; set; }

		#endregion

	}
}