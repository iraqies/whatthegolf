using Il2CppDummyDll;

namespace Amazon.Kinesis.Model
{
	[Token(Token = "0x2000055")]
	public class StopStreamEncryptionRequest : AmazonKinesisRequest
	{
		[Token(Token = "0x4000099")]
		[FieldOffset(Offset = "0x30")]
		private EncryptionType _encryptionType;

		[Token(Token = "0x400009A")]
		[FieldOffset(Offset = "0x38")]
		private string _keyId;

		[Token(Token = "0x400009B")]
		[FieldOffset(Offset = "0x40")]
		private string _streamName;

		[Token(Token = "0x17000083")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x301C0", Offset = "0x301C0")]
		public EncryptionType EncryptionType
		{
			[Token(Token = "0x6000283")]
			[Address(RVA = "0x12C9C70", Offset = "0x12C9C70", VA = "0x12C9C70")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000284")]
			[Address(RVA = "0x12C9C78", Offset = "0x12C9C78", VA = "0x12C9C78")]
			set
			{
			}
		}

		[Token(Token = "0x17000084")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x301F4", Offset = "0x301F4")]
		public string KeyId
		{
			[Token(Token = "0x6000286")]
			[Address(RVA = "0x12C9CFC", Offset = "0x12C9CFC", VA = "0x12C9CFC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000287")]
			[Address(RVA = "0x12C9D04", Offset = "0x12C9D04", VA = "0x12C9D04")]
			set
			{
			}
		}

		[Token(Token = "0x17000085")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x30244", Offset = "0x30244")]
		public string StreamName
		{
			[Token(Token = "0x6000289")]
			[Address(RVA = "0x12C9D1C", Offset = "0x12C9D1C", VA = "0x12C9D1C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600028A")]
			[Address(RVA = "0x12C9D24", Offset = "0x12C9D24", VA = "0x12C9D24")]
			set
			{
			}
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x12C9C80", Offset = "0x12C9C80", VA = "0x12C9C80")]
		internal bool IsSetEncryptionType()
		{
			return default;
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x12C9D0C", Offset = "0x12C9D0C", VA = "0x12C9D0C")]
		internal bool IsSetKeyId()
		{
			return default;
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x12C9D2C", Offset = "0x12C9D2C", VA = "0x12C9D2C")]
		internal bool IsSetStreamName()
		{
			return default;
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x12C9D3C", Offset = "0x12C9D3C", VA = "0x12C9D3C")]
		public StopStreamEncryptionRequest()
		{
		}
	}
}
