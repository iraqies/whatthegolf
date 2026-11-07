using System;
using System.Net;
using Il2CppDummyDll;

namespace Amazon.Runtime
{
	[Token(Token = "0x200009C")]
	public class AmazonServiceException : Exception
	{
		[Token(Token = "0x40002B3")]
		[FieldOffset(Offset = "0x88")]
		private ErrorType errorType;

		[Token(Token = "0x40002B4")]
		[FieldOffset(Offset = "0x90")]
		private string errorCode;

		[Token(Token = "0x40002B5")]
		[FieldOffset(Offset = "0x98")]
		private string requestId;

		[Token(Token = "0x40002B6")]
		[FieldOffset(Offset = "0xA0")]
		private HttpStatusCode statusCode;

		[Token(Token = "0x17000166")]
		public ErrorType ErrorType
		{
			[Token(Token = "0x60005C1")]
			[Address(RVA = "0x11CD31C", Offset = "0x11CD31C", VA = "0x11CD31C")]
			get
			{
				return default;
			}
			[Token(Token = "0x60005C2")]
			[Address(RVA = "0x11CD324", Offset = "0x11CD324", VA = "0x11CD324")]
			set
			{
			}
		}

		[Token(Token = "0x17000167")]
		public string ErrorCode
		{
			[Token(Token = "0x60005C3")]
			[Address(RVA = "0x11CD32C", Offset = "0x11CD32C", VA = "0x11CD32C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005C4")]
			[Address(RVA = "0x11CD334", Offset = "0x11CD334", VA = "0x11CD334")]
			set
			{
			}
		}

		[Token(Token = "0x17000168")]
		public string RequestId
		{
			[Token(Token = "0x60005C5")]
			[Address(RVA = "0x11CD33C", Offset = "0x11CD33C", VA = "0x11CD33C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005C6")]
			[Address(RVA = "0x11CD344", Offset = "0x11CD344", VA = "0x11CD344")]
			set
			{
			}
		}

		[Token(Token = "0x17000169")]
		public HttpStatusCode StatusCode
		{
			[Token(Token = "0x60005C7")]
			[Address(RVA = "0x11CD34C", Offset = "0x11CD34C", VA = "0x11CD34C")]
			get
			{
				return default;
			}
			[Token(Token = "0x60005C8")]
			[Address(RVA = "0x11CD354", Offset = "0x11CD354", VA = "0x11CD354")]
			set
			{
			}
		}

		[Token(Token = "0x1700016A")]
		public virtual RetryableDetails Retryable
		{
			[Token(Token = "0x60005C9")]
			[Address(RVA = "0x11CD35C", Offset = "0x11CD35C", VA = "0x11CD35C", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x11CCEDC", Offset = "0x11CCEDC", VA = "0x11CCEDC")]
		public AmazonServiceException()
		{
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x11B2A8C", Offset = "0x11B2A8C", VA = "0x11B2A8C")]
		public AmazonServiceException(string message)
		{
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x11C2A8C", Offset = "0x11C2A8C", VA = "0x11C2A8C")]
		public AmazonServiceException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x11CCF58", Offset = "0x11CCF58", VA = "0x11CCF58")]
		public AmazonServiceException(string message, Exception innerException, HttpStatusCode statusCode)
		{
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x11CCFF8", Offset = "0x11CCFF8", VA = "0x11CCFF8")]
		public AmazonServiceException(Exception innerException)
		{
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x11CD088", Offset = "0x11CD088", VA = "0x11CD088")]
		public AmazonServiceException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x11CD238", Offset = "0x11CD238", VA = "0x11CD238")]
		public AmazonServiceException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
		{
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x11CD164", Offset = "0x11CD164", VA = "0x11CD164")]
		private static string BuildGenericErrorMessage(string errorCode, HttpStatusCode statusCode)
		{
			return null;
		}
	}
}
