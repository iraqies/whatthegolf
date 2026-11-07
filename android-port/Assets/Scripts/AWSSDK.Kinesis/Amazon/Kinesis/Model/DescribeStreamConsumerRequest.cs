using Il2CppDummyDll;

namespace Amazon.Kinesis.Model
{
	[Token(Token = "0x200001B")]
	public class DescribeStreamConsumerRequest : AmazonKinesisRequest
	{
		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x30")]
		private string _consumerARN;

		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0x38")]
		private string _consumerName;

		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0x40")]
		private string _streamARN;

		[Token(Token = "0x1700001B")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2E9A4", Offset = "0x2E9A4")]
		public string ConsumerARN
		{
			[Token(Token = "0x60000DD")]
			[Address(RVA = "0x12A8B84", Offset = "0x12A8B84", VA = "0x12A8B84")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000DE")]
			[Address(RVA = "0x12A8B8C", Offset = "0x12A8B8C", VA = "0x12A8B8C")]
			set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2E9EC", Offset = "0x2E9EC")]
		public string ConsumerName
		{
			[Token(Token = "0x60000E0")]
			[Address(RVA = "0x12A8BA4", Offset = "0x12A8BA4", VA = "0x12A8BA4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000E1")]
			[Address(RVA = "0x12A8BAC", Offset = "0x12A8BAC", VA = "0x12A8BAC")]
			set
			{
			}
		}

		[Token(Token = "0x1700001D")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2EA34", Offset = "0x2EA34")]
		public string StreamARN
		{
			[Token(Token = "0x60000E3")]
			[Address(RVA = "0x12A8BC4", Offset = "0x12A8BC4", VA = "0x12A8BC4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000E4")]
			[Address(RVA = "0x12A8BCC", Offset = "0x12A8BCC", VA = "0x12A8BCC")]
			set
			{
			}
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x12A8B94", Offset = "0x12A8B94", VA = "0x12A8B94")]
		internal bool IsSetConsumerARN()
		{
			return default;
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x12A8BB4", Offset = "0x12A8BB4", VA = "0x12A8BB4")]
		internal bool IsSetConsumerName()
		{
			return default;
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x12A8BD4", Offset = "0x12A8BD4", VA = "0x12A8BD4")]
		internal bool IsSetStreamARN()
		{
			return default;
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x12A8BE4", Offset = "0x12A8BE4", VA = "0x12A8BE4")]
		public DescribeStreamConsumerRequest()
		{
		}
	}
}
