using Il2CppDummyDll;

namespace Amazon.Kinesis.Model
{
	[Token(Token = "0x2000053")]
	public class StartStreamEncryptionRequest : AmazonKinesisRequest
	{
		[Token(Token = "0x4000096")]
		[FieldOffset(Offset = "0x30")]
		private EncryptionType _encryptionType;

		[Token(Token = "0x4000097")]
		[FieldOffset(Offset = "0x38")]
		private string _keyId;

		[Token(Token = "0x4000098")]
		[FieldOffset(Offset = "0x40")]
		private string _streamName;

		[Token(Token = "0x17000080")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x300EC", Offset = "0x300EC")]
		public EncryptionType EncryptionType
		{
			[Token(Token = "0x6000278")]
			[Address(RVA = "0x12C8334", Offset = "0x12C8334", VA = "0x12C8334")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000279")]
			[Address(RVA = "0x12C833C", Offset = "0x12C833C", VA = "0x12C833C")]
			set
			{
			}
		}

		[Token(Token = "0x17000081")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x30120", Offset = "0x30120")]
		public string KeyId
		{
			[Token(Token = "0x600027B")]
			[Address(RVA = "0x12C83C0", Offset = "0x12C83C0", VA = "0x12C83C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600027C")]
			[Address(RVA = "0x12C83C8", Offset = "0x12C83C8", VA = "0x12C83C8")]
			set
			{
			}
		}

		[Token(Token = "0x17000082")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x30170", Offset = "0x30170")]
		public string StreamName
		{
			[Token(Token = "0x600027E")]
			[Address(RVA = "0x12C83E0", Offset = "0x12C83E0", VA = "0x12C83E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600027F")]
			[Address(RVA = "0x12C83E8", Offset = "0x12C83E8", VA = "0x12C83E8")]
			set
			{
			}
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x12C8344", Offset = "0x12C8344", VA = "0x12C8344")]
		internal bool IsSetEncryptionType()
		{
			return default;
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x12C83D0", Offset = "0x12C83D0", VA = "0x12C83D0")]
		internal bool IsSetKeyId()
		{
			return default;
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x12C83F0", Offset = "0x12C83F0", VA = "0x12C83F0")]
		internal bool IsSetStreamName()
		{
			return default;
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x12C8400", Offset = "0x12C8400", VA = "0x12C8400")]
		public StartStreamEncryptionRequest()
		{
		}
	}
}
