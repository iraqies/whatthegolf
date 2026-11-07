using System;
using System.Net;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Util
{
	[Token(Token = "0x200020C")]
	public class WebProxy : IWebProxy
	{
		[Token(Token = "0x40007B4")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x27B68", Offset = "0x27B68")]
		private Uri ProxyUri__BackingField;

		[Token(Token = "0x40007B5")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x27B78", Offset = "0x27B78")]
		private ICredentials Credentials__BackingField;

		[Token(Token = "0x17000401")]
		public Uri ProxyUri
		{
			[Token(Token = "0x6000FFC")]
			[Address(RVA = "0x1281B10", Offset = "0x1281B10", VA = "0x1281B10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BCB0", Offset = "0x2BCB0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000FFD")]
			[Address(RVA = "0x1281B18", Offset = "0x1281B18", VA = "0x1281B18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BCC0", Offset = "0x2BCC0")]
			set
			{
			}
		}

		[Token(Token = "0x17000402")]
		public ICredentials Credentials
		{
			[Token(Token = "0x6000FFE")]
			[Address(RVA = "0x1281B20", Offset = "0x1281B20", VA = "0x1281B20", Slot = "6")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BCD0", Offset = "0x2BCD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000FFF")]
			[Address(RVA = "0x1281B28", Offset = "0x1281B28", VA = "0x1281B28", Slot = "7")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BCE0", Offset = "0x2BCE0")]
			set
			{
			}
		}

		[Token(Token = "0x6000FF9")]
		[Address(RVA = "0x1281990", Offset = "0x1281990", VA = "0x1281990")]
		public WebProxy(string proxyUri)
		{
		}

		[Token(Token = "0x6000FFA")]
		[Address(RVA = "0x1281A08", Offset = "0x1281A08", VA = "0x1281A08")]
		public WebProxy(Uri proxyUri)
		{
		}

		[Token(Token = "0x6000FFB")]
		[Address(RVA = "0x1281A34", Offset = "0x1281A34", VA = "0x1281A34")]
		public WebProxy(string proxyHost, int proxyPort)
		{
		}

		[Token(Token = "0x6001000")]
		[Address(RVA = "0x1281B30", Offset = "0x1281B30", VA = "0x1281B30", Slot = "4")]
		public Uri GetProxy(Uri destination)
		{
			return null;
		}

		[Token(Token = "0x6001001")]
		[Address(RVA = "0x1281B38", Offset = "0x1281B38", VA = "0x1281B38", Slot = "5")]
		public bool IsBypassed(Uri host)
		{
			return default;
		}
	}
}
