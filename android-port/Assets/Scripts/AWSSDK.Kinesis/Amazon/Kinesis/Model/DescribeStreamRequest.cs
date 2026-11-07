using Il2CppDummyDll;

namespace Amazon.Kinesis.Model
{
	[Token(Token = "0x200001D")]
	public class DescribeStreamRequest : AmazonKinesisRequest
	{
		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0x30")]
		private string _exclusiveStartShardId;

		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0x38")]
		private int? _limit;

		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0x40")]
		private string _streamName;

		[Token(Token = "0x1700001F")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2EAB0", Offset = "0x2EAB0")]
		public string ExclusiveStartShardId
		{
			[Token(Token = "0x60000EB")]
			[Address(RVA = "0x12A9F78", Offset = "0x12A9F78", VA = "0x12A9F78")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000EC")]
			[Address(RVA = "0x12A9F80", Offset = "0x12A9F80", VA = "0x12A9F80")]
			set
			{
			}
		}

		[Token(Token = "0x17000020")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2EAF8", Offset = "0x2EAF8")]
		public int Limit
		{
			[Token(Token = "0x60000EE")]
			[Address(RVA = "0x12A9F98", Offset = "0x12A9F98", VA = "0x12A9F98")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000EF")]
			[Address(RVA = "0x12A9FD8", Offset = "0x12A9FD8", VA = "0x12A9FD8")]
			set
			{
			}
		}

		[Token(Token = "0x17000021")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2EB40", Offset = "0x2EB40")]
		public string StreamName
		{
			[Token(Token = "0x60000F1")]
			[Address(RVA = "0x12AA08C", Offset = "0x12AA08C", VA = "0x12AA08C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000F2")]
			[Address(RVA = "0x12AA094", Offset = "0x12AA094", VA = "0x12AA094")]
			set
			{
			}
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x12A9F88", Offset = "0x12A9F88", VA = "0x12A9F88")]
		internal bool IsSetExclusiveStartShardId()
		{
			return default;
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x12AA04C", Offset = "0x12AA04C", VA = "0x12AA04C")]
		internal bool IsSetLimit()
		{
			return default;
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x12AA09C", Offset = "0x12AA09C", VA = "0x12AA09C")]
		internal bool IsSetStreamName()
		{
			return default;
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x12AA0AC", Offset = "0x12AA0AC", VA = "0x12AA0AC")]
		public DescribeStreamRequest()
		{
		}
	}
}
