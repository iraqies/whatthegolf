using Il2CppDummyDll;

namespace RedBlueGames.Tools.TextTyper
{
	[Token(Token = "0x2001027")]
	public class RichTextTag
	{
		[Token(Token = "0x4005536")]
		[FieldOffset(Offset = "0x0")]
		public static readonly RichTextTag ClearColorTag;

		[Token(Token = "0x4005537")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x55470", Offset = "0x55470")]
		private string TagText__BackingField;

		[Token(Token = "0x17000795")]
		public string TagText
		{
			[Token(Token = "0x6004838")]
			[Address(RVA = "0x165679C", Offset = "0x165679C", VA = "0x165679C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6EEC4", Offset = "0x6EEC4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004839")]
			[Address(RVA = "0x16567A4", Offset = "0x16567A4", VA = "0x16567A4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6EED4", Offset = "0x6EED4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000796")]
		public string ClosingTagText
		{
			[Token(Token = "0x600483A")]
			[Address(RVA = "0x16567AC", Offset = "0x16567AC", VA = "0x16567AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000797")]
		public string TagType
		{
			[Token(Token = "0x600483B")]
			[Address(RVA = "0x1656888", Offset = "0x1656888", VA = "0x1656888")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000798")]
		public string Parameter
		{
			[Token(Token = "0x600483C")]
			[Address(RVA = "0x1656980", Offset = "0x1656980", VA = "0x1656980")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000799")]
		public bool IsOpeningTag
		{
			[Token(Token = "0x600483D")]
			[Address(RVA = "0x1656A2C", Offset = "0x1656A2C", VA = "0x1656A2C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700079A")]
		public bool IsClosingTag
		{
			[Token(Token = "0x600483E")]
			[Address(RVA = "0x1656840", Offset = "0x1656840", VA = "0x1656840")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700079B")]
		public int Length
		{
			[Token(Token = "0x600483F")]
			[Address(RVA = "0x1656A74", Offset = "0x1656A74", VA = "0x1656A74")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6004837")]
		[Address(RVA = "0x1656770", Offset = "0x1656770", VA = "0x1656770")]
		public RichTextTag(string tagText)
		{
		}

		[Token(Token = "0x6004840")]
		[Address(RVA = "0x1656A90", Offset = "0x1656A90", VA = "0x1656A90")]
		public static bool StringStartsWithTag(string text)
		{
			return default;
		}

		[Token(Token = "0x6004841")]
		[Address(RVA = "0x1656AE0", Offset = "0x1656AE0", VA = "0x1656AE0")]
		public static RichTextTag ParseNext(string text)
		{
			return null;
		}

		[Token(Token = "0x6004842")]
		[Address(RVA = "0x1656B98", Offset = "0x1656B98", VA = "0x1656B98")]
		public static string RemoveTagsFromString(string text, string tagType)
		{
			return null;
		}

		[Token(Token = "0x6004843")]
		[Address(RVA = "0x1656D20", Offset = "0x1656D20", VA = "0x1656D20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
