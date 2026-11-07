using Il2CppDummyDll;

namespace Amazon.Kinesis.Model
{
	[Token(Token = "0x2000049")]
	public class RegisterStreamConsumerRequest : AmazonKinesisRequest
	{
		[Token(Token = "0x4000087")]
		[FieldOffset(Offset = "0x30")]
		private string _consumerName;

		[Token(Token = "0x4000088")]
		[FieldOffset(Offset = "0x38")]
		private string _streamARN;

		[Token(Token = "0x17000071")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2FD28", Offset = "0x2FD28")]
		public string ConsumerName
		{
			[Token(Token = "0x6000239")]
			[Address(RVA = "0x12C3118", Offset = "0x12C3118", VA = "0x12C3118")]
			get
			{
				return null;
			}
			[Token(Token = "0x600023A")]
			[Address(RVA = "0x12C3120", Offset = "0x12C3120", VA = "0x12C3120")]
			set
			{
			}
		}

		[Token(Token = "0x17000072")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2FD78", Offset = "0x2FD78")]
		public string StreamARN
		{
			[Token(Token = "0x600023C")]
			[Address(RVA = "0x12C3138", Offset = "0x12C3138", VA = "0x12C3138")]
			get
			{
				return null;
			}
			[Token(Token = "0x600023D")]
			[Address(RVA = "0x12C3140", Offset = "0x12C3140", VA = "0x12C3140")]
			set
			{
			}
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x12C3128", Offset = "0x12C3128", VA = "0x12C3128")]
		internal bool IsSetConsumerName()
		{
			return default;
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x12C3148", Offset = "0x12C3148", VA = "0x12C3148")]
		internal bool IsSetStreamARN()
		{
			return default;
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x12C3158", Offset = "0x12C3158", VA = "0x12C3158")]
		public RegisterStreamConsumerRequest()
		{
		}
	}
}
