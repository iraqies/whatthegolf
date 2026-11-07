using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;

namespace ThirdParty.Json.LitJson
{
	[Token(Token = "0x2000029")]
	public class JsonReader
	{
		[Token(Token = "0x4000087")]
		[FieldOffset(Offset = "0x10")]
		private Stack<JsonToken> depth;

		[Token(Token = "0x4000088")]
		[FieldOffset(Offset = "0x18")]
		private int current_input;

		[Token(Token = "0x4000089")]
		[FieldOffset(Offset = "0x1C")]
		private int current_symbol;

		[Token(Token = "0x400008A")]
		[FieldOffset(Offset = "0x20")]
		private bool end_of_json;

		[Token(Token = "0x400008B")]
		[FieldOffset(Offset = "0x21")]
		private bool end_of_input;

		[Token(Token = "0x400008C")]
		[FieldOffset(Offset = "0x28")]
		private Lexer lexer;

		[Token(Token = "0x400008D")]
		[FieldOffset(Offset = "0x30")]
		private bool parser_in_string;

		[Token(Token = "0x400008E")]
		[FieldOffset(Offset = "0x31")]
		private bool parser_return;

		[Token(Token = "0x400008F")]
		[FieldOffset(Offset = "0x32")]
		private bool read_started;

		[Token(Token = "0x4000090")]
		[FieldOffset(Offset = "0x38")]
		private TextReader reader;

		[Token(Token = "0x4000091")]
		[FieldOffset(Offset = "0x40")]
		private bool reader_is_owned;

		[Token(Token = "0x4000092")]
		[FieldOffset(Offset = "0x48")]
		private object token_value;

		[Token(Token = "0x4000093")]
		[FieldOffset(Offset = "0x50")]
		private JsonToken token;

		[Token(Token = "0x17000049")]
		public bool AllowComments
		{
			[Token(Token = "0x6000182")]
			[Address(RVA = "0x1234DA8", Offset = "0x1234DA8", VA = "0x1234DA8")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000183")]
			[Address(RVA = "0x1234DC4", Offset = "0x1234DC4", VA = "0x1234DC4")]
			set
			{
			}
		}

		[Token(Token = "0x1700004A")]
		public bool AllowSingleQuotedStrings
		{
			[Token(Token = "0x6000184")]
			[Address(RVA = "0x1234DE0", Offset = "0x1234DE0", VA = "0x1234DE0")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000185")]
			[Address(RVA = "0x1234DFC", Offset = "0x1234DFC", VA = "0x1234DFC")]
			set
			{
			}
		}

		[Token(Token = "0x1700004B")]
		public bool EndOfInput
		{
			[Token(Token = "0x6000186")]
			[Address(RVA = "0x1234E18", Offset = "0x1234E18", VA = "0x1234E18")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700004C")]
		public bool EndOfJson
		{
			[Token(Token = "0x6000187")]
			[Address(RVA = "0x1234E20", Offset = "0x1234E20", VA = "0x1234E20")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700004D")]
		public JsonToken Token
		{
			[Token(Token = "0x6000188")]
			[Address(RVA = "0x1234E28", Offset = "0x1234E28", VA = "0x1234E28")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700004E")]
		public object Value
		{
			[Token(Token = "0x6000189")]
			[Address(RVA = "0x1234E30", Offset = "0x1234E30", VA = "0x1234E30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x122F5AC", Offset = "0x122F5AC", VA = "0x122F5AC")]
		public JsonReader(string json_text)
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x122F328", Offset = "0x122F328", VA = "0x122F328")]
		public JsonReader(TextReader reader)
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x1234E38", Offset = "0x1234E38", VA = "0x1234E38")]
		private JsonReader(TextReader reader, bool owned)
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x123502C", Offset = "0x123502C", VA = "0x123502C")]
		private void ProcessNumber(string number)
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x123530C", Offset = "0x123530C", VA = "0x123530C")]
		private void ProcessSymbol()
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x12354F4", Offset = "0x12354F4", VA = "0x12354F4")]
		private bool ReadToken()
		{
			return default;
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x1235728", Offset = "0x1235728", VA = "0x1235728")]
		public void Close()
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x122C7B8", Offset = "0x122C7B8", VA = "0x122C7B8")]
		public bool Read()
		{
			return default;
		}
	}
}
