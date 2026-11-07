using System.Text;
using Il2CppDummyDll;

namespace ZXing.PDF417.Internal
{
	[Token(Token = "0x2000032")]
	internal sealed class PDF417
	{
		[Token(Token = "0x40000C1")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int[][] CODEWORD_TABLE;

		[Token(Token = "0x40000C2")]
		[FieldOffset(Offset = "0x10")]
		private BarcodeMatrix barcodeMatrix;

		[Token(Token = "0x40000C3")]
		[FieldOffset(Offset = "0x18")]
		private bool compact;

		[Token(Token = "0x40000C4")]
		[FieldOffset(Offset = "0x1C")]
		private Compaction compaction;

		[Token(Token = "0x40000C5")]
		[FieldOffset(Offset = "0x20")]
		private Encoding encoding;

		[Token(Token = "0x40000C6")]
		[FieldOffset(Offset = "0x28")]
		private PDF417MacroMetadata metadata;

		[Token(Token = "0x40000C7")]
		[FieldOffset(Offset = "0x30")]
		private bool disableEci;

		[Token(Token = "0x40000C8")]
		[FieldOffset(Offset = "0x34")]
		private int minCols;

		[Token(Token = "0x40000C9")]
		[FieldOffset(Offset = "0x38")]
		private int maxCols;

		[Token(Token = "0x40000CA")]
		[FieldOffset(Offset = "0x3C")]
		private int maxRows;

		[Token(Token = "0x40000CB")]
		[FieldOffset(Offset = "0x40")]
		private int minRows;

		[Token(Token = "0x40000CC")]
		[FieldOffset(Offset = "0x44")]
		private float preferredRatio;

		[Token(Token = "0x17000033")]
		internal BarcodeMatrix BarcodeMatrix
		{
			[Token(Token = "0x6000131")]
			[Address(RVA = "0x2ECA8DC", Offset = "0x2ECA8DC", VA = "0x2ECA8DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x2ECA830", Offset = "0x2ECA830", VA = "0x2ECA830")]
		internal PDF417()
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x2ECA884", Offset = "0x2ECA884", VA = "0x2ECA884")]
		internal PDF417(bool compact)
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x2ECA8E4", Offset = "0x2ECA8E4", VA = "0x2ECA8E4")]
		private static int calculateNumberOfRows(int m, int k, int c)
		{
			return default;
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x2ECA908", Offset = "0x2ECA908", VA = "0x2ECA908")]
		private static int getNumberOfPadCodewords(int m, int k, int c, int r)
		{
			return default;
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x2ECA928", Offset = "0x2ECA928", VA = "0x2ECA928")]
		private static void encodeChar(int pattern, int len, BarcodeRow logic)
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x2ECA9D4", Offset = "0x2ECA9D4", VA = "0x2ECA9D4")]
		private void encodeLowLevel(string fullCodewords, int c, int r, int errorCorrectionLevel, BarcodeMatrix logic)
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x2ECAF40", Offset = "0x2ECAF40", VA = "0x2ECAF40")]
		internal void generateBarcodeLogic(string msg, int errorCorrectionLevel, int longDimension, int shortDimension, ref int aspectRatio, bool autoECI)
		{
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x2ECBE38", Offset = "0x2ECBE38", VA = "0x2ECBE38")]
		private string getMacroBlock(ref int sourceCodeWords)
		{
			return null;
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x2ECCF68", Offset = "0x2ECCF68", VA = "0x2ECCF68")]
		private void appendMacroOptionalField(PDF417OptionalMacroFields field, string value, ref int sourceCodeWords, StringBuilder macroCodewords)
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x2ECC6C8", Offset = "0x2ECC6C8", VA = "0x2ECC6C8")]
		internal int[] determineDimensions(int sourceCodeWords, int errorCorrectionCodeWords, int longDimension, int shortDimension, ref int aspectRatio)
		{
			return null;
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x2ECD15C", Offset = "0x2ECD15C", VA = "0x2ECD15C")]
		internal void setDesiredAspectRatio(float ratio)
		{
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x2ECD164", Offset = "0x2ECD164", VA = "0x2ECD164")]
		internal void setDimensions(int maxCols, int minCols, int maxRows, int minRows)
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x2ECD170", Offset = "0x2ECD170", VA = "0x2ECD170")]
		internal void setCompaction(Compaction compaction)
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x2ECD178", Offset = "0x2ECD178", VA = "0x2ECD178")]
		internal void setCompact(bool compact)
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x2ECD180", Offset = "0x2ECD180", VA = "0x2ECD180")]
		internal void setEncoding(Encoding encoding)
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x2ECD188", Offset = "0x2ECD188", VA = "0x2ECD188")]
		internal void setDisableEci(bool disabled)
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x2ECD190", Offset = "0x2ECD190", VA = "0x2ECD190")]
		internal void setMetaData(PDF417MacroMetadata metadata)
		{
		}
	}
}
