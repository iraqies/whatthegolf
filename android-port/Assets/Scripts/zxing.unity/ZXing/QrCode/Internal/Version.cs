namespace ZXing.QrCode.Internal
{
	public sealed class Version
	{
		public sealed class ECBlocks
		{
			private readonly int ecCodewordsPerBlock;

			private readonly ECB[] ecBlocks;

			public int ECCodewordsPerBlock => 0;

			public int NumBlocks => 0;

			public int TotalECCodewords => 0;

			internal ECBlocks(int ecCodewordsPerBlock, params ECB[] ecBlocks)
			{
			}

			public ECB[] getECBlocks()
			{
				return null;
			}
		}

		public sealed class ECB
		{
			private readonly int count;

			private readonly int dataCodewords;

			public int Count => 0;

			public int DataCodewords => 0;

			internal ECB(int count, int dataCodewords)
			{
			}
		}

		private static readonly int[] VERSION_DECODE_INFO;

		private static readonly Version[] VERSIONS;

		private readonly int versionNumber;

		private readonly int[] alignmentPatternCenters;

		private readonly ECBlocks[] ecBlocks;

		private readonly int totalCodewords;

		public int VersionNumber => 0;

		public int TotalCodewords => 0;

		public int DimensionForVersion => 0;

		private Version(int versionNumber, int[] alignmentPatternCenters, params ECBlocks[] ecBlocks)
		{
		}

		public ECBlocks getECBlocksForLevel(ErrorCorrectionLevel ecLevel)
		{
			return null;
		}

		public static Version getVersionForNumber(int versionNumber)
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		private static Version[] buildVersions()
		{
			return null;
		}
	}
}
