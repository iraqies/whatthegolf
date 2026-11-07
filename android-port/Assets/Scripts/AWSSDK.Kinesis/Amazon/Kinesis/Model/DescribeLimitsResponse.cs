using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model
{
	[Token(Token = "0x200001A")]
	public class DescribeLimitsResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0x24")]
		private int? _openShardCount;

		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0x2C")]
		private int? _shardLimit;

		[Token(Token = "0x17000019")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2E8FC", Offset = "0x2E8FC")]
		public int OpenShardCount
		{
			[Token(Token = "0x60000D6")]
			[Address(RVA = "0x12A81D8", Offset = "0x12A81D8", VA = "0x12A81D8")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000D7")]
			[Address(RVA = "0x12A8218", Offset = "0x12A8218", VA = "0x12A8218")]
			set
			{
			}
		}

		[Token(Token = "0x1700001A")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2E950", Offset = "0x2E950")]
		public int ShardLimit
		{
			[Token(Token = "0x60000D9")]
			[Address(RVA = "0x12A82CC", Offset = "0x12A82CC", VA = "0x12A82CC")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000DA")]
			[Address(RVA = "0x12A830C", Offset = "0x12A830C", VA = "0x12A830C")]
			set
			{
			}
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x12A828C", Offset = "0x12A828C", VA = "0x12A828C")]
		internal bool IsSetOpenShardCount()
		{
			return default;
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x12A8380", Offset = "0x12A8380", VA = "0x12A8380")]
		internal bool IsSetShardLimit()
		{
			return default;
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x12A83C0", Offset = "0x12A83C0", VA = "0x12A83C0")]
		public DescribeLimitsResponse()
		{
		}
	}
}
