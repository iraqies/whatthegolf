using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x200007A")]
	public class ContextDataType
	{
		[Token(Token = "0x4000136")]
		[FieldOffset(Offset = "0x10")]
		private string _encodedData;

		[Token(Token = "0x4000137")]
		[FieldOffset(Offset = "0x18")]
		private List<HttpHeader> _httpHeaders;

		[Token(Token = "0x4000138")]
		[FieldOffset(Offset = "0x20")]
		private string _ipAddress;

		[Token(Token = "0x4000139")]
		[FieldOffset(Offset = "0x28")]
		private string _serverName;

		[Token(Token = "0x400013A")]
		[FieldOffset(Offset = "0x30")]
		private string _serverPath;

		[Token(Token = "0x170000C3")]
		public string EncodedData
		{
			[Token(Token = "0x600046C")]
			[Address(RVA = "0x10EAEFC", Offset = "0x10EAEFC", VA = "0x10EAEFC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600046D")]
			[Address(RVA = "0x10EAF04", Offset = "0x10EAF04", VA = "0x10EAF04")]
			set
			{
			}
		}

		[Token(Token = "0x170000C4")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1CC18", Offset = "0x1CC18")]
		public List<HttpHeader> HttpHeaders
		{
			[Token(Token = "0x600046F")]
			[Address(RVA = "0x10EAF1C", Offset = "0x10EAF1C", VA = "0x10EAF1C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000470")]
			[Address(RVA = "0x10EAF24", Offset = "0x10EAF24", VA = "0x10EAF24")]
			set
			{
			}
		}

		[Token(Token = "0x170000C5")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1CC4C", Offset = "0x1CC4C")]
		public string IpAddress
		{
			[Token(Token = "0x6000472")]
			[Address(RVA = "0x10EAF84", Offset = "0x10EAF84", VA = "0x10EAF84")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000473")]
			[Address(RVA = "0x10EAF8C", Offset = "0x10EAF8C", VA = "0x10EAF8C")]
			set
			{
			}
		}

		[Token(Token = "0x170000C6")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1CC80", Offset = "0x1CC80")]
		public string ServerName
		{
			[Token(Token = "0x6000475")]
			[Address(RVA = "0x10EAFA4", Offset = "0x10EAFA4", VA = "0x10EAFA4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000476")]
			[Address(RVA = "0x10EAFAC", Offset = "0x10EAFAC", VA = "0x10EAFAC")]
			set
			{
			}
		}

		[Token(Token = "0x170000C7")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1CCB4", Offset = "0x1CCB4")]
		public string ServerPath
		{
			[Token(Token = "0x6000478")]
			[Address(RVA = "0x10EAFC4", Offset = "0x10EAFC4", VA = "0x10EAFC4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000479")]
			[Address(RVA = "0x10EAFCC", Offset = "0x10EAFCC", VA = "0x10EAFCC")]
			set
			{
			}
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x10EAF0C", Offset = "0x10EAF0C", VA = "0x10EAF0C")]
		internal bool IsSetEncodedData()
		{
			return default;
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0x10EAF2C", Offset = "0x10EAF2C", VA = "0x10EAF2C")]
		internal bool IsSetHttpHeaders()
		{
			return default;
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0x10EAF94", Offset = "0x10EAF94", VA = "0x10EAF94")]
		internal bool IsSetIpAddress()
		{
			return default;
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x10EAFB4", Offset = "0x10EAFB4", VA = "0x10EAFB4")]
		internal bool IsSetServerName()
		{
			return default;
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0x10EAFD4", Offset = "0x10EAFD4", VA = "0x10EAFD4")]
		internal bool IsSetServerPath()
		{
			return default;
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0x10EAFE4", Offset = "0x10EAFE4", VA = "0x10EAFE4")]
		public ContextDataType()
		{
		}
	}
}
