using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model
{
	[Token(Token = "0x200002B")]
	public class GetShardIteratorResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0x28")]
		private string _shardIterator;

		[Token(Token = "0x1700003A")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2F1A0", Offset = "0x2F1A0")]
		public string ShardIterator
		{
			[Token(Token = "0x6000152")]
			[Address(RVA = "0x12B3940", Offset = "0x12B3940", VA = "0x12B3940")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000153")]
			[Address(RVA = "0x12B3948", Offset = "0x12B3948", VA = "0x12B3948")]
			set
			{
			}
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x12B3950", Offset = "0x12B3950", VA = "0x12B3950")]
		internal bool IsSetShardIterator()
		{
			return default;
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x12B3960", Offset = "0x12B3960", VA = "0x12B3960")]
		public GetShardIteratorResponse()
		{
		}
	}
}
