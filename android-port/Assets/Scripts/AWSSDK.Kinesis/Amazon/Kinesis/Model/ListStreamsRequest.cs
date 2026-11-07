using Il2CppDummyDll;

namespace Amazon.Kinesis.Model
{
	[Token(Token = "0x200003B")]
	public class ListStreamsRequest : AmazonKinesisRequest
	{
		[Token(Token = "0x4000062")]
		[FieldOffset(Offset = "0x30")]
		private string _exclusiveStartStreamName;

		[Token(Token = "0x4000063")]
		[FieldOffset(Offset = "0x38")]
		private int? _limit;

		[Token(Token = "0x1700004C")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2F580", Offset = "0x2F580")]
		public string ExclusiveStartStreamName
		{
			[Token(Token = "0x60001B8")]
			[Address(RVA = "0x12B9B64", Offset = "0x12B9B64", VA = "0x12B9B64")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001B9")]
			[Address(RVA = "0x12B9B6C", Offset = "0x12B9B6C", VA = "0x12B9B6C")]
			set
			{
			}
		}

		[Token(Token = "0x1700004D")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2F5C8", Offset = "0x2F5C8")]
		public int Limit
		{
			[Token(Token = "0x60001BB")]
			[Address(RVA = "0x12B9B84", Offset = "0x12B9B84", VA = "0x12B9B84")]
			get
			{
				return default;
			}
			[Token(Token = "0x60001BC")]
			[Address(RVA = "0x12B9BC4", Offset = "0x12B9BC4", VA = "0x12B9BC4")]
			set
			{
			}
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x12B9B74", Offset = "0x12B9B74", VA = "0x12B9B74")]
		internal bool IsSetExclusiveStartStreamName()
		{
			return default;
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x12B9C38", Offset = "0x12B9C38", VA = "0x12B9C38")]
		internal bool IsSetLimit()
		{
			return default;
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x129F468", Offset = "0x129F468", VA = "0x129F468")]
		public ListStreamsRequest()
		{
		}
	}
}
