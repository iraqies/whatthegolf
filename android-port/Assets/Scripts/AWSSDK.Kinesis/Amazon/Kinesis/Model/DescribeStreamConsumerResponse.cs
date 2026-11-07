using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model
{
	[Token(Token = "0x200001C")]
	public class DescribeStreamConsumerResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0x28")]
		private ConsumerDescription _consumerDescription;

		[Token(Token = "0x1700001E")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2EA7C", Offset = "0x2EA7C")]
		public ConsumerDescription ConsumerDescription
		{
			[Token(Token = "0x60000E7")]
			[Address(RVA = "0x12A972C", Offset = "0x12A972C", VA = "0x12A972C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000E8")]
			[Address(RVA = "0x12A9734", Offset = "0x12A9734", VA = "0x12A9734")]
			set
			{
			}
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x12A973C", Offset = "0x12A973C", VA = "0x12A973C")]
		internal bool IsSetConsumerDescription()
		{
			return default;
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x12A974C", Offset = "0x12A974C", VA = "0x12A974C")]
		public DescribeStreamConsumerResponse()
		{
		}
	}
}
