namespace ZXing.QrCode.Internal
{
	public sealed class Mode
	{
		public enum Names
		{
			TERMINATOR = 0,
			NUMERIC = 1,
			ALPHANUMERIC = 2,
			STRUCTURED_APPEND = 3,
			BYTE = 4,
			ECI = 5,
			KANJI = 6,
			FNC1_FIRST_POSITION = 7,
			FNC1_SECOND_POSITION = 8,
			HANZI = 9
		}

		public static readonly Mode TERMINATOR;

		public static readonly Mode NUMERIC;

		public static readonly Mode ALPHANUMERIC;

		public static readonly Mode STRUCTURED_APPEND;

		public static readonly Mode BYTE;

		public static readonly Mode ECI;

		public static readonly Mode KANJI;

		public static readonly Mode FNC1_FIRST_POSITION;

		public static readonly Mode FNC1_SECOND_POSITION;

		public static readonly Mode HANZI;

		private readonly int[] characterCountBitsForVersions;

		public Names Name { get; private set; }

		public int Bits { get; private set; }

		private Mode(int[] characterCountBitsForVersions, int bits, Names name)
		{
		}

		public int getCharacterCountBits(Version version)
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
