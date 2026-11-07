using System.Collections.Generic;
using Il2CppDummyDll;

namespace RedBlueGames.Tools.TextTyper
{
	[Token(Token = "0x200102C")]
	public sealed class TypedTextGenerator
	{
		[Token(Token = "0x200102D")]
		public class TypedText
		{
			[Token(Token = "0x400554F")]
			[FieldOffset(Offset = "0x10")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x554E0", Offset = "0x554E0")]
			private string TextToPrint__BackingField;

			[Token(Token = "0x4005550")]
			[FieldOffset(Offset = "0x18")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x554F0", Offset = "0x554F0")]
			private float Delay__BackingField;

			[Token(Token = "0x4005551")]
			[FieldOffset(Offset = "0x1C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x55500", Offset = "0x55500")]
			private char LastPrintedChar__BackingField;

			[Token(Token = "0x4005552")]
			[FieldOffset(Offset = "0x1E")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x55510", Offset = "0x55510")]
			private bool IsComplete__BackingField;

			[Token(Token = "0x170007A1")]
			public string TextToPrint
			{
				[Token(Token = "0x6004869")]
				[Address(RVA = "0x1871204", Offset = "0x1871204", VA = "0x1871204")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6EF34", Offset = "0x6EF34")]
				get
				{
					return null;
				}
				[Token(Token = "0x600486A")]
				[Address(RVA = "0x187120C", Offset = "0x187120C", VA = "0x187120C")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6EF44", Offset = "0x6EF44")]
				set
				{
				}
			}

			[Token(Token = "0x170007A2")]
			public float Delay
			{
				[Token(Token = "0x600486B")]
				[Address(RVA = "0x1871214", Offset = "0x1871214", VA = "0x1871214")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6EF54", Offset = "0x6EF54")]
				get
				{
					return default;
				}
				[Token(Token = "0x600486C")]
				[Address(RVA = "0x187121C", Offset = "0x187121C", VA = "0x187121C")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6EF64", Offset = "0x6EF64")]
				set
				{
				}
			}

			[Token(Token = "0x170007A3")]
			public char LastPrintedChar
			{
				[Token(Token = "0x600486D")]
				[Address(RVA = "0x1871224", Offset = "0x1871224", VA = "0x1871224")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6EF74", Offset = "0x6EF74")]
				get
				{
					return default;
				}
				[Token(Token = "0x600486E")]
				[Address(RVA = "0x187122C", Offset = "0x187122C", VA = "0x187122C")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6EF84", Offset = "0x6EF84")]
				set
				{
				}
			}

			[Token(Token = "0x170007A4")]
			public bool IsComplete
			{
				[Token(Token = "0x600486F")]
				[Address(RVA = "0x1871234", Offset = "0x1871234", VA = "0x1871234")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6EF94", Offset = "0x6EF94")]
				get
				{
					return default;
				}
				[Token(Token = "0x6004870")]
				[Address(RVA = "0x187123C", Offset = "0x187123C", VA = "0x187123C")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6EFA4", Offset = "0x6EFA4")]
				set
				{
				}
			}

			[Token(Token = "0x6004871")]
			[Address(RVA = "0x1871244", Offset = "0x1871244", VA = "0x1871244")]
			public TypedText()
			{
			}
		}

		[Token(Token = "0x200102E")]
		private class TypedTextSymbol
		{
			[Token(Token = "0x4005553")]
			[FieldOffset(Offset = "0x10")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x55520", Offset = "0x55520")]
			private string Character__BackingField;

			[Token(Token = "0x4005554")]
			[FieldOffset(Offset = "0x18")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x55530", Offset = "0x55530")]
			private RichTextTag Tag__BackingField;

			[Token(Token = "0x170007A5")]
			public string Character
			{
				[Token(Token = "0x6004874")]
				[Address(RVA = "0x18712A4", Offset = "0x18712A4", VA = "0x18712A4")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6EFB4", Offset = "0x6EFB4")]
				get
				{
					return null;
				}
				[Token(Token = "0x6004875")]
				[Address(RVA = "0x18712AC", Offset = "0x18712AC", VA = "0x18712AC")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6EFC4", Offset = "0x6EFC4")]
				private set
				{
				}
			}

			[Token(Token = "0x170007A6")]
			public RichTextTag Tag
			{
				[Token(Token = "0x6004876")]
				[Address(RVA = "0x18712B4", Offset = "0x18712B4", VA = "0x18712B4")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6EFD4", Offset = "0x6EFD4")]
				get
				{
					return null;
				}
				[Token(Token = "0x6004877")]
				[Address(RVA = "0x18712BC", Offset = "0x18712BC", VA = "0x18712BC")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6EFE4", Offset = "0x6EFE4")]
				private set
				{
				}
			}

			[Token(Token = "0x170007A7")]
			public int Length
			{
				[Token(Token = "0x6004878")]
				[Address(RVA = "0x18712C4", Offset = "0x18712C4", VA = "0x18712C4")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x170007A8")]
			public string Text
			{
				[Token(Token = "0x6004879")]
				[Address(RVA = "0x18712EC", Offset = "0x18712EC", VA = "0x18712EC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170007A9")]
			public bool IsTag
			{
				[Token(Token = "0x600487A")]
				[Address(RVA = "0x1871300", Offset = "0x1871300", VA = "0x1871300")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x6004872")]
			[Address(RVA = "0x187124C", Offset = "0x187124C", VA = "0x187124C")]
			public TypedTextSymbol(string character)
			{
			}

			[Token(Token = "0x6004873")]
			[Address(RVA = "0x1871278", Offset = "0x1871278", VA = "0x1871278")]
			public TypedTextSymbol(RichTextTag tag)
			{
			}
		}

		[Token(Token = "0x400554D")]
		[FieldOffset(Offset = "0x0")]
		private static readonly List<string> UnityTagTypes;

		[Token(Token = "0x400554E")]
		[FieldOffset(Offset = "0x8")]
		private static readonly List<string> CustomTagTypes;

		[Token(Token = "0x6004861")]
		[Address(RVA = "0x1735770", Offset = "0x1735770", VA = "0x1735770")]
		public TypedText GetCompletedText(string text)
		{
			return null;
		}

		[Token(Token = "0x6004862")]
		[Address(RVA = "0x1735A04", Offset = "0x1735A04", VA = "0x1735A04")]
		public TypedText GetTypedTextAt(string text, int visibleCharacterIndex)
		{
			return null;
		}

		[Token(Token = "0x6004863")]
		[Address(RVA = "0x1736630", Offset = "0x1736630", VA = "0x1736630")]
		private static List<RichTextTag> GetActiveTagsInSymbolList(List<TypedTextSymbol> symbolList, int visibleCharacterPosition)
		{
			return null;
		}

		[Token(Token = "0x6004864")]
		[Address(RVA = "0x1736468", Offset = "0x1736468", VA = "0x1736468")]
		private static List<TypedTextSymbol> CreateSymbolListFromText(string text)
		{
			return null;
		}

		[Token(Token = "0x6004865")]
		[Address(RVA = "0x1735840", Offset = "0x1735840", VA = "0x1735840")]
		private static string RemoveCustomTags(string textWithTags)
		{
			return null;
		}

		[Token(Token = "0x6004866")]
		[Address(RVA = "0x17369E0", Offset = "0x17369E0", VA = "0x17369E0")]
		private static string RemoveFirstOccurance(string source, string searchString)
		{
			return null;
		}

		[Token(Token = "0x6004867")]
		[Address(RVA = "0x1736A38", Offset = "0x1736A38", VA = "0x1736A38")]
		public TypedTextGenerator()
		{
		}
	}
}
