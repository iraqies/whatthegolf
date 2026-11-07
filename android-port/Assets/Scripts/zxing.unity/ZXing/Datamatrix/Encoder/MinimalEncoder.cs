using System.Collections.Generic;
using System.Text;
using Il2CppDummyDll;
using ZXing.Common;

namespace ZXing.Datamatrix.Encoder
{
	[Token(Token = "0x200005D")]
	internal static class MinimalEncoder
	{
		[Token(Token = "0x200005E")]
		internal enum Mode
		{
			[Token(Token = "0x400014F")]
			ASCII = 0,
			[Token(Token = "0x4000150")]
			C40 = 1,
			[Token(Token = "0x4000151")]
			TEXT = 2,
			[Token(Token = "0x4000152")]
			X12 = 3,
			[Token(Token = "0x4000153")]
			EDF = 4,
			[Token(Token = "0x4000154")]
			B256 = 5
		}

		[Token(Token = "0x200005F")]
		internal class Edge
		{
			[Token(Token = "0x4000155")]
			[FieldOffset(Offset = "0x0")]
			private static int[] allCodewordCapacities;

			[Token(Token = "0x4000156")]
			[FieldOffset(Offset = "0x8")]
			private static int[] squareCodewordCapacities;

			[Token(Token = "0x4000157")]
			[FieldOffset(Offset = "0x10")]
			private static int[] rectangularCodewordCapacities;

			[Token(Token = "0x4000158")]
			[FieldOffset(Offset = "0x10")]
			internal Input input;

			[Token(Token = "0x4000159")]
			[FieldOffset(Offset = "0x18")]
			private Mode mode;

			[Token(Token = "0x400015A")]
			[FieldOffset(Offset = "0x1C")]
			internal int fromPosition;

			[Token(Token = "0x400015B")]
			[FieldOffset(Offset = "0x20")]
			internal int characterLength;

			[Token(Token = "0x400015C")]
			[FieldOffset(Offset = "0x28")]
			internal Edge previous;

			[Token(Token = "0x400015D")]
			[FieldOffset(Offset = "0x30")]
			internal int cachedTotalSize;

