using System.Text;

namespace ZXing.Datamatrix.Encoder
{
	internal sealed class EncoderContext
	{
		private readonly string msg;

		private SymbolShapeHint shape;

		private Dimension minSize;

		private Dimension maxSize;

		private readonly StringBuilder codewords;

		private int pos;

		private int newEncoding;

		private SymbolInfo symbolInfo;

		private int skipAtEnd;

		private static readonly Encoding encoding;

		public char CurrentChar => '\0';

		public int CodewordCount => 0;

		public bool HasMoreCharacters => false;

		private int TotalMessageCharCount => 0;

		public int RemainingCharacters => 0;

		public int Pos
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public StringBuilder Codewords => null;

		public SymbolInfo SymbolInfo => null;

		public int NewEncoding => 0;

		public string Message => null;

		public bool Fnc1CodewordIsWritten { get; set; }

		static EncoderContext()
		{
		}

		public EncoderContext(string msg, Encoding customEncoding, bool disableEci)
		{
		}

		public void setSymbolShape(SymbolShapeHint shape)
		{
		}

		public void setSizeConstraints(Dimension minSize, Dimension maxSize)
		{
		}

		public void setSkipAtEnd(int count)
		{
		}

		public void writeCodewords(string codewords)
		{
		}

		public void writeCodeword(char codeword)
		{
		}

		public void signalEncoderChange(int encoding)
		{
		}

		public void resetEncoderSignal()
		{
		}

		public void updateSymbolInfo()
		{
		}

		public void updateSymbolInfo(int len)
		{
		}

		public void resetSymbolInfo()
		{
		}
	}
}
