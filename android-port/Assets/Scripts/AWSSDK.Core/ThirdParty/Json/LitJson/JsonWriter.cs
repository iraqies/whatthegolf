using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using Il2CppDummyDll;

namespace ThirdParty.Json.LitJson
{
	[Token(Token = "0x200002C")]
	public class JsonWriter
	{
		[Token(Token = "0x400009F")]
		[FieldOffset(Offset = "0x0")]
		private static NumberFormatInfo number_format;

		[Token(Token = "0x40000A0")]
		[FieldOffset(Offset = "0x10")]
		private WriterContext context;

		[Token(Token = "0x40000A1")]
		[FieldOffset(Offset = "0x18")]
		private Stack<WriterContext> ctx_stack;

		[Token(Token = "0x40000A2")]
		[FieldOffset(Offset = "0x20")]
		private bool has_reached_end;

		[Token(Token = "0x40000A3")]
		[FieldOffset(Offset = "0x28")]
		private char[] hex_seq;

		[Token(Token = "0x40000A4")]
		[FieldOffset(Offset = "0x30")]
		private int indentation;

		[Token(Token = "0x40000A5")]
		[FieldOffset(Offset = "0x34")]
		private int indent_value;

		[Token(Token = "0x40000A6")]
		[FieldOffset(Offset = "0x38")]
		private StringBuilder inst_string_builder;

		[Token(Token = "0x40000A7")]
		[FieldOffset(Offset = "0x40")]
		private bool pretty_print;

		[Token(Token = "0x40000A8")]
		[FieldOffset(Offset = "0x41")]
		private bool validate;

		[Token(Token = "0x40000A9")]
		[FieldOffset(Offset = "0x48")]
		private TextWriter writer;

		[Token(Token = "0x1700004F")]
		public int IndentValue
		{
			[Token(Token = "0x6000193")]
			[Address(RVA = "0x1236A54", Offset = "0x1236A54", VA = "0x1236A54")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000194")]
			[Address(RVA = "0x123274C", Offset = "0x123274C", VA = "0x123274C")]
			set
			{
			}
		}

		[Token(Token = "0x17000050")]
		public bool PrettyPrint
		{
			[Token(Token = "0x6000195")]
			[Address(RVA = "0x1236A5C", Offset = "0x1236A5C", VA = "0x1236A5C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000196")]
			[Address(RVA = "0x1236A64", Offset = "0x1236A64", VA = "0x1236A64")]
			set
			{
			}
		}

		[Token(Token = "0x17000051")]
		public TextWriter TextWriter
		{
			[Token(Token = "0x6000197")]
			[Address(RVA = "0x1236A6C", Offset = "0x1236A6C", VA = "0x1236A6C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000052")]
		public bool Validate
		{
			[Token(Token = "0x6000198")]
			[Address(RVA = "0x1236A74", Offset = "0x1236A74", VA = "0x1236A74")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000199")]
			[Address(RVA = "0x1236A7C", Offset = "0x1236A7C", VA = "0x1236A7C")]
			set
			{
			}
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x1236A84", Offset = "0x1236A84", VA = "0x1236A84")]
		static JsonWriter()
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x12268C8", Offset = "0x12268C8", VA = "0x12268C8")]
		public JsonWriter()
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x1236BE0", Offset = "0x1236BE0", VA = "0x1236BE0")]
		public JsonWriter(StringBuilder sb)
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x12250EC", Offset = "0x12250EC", VA = "0x12250EC")]
		public JsonWriter(TextWriter writer)
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x1236C50", Offset = "0x1236C50", VA = "0x1236C50")]
		private void DoValidation(Condition cond)
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x1236AD8", Offset = "0x1236AD8", VA = "0x1236AD8")]
		private void Init()
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x1236DF4", Offset = "0x1236DF4", VA = "0x1236DF4")]
		private static void IntToHex(int n, char[] hex)
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x1236E88", Offset = "0x1236E88", VA = "0x1236E88")]
		private void Indent()
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x1236EA4", Offset = "0x1236EA4", VA = "0x1236EA4")]
		private void Put(string str)
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x1236F40", Offset = "0x1236F40", VA = "0x1236F40")]
		private void PutNewline()
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x1236F48", Offset = "0x1236F48", VA = "0x1236F48")]
		private void PutNewline(bool add_comma)
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x123701C", Offset = "0x123701C", VA = "0x123701C")]
		private void PutString(string str)
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x12373F8", Offset = "0x12373F8", VA = "0x12373F8")]
		private void Unindent()
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x1237414", Offset = "0x1237414", VA = "0x1237414", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x122ED8C", Offset = "0x122ED8C", VA = "0x122ED8C")]
		public void Reset()
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x1223DB4", Offset = "0x1223DB4", VA = "0x1223DB4")]
		public void Write(bool boolean)
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x1237480", Offset = "0x1237480", VA = "0x1237480")]
		public void Write(decimal number)
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x1223ECC", Offset = "0x1223ECC", VA = "0x1223ECC")]
		public void Write(double number)
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x1224070", Offset = "0x1224070", VA = "0x1224070")]
		public void Write(int number)
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x12241C4", Offset = "0x12241C4", VA = "0x12241C4")]
		public void Write(uint number)
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x1224318", Offset = "0x1224318", VA = "0x1224318")]
		public void Write(long number)
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x1223CA8", Offset = "0x1223CA8", VA = "0x1223CA8")]
		public void Write(string str)
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x12375E4", Offset = "0x12375E4", VA = "0x12375E4")]
		public void WriteRaw(string str)
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x122446C", Offset = "0x122446C", VA = "0x122446C")]
		public void Write(ulong number)
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x1237734", Offset = "0x1237734", VA = "0x1237734")]
		public void Write(DateTime date)
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x1224718", Offset = "0x1224718", VA = "0x1224718")]
		public void WriteArrayEnd()
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x12245C0", Offset = "0x12245C0", VA = "0x12245C0")]
		public void WriteArrayStart()
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x1224B4C", Offset = "0x1224B4C", VA = "0x1224B4C")]
		public void WriteObjectEnd()
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x12248CC", Offset = "0x12248CC", VA = "0x12248CC")]
		public void WriteObjectStart()
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x1224A24", Offset = "0x1224A24", VA = "0x1224A24")]
		public void WritePropertyName(string property_name)
		{
		}
	}
}
