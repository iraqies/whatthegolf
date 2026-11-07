using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model
{
	[Token(Token = "0x2000043")]
	public class PutRecordResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x4000073")]
		[FieldOffset(Offset = "0x28")]
		private EncryptionType _encryptionType;

		[Token(Token = "0x4000074")]
		[FieldOffset(Offset = "0x30")]
		private string _sequenceNumber;

		[Token(Token = "0x4000075")]
		[FieldOffset(Offset = "0x38")]
		private string _shardId;

		[Token(Token = "0x1700005D")]
		public EncryptionType EncryptionType
		{
			[Token(Token = "0x60001F7")]
			[Address(RVA = "0x12BF290", Offset = "0x12BF290", VA = "0x12BF290")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001F8")]
			[Address(RVA = "0x12BF298", Offset = "0x12BF298", VA = "0x12BF298")]
			set
			{
			}
		}

		[Token(Token = "0x1700005E")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2F9AC", Offset = "0x2F9AC")]
		public string SequenceNumber
		{
			[Token(Token = "0x60001FA")]
			[Address(RVA = "0x12BF31C", Offset = "0x12BF31C", VA = "0x12BF31C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001FB")]
			[Address(RVA = "0x12BF324", Offset = "0x12BF324", VA = "0x12BF324")]
			set
			{
			}
		}

		[Token(Token = "0x1700005F")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2F9E0", Offset = "0x2F9E0")]
		public string ShardId
		{
			[Token(Token = "0x60001FD")]
			[Address(RVA = "0x12BF33C", Offset = "0x12BF33C", VA = "0x12BF33C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001FE")]
			[Address(RVA = "0x12BF344", Offset = "0x12BF344", VA = "0x12BF344")]
			set
			{
			}
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x12BF2A0", Offset = "0x12BF2A0", VA = "0x12BF2A0")]
		internal bool IsSetEncryptionType()
		{
			return default;
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x12BF32C", Offset = "0x12BF32C", VA = "0x12BF32C")]
		internal bool IsSetSequenceNumber()
		{
			return default;
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x12BF34C", Offset = "0x12BF34C", VA = "0x12BF34C")]
		internal bool IsSetShardId()
		{
			return default;
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x12BF35C", Offset = "0x12BF35C", VA = "0x12BF35C")]
		public PutRecordResponse()
		{
		}
	}
}
