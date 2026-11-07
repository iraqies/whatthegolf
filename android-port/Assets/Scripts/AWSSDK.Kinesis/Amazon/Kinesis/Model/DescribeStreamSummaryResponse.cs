using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model
{
	[Token(Token = "0x2000020")]
	public class DescribeStreamSummaryResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x400003A")]
		[FieldOffset(Offset = "0x28")]
		private StreamDescriptionSummary _streamDescriptionSummary;

		[Token(Token = "0x17000024")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2EC14", Offset = "0x2EC14")]
		public StreamDescriptionSummary StreamDescriptionSummary
		{
			[Token(Token = "0x60000FD")]
			[Address(RVA = "0x12ABE54", Offset = "0x12ABE54", VA = "0x12ABE54")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000FE")]
			[Address(RVA = "0x12ABE5C", Offset = "0x12ABE5C", VA = "0x12ABE5C")]
			set
			{
			}
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x12ABE64", Offset = "0x12ABE64", VA = "0x12ABE64")]
		internal bool IsSetStreamDescriptionSummary()
		{
			return default;
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x12ABE74", Offset = "0x12ABE74", VA = "0x12ABE74")]
		public DescribeStreamSummaryResponse()
		{
		}
	}
}
