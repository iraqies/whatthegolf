using Il2CppDummyDll;

namespace Amazon.Kinesis.Model
{
	[Token(Token = "0x200003F")]
	public class MergeShardsRequest : AmazonKinesisRequest
	{
		[Token(Token = "0x400006B")]
		[FieldOffset(Offset = "0x30")]
		private string _adjacentShardToMerge;

		[Token(Token = "0x400006C")]
		[FieldOffset(Offset = "0x38")]
		private string _shardToMerge;

		[Token(Token = "0x400006D")]
		[FieldOffset(Offset = "0x40")]
		private string _streamName;

		[Token(Token = "0x17000055")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2F7CC", Offset = "0x2F7CC")]
		public string AdjacentShardToMerge
		{
			[Token(Token = "0x60001D7")]
			[Address(RVA = "0x12BCAC4", Offset = "0x12BCAC4", VA = "0x12BCAC4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001D8")]
			[Address(RVA = "0x12BCACC", Offset = "0x12BCACC", VA = "0x12BCACC")]
			set
			{
			}
		}

		[Token(Token = "0x17000056")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2F81C", Offset = "0x2F81C")]
		public string ShardToMerge
		{
			[Token(Token = "0x60001DA")]
			[Address(RVA = "0x12BCAE4", Offset = "0x12BCAE4", VA = "0x12BCAE4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001DB")]
			[Address(RVA = "0x12BCAEC", Offset = "0x12BCAEC", VA = "0x12BCAEC")]
			set
			{
			}
		}

		[Token(Token = "0x17000057")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2F86C", Offset = "0x2F86C")]
		public string StreamName
		{
			[Token(Token = "0x60001DD")]
			[Address(RVA = "0x12BCB04", Offset = "0x12BCB04", VA = "0x12BCB04")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001DE")]
			[Address(RVA = "0x12BCB0C", Offset = "0x12BCB0C", VA = "0x12BCB0C")]
			set
			{
			}
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x12BCAD4", Offset = "0x12BCAD4", VA = "0x12BCAD4")]
		internal bool IsSetAdjacentShardToMerge()
		{
			return default;
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x12BCAF4", Offset = "0x12BCAF4", VA = "0x12BCAF4")]
		internal bool IsSetShardToMerge()
		{
			return default;
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x12BCB14", Offset = "0x12BCB14", VA = "0x12BCB14")]
		internal bool IsSetStreamName()
		{
			return default;
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x12BCB24", Offset = "0x12BCB24", VA = "0x12BCB24")]
		public MergeShardsRequest()
		{
		}
	}
}
