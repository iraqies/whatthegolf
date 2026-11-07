using System.Collections.Generic;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model
{
	[Token(Token = "0x2000038")]
	public class ListShardsResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x400005A")]
		[FieldOffset(Offset = "0x28")]
		private string _nextToken;

		[Token(Token = "0x400005B")]
		[FieldOffset(Offset = "0x30")]
		private List<Shard> _shards;

		[Token(Token = "0x17000044")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2F410", Offset = "0x2F410")]
		public string NextToken
		{
			[Token(Token = "0x600019D")]
			[Address(RVA = "0x12B748C", Offset = "0x12B748C", VA = "0x12B748C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600019E")]
			[Address(RVA = "0x12B7494", Offset = "0x12B7494", VA = "0x12B7494")]
			set
			{
			}
		}

		[Token(Token = "0x17000045")]
		public List<Shard> Shards
		{
			[Token(Token = "0x60001A0")]
			[Address(RVA = "0x12B74AC", Offset = "0x12B74AC", VA = "0x12B74AC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001A1")]
			[Address(RVA = "0x12B74B4", Offset = "0x12B74B4", VA = "0x12B74B4")]
			set
			{
			}
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x12B749C", Offset = "0x12B749C", VA = "0x12B749C")]
		internal bool IsSetNextToken()
		{
			return default;
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x12B74BC", Offset = "0x12B74BC", VA = "0x12B74BC")]
		internal bool IsSetShards()
		{
			return default;
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x12B7514", Offset = "0x12B7514", VA = "0x12B7514")]
		public ListShardsResponse()
		{
		}
	}
}
