namespace CrtDigitalAdsApp.Providers
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Net.Http;
	using System.Net.Http.Headers;
	using System.Threading.Tasks;
	using Common.Logging;
	using CrtDigitalAdsApp.Models.Requests;
	using CrtDigitalAdsApp.Models.Responses;
	using CrtDigitalAdsApp.Providers.Responses;
	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using Terrasoft.Core;
	using Terrasoft.Core.Factories;
	using Terrasoft.OAuthIntegration;
	using SysSettings = Terrasoft.Core.Configuration.SysSettings;

	/// <inheritdoc cref="IDigitalAdsAdAccountsProvider"/>
	[DefaultBinding(typeof(IDigitalAdsAdAccountsProvider))]
	public class DigitalAdsAdAccountsProvider : IDigitalAdsAdAccountsProvider
	{

		#region Constants: Private

		private const string DigitalAdsAdAccountsProviderRequestExceptionTemplate =
			"DigitalAdsAdAccountsProvider. Send request failed. " +
			"RequestUri: {0}, ResponseStatusCode: {1}, " +
			"ResponseContent: {2}, Exception: {3}";

		private const string GetAdAccountsUrl = "api/digitalads/getAdAccounts";
		private const string GetCampaignDailyInsights = "api/digitalads/getCampaignDailyInsights";
		private const string GetCampaignInsights = "api/digitalads/getCampaignInsights";
		private const string GetCampaignsInfosUrl = "api/digitalads/getCampaignsInfos";
		private const string Scopes = "digital_ads.service.full_access";
		private const string SmPlatformUrlSysSettingCode = "SocialPlatformServiceUrl";

		#endregion

		#region Fields: Private

		private HttpClient _httpClient;
		private ILog _logger;

		private readonly string[] _errorReasons =
			{ "UnknownError", "AppNotInstalled", "NotEnoughPermissions", "Unauthenticated" };

		#endregion

		#region Constructors: Public

		/// <summary>
		/// Creates instance of <see cref="DigitalAdsAdAccountsProvider"/>
		/// </summary>
		/// <param name="userConnection">User connection</param>
		public DigitalAdsAdAccountsProvider(UserConnection userConnection) {
			var platformServiceUrl = SysSettings.GetValue(userConnection, SmPlatformUrlSysSettingCode);
			var baseAddress = new Uri(platformServiceUrl.ToString());
			HttpClient = new HttpClient {
				BaseAddress = baseAddress
			};
		}

		#endregion

		#region Properties: Private

		private ILog Logger => _logger ?? (_logger = LogManager.GetLogger(nameof(DigitalAdsAdAccountsProvider)));

		#endregion

		#region Properties: Public

		/// <summary>
		/// Provides a base class for sending HTTP requests and receiving HTTP responses from a resource identified by a URI.
		/// </summary>
		public HttpClient HttpClient {
			get => _httpClient ?? (_httpClient = new HttpClient());
			set => _httpClient = value;
		}

		#endregion

		#region Methods: Private

		private static string GetAccessToken() {
			var identityServiceWrapper = GlobalAppSettings.FeatureUseSeparateSettingsForOAuth20
				? ClassFactory.Get<IIdentityServiceWrapper>("ExternalAccess")
				: ClassFactory.Get<IIdentityServiceWrapper>();
			var token = identityServiceWrapper.GetAccessToken(Scopes);
			return token;
		}

		private static HttpRequestMessage GetHttpRequestMessage(BaseDigitalAdsRequest request, string requestUrl) {
			var token = GetAccessToken();
			var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUrl);
			httpRequestMessage.Content = new StringContent(JsonConvert.SerializeObject(request));
			httpRequestMessage.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
			httpRequestMessage.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
			return httpRequestMessage;
		}

		private void LogError(string messageTemplate, HttpRequestMessage httpRequestMessage,
			HttpResponseMessage httpResponseMessage, Exception exception = default) {
			Logger.Error(string.Format(messageTemplate, httpRequestMessage.RequestUri, httpResponseMessage.StatusCode,
				httpResponseMessage.Content, exception));
		}

		private async Task<string> SendRequest(HttpRequestMessage httpRequestMessage) {
			HttpResponseMessage response = null;
			try {
				response = await HttpClient.SendAsync(httpRequestMessage);
				if (!response.IsSuccessStatusCode) {
					var errorContent = await response.Content.ReadAsStringAsync();
					var error = JsonConvert.DeserializeObject<AdPlatformErrorResponse>(errorContent);
					if (_errorReasons.Contains(error.Reason)) {
						LogError(DigitalAdsAdAccountsProviderRequestExceptionTemplate, httpRequestMessage, response);
						return string.Empty;
					}
				}
				var content = await response.Content.ReadAsStringAsync();
				return content;
			} catch (Exception e) {
				LogError(DigitalAdsAdAccountsProviderRequestExceptionTemplate, httpRequestMessage, response, e);
				return string.Empty;
			}
		}

		#endregion

		#region Methods: Public

		/// <inheritdoc cref="IDigitalAdsAdAccountsProvider.GetAdAccounts"/>
		public async Task<List<AdAccountResponse>> GetAdAccounts(GetAdAccountsRequest getAdAccountsRequest) {
			try {
				var httpRequestMessage = GetHttpRequestMessage(getAdAccountsRequest, GetAdAccountsUrl);
				var content = await SendRequest(httpRequestMessage);
				var adAccounts = JsonConvert.DeserializeObject<List<AdAccountResponse>>(content);
				return adAccounts ?? new List<AdAccountResponse>();
			} catch (Exception e) {
				Logger.Error("DigitalAdsAdAccountsProvider_GetAdAccounts. Something went wrong while processing the request", e);
				return new List<AdAccountResponse>();
			}
			
		}

		/// <inheritdoc cref="IDigitalAdsAdAccountsProvider.GetCampaignsDailyInsights"/>
		public async Task<IEnumerable<AdCampaignDailyInsightsResponse>> GetCampaignsDailyInsights(
			GetAdCampaignsDailyInsightsRequest campaignsDailyInsightRequest) {
			try {
				var httpRequestMessage = GetHttpRequestMessage(campaignsDailyInsightRequest, GetCampaignDailyInsights);
				var content = await SendRequest(httpRequestMessage);
				var result = JsonConvert.DeserializeObject<IEnumerable<AdCampaignDailyInsightsResponse>>(content);
				return result ?? new List<AdCampaignDailyInsightsResponse>();
			} catch (Exception e) {
				Logger.Error("DigitalAdsAdAccountsProvider_GetCampaignsDailyInsights. " +
				             "Something went wrong while processing the request", e);
				return new List<AdCampaignDailyInsightsResponse>();
			}
			
		}

		/// <inheritdoc cref="IDigitalAdsAdAccountsProvider.GetCampaignsInfos"/>
		public async Task<List<AdCampaignInfoResponse>> GetCampaignsInfos(
			GetAdCampaignsInfosRequest getAdCampaignsInfosRequest) {
			try {
				var httpRequestMessage = GetHttpRequestMessage(getAdCampaignsInfosRequest, GetCampaignsInfosUrl);
				var content = await SendRequest(httpRequestMessage);
				var adCampaignInfo = JsonConvert.DeserializeObject<List<AdCampaignInfoResponse>>(content);
				return adCampaignInfo ?? new List<AdCampaignInfoResponse>();
			} catch (Exception e) {
				Logger.Error("DigitalAdsAdAccountsProvider_GetCampaignsInfos. " +
				             "Something went wrong while processing the request", e);
				return new List<AdCampaignInfoResponse>();
			}
			
		}

		/// <inheritdoc cref="IDigitalAdsAdAccountsProvider.GetCampaignsInsight"/>
		public async Task<AdCampaignInsightsResponse> GetCampaignsInsight(
			GetAdCampaignsInsightsRequest getAdCampaignsInsightsRequest) {
			try {
				var httpRequestMessage = GetHttpRequestMessage(getAdCampaignsInsightsRequest, GetCampaignInsights);
				var content = await SendRequest(httpRequestMessage);
				JObject jsonObject = JsonConvert.DeserializeObject<JObject>(content);
				if (jsonObject == null || !jsonObject.HasValues) {
					return null;
				}
				var adCampaignInsights = jsonObject.ToObject<AdCampaignInsightsResponse>();
				return adCampaignInsights;
			} catch (Exception e) {
				Logger.Error("DigitalAdsAdAccountsProvider_GetCampaignsInsight. " +
				            "Something went wrong while processing the request", e);
				return new AdCampaignInsightsResponse();
			}
		}

		#endregion

	}
}