using System.Collections.Generic;
using System.Text;
using Il2CppDummyDll;

namespace Prime31
{
	[Token(Token = "0x2000011")]
	public class JsonFormatter
	{
		[Token(Token = "0x2000012")]
		private enum JsonContextType
		{
			[Token(Token = "0x4000038")]
			Object = 0,
			[Token(Token = "0x4000039")]
			Array = 1
		}

		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0x10")]
		private bool inDoubleString;

		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0x11")]
		private bool inSingleString;

		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0x12")]
		private bool inVariableAssignment;

		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0x14")]
		private char prevChar;

		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0x18")]
		private Stack<JsonContextType> context;

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x233C960", Offset = "0x233C960", VA = "0x233C960")]
		public static string prettyPrint(string input)
		{
			return null;
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x233D1B8", Offset = "0x233D1B8", VA = "0x233D1B8")]
		private static void buildIndents(int indents, StringBuilder output)
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x233D238", Offset = "0x233D238", VA = "0x233D238")]
		private bool inString()
		{
			return default;
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x233CC10", Offset = "0x233CC10", VA = "0x233CC10")]
		public string print(string input)
		{
			return null;
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x233CB84", Offset = "0x233CB84", VA = "0x233CB84")]
		public JsonFormatter()
		{
		}
	}
}
