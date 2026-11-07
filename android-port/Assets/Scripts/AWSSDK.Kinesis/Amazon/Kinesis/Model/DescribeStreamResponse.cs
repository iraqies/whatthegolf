using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model
{
	[Token(Token = "0x200001E")]
	public class DescribeStreamResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0x28")]
		private StreamDescription _streamDescription;

		[Token(Token = "0x17000022")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2EB90", Offset = "0x2EB90")]
		public StreamDescription StreamDescription
		{
			[Token(Token = "0x60000F5")]
			[Address(RVA = "0x12AAC3C", Offset = "0x12AAC3C", VA = "0x12AAC3C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000F6")]
			[Address(RVA = "0x12AAC44", Offset = "0x12AAC44", VA = "0x12AAC44")]
			set
			{
			}
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x12AAC4C", Offset = "0x12AAC4C", VA = "0x12AAC4C")]
		internal bool IsSetStreamDescription()
		{
			return default;
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x12AAC5C", Offset = "0x12AAC5C", VA = "0x12AAC5C")]
		public DescribeStreamResponse()
		{
		}
	}
}
