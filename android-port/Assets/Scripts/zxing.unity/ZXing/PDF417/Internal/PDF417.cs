using System.Text;

namespace ZXing.PDF417.Internal
{
	internal sealed class PDF417
	{
		private static readonly int[][] CODEWORD_TABLE;

		private BarcodeMatrix barcodeMatrix;

		private bool compact;

		private Compaction compaction;

		private Encoding encoding;

		private PDF417MacroMetadata metadata;

		private bool disableEci;

		private int minCols;

		private int maxCols;

		private int maxRows;

		private int minRows;

		private float preferredRatio;

		internal BarcodeMatrix BarcodeMatrix => null;

		internal PDF417()
		{
		}

		internal PDF417(bool compact)
		{
		}

		private static int calculateNumberOfRows(int m, int k, int c)
		{
			return 0;
		}

		private static int getNumberOfPadCodewords(int m, int k, int c, int r)
		{
			return 0;
		}

		private static void encodeChar(int pattern, int len, BarcodeRow logic)
		{
		}

		private void encodeLowLevel(string fullCodewords, int c, int r, int errorCorrectionLevel, BarcodeMatrix logic)
		{
		}

		internal void generateBarcodeLogic(string msg, int errorCorrectionLevel, int longDimension, int shortDimension, ref int aspectRatio, bool autoECI)
		{
		}

		private string getMacroBlock(ref int sourceCodeWords)
		{
			return null;
		}

		private void appendMacroOptionalField(PDF417OptionalMacroFields field, string value, ref int sourceCodeWords, StringBuilder macroCodewords)
		{
		}

		internal int[] determineDimensions(int sourceCodeWords, int errorCorrectionCodeWords, int longDimension, int shortDimension, ref int aspectRatio)
		{
			return null;
		}

		internal void setDesiredAspectRatio(float ratio)
		{
		}

		internal void setDimensions(int maxCols, int minCols, int maxRows, int minRows)
		{
		}

		internal void setCompaction(Compaction compaction)
		{
		}

		internal void setCompact(bool compact)
		{
		}

		internal void setEncoding(Encoding encoding)
		{
		}

		internal void setDisableEci(bool disabled)
		{
		}

		internal void setMetaData(PDF417MacroMetadata metadata)
		{
		}
	}
}
