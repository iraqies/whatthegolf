using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.Runtime.Internal
{
	public class HttpErrorResponseExceptionHandler : ExceptionHandler<HttpErrorResponseException>
	{
		public HttpErrorResponseExceptionHandler(ILogger logger)
			: base((ILogger)null)
		{
		}

		public override bool HandleException(IExecutionContext executionContext, HttpErrorResponseException exception)
		{
			return false;
		}

		private bool HandleSuppressed404(IExecutionContext executionContext, IWebResponseData httpErrorResponse)
		{
			return false;
		}
	}
}
