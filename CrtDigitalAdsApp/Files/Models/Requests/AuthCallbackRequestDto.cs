namespace CrtDigitalAdsApp.Models.Requests
{
	using System.Runtime.Serialization;

	/// <summary>
	/// Data transfer object which contains information about a callback
	/// </summary>
	[DataContract]
	public class AuthCallbackRequestDto
	{

		#region Properties: Public

		/// <summary>
		/// Application name
		/// </summary>
		[DataMember(Name = "application")]//digital_ads
		public string Application { get; set; }

		/// <summary>
		/// Platform name
		/// </summary>
		[DataMember(Name = "platform")] //facebook
		public string Platform { get; set; }

		/// <summary>
		/// Platform user identifier
		/// </summary>
		[DataMember(Name = "platformUserId")] //237846520394875
		public string PlatformUserId { get; set; }

		/// <summary>
		/// Status of operation
		/// </summary>
		[DataMember(Name = "status")] //OK
		public string Status { get; set; }

		#endregion

	}
}