			[Token(Token = "0x17000050")]
			internal Mode Mode
			{
				[Token(Token = "0x600021F")]
				[Address(RVA = "0x2EE2804", Offset = "0x2EE2804", VA = "0x2EE2804")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x600021A")]
			[Address(RVA = "0x2EE2018", Offset = "0x2EE2018", VA = "0x2EE2018")]
			internal Edge(Input input, Mode mode, int fromPosition, int characterLength, Edge previous)
			{
			}

			[Token(Token = "0x600021B")]
			[Address(RVA = "0x2EE22EC", Offset = "0x2EE22EC", VA = "0x2EE22EC")]
			private int getB256Size()
			{
				return default;
			}

			[Token(Token = "0x600021C")]
			[Address(RVA = "0x2EE231C", Offset = "0x2EE231C", VA = "0x2EE231C")]
			internal Mode getPreviousStartMode()
			{
				return default;
			}

			[Token(Token = "0x600021D")]
			[Address(RVA = "0x2EE22DC", Offset = "0x2EE22DC", VA = "0x2EE22DC")]
			internal Mode getPreviousMode()
			{
				return default;
			}

			[Token(Token = "0x600021E")]
			[Address(RVA = "0x2EE2334", Offset = "0x2EE2334", VA = "0x2EE2334")]
			internal Mode getEndMode()
			{
				return default;
			}

			[Token(Token = "0x6000220")]
			[Address(RVA = "0x2EE242C", Offset = "0x2EE242C", VA = "0x2EE242C")]
			private int getLastASCII()
			{
				return default;
			}

			[Token(Token = "0x6000221")]
			[Address(RVA = "0x2EE280C", Offset = "0x2EE280C", VA = "0x2EE280C")]
			internal int getMinSymbolSize(int minimum)
			{
				return default;
			}

			[Token(Token = "0x6000222")]
			[Address(RVA = "0x2EE27E0", Offset = "0x2EE27E0", VA = "0x2EE27E0")]
			private int getCodewordsRemaining(int minimum)
			{
				return default;
			}

			[Token(Token = "0x6000223")]
			[Address(RVA = "0x2EE29EC", Offset = "0x2EE29EC", VA = "0x2EE29EC")]
			internal static byte[] getBytes(int c)
			{
				return null;
			}

			[Token(Token = "0x6000224")]
			[Address(RVA = "0x2EE2A64", Offset = "0x2EE2A64", VA = "0x2EE2A64")]
			private static byte[] getBytes(int c1, int c2)
			{
				return null;
			}

			[Token(Token = "0x6000225")]
			[Address(RVA = "0x2EE2AEC", Offset = "0x2EE2AEC", VA = "0x2EE2AEC")]
			private static void setC40Word(byte[] bytes, int offset, int c1, int c2, int c3)
			{
			}

			[Token(Token = "0x6000226")]
			[Address(RVA = "0x2EE2B5C", Offset = "0x2EE2B5C", VA = "0x2EE2B5C")]
			private static int getX12Value(char c)
			{
				return default;
			}

			[Token(Token = "0x6000227")]
			[Address(RVA = "0x2EE2BC8", Offset = "0x2EE2BC8", VA = "0x2EE2BC8")]
			private byte[] getX12Words()
			{
				return null;
			}

			[Token(Token = "0x6000228")]
			[Address(RVA = "0x2EE2EE8", Offset = "0x2EE2EE8", VA = "0x2EE2EE8")]
			private static int getShiftValue(char c, bool c40, int fnc1)
			{
				return default;
			}

			[Token(Token = "0x6000229")]
			[Address(RVA = "0x2EE2FFC", Offset = "0x2EE2FFC", VA = "0x2EE2FFC")]
			private static int getC40Value(bool c40, int setIndex, char c, int fnc1)
			{
				return default;
			}

			[Token(Token = "0x600022A")]
			[Address(RVA = "0x2EE315C", Offset = "0x2EE315C", VA = "0x2EE315C")]
			private byte[] getC40Words(bool c40, int fnc1)
			{
				return null;
			}

			[Token(Token = "0x600022B")]
			[Address(RVA = "0x2EE35D8", Offset = "0x2EE35D8", VA = "0x2EE35D8")]
			private byte[] getEDFBytes()
			{
				return null;
			}

			[Token(Token = "0x600022C")]
			[Address(RVA = "0x2EE3830", Offset = "0x2EE3830", VA = "0x2EE3830")]
			internal byte[] getLatchBytes()
			{
				return null;
			}

			[Token(Token = "0x600022D")]
			[Address(RVA = "0x2EE3CB0", Offset = "0x2EE3CB0", VA = "0x2EE3CB0")]
			internal byte[] getDataBytes()
			{
				return null;
			}
		}

		[Token(Token = "0x2000060")]
		internal class Result
		{
			[Token(Token = "0x400015E")]
			[FieldOffset(Offset = "0x10")]
			private Input input;

			[Token(Token = "0x400015F")]
			[FieldOffset(Offset = "0x18")]
			private byte[] bytes;

			[Token(Token = "0x17000051")]
			public byte[] Bytes
			{
				[Token(Token = "0x6000233")]
				[Address(RVA = "0x2EE4A14", Offset = "0x2EE4A14", VA = "0x2EE4A14")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600022F")]
			[Address(RVA = "0x2EE4278", Offset = "0x2EE4278", VA = "0x2EE4278")]
			public Result(Edge solution)
			{
			}

			[Token(Token = "0x6000230")]
			[Address(RVA = "0x2EE4828", Offset = "0x2EE4828", VA = "0x2EE4828")]
			private static int prepend(byte[] bytes, List<byte> into)
			{
				return default;
			}

			[Token(Token = "0x6000231")]
			[Address(RVA = "0x2EE49D0", Offset = "0x2EE49D0", VA = "0x2EE49D0")]
			private static int randomize253State(int codewordPosition)
			{
				return default;
			}

			[Token(Token = "0x6000232")]
			[Address(RVA = "0x2EE48D8", Offset = "0x2EE48D8", VA = "0x2EE48D8")]
			private static void applyRandomPattern(List<byte> bytesAL, int startPosition, int length)
			{
			}
		}

		[Token(Token = "0x2000061")]
		internal class Input : MinimalECIInput
		{
			[Token(Token = "0x4000160")]
			[FieldOffset(Offset = "0x1C")]
			private SymbolShapeHint shape;

			[Token(Token = "0x4000161")]
			[FieldOffset(Offset = "0x20")]
			private int macroId;

			[Token(Token = "0x6000234")]
			[Address(RVA = "0x2EE41AC", Offset = "0x2EE41AC", VA = "0x2EE41AC")]
			public Input(string stringToEncode, Encoding priorityCharset, int fnc1, SymbolShapeHint shape, int macroId)
			{
			}

			[Token(Token = "0x6000235")]
			[Address(RVA = "0x2EE4268", Offset = "0x2EE4268", VA = "0x2EE4268")]
			internal int getMacroId()
			{
				return default;
			}

			[Token(Token = "0x6000236")]
			[Address(RVA = "0x2EE4270", Offset = "0x2EE4270", VA = "0x2EE4270")]
			internal SymbolShapeHint getShapeHint()
			{
				return default;
			}
		}

		[Token(Token = "0x400014D")]
		[FieldOffset(Offset = "0x0")]
		private static char[] C40_SHIFT2_CHARS;

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x2EC5B70", Offset = "0x2EC5B70", VA = "0x2EC5B70")]
		private static bool isExtendedASCII(char ch, int fnc1)
		{
			return default;
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x2EC5B88", Offset = "0x2EC5B88", VA = "0x2EC5B88")]
		private static bool isInC40Shift1Set(char ch)
		{
			return default;
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x2EC5B94", Offset = "0x2EC5B94", VA = "0x2EC5B94")]
		private static bool isInC40Shift2Set(char ch, int fnc1)
		{
			return default;
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x2EC5C64", Offset = "0x2EC5C64", VA = "0x2EC5C64")]
		private static bool isInTextShift1Set(char ch)
		{
			return default;
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x2EC5CD0", Offset = "0x2EC5CD0", VA = "0x2EC5CD0")]
		private static bool isInTextShift2Set(char ch, int fnc1)
		{
			return default;
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x2EC5D58", Offset = "0x2EC5D58", VA = "0x2EC5D58")]
		public static string encodeHighLevel(string msg, Encoding priorityCharset, int fnc1, SymbolShapeHint shape)
		{
			return null;
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x2EC5F20", Offset = "0x2EC5F20", VA = "0x2EC5F20")]
		private static byte[] encode(string input, Encoding priorityCharset, int fnc1, SymbolShapeHint shape, int macroId)
		{
			return null;
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x2EC636C", Offset = "0x2EC636C", VA = "0x2EC636C")]
		private static void addEdge(Edge[][] edges, Edge edge)
		{
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x2EC6434", Offset = "0x2EC6434", VA = "0x2EC6434")]
		private static int getNumberOfC40Words(Input input, int from, bool c40, int[] characterLength)
		{
			return default;
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x2EC6718", Offset = "0x2EC6718", VA = "0x2EC6718")]
		private static void addEdges(Input input, Edge[][] edges, int from, Edge previous)
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x2EC5FF4", Offset = "0x2EC5FF4", VA = "0x2EC5FF4")]
		private static Result encodeMinimally(Input input)
		{
			return null;
		}
	}
}
