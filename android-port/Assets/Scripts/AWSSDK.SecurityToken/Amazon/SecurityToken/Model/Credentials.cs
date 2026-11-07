using System;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.SecurityToken.Model
{
	[Token(Token = "0x2000015")]
	public class Credentials : AWSCredentials
	{
		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x10")]
		private ImmutableCredentials _credentials;

		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0x18")]
		private string _accessKeyId;

		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0x20")]
		private DateTime? _expiration;

		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0x30")]
		private string _secretAccessKey;

		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x38")]
		private string _sessionToken;

		[Token(Token = "0x1700000D")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x30B8C", Offset = "0x30B8C")]
		public string AccessKeyId
		{
			[Token(Token = "0x600007F")]
			[Address(RVA = "0x12DD294", Offset = "0x12DD294", VA = "0x12DD294")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000080")]
			[Address(RVA = "0x12DD29C", Offset = "0x12DD29C", VA = "0x12DD29C")]
			set
			{
			}
		}

		[Token(Token = "0x1700000E")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x30BDC", Offset = "0x30BDC")]
		public DateTime Expiration
		{
			[Token(Token = "0x6000082")]
			[Address(RVA = "0x12D179C", Offset = "0x12D179C", VA = "0x12D179C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000083")]
			[Address(RVA = "0x12DD2B4", Offset = "0x12DD2B4", VA = "0x12DD2B4")]
			set
			{
			}
		}

		[Token(Token = "0x1700000F")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x30C10", Offset = "0x30C10")]
		public string SecretAccessKey
		{
			[Token(Token = "0x6000085")]
			[Address(RVA = "0x12DD368", Offset = "0x12DD368", VA = "0x12DD368")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000086")]
			[Address(RVA = "0x12DD370", Offset = "0x12DD370", VA = "0x12DD370")]
			set
			{
			}
		}

		[Token(Token = "0x17000010")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x30C44", Offset = "0x30C44")]
		public string SessionToken
		{
			[Token(Token = "0x6000088")]
			[Address(RVA = "0x12DD388", Offset = "0x12DD388", VA = "0x12DD388")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000089")]
			[Address(RVA = "0x12DD390", Offset = "0x12DD390", VA = "0x12DD390")]
			set
			{
			}
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x12DD13C", Offset = "0x12DD13C", VA = "0x12DD13C", Slot = "4")]
		public override ImmutableCredentials GetCredentials()
		{
			return null;
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x12DD1E8", Offset = "0x12DD1E8", VA = "0x12DD1E8")]
		public Credentials()
		{
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x12DD1F0", Offset = "0x12DD1F0", VA = "0x12DD1F0")]
		public Credentials(string accessKeyId, string secretAccessKey, string sessionToken, DateTime expiration)
		{
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x12DD2A4", Offset = "0x12DD2A4", VA = "0x12DD2A4")]
		internal bool IsSetAccessKeyId()
		{
			return default;
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x12DD328", Offset = "0x12DD328", VA = "0x12DD328")]
		internal bool IsSetExpiration()
		{
			return default;
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x12DD378", Offset = "0x12DD378", VA = "0x12DD378")]
		internal bool IsSetSecretAccessKey()
		{
			return default;
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x12DD398", Offset = "0x12DD398", VA = "0x12DD398")]
		internal bool IsSetSessionToken()
		{
			return default;
		}
	}
}
