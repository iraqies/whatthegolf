using System.Collections.Generic;
using System.Text;
using ZXing.Common;

namespace ZXing.Datamatrix.Encoder
{
	internal static class MinimalEncoder
	{
		internal enum Mode
		{
			ASCII = 0,
			C40 = 1,
			TEXT = 2,
			X12 = 3,
			EDF = 4,
			B256 = 5
		}

		internal class Edge
		{
			private static int[] allCodewordCapacities;

			private static int[] squareCodewordCapacities;

			private static int[] rectangularCodewordCapacities;

			internal Input input;

			private Mode mode;

			internal int fromPosition;

			internal int characterLength;

			internal Edge previous;

			internal int cachedTotalSize;

			internal Mode Mode => Mode.ASCII;

			internal Edge(Input input, Mode mode, int fromPosition, int characterLength, Edge previous)
			{
			}

			private int getB256Size()
			{
				return 0;
			}

			internal Mode getPreviousStartMode()
			{
				return Mode.ASCII;
			}

			internal Mode getPreviousMode()
			{
				return Mode.ASCII;
			}

			internal Mode getEndMode()
			{
				return Mode.ASCII;
			}

			private int getLastASCII()
			{
				return 0;
			}

			internal int getMinSymbolSize(int minimum)
			{
				return 0;
			}

			private int getCodewordsRemaining(int minimum)
			{
				return 0;
			}

			internal static byte[] getBytes(int c)
			{
				return null;
			}

			private static byte[] getBytes(int c1, int c2)
			{
				return null;
			}

			private static void setC40Word(byte[] bytes, int offset, int c1, int c2, int c3)
			{
			}

			private static int getX12Value(char c)
			{
				return 0;
			}

			private byte[] getX12Words()
			{
				return null;
			}

			private static int getShiftValue(char c, bool c40, int fnc1)
			{
				return 0;
			}

			private static int getC40Value(bool c40, int setIndex, char c, int fnc1)
			{
				return 0;
			}

			private byte[] getC40Words(bool c40, int fnc1)
			{
				return null;
			}

			private byte[] getEDFBytes()
			{
				return null;
			}

			internal byte[] getLatchBytes()
			{
				return null;
			}

			internal byte[] getDataBytes()
			{
				return null;
			}
		}

		internal class Result
		{
			private Input input;

			private byte[] bytes;

			public byte[] Bytes => null;

			public Result(Edge solution)
			{
			}

			private static int prepend(byte[] bytes, List<byte> into)
			{
				return 0;
			}

			private static int randomize253State(int codewordPosition)
			{
				return 0;
			}

			private static void applyRandomPattern(List<byte> bytesAL, int startPosition, int length)
			{
			}
		}

		internal class Input : MinimalECIInput
		{
			private SymbolShapeHint shape;

			private int macroId;

			public Input(string stringToEncode, Encoding priorityCharset, int fnc1, SymbolShapeHint shape, int macroId)
				: base(null, null, 0)
			{
			}

			internal int getMacroId()
			{
				return 0;
			}

			internal SymbolShapeHint getShapeHint()
			{
				return SymbolShapeHint.FORCE_NONE;
			}
		}

		private static char[] C40_SHIFT2_CHARS;

		private static bool isExtendedASCII(char ch, int fnc1)
		{
			return false;
		}

		private static bool isInC40Shift1Set(char ch)
		{
			return false;
		}

		private static bool isInC40Shift2Set(char ch, int fnc1)
		{
			return false;
		}

		private static bool isInTextShift1Set(char ch)
		{
			return false;
		}

		private static bool isInTextShift2Set(char ch, int fnc1)
		{
			return false;
		}

		public static string encodeHighLevel(string msg, Encoding priorityCharset, int fnc1, SymbolShapeHint shape)
		{
			return null;
		}

		private static byte[] encode(string input, Encoding priorityCharset, int fnc1, SymbolShapeHint shape, int macroId)
		{
			return null;
		}

		private static void addEdge(Edge[][] edges, Edge edge)
		{
		}

		private static int getNumberOfC40Words(Input input, int from, bool c40, int[] characterLength)
		{
			return 0;
		}

		private static void addEdges(Input input, Edge[][] edges, int from, Edge previous)
		{
		}

		private static Result encodeMinimally(Input input)
		{
			return null;
		}
	}
}
