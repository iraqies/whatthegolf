using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.Runtime
{
	[Token(Token = "0x20000E4")]
	public class StringListParameterValue : ParameterValue
	{
		[Token(Token = "0x40003BC")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x26BE8", Offset = "0x26BE8")]
		private List<string> Value__BackingField;

		[Token(Token = "0x17000217")]
		public List<string> Value
		{
			[Token(Token = "0x60007F2")]
			[Address(RVA = "0x127C43C", Offset = "0x127C43C", VA = "0x127C43C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x294DC", Offset = "0x294DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007F3")]
			[Address(RVA = "0x127C444", Offset = "0x127C444", VA = "0x127C444")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x294EC", Offset = "0x294EC")]
			set
			{
			}
		}

		[Token(Token = "0x60007F4")]
		[Address(RVA = "0x127C44C", Offset = "0x127C44C", VA = "0x127C44C")]
		public StringListParameterValue(List<string> values)
		{
		}

		[Token(Token = "0x60007F5")]
		[Address(RVA = "0x127C478", Offset = "0x127C478", VA = "0x127C478")]
		internal StringListParameterValue()
		{
		}
	}
}
