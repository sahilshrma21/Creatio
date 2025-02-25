namespace CrtDigitalAdsApp.Models.Requests
{
	using System.Runtime.Serialization;
	using Newtonsoft.Json;

	/// <summary>
	/// Model of request, which contains properties for
	/// retrieving ad accounts from Creatio
	/// </summary>
    [DataContract]
	public class GetAdAccountsFromCreatioRequest
    {

        #region Properties: Public

        /// <summary>
        /// Ad platform name
        /// </summary>
        [DataMember(Name = "platform")]
		[JsonProperty("platform")]
		public string PlatformName { get; set; }

        #endregion

    }
}