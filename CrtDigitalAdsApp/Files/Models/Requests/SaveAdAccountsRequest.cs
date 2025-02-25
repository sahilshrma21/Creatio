namespace CrtDigitalAdsApp.Models.Requests
{
	using System.Runtime.Serialization;
	using Newtonsoft.Json;

	/// <summary>
	/// Model of request, which contains properties for
	/// saving ad accounts
	/// </summary>
	[DataContract]
	public class SaveAdAccountsRequest
	{

		#region Properties: Public

		/// <summary>
		/// Ad platform name
		/// </summary>
		[DataMember(Name = "platform")]
		[JsonProperty("platform")]
		public string PlatformName { get; set; }

		/// <summary>
		/// Virtual ad accounts which were
		/// selected in Select ad accounts window
		/// </summary>
		[DataMember(Name = "virtualAdAccountsIdentifiers")]
		[JsonProperty("virtualAdAccountsIdentifiers")]
		public string[] VirtualAdAccountsIdentifiers { get; set; }

		/// <summary>
		/// Gets or sets the websocket session identifier.
		/// </summary>
		[DataMember(Name = "websocketSessionId")]
		[JsonProperty("websocketSessionId")]
		public string WebsocketSessionId { get; set; }

		#endregion

	}
}