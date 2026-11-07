using System.Collections.Generic;
using System.Text;
using Il2CppDummyDll;
using ZXing.Common;

namespace ZXing.Aztec.Internal
{
	[Token(Token = "0x2000077")]
	public sealed class HighLevelEncoder
	{
		[Token(Token = "0x40001AE")]
		[FieldOffset(Offset = "0x0")]
		internal static string[] MODE_NAMES;

		[Token(Token = "0x40001AF")]
		[FieldOffset(Offset = "0x8")]
		internal static readonly int[][] LATCH_TABLE;

		[Token(Token = "0x40001B0")]
		[FieldOffset(Offset = "0x10")]
		internal static readonly int[][] CHAR_MAP;

		[Token(Token = "0x40001B1")]
		[FieldOffset(Offset = "0x18")]
		internal static readonly int[][] SHIFT_TABLE;

		[Token(Token = "0x40001B2")]
		[FieldOffset(Offset = "0x10")]
		private readonly byte[] text;

		[Token(Token = "0x40001B3")]
		[FieldOffset(Offset = "0x18")]
		private readonly Encoding encoding;

		[Token(Token = "0x40001B4")]
		[FieldOffset(Offset = "0x20")]
		private readonly bool disableEci;

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x2EBB354", Offset = "0x2EBB354", VA = "0x2EBB354")]
		static HighLevelEncoder()
		{
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x2EBBDE4", Offset = "0x2EBBDE4", VA = "0x2EBBDE4")]
		public HighLevelEncoder(byte[] text, Encoding encoding, bool disableEci)
		{
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x2EBBE24", Offset = "0x2EBBE24", VA = "0x2EBBE24")]
		public BitArray encode()
		{
			return null;
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x2EBC80C", Offset = "0x2EBC80C", VA = "0x2EBC80C")]
		private ICollection<State> updateStateListForChar(IEnumerable<State> states, int index)
		{
			return null;
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x2EBCB7C", Offset = "0x2EBCB7C", VA = "0x2EBCB7C")]
		private void updateStateForChar(State state, int index, ICollection<State> result)
		{
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x2EBC474", Offset = "0x2EBC474", VA = "0x2EBC474")]
		private static ICollection<State> updateStateListForPair(IEnumerable<State> states, int index, int pairCode)
		{
			return null;
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x2EBD6B4", Offset = "0x2EBD6B4", VA = "0x2EBD6B4")]
		private static void updateStateForPair(State state, int index, int pairCode, ICollection<State> result)
		{
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x2EBCFFC", Offset = "0x2EBCFFC", VA = "0x2EBCFFC")]
		private static ICollection<State> simplifyStates(IEnumerable<State> states)
		{
			return null;
		}
	}
}
