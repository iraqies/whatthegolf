using System.IO;
using System.Text;
using Il2CppDummyDll;

namespace ThirdParty.Json.LitJson
{
	[Token(Token = "0x200002E")]
	internal class Lexer
	{
		[Token(Token = "0x200002F")]
		private delegate bool StateHandler(FsmContext ctx);

		[Token(Token = "0x40000AE")]
		[FieldOffset(Offset = "0x0")]
		private static int[] fsm_return_table;

		[Token(Token = "0x40000AF")]
		[FieldOffset(Offset = "0x8")]
		private static StateHandler[] fsm_handler_table;

		[Token(Token = "0x40000B0")]
		[FieldOffset(Offset = "0x10")]
		private bool allow_comments;

		[Token(Token = "0x40000B1")]
		[FieldOffset(Offset = "0x11")]
		private bool allow_single_quoted_strings;

		[Token(Token = "0x40000B2")]
		[FieldOffset(Offset = "0x12")]
		private bool end_of_input;

		[Token(Token = "0x40000B3")]
		[FieldOffset(Offset = "0x18")]
		private FsmContext fsm_context;

		[Token(Token = "0x40000B4")]
		[FieldOffset(Offset = "0x20")]
		private int input_buffer;

		[Token(Token = "0x40000B5")]
		[FieldOffset(Offset = "0x24")]
		private int input_char;

		[Token(Token = "0x40000B6")]
		[FieldOffset(Offset = "0x28")]
		private TextReader reader;

		[Token(Token = "0x40000B7")]
		[FieldOffset(Offset = "0x30")]
		private int state;

		[Token(Token = "0x40000B8")]
		[FieldOffset(Offset = "0x38")]
		private StringBuilder string_buffer;

		[Token(Token = "0x40000B9")]
		[FieldOffset(Offset = "0x40")]
		private string string_value;

		[Token(Token = "0x40000BA")]
		[FieldOffset(Offset = "0x48")]
		private int token;

		[Token(Token = "0x40000BB")]
		[FieldOffset(Offset = "0x4C")]
		private int unichar;

		[Token(Token = "0x17000053")]
		public bool AllowComments
		{
			[Token(Token = "0x60001B9")]
			[Address(RVA = "0x1237B40", Offset = "0x1237B40", VA = "0x1237B40")]
			get
			{
				return default;
			}
			[Token(Token = "0x60001BA")]
			[Address(RVA = "0x1237B48", Offset = "0x1237B48", VA = "0x1237B48")]
			set
			{
			}
		}

		[Token(Token = "0x17000054")]
		public bool AllowSingleQuotedStrings
		{
			[Token(Token = "0x60001BB")]
			[Address(RVA = "0x1237B50", Offset = "0x1237B50", VA = "0x1237B50")]
			get
			{
				return default;
			}
			[Token(Token = "0x60001BC")]
			[Address(RVA = "0x1237B58", Offset = "0x1237B58", VA = "0x1237B58")]
			set
			{
			}
		}

