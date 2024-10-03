namespace CrtDigitalAdsApp.Models.Responses
{
	using System;

	public class AdCampaignDailyInsightsResponse
	{
		#region Properties: Public

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
		public DateTime Date { get; set; }

		/// <summary>
		/// The percentage of times people saw an ad and performed a click.
		/// </summary>
		public double Ctr { get; set; }

		/// <summary>
		/// The average number of times each person saw an ad.
		/// </summary>
		public double Frequency { get; set; }

		/// <summary>
		/// The number of times ads were on screen.
		/// </summary>
		public int Impressions { get; set; }

		/// <summary>
		/// The number of people who saw ads at least once.
		/// </summary>
		public double Reach { get; set; }

		/// <summary>
		/// The estimated total amount of money spent on campaign.
		/// </summary>
		public double Spend { get; set; }

		#endregion
	}
}