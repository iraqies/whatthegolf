using Il2CppDummyDll;

namespace Amazon.Runtime
{
	[Token(Token = "0x20000E3")]
	public class StringParameterValue : ParameterValue
	{
		[Token(Token = "0x40003BB")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x26BD8", Offset = "0x26BD8")]
		private string Value__BackingField;

		[Token(Token = "0x17000216")]
		public string Value
		{
			[Token(Token = "0x60007EE")]
			[Address(RVA = "0x127C480", Offset = "0x127C480", VA = "0x127C480")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x294BC", Offset = "0x294BC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007EF")]
			[Address(RVA = "0x127C488", Offset = "0x127C488", VA = "0x127C488")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x294CC", Offset = "0x294CC")]
			set
			{
			}
		}

		[Token(Token = "0x60007F0")]
		[Address(RVA = "0x127C490", Offset = "0x127C490", VA = "0x127C490")]
		public StringParameterValue(string value)
		{
		}

		[Token(Token = "0x60007F1")]
		[Address(RVA = "0x127C4BC", Offset = "0x127C4BC", VA = "0x127C4BC")]
		internal StringParameterValue()
		{
		}
	}
}
