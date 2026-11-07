using System.Collections.Generic;

namespace RedBlueGames.Tools.TextTyper
{
	public sealed class TypedTextGenerator
	{
		public class TypedText
		{
			public string TextToPrint { get; set; }

			public float Delay { get; set; }

			public char LastPrintedChar { get; set; }

			public bool IsComplete { get; set; }
		}

		private class TypedTextSymbol
		{
			public string Character { get; private set; }

			public RichTextTag Tag { get; private set; }

			public int Length => 0;

			public string Text => null;

			public bool IsTag => false;

			public TypedTextSymbol(string character)
			{
			}

			public TypedTextSymbol(RichTextTag tag)
			{
			}
		}

		private static readonly List<string> UnityTagTypes;

		private static readonly List<string> CustomTagTypes;

		public TypedText GetCompletedText(string text)
		{
			return null;
		}

		public TypedText GetTypedTextAt(string text, int visibleCharacterIndex)
		{
			return null;
		}

		private static List<RichTextTag> GetActiveTagsInSymbolList(List<TypedTextSymbol> symbolList, int visibleCharacterPosition)
		{
			return null;
		}

		private static List<TypedTextSymbol> CreateSymbolListFromText(string text)
		{
			return null;
		}

		private static string RemoveCustomTags(string textWithTags)
		{
			return null;
		}

		private static string RemoveFirstOccurance(string source, string searchString)
		{
			return null;
		}
	}
}
