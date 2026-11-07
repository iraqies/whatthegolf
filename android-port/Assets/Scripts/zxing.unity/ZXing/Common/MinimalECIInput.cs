using System.Text;

namespace ZXing.Common
{
	public class MinimalECIInput : ECIInput
	{
		internal class InputEdge
		{
			internal char c;

			private bool cIsFnc1;

			internal int encoderIndex;

			internal InputEdge previous;

			internal int cachedTotalSize;

			internal bool isFNC1 => false;

			internal InputEdge(char c, ECIEncoderSet encoderSet, int encoderIndex, InputEdge previous, int fnc1)
			{
			}
		}

		private static int COST_PER_ECI;

		private int[] bytes;

		private int fnc1;

		public int Length => 0;

		public MinimalECIInput(string stringToEncode, Encoding priorityCharset, int fnc1)
		{
		}

		public int getFNC1Character()
		{
			return 0;
		}

		public bool haveNCharacters(int index, int n)
		{
			return false;
		}

		public char charAt(int index)
		{
			return '\0';
		}

		public string subSequence(int start, int end)
		{
			return null;
		}

		public bool isECI(int index)
		{
			return false;
		}

		public bool isFNC1(int index)
		{
			return false;
		}

		public int getECIValue(int index)
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}

		private static void addEdge(InputEdge[][] edges, int to, InputEdge edge)
		{
		}

		private static void addEdges(string stringToEncode, ECIEncoderSet encoderSet, InputEdge[][] edges, int from, InputEdge previous, int fnc1)
		{
		}

		private static int[] encodeMinimally(string stringToEncode, ECIEncoderSet encoderSet, int fnc1)
		{
			return null;
		}
	}
}
