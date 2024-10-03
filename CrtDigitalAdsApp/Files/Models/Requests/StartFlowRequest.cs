namespace CrtDigitalAdsApp.Models.Requests
{
	using System;

	/// <summary>
	/// Represents a request to start the authentication flow.
	/// </summary>
	public class StartFlowRequest : BaseRequest
	{

		#region Properties: Public

		/// <summary>
		/// The end user identifier.
		/// </summary>
		public Guid CreatioUserId { get; set; }

		#endregion

	}
}