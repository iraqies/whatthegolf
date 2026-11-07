using System.Collections.Generic;
using System.Text;
using ZXing.Common;

namespace ZXing.QrCode.Internal
{
	internal class MinimalEncoder
	{
		internal enum VersionSize
		{
			SMALL = 0,
			MEDIUM = 1,
			LARGE = 2
		}

		internal sealed class Edge
		{
			public Mode mode;

			public int fromPosition;

			public int charsetEncoderIndex;

			public int characterLength;

			public Edge previous;

			public int cachedTotalSize;

			public Edge(Mode mode, int fromPosition, int charsetEncoderIndex, int characterLength, Edge previous, Version version, MinimalEncoder encoder)
			{
			}
		}

		internal class ResultList
		{
			internal class ResultNode
			{
				public Mode mode;

				public int fromPosition;

				public int charsetEncoderIndex;

				public int characterLength;

				public ResultList resultList;

				public MinimalEncoder encoder;

				public int CharacterCountIndicator => 0;

				public ResultNode(Mode mode, int fromPosition, int charsetEncoderIndex, int characterLength, MinimalEncoder encoder, ResultList resultList)
				{
				}

				public int getSize(Version version)
				{
					return 0;
				}

				public void getBits(BitArray bits)
				{
				}

				public override string ToString()
				{
					return null;
				}

				private string makePrintable(string s)
				{
					return null;
				}
			}

			private List<ResultNode> list;

			private Version version;

			private MinimalEncoder encoder;

			public int Size => 0;

			public ResultList(Version version, Edge solution, MinimalEncoder encoder)
			{
			}

			private int getSize(Version version)
			{
				return 0;
			}

			public void getBits(BitArray bits)
			{
			}

			public Version getVersion()
			{
				return null;
			}

			public override string ToString()
			{
				return null;
			}
		}

		private string stringToEncode;

		private bool isGS1;

		private ECIEncoderSet encoders;

		private ErrorCorrectionLevel ecLevel;

		public MinimalEncoder(string stringToEncode, Encoding priorityCharset, bool isGS1, ErrorCorrectionLevel ecLevel)
		{
		}

		public static ResultList encode(string stringToEncode, Version version, Encoding priorityCharset, bool isGS1, ErrorCorrectionLevel ecLevel)
		{
			return null;
		}

		public ResultList encode(Version version)
		{
			return null;
		}

		public static VersionSize getVersionSize(Version version)
		{
			return VersionSize.SMALL;
		}

		public static Version getVersion(VersionSize versionSize)
		{
			return null;
		}

		private static bool isNumeric(char c)
		{
			return false;
		}

		private static bool isDoubleByteKanji(char c)
		{
			return false;
		}

		private static bool isAlphanumeric(char c)
		{
			return false;
		}

		public bool canEncode(Mode mode, char c)
		{
			return false;
		}

		private static int getCompactedOrdinal(Mode mode)
		{
			return 0;
		}

		private void addEdge(Edge[][][] edges, int position, Edge edge)
		{
		}

		private void addEdges(Version version, Edge[][][] edges, int from, Edge previous)
		{
		}

		public ResultList encodeSpecificVersion(Version version)
		{
			return null;
		}
	}
}
