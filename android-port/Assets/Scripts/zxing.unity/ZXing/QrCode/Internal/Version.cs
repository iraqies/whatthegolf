using Il2CppDummyDll;

namespace ZXing.QrCode.Internal
{
	[Token(Token = "0x200001D")]
	public sealed class Version
	{
		[Token(Token = "0x200001E")]
		public sealed class ECBlocks
		{
			[Token(Token = "0x4000077")]
			[FieldOffset(Offset = "0x10")]
			private readonly int ecCodewordsPerBlock;

			[Token(Token = "0x4000078")]
			[FieldOffset(Offset = "0x18")]
			private readonly ECB[] ecBlocks;

			[Token(Token = "0x17000014")]
			public int ECCodewordsPerBlock
			{
				[Token(Token = "0x60000A7")]
				[Address(RVA = "0x2EE624C", Offset = "0x2EE624C", VA = "0x2EE624C")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000015")]
			public int NumBlocks
			{
				[Token(Token = "0x60000A8")]
				[Address(RVA = "0x2EE6254", Offset = "0x2EE6254", VA = "0x2EE6254")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000016")]
			public int TotalECCodewords
			{
				[Token(Token = "0x60000A9")]
				[Address(RVA = "0x2EE62C8", Offset = "0x2EE62C8", VA = "0x2EE62C8")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x60000A6")]
			[Address(RVA = "0x2EE15B4", Offset = "0x2EE15B4", VA = "0x2EE15B4")]
			internal ECBlocks(int ecCodewordsPerBlock, params ECB[] ecBlocks)
			{
			}

			[Token(Token = "0x60000AA")]
			[Address(RVA = "0x2EE6330", Offset = "0x2EE6330", VA = "0x2EE6330")]
			public ECB[] getECBlocks()
			{
				return null;
			}
		}

		[Token(Token = "0x200001F")]
		public sealed class ECB
		{
			[Token(Token = "0x4000079")]
			[FieldOffset(Offset = "0x10")]
			private readonly int count;

			[Token(Token = "0x400007A")]
			[FieldOffset(Offset = "0x14")]
			private readonly int dataCodewords;

			[Token(Token = "0x17000017")]
			public int Count
			{
				[Token(Token = "0x60000AC")]
				[Address(RVA = "0x2EE623C", Offset = "0x2EE623C", VA = "0x2EE623C")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000018")]
			public int DataCodewords
			{
				[Token(Token = "0x60000AD")]
				[Address(RVA = "0x2EE6244", Offset = "0x2EE6244", VA = "0x2EE6244")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x60000AB")]
			[Address(RVA = "0x2EE157C", Offset = "0x2EE157C", VA = "0x2EE157C")]
			internal ECB(int count, int dataCodewords)
			{
			}
		}

		[Token(Token = "0x4000071")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int[] VERSION_DECODE_INFO;

		[Token(Token = "0x4000072")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Version[] VERSIONS;

		[Token(Token = "0x4000073")]
		[FieldOffset(Offset = "0x10")]
		private readonly int versionNumber;

		[Token(Token = "0x4000074")]
		[FieldOffset(Offset = "0x18")]
		private readonly int[] alignmentPatternCenters;

		[Token(Token = "0x4000075")]
		[FieldOffset(Offset = "0x20")]
		private readonly ECBlocks[] ecBlocks;

		[Token(Token = "0x4000076")]
		[FieldOffset(Offset = "0x28")]
		private readonly int totalCodewords;

		[Token(Token = "0x17000011")]
		public int VersionNumber
		{
			[Token(Token = "0x600009E")]
			[Address(RVA = "0x2ED7500", Offset = "0x2ED7500", VA = "0x2ED7500")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000012")]
		public int TotalCodewords
		{
			[Token(Token = "0x600009F")]
			[Address(RVA = "0x2ED7508", Offset = "0x2ED7508", VA = "0x2ED7508")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000013")]
		public int DimensionForVersion
		{
			[Token(Token = "0x60000A0")]
			[Address(RVA = "0x2ED7510", Offset = "0x2ED7510", VA = "0x2ED7510")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x2ED7440", Offset = "0x2ED7440", VA = "0x2ED7440")]
		private Version(int versionNumber, int[] alignmentPatternCenters, params ECBlocks[] ecBlocks)
		{
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x2ED7520", Offset = "0x2ED7520", VA = "0x2ED7520")]
		public ECBlocks getECBlocksForLevel(ErrorCorrectionLevel ecLevel)
		{
			return null;
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x2ED7564", Offset = "0x2ED7564", VA = "0x2ED7564")]
		public static Version getVersionForNumber(int versionNumber)
		{
			return null;
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x2ED7634", Offset = "0x2ED7634", VA = "0x2ED7634", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x2ED76AC", Offset = "0x2ED76AC", VA = "0x2ED76AC")]
		private static Version[] buildVersions()
		{
			return null;
		}
	}
}
