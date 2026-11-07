using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model
{
	[Token(Token = "0x200004A")]
	public class RegisterStreamConsumerResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x4000089")]
		[FieldOffset(Offset = "0x28")]
		private Consumer _consumer;

		[Token(Token = "0x17000073")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2FDC8", Offset = "0x2FDC8")]
		public Consumer Consumer
		{
			[Token(Token = "0x6000240")]
			[Address(RVA = "0x12C3C34", Offset = "0x12C3C34", VA = "0x12C3C34")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000241")]
			[Address(RVA = "0x12C3C3C", Offset = "0x12C3C3C", VA = "0x12C3C3C")]
			set
			{
			}
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x12C3C44", Offset = "0x12C3C44", VA = "0x12C3C44")]
		internal bool IsSetConsumer()
		{
			return default;
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x12C3C54", Offset = "0x12C3C54", VA = "0x12C3C54")]
		public RegisterStreamConsumerResponse()
		{
		}
	}
}
