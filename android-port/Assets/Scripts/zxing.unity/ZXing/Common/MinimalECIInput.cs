using System.Text;
using Il2CppDummyDll;

namespace ZXing.Common
{
	[Token(Token = "0x200006D")]
	public class MinimalECIInput : ECIInput
	{
		[Token(Token = "0x200006E")]
		internal class InputEdge
		{
			[Token(Token = "0x4000184")]
			[FieldOffset(Offset = "0x10")]
			internal char c;

			[Token(Token = "0x4000185")]
			[FieldOffset(Offset = "0x12")]
			private bool cIsFnc1;

			[Token(Token = "0x4000186")]
			[FieldOffset(Offset = "0x14")]
			internal int encoderIndex;

			[Token(Token = "0x4000187")]
			[FieldOffset(Offset = "0x18")]
			internal InputEdge previous;

			[Token(Token = "0x4000188")]
			[FieldOffset(Offset = "0x20")]
			internal int cachedTotalSize;

			[Token(Token = "0x17000063")]
			internal bool isFNC1
			{
				[Token(Token = "0x600029F")]
				[Address(RVA = "0x2EE2010", Offset = "0x2EE2010", VA = "0x2EE2010")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x600029E")]
			[Address(RVA = "0x2EE1EF4", Offset = "0x2EE1EF4", VA = "0x2EE1EF4")]
			internal InputEdge(char c, ECIEncoderSet encoderSet, int encoderIndex, InputEdge previous, int fnc1)
			{
			}
		}

		[Token(Token = "0x4000181")]
		[FieldOffset(Offset = "0x0")]
		private static int COST_PER_ECI;

		[Token(Token = "0x4000182")]
		[FieldOffset(Offset = "0x10")]
		private int[] bytes;

		[Token(Token = "0x4000183")]
		[FieldOffset(Offset = "0x18")]
		private int fnc1;

		[Token(Token = "0x17000062")]
		public int Length
		{
			[Token(Token = "0x6000292")]
			[Address(RVA = "0x2EC50C8", Offset = "0x2EC50C8", VA = "0x2EC50C8", Slot = "4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x2EC49D4", Offset = "0x2EC49D4", VA = "0x2EC49D4")]
		public MinimalECIInput(string stringToEncode, Encoding priorityCharset, int fnc1)
		{
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x2EC50C0", Offset = "0x2EC50C0", VA = "0x2EC50C0")]
		public int getFNC1Character()
		{
			return default;
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x2EC50E4", Offset = "0x2EC50E4", VA = "0x2EC50E4", Slot = "9")]
		public bool haveNCharacters(int index, int n)
		{
			return default;
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x2EC5228", Offset = "0x2EC5228", VA = "0x2EC5228", Slot = "5")]
		public char charAt(int index)
		{
			return default;
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x2EC5440", Offset = "0x2EC5440", VA = "0x2EC5440", Slot = "6")]
		public string subSequence(int start, int end)
		{
			return null;
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x2EC5168", Offset = "0x2EC5168", VA = "0x2EC5168", Slot = "7")]
		public bool isECI(int index)
		{
			return default;
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x2EC5384", Offset = "0x2EC5384", VA = "0x2EC5384")]
		public bool isFNC1(int index)
		{
			return default;
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x2EC55F8", Offset = "0x2EC55F8", VA = "0x2EC55F8", Slot = "8")]
		public int getECIValue(int index)
		{
			return default;
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x2EC573C", Offset = "0x2EC573C", VA = "0x2EC573C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x2EC58E8", Offset = "0x2EC58E8", VA = "0x2EC58E8")]
		private static void addEdge(InputEdge[][] edges, int to, InputEdge edge)
		{
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x2EC5998", Offset = "0x2EC5998", VA = "0x2EC5998")]
		private static void addEdges(string stringToEncode, ECIEncoderSet encoderSet, InputEdge[][] edges, int from, InputEdge previous, int fnc1)
		{
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x2EC4B4C", Offset = "0x2EC4B4C", VA = "0x2EC4B4C")]
		private static int[] encodeMinimally(string stringToEncode, ECIEncoderSet encoderSet, int fnc1)
		{
			return null;
		}
	}
}
