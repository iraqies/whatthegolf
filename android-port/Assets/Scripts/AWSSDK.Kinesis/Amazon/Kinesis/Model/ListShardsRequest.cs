using System;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model
{
	[Token(Token = "0x2000037")]
	public class ListShardsRequest : AmazonKinesisRequest
	{
		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0x30")]
		private string _exclusiveStartShardId;

		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0x38")]
		private int? _maxResults;

		[Token(Token = "0x4000057")]
		[FieldOffset(Offset = "0x40")]
		private string _nextToken;

		[Token(Token = "0x4000058")]
		[FieldOffset(Offset = "0x48")]
		private DateTime? _streamCreationTimestamp;

		[Token(Token = "0x4000059")]
		[FieldOffset(Offset = "0x58")]
		private string _streamName;

		[Token(Token = "0x1700003F")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x2F2F0", Offset = "0x2F2F0")]
		public string ExclusiveStartShardId
		{
			[Token(Token = "0x600018D")]
			[Address(RVA = "0x12B6590", Offset = "0x12B6590", VA = "0x12B6590")]
			get
			{
				return null;
			}
			[Token(Token = "0x600018E")]
			[Address(RVA = "0x12B6598", Offset = "0x12B6598", VA = "0x12B6598")]
			set
			{
			}
		}

		[Token(Token = "0x17000040")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x2F338", Offset = "0x2F338")]
		public int MaxResults
		{
			[Token(Token = "0x6000190")]
			[Address(RVA = "0x12B65B0", Offset = "0x12B65B0", VA = "0x12B65B0")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000191")]
			[Address(RVA = "0x12B65F0", Offset = "0x12B65F0", VA = "0x12B65F0")]
			set
			{
			}
		}

		[Token(Token = "0x17000041")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x2F380", Offset = "0x2F380")]
		public string NextToken
		{
			[Token(Token = "0x6000193")]
			[Address(RVA = "0x12B66A4", Offset = "0x12B66A4", VA = "0x12B66A4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000194")]
			[Address(RVA = "0x12B66AC", Offset = "0x12B66AC", VA = "0x12B66AC")]
			set
			{
			}
		}

		[Token(Token = "0x17000042")]
		public DateTime StreamCreationTimestamp
		{
			[Token(Token = "0x6000196")]
			[Address(RVA = "0x12B66C4", Offset = "0x12B66C4", VA = "0x12B66C4")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000197")]
			[Address(RVA = "0x12B6704", Offset = "0x12B6704", VA = "0x12B6704")]
			set
			{
			}
		}

		[Token(Token = "0x17000043")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x2F3C8", Offset = "0x2F3C8")]
		public string StreamName
		{
			[Token(Token = "0x6000199")]
			[Address(RVA = "0x12B67B8", Offset = "0x12B67B8", VA = "0x12B67B8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600019A")]
			[Address(RVA = "0x12B67C0", Offset = "0x12B67C0", VA = "0x12B67C0")]
			set
			{
			}
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x12B65A0", Offset = "0x12B65A0", VA = "0x12B65A0")]
		internal bool IsSetExclusiveStartShardId()
		{
			return default;
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x12B6664", Offset = "0x12B6664", VA = "0x12B6664")]
		internal bool IsSetMaxResults()
		{
			return default;
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x12B66B4", Offset = "0x12B66B4", VA = "0x12B66B4")]
		internal bool IsSetNextToken()
		{
			return default;
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x12B6778", Offset = "0x12B6778", VA = "0x12B6778")]
		internal bool IsSetStreamCreationTimestamp()
		{
			return default;
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x12B67C8", Offset = "0x12B67C8", VA = "0x12B67C8")]
		internal bool IsSetStreamName()
		{
			return default;
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x12B67D8", Offset = "0x12B67D8", VA = "0x12B67D8")]
		public ListShardsRequest()
		{
		}
	}
}
