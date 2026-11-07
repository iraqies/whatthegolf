using System;
using System.Net;
using Il2CppDummyDll;

namespace Amazon.SecurityToken.SAML
{
	[Token(Token = "0x2000014")]
	public class SAMLAuthenticationController
	{
		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x30A8C", Offset = "0x30A8C")]
		private IAuthenticationController AuthenticationController__BackingField;

		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x30A9C", Offset = "0x30A9C")]
		private IAuthenticationResponseParser ResponseParser__BackingField;

		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x30AAC", Offset = "0x30AAC")]
		private IWebProxy ProxySettings__BackingField;

		[Token(Token = "0x1700000A")]
		public IAuthenticationController AuthenticationController
		{
			[Token(Token = "0x6000071")]
			[Address(RVA = "0x12E4FCC", Offset = "0x12E4FCC", VA = "0x12E4FCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x30B2C", Offset = "0x30B2C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000072")]
			[Address(RVA = "0x12E4FD4", Offset = "0x12E4FD4", VA = "0x12E4FD4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x30B3C", Offset = "0x30B3C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000B")]
		public IAuthenticationResponseParser ResponseParser
		{
			[Token(Token = "0x6000073")]
			[Address(RVA = "0x12E4FDC", Offset = "0x12E4FDC", VA = "0x12E4FDC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x30B4C", Offset = "0x30B4C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000074")]
			[Address(RVA = "0x12E4FE4", Offset = "0x12E4FE4", VA = "0x12E4FE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x30B5C", Offset = "0x30B5C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000C")]
		public IWebProxy ProxySettings
		{
			[Token(Token = "0x6000075")]
			[Address(RVA = "0x12E4FEC", Offset = "0x12E4FEC", VA = "0x12E4FEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x30B6C", Offset = "0x30B6C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000076")]
			[Address(RVA = "0x12E4FF4", Offset = "0x12E4FF4", VA = "0x12E4FF4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x30B7C", Offset = "0x30B7C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x12E4FFC", Offset = "0x12E4FFC", VA = "0x12E4FFC")]
		public SAMLAuthenticationController()
		{
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x12D0728", Offset = "0x12D0728", VA = "0x12D0728")]
		public SAMLAuthenticationController(IWebProxy proxySettings)
		{
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x12E5094", Offset = "0x12E5094", VA = "0x12E5094")]
		public SAMLAuthenticationController(IAuthenticationController authenticationController, IAuthenticationResponseParser responseParser, IWebProxy proxySettings)
		{
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x12D07CC", Offset = "0x12D07CC", VA = "0x12D07CC")]
		public SAMLAssertion GetSAMLAssertion(string identityProviderUrl, ICredentials credentials, string authenticationType)
		{
			return null;
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x12E5144", Offset = "0x12E5144", VA = "0x12E5144")]
		public SAMLAssertion GetSAMLAssertion(Uri identityProviderUrl, ICredentials credentials, string authenticationType)
		{
			return null;
		}
	}
}
