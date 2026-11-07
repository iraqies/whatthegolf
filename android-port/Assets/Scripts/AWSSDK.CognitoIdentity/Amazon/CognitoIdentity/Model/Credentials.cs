using System;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentity.Model
{
	[Token(Token = "0x200001A")]
	public class Credentials : AWSCredentials
	{
		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0x10")]
		private ImmutableCredentials _credentials;

		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0x18")]
		private string _accessKeyId;

		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0x20")]
		private DateTime? _expiration;

		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0x30")]
		private string _secretKey;

		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0x38")]
		private string _sessionToken;

		[Token(Token = "0x17000017")]
		public string AccessKeyId
		{
			[Token(Token = "0x60000D3")]
			[Address(RVA = "0x107CA70", Offset = "0x107CA70", VA = "0x107CA70")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000D4")]
			[Address(RVA = "0x107CA78", Offset = "0x107CA78", VA = "0x107CA78")]
			set
			{
			}
		}

		[Token(Token = "0x17000018")]
		public DateTime Expiration
		{
			[Token(Token = "0x60000D6")]
			[Address(RVA = "0x1078230", Offset = "0x1078230", VA = "0x1078230")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000D7")]
			[Address(RVA = "0x107CA90", Offset = "0x107CA90", VA = "0x107CA90")]
			set
			{
			}
		}

		[Token(Token = "0x17000019")]
		public string SecretKey
		{
			[Token(Token = "0x60000D9")]
			[Address(RVA = "0x107CB44", Offset = "0x107CB44", VA = "0x107CB44")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000DA")]
			[Address(RVA = "0x107CB4C", Offset = "0x107CB4C", VA = "0x107CB4C")]
			set
			{
			}
		}

		[Token(Token = "0x1700001A")]
		public string SessionToken
		{
			[Token(Token = "0x60000DC")]
			[Address(RVA = "0x107CB64", Offset = "0x107CB64", VA = "0x107CB64")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000DD")]
			[Address(RVA = "0x107CB6C", Offset = "0x107CB6C", VA = "0x107CB6C")]
			set
			{
			}
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x107C9C4", Offset = "0x107C9C4", VA = "0x107C9C4", Slot = "4")]
		public override ImmutableCredentials GetCredentials()
		{
			return null;
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x107CA80", Offset = "0x107CA80", VA = "0x107CA80")]
		internal bool IsSetAccessKeyId()
		{
			return default;
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x107CB04", Offset = "0x107CB04", VA = "0x107CB04")]
		internal bool IsSetExpiration()
		{
			return default;
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x107CB54", Offset = "0x107CB54", VA = "0x107CB54")]
		internal bool IsSetSecretKey()
		{
			return default;
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x107CB74", Offset = "0x107CB74", VA = "0x107CB74")]
		internal bool IsSetSessionToken()
		{
			return default;
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x107CB84", Offset = "0x107CB84", VA = "0x107CB84")]
		public Credentials()
		{
		}
	}
}
