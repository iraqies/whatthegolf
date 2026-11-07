namespace Newtonsoft.Json.Utilities
{
	internal struct StringReference
	{
		private readonly char[] _chars;

		private readonly int _startIndex;

		private readonly int _length;

		// C# has no syntax for parameterized property 'Item'.
		public char get_Item(int i)
		{
			return '\0';
		}

		public char[] Chars => null;

		public int StartIndex => 0;

		public int Length => 0;

		public StringReference(char[] chars, int startIndex, int length)
		{
			_chars = null;
			_startIndex = 0;
			_length = 0;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
