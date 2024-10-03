namespace CrtDigitalAdsApp.Utilities.Errors
{
	
	public abstract class GenericError : IError
	{
		protected GenericError(string errorCode, string description) {
			ErrorCode = errorCode;
			Description = description;
		}
		public string ErrorCode { get; private set; }
		public string Description { get; private set; }
	}
	
	public class GenericErrorOne : GenericError
	{
		public GenericErrorOne(string errorCode, string description) :base(errorCode, description) {
		}
	}
}