		[Token(Token = "0x17000055")]
		public bool EndOfInput
		{
			[Token(Token = "0x60001BD")]
			[Address(RVA = "0x1237B60", Offset = "0x1237B60", VA = "0x1237B60")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000056")]
		public int Token
		{
			[Token(Token = "0x60001BE")]
			[Address(RVA = "0x1237B68", Offset = "0x1237B68", VA = "0x1237B68")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000057")]
		public string StringValue
		{
			[Token(Token = "0x60001BF")]
			[Address(RVA = "0x1237B70", Offset = "0x1237B70", VA = "0x1237B70")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x1237B78", Offset = "0x1237B78", VA = "0x1237B78")]
		static Lexer()
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x1234F58", Offset = "0x1234F58", VA = "0x1234F58")]
		public Lexer(TextReader reader)
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x1238634", Offset = "0x1238634", VA = "0x1238634")]
		private static int HexValue(int digit)
		{
			return default;
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x1237B7C", Offset = "0x1237B7C", VA = "0x1237B7C")]
		private static void PopulateFsmTables()
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x12386D4", Offset = "0x12386D4", VA = "0x12386D4")]
		private static char ProcessEscChar(int esc_char)
		{
			return default;
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x12387BC", Offset = "0x12387BC", VA = "0x12387BC")]
		private static bool State1(FsmContext ctx)
		{
			return default;
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x1238A40", Offset = "0x1238A40", VA = "0x1238A40")]
		private static bool State2(FsmContext ctx)
		{
			return default;
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x1238B04", Offset = "0x1238B04", VA = "0x1238B04")]
		private static bool State3(FsmContext ctx)
		{
			return default;
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x1238C54", Offset = "0x1238C54", VA = "0x1238C54")]
		private static bool State4(FsmContext ctx)
		{
			return default;
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x1238D6C", Offset = "0x1238D6C", VA = "0x1238D6C")]
		private static bool State5(FsmContext ctx)
		{
			return default;
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x1238E08", Offset = "0x1238E08", VA = "0x1238E08")]
		private static bool State6(FsmContext ctx)
		{
			return default;
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x1238F28", Offset = "0x1238F28", VA = "0x1238F28")]
		private static bool State7(FsmContext ctx)
		{
			return default;
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x1238FDC", Offset = "0x1238FDC", VA = "0x1238FDC")]
		private static bool State8(FsmContext ctx)
		{
			return default;
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x12390CC", Offset = "0x12390CC", VA = "0x12390CC")]
		private static bool State9(FsmContext ctx)
		{
			return default;
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x123915C", Offset = "0x123915C", VA = "0x123915C")]
		private static bool State10(FsmContext ctx)
		{
			return default;
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x12391EC", Offset = "0x12391EC", VA = "0x12391EC")]
		private static bool State11(FsmContext ctx)
		{
			return default;
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x1239280", Offset = "0x1239280", VA = "0x1239280")]
		private static bool State12(FsmContext ctx)
		{
			return default;
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x1239310", Offset = "0x1239310", VA = "0x1239310")]
		private static bool State13(FsmContext ctx)
		{
			return default;
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x12393A0", Offset = "0x12393A0", VA = "0x12393A0")]
		private static bool State14(FsmContext ctx)
		{
			return default;
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x1239430", Offset = "0x1239430", VA = "0x1239430")]
		private static bool State15(FsmContext ctx)
		{
			return default;
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x12394C4", Offset = "0x12394C4", VA = "0x12394C4")]
		private static bool State16(FsmContext ctx)
		{
			return default;
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x1239554", Offset = "0x1239554", VA = "0x1239554")]
		private static bool State17(FsmContext ctx)
		{
			return default;
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x12395E4", Offset = "0x12395E4", VA = "0x12395E4")]
		private static bool State18(FsmContext ctx)
		{
			return default;
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x1239678", Offset = "0x1239678", VA = "0x1239678")]
		private static bool State19(FsmContext ctx)
		{
			return default;
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x1239740", Offset = "0x1239740", VA = "0x1239740")]
		private static bool State20(FsmContext ctx)
		{
			return default;
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x12397D4", Offset = "0x12397D4", VA = "0x12397D4")]
		private static bool State21(FsmContext ctx)
		{
			return default;
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x1239984", Offset = "0x1239984", VA = "0x1239984")]
		private static bool State22(FsmContext ctx)
		{
			return default;
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x1239B40", Offset = "0x1239B40", VA = "0x1239B40")]
		private static bool State23(FsmContext ctx)
		{
			return default;
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x1239C08", Offset = "0x1239C08", VA = "0x1239C08")]
		private static bool State24(FsmContext ctx)
		{
			return default;
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x1239CA4", Offset = "0x1239CA4", VA = "0x1239CA4")]
		private static bool State25(FsmContext ctx)
		{
			return default;
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x1239D48", Offset = "0x1239D48", VA = "0x1239D48")]
		private static bool State26(FsmContext ctx)
		{
			return default;
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x1239DD0", Offset = "0x1239DD0", VA = "0x1239DD0")]
		private static bool State27(FsmContext ctx)
		{
			return default;
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x1239E58", Offset = "0x1239E58", VA = "0x1239E58")]
		private static bool State28(FsmContext ctx)
		{
			return default;
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x12389D8", Offset = "0x12389D8", VA = "0x12389D8")]
		private bool GetChar()
		{
			return default;
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x1239EF0", Offset = "0x1239EF0", VA = "0x1239EF0")]
		private int NextChar()
		{
			return default;
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x123556C", Offset = "0x123556C", VA = "0x123556C")]
		public bool NextToken()
		{
			return default;
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x1238C48", Offset = "0x1238C48", VA = "0x1238C48")]
		private void UngetChar()
		{
		}
	}
}
