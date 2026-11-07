using System;
using Il2CppDummyDll;

namespace Amazon.SecurityToken.SAML
{
	[Token(Token = "0x200000F")]
	public class AdfsAuthenticationControllerException : Exception
	{
		[Token(Token = "0x6000061")]
		[Address(RVA = "0x12CFEFC", Offset = "0x12CFEFC", VA = "0x12CFEFC")]
		public AdfsAuthenticationControllerException(string message)
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x12CFE50", Offset = "0x12CFE50", VA = "0x12CFE50")]
		public AdfsAuthenticationControllerException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x12CFF88", Offset = "0x12CFF88", VA = "0x12CFF88")]
		public AdfsAuthenticationControllerException(Exception innerException)
		{
		}
	}
}
