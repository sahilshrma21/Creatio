namespace CrtDigitalAdsApp.Utilities
{
	using CrtDigitalAdsApp.Dto;
	using CrtDigitalAdsApp.Utilities.Errors;
	using Newtonsoft.Json;
	using Terrasoft.Common.Json;
	using Terrasoft.Core;
	using Terrasoft.Core.Factories;

	/// <summary>
	/// Interface for the notification on UI.
	/// </summary>
	public interface IUINotifier
	{

		#region Methods: Public

		/// <summary>
		/// Send notification with the specified command and description.
		/// </summary>
		/// <param name="commandName">Name of the command.</param>
		/// <param name="description">The description.</param>
		/// <param name="senderName">Name of the sender.</param>
		/// <param name="platform">Ad platform name</param>
		/// <param name="websocketSessionId">The websocket session identifier.</param>
		void Notify(string commandName, string platform = "", string description = "", string senderName = "CrtDigitalAdsApp", 
			string websocketSessionId = "");

		/// <summary>
		/// Reports the error.
		/// </summary>
		/// <param name="error">The error.</param>
		/// <param name="senderName">Name of the sender.</param>
		/// <param name="websocketSessionId">The websocket session identifier.</param>
		void ReportError(IError error, string senderName = "CrtDigitalAdsApp", string websocketSessionId = "");

		#endregion

	}

	/// <summary>
	/// Represents the implementation of UI notifier.
	/// </summary>
	/// <seealso cref="CrtDigitalAdsApp.Utilities.IUINotifier" />
	[DefaultBinding(typeof(IUINotifier))]
	public class UINotifier : IUINotifier
	{

		#region Constants: Private

		private const string DefaultSenderName = "CrtDigitalAdsApp";

		#endregion

		#region Fields: Private

		private readonly IMsgChannelUtilities _msgChannelUtilities;
		private readonly UserConnection _userConnection;

		#endregion

		#region Constructors: Public

		/// <summary>
		/// Initializes a new instance of the <see cref="UINotifier"/> class.
		/// </summary>
		public UINotifier() {
			_msgChannelUtilities = ClassFactory.Get<IMsgChannelUtilities>();
			_userConnection = ClassFactory.Get<UserConnection>();
		}

		#endregion

		#region Methods: Private

		/// <summary>
		/// Posts the message.
		/// </summary>
		/// <param name="webSocketDto">The web socket dto.</param>
		/// <param name="senderName">Name of the sender.</param>
		private void PostMessage(WebSocketDto webSocketDto, string senderName = DefaultSenderName) {
			_msgChannelUtilities.PostMessage(
				_userConnection, senderName,
				Json.FormatJsonString(Json.Serialize(webSocketDto), Formatting.Indented)
			);
		}

		#endregion

		#region Methods: Public

		/// <inheritdoc cref="IUINotifier.Notify"/>
		public void Notify(string commandName, string platform = "", string description = "", string senderName = DefaultSenderName, 
			string websocketSessionId = "") {
			var webSocketDto = new WebSocketDto {
				IsSuccess = true,
				Command = commandName,
				Description = description,
				Platform = platform,
				WebsocketSessionId = websocketSessionId
			};
			PostMessage(webSocketDto, senderName);
		}

		/// <inheritdoc cref="IUINotifier.ReportError"/>
		public void ReportError(IError error, string senderName = DefaultSenderName, string websocketSessionId = "") {
			var translation = new ErrorToNotificationTranslator(_userConnection);
			var webSocketDto = translation.TranslateError(error);
			webSocketDto.WebsocketSessionId = websocketSessionId;
			PostMessage(webSocketDto, senderName);
		}

		#endregion

	}
}