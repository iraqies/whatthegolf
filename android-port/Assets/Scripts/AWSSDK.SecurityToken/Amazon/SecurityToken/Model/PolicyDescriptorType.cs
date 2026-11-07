using Il2CppDummyDll;

namespace Amazon.SecurityToken.Model
{
	[Token(Token = "0x200002F")]
	public class PolicyDescriptorType
	{
		[Token(Token = "0x4000065")]
		[FieldOffset(Offset = "0x10")]
		private string _arn;

		[Token(Token = "0x17000050")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x31784", Offset = "0x31784")]
		public string Arn
		{
			[Token(Token = "0x600017F")]
			[Address(RVA = "0x12E43B8", Offset = "0x12E43B8", VA = "0x12E43B8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000180")]
			[Address(RVA = "0x12E43C0", Offset = "0x12E43C0", VA = "0x12E43C0")]
			set
			{
			}
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x12D6A1C", Offset = "0x12D6A1C", VA = "0x12D6A1C")]
		internal bool IsSetArn()
		{
			return default;
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x12E43C8", Offset = "0x12E43C8", VA = "0x12E43C8")]
		public PolicyDescriptorType()
		{
		}
	}
}
