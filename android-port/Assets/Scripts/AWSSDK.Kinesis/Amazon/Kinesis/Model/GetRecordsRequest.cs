using Il2CppDummyDll;

namespace Amazon.Kinesis.Model
{
	[Token(Token = "0x2000028")]
	public class GetRecordsRequest : AmazonKinesisRequest
	{
		[Token(Token = "0x4000046")]
		[FieldOffset(Offset = "0x2C")]
		private int? _limit;

		[Token(Token = "0x4000047")]
		[FieldOffset(Offset = "0x38")]
		private string _shardIterator;

		[Token(Token = "0x17000030")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2EF80", Offset = "0x2EF80")]
		public int Limit
		{
			[Token(Token = "0x6000131")]
			[Address(RVA = "0x12B05A0", Offset = "0x12B05A0", VA = "0x12B05A0")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000132")]
			[Address(RVA = "0x12B05E0", Offset = "0x12B05E0", VA = "0x12B05E0")]
			set
			{
			}
		}

		[Token(Token = "0x17000031")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2EFC8", Offset = "0x2EFC8")]
		public string ShardIterator
		{
			[Token(Token = "0x6000134")]
			[Address(RVA = "0x12B0694", Offset = "0x12B0694", VA = "0x12B0694")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000135")]
			[Address(RVA = "0x12B069C", Offset = "0x12B069C", VA = "0x12B069C")]
			set
			{
			}
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x12B0654", Offset = "0x12B0654", VA = "0x12B0654")]
		internal bool IsSetLimit()
		{
			return default;
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x12B06A4", Offset = "0x12B06A4", VA = "0x12B06A4")]
		internal bool IsSetShardIterator()
		{
			return default;
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x12B06B4", Offset = "0x12B06B4", VA = "0x12B06B4")]
		public GetRecordsRequest()
		{
		}
	}
}
