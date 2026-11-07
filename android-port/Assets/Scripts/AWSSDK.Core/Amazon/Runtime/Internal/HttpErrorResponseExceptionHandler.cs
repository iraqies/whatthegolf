using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal
{
	[Token(Token = "0x2000180")]
	public class HttpErrorResponseExceptionHandler : ExceptionHandler<HttpErrorResponseException>
	{
		[Token(Token = "0x6000C11")]
		[Address(RVA = "0x1200AB0", Offset = "0x1200AB0", VA = "0x1200AB0")]
		public HttpErrorResponseExceptionHandler(ILogger logger)
		{
		}

		[Token(Token = "0x6000C12")]
		[Address(RVA = "0x120F844", Offset = "0x120F844", VA = "0x120F844", Slot = "6")]
		public override bool HandleException(IExecutionContext executionContext, HttpErrorResponseException exception)
		{
			return default;
		}

		[Token(Token = "0x6000C13")]
		[Address(RVA = "0x1210084", Offset = "0x1210084", VA = "0x1210084")]
		private bool HandleSuppressed404(IExecutionContext executionContext, IWebResponseData httpErrorResponse)
		{
			return default;
		}
	}
}
