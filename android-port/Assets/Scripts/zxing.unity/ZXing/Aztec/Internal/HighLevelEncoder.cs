using System.Collections.Generic;
using System.Text;
using ZXing.Common;

namespace ZXing.Aztec.Internal
{
	public sealed class HighLevelEncoder
	{
		internal static string[] MODE_NAMES;

		internal static readonly int[][] LATCH_TABLE;

		internal static readonly int[][] CHAR_MAP;

		internal static readonly int[][] SHIFT_TABLE;

		private readonly byte[] text;

		private readonly Encoding encoding;

		private readonly bool disableEci;

		static HighLevelEncoder()
		{
		}

		public HighLevelEncoder(byte[] text, Encoding encoding, bool disableEci)
		{
		}

		public BitArray encode()
		{
			return null;
		}

		private ICollection<State> updateStateListForChar(IEnumerable<State> states, int index)
		{
			return null;
		}

		private void updateStateForChar(State state, int index, ICollection<State> result)
		{
		}

		private static ICollection<State> updateStateListForPair(IEnumerable<State> states, int index, int pairCode)
		{
			return null;
		}

		private static void updateStateForPair(State state, int index, int pairCode, ICollection<State> result)
		{
		}

		private static ICollection<State> simplifyStates(IEnumerable<State> states)
		{
			return null;
		}
	}
}
