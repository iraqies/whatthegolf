using Il2CppDummyDll;

namespace Amazon.Kinesis.Model
{
	[Token(Token = "0x2000011")]
	public class CreateStreamRequest : AmazonKinesisRequest
	{
		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0x2C")]
		private int? _shardCount;

		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x38")]
		private string _streamName;

		[Token(Token = "0x17000010")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2E690", Offset = "0x2E690")]
		public int ShardCount
		{
			[Token(Token = "0x60000B2")]
			[Address(RVA = "0x12A2D60", Offset = "0x12A2D60", VA = "0x12A2D60")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000B3")]
			[Address(RVA = "0x12A2DA0", Offset = "0x12A2DA0", VA = "0x12A2DA0")]
			set
			{
			}
		}

		[Token(Token = "0x17000011")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2E6E4", Offset = "0x2E6E4")]
		public string StreamName
		{
			[Token(Token = "0x60000B5")]
			[Address(RVA = "0x12A2E54", Offset = "0x12A2E54", VA = "0x12A2E54")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000B6")]
			[Address(RVA = "0x12A2E5C", Offset = "0x12A2E5C", VA = "0x12A2E5C")]
			set
			{
			}
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x12A2E14", Offset = "0x12A2E14", VA = "0x12A2E14")]
		internal bool IsSetShardCount()
		{
			return default;
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x12A2E64", Offset = "0x12A2E64", VA = "0x12A2E64")]
		internal bool IsSetStreamName()
		{
			return default;
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x12A2E74", Offset = "0x12A2E74", VA = "0x12A2E74")]
		public CreateStreamRequest()
		{
		}
	}
}
