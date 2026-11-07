using Il2CppDummyDll;

namespace Amazon.Kinesis.Model
{
	[Token(Token = "0x200001F")]
	public class DescribeStreamSummaryRequest : AmazonKinesisRequest
	{
		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0x30")]
		private string _streamName;

		[Token(Token = "0x17000023")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2EBC4", Offset = "0x2EBC4")]
		public string StreamName
		{
			[Token(Token = "0x60000F9")]
			[Address(RVA = "0x12AB3C4", Offset = "0x12AB3C4", VA = "0x12AB3C4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000FA")]
			[Address(RVA = "0x12AB3CC", Offset = "0x12AB3CC", VA = "0x12AB3CC")]
			set
			{
			}
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x12AB3D4", Offset = "0x12AB3D4", VA = "0x12AB3D4")]
		internal bool IsSetStreamName()
		{
			return default;
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x12AB3E4", Offset = "0x12AB3E4", VA = "0x12AB3E4")]
		public DescribeStreamSummaryRequest()
		{
		}
	}
}
