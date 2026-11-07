using System.Collections.Generic;
using Il2CppDummyDll;

namespace ZXing.OneD
{
	[Token(Token = "0x200003D")]
	internal sealed class MinimalEncoder
	{
		[Token(Token = "0x200003E")]
		private enum Charset
		{
			[Token(Token = "0x4000102")]
			A = 0,
			[Token(Token = "0x4000103")]
			B = 1,
			[Token(Token = "0x4000104")]
			C = 2,
			[Token(Token = "0x4000105")]
			NONE = 3
		}

		[Token(Token = "0x200003F")]
		private enum Latch
		{
			[Token(Token = "0x4000107")]
			A = 0,
			[Token(Token = "0x4000108")]
			B = 1,
			[Token(Token = "0x4000109")]
			C = 2,
			[Token(Token = "0x400010A")]
			SHIFT = 3,
			[Token(Token = "0x400010B")]
			NONE = 4
		}

		[Token(Token = "0x40000FC")]
		[FieldOffset(Offset = "0x0")]
		private static string A;

		[Token(Token = "0x40000FD")]
		[FieldOffset(Offset = "0x8")]
		private static string B;

		[Token(Token = "0x40000FE")]
		[FieldOffset(Offset = "0x10")]
		private static int CODE_SHIFT;

		[Token(Token = "0x40000FF")]
		[FieldOffset(Offset = "0x10")]
		private int[][] memoizedCost;

		[Token(Token = "0x4000100")]
		[FieldOffset(Offset = "0x18")]
		private Latch[][] minPath;

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x2EC6E38", Offset = "0x2EC6E38", VA = "0x2EC6E38")]
		public bool[] encode(string contents)
		{
			return null;
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x2EC78F8", Offset = "0x2EC78F8", VA = "0x2EC78F8")]
		private static void addPattern(List<int[]> patterns, int patternIndex, int[] checkSum, int[] checkWeight, int position)
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x2EC7A28", Offset = "0x2EC7A28", VA = "0x2EC7A28")]
		private static bool isDigit(char c)
		{
			return default;
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x2EC7A38", Offset = "0x2EC7A38", VA = "0x2EC7A38")]
		private bool canEncode(string contents, Charset charset, int position)
		{
			return default;
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x2EC7424", Offset = "0x2EC7424", VA = "0x2EC7424")]
		private int encode(string contents, Charset charset, int position)
		{
			return default;
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x2EC7C14", Offset = "0x2EC7C14", VA = "0x2EC7C14")]
		public MinimalEncoder()
		{
		}
	}
}
