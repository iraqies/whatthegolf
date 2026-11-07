namespace RedBlueGames.Tools.TextTyper
{
	public class RichTextTag
	{
		public static readonly RichTextTag ClearColorTag;

		public string TagText { get; private set; }

		public string ClosingTagText => null;

		public string TagType => null;

		public string Parameter => null;

		public bool IsOpeningTag => false;

		public bool IsClosingTag => false;

		public int Length => 0;

		public RichTextTag(string tagText)
		{
		}

		public static bool StringStartsWithTag(string text)
		{
			return false;
		}

		public static RichTextTag ParseNext(string text)
		{
			return null;
		}

		public static string RemoveTagsFromString(string text, string tagType)
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
