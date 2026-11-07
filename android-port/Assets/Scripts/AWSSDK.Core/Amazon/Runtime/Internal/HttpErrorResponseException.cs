using System;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal
{
	[Token(Token = "0x2000193")]
	public class HttpErrorResponseException : Exception
	{
		[Token(Token = "0x4000603")]
		[FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x27468", Offset = "0x27468")]
		private IWebResponseData Response__BackingField;

		[Token(Token = "0x1700033F")]
		public IWebResponseData Response
		{
			[Token(Token = "0x6000C6B")]
			[Address(RVA = "0x120F68C", Offset = "0x120F68C", VA = "0x120F68C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A9C4", Offset = "0x2A9C4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C6C")]
			[Address(RVA = "0x120F694", Offset = "0x120F694", VA = "0x120F694")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A9D4", Offset = "0x2A9D4")]
			private set
			{
			}
		}

		[Token(Token = "0x6000C6D")]
		[Address(RVA = "0x120F69C", Offset = "0x120F69C", VA = "0x120F69C")]
		public HttpErrorResponseException(IWebResponseData response)
		{
		}

		[Token(Token = "0x6000C6E")]
		[Address(RVA = "0x120F714", Offset = "0x120F714", VA = "0x120F714")]
		public HttpErrorResponseException(string message, IWebResponseData response)
		{
		}

		[Token(Token = "0x6000C6F")]
		[Address(RVA = "0x120F7A4", Offset = "0x120F7A4", VA = "0x120F7A4")]
		public HttpErrorResponseException(string message, Exception innerException, IWebResponseData response)
		{
		}
	}
}
