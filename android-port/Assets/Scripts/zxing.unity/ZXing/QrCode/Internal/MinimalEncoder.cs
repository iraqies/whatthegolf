using System.Collections.Generic;
using System.Text;
using Il2CppDummyDll;
using ZXing.Common;

namespace ZXing.QrCode.Internal
{
	[Token(Token = "0x2000025")]
	internal class MinimalEncoder
	{
		[Token(Token = "0x2000026")]
		internal enum VersionSize
		{
			[Token(Token = "0x400008B")]
			SMALL = 0,
			[Token(Token = "0x400008C")]
			MEDIUM = 1,
			[Token(Token = "0x400008D")]
			LARGE = 2
		}

		[Token(Token = "0x2000027")]
		internal sealed class Edge
		{
			[Token(Token = "0x400008E")]
			[FieldOffset(Offset = "0x10")]
			public Mode mode;

			[Token(Token = "0x400008F")]
			[FieldOffset(Offset = "0x18")]
			public int fromPosition;

			[Token(Token = "0x4000090")]
			[FieldOffset(Offset = "0x1C")]
			public int charsetEncoderIndex;

			[Token(Token = "0x4000091")]
			[FieldOffset(Offset = "0x20")]
			public int characterLength;

			[Token(Token = "0x4000092")]
			[FieldOffset(Offset = "0x28")]
			public Edge previous;

			[Token(Token = "0x4000093")]
			[FieldOffset(Offset = "0x30")]
			public int cachedTotalSize;

			[Token(Token = "0x60000FA")]
			[Address(RVA = "0x2EE4A1C", Offset = "0x2EE4A1C", VA = "0x2EE4A1C")]
			public Edge(Mode mode, int fromPosition, int charsetEncoderIndex, int characterLength, Edge previous, Version version, MinimalEncoder encoder)
			{
			}
		}

		[Token(Token = "0x2000028")]
		internal class ResultList
		{
			[Token(Token = "0x2000029")]
			internal class ResultNode
			{
				[Token(Token = "0x4000097")]
				[FieldOffset(Offset = "0x10")]
				public Mode mode;

				[Token(Token = "0x4000098")]
				[FieldOffset(Offset = "0x18")]
				public int fromPosition;

				[Token(Token = "0x4000099")]
				[FieldOffset(Offset = "0x1C")]
				public int charsetEncoderIndex;

				[Token(Token = "0x400009A")]
				[FieldOffset(Offset = "0x20")]
				public int characterLength;

				[Token(Token = "0x400009B")]
				[FieldOffset(Offset = "0x28")]
				public ResultList resultList;

				[Token(Token = "0x400009C")]
				[FieldOffset(Offset = "0x30")]
				public MinimalEncoder encoder;

				[Token(Token = "0x17000020")]
				public int CharacterCountIndicator
				{
					[Token(Token = "0x6000103")]
					[Address(RVA = "0x2EE6338", Offset = "0x2EE6338", VA = "0x2EE6338")]
					get
					{
						return default;
					}
				}

				[Token(Token = "0x6000101")]
				[Address(RVA = "0x2EE5344", Offset = "0x2EE5344", VA = "0x2EE5344")]
				public ResultNode(Mode mode, int fromPosition, int charsetEncoderIndex, int characterLength, MinimalEncoder encoder, ResultList resultList)
				{
				}

				[Token(Token = "0x6000102")]
				[Address(RVA = "0x2EE5510", Offset = "0x2EE5510", VA = "0x2EE5510")]
				public int getSize(Version version)
				{
					return default;
				}

				[Token(Token = "0x6000104")]
				[Address(RVA = "0x2EE5794", Offset = "0x2EE5794", VA = "0x2EE5794")]
				public void getBits(BitArray bits)
				{
				}

				[Token(Token = "0x6000105")]
				[Address(RVA = "0x2EE6404", Offset = "0x2EE6404", VA = "0x2EE6404", Slot = "3")]
				public override string ToString()
				{
					return null;
				}

				[Token(Token = "0x6000106")]
				[Address(RVA = "0x2EE6540", Offset = "0x2EE6540", VA = "0x2EE6540")]
				private string makePrintable(string s)
				{
					return null;
				}
			}

			[Token(Token = "0x4000094")]
			[FieldOffset(Offset = "0x10")]
			private List<ResultNode> list;

			[Token(Token = "0x4000095")]
			[FieldOffset(Offset = "0x18")]
			private Version version;

			[Token(Token = "0x4000096")]
			[FieldOffset(Offset = "0x20")]
			private MinimalEncoder encoder;

			[Token(Token = "0x1700001F")]
			public int Size
			{
				[Token(Token = "0x60000FC")]
				[Address(RVA = "0x2EE5508", Offset = "0x2EE5508", VA = "0x2EE5508")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x60000FB")]
			[Address(RVA = "0x2EE4CC0", Offset = "0x2EE4CC0", VA = "0x2EE4CC0")]
			public ResultList(Version version, Edge solution, MinimalEncoder encoder)
			{
			}

			[Token(Token = "0x60000FD")]
			[Address(RVA = "0x2EE53A8", Offset = "0x2EE53A8", VA = "0x2EE53A8")]
			private int getSize(Version version)
			{
				return default;
			}

			[Token(Token = "0x60000FE")]
			[Address(RVA = "0x2EE5640", Offset = "0x2EE5640", VA = "0x2EE5640")]
			public void getBits(BitArray bits)
			{
			}

			[Token(Token = "0x60000FF")]
			[Address(RVA = "0x2EE595C", Offset = "0x2EE595C", VA = "0x2EE595C")]
			public Version getVersion()
			{
				return null;
			}

			[Token(Token = "0x6000100")]
			[Address(RVA = "0x2EE5964", Offset = "0x2EE5964", VA = "0x2EE5964", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Token(Token = "0x4000086")]
		[FieldOffset(Offset = "0x10")]
		private string stringToEncode;

		[Token(Token = "0x4000087")]
		[FieldOffset(Offset = "0x18")]
		private bool isGS1;

		[Token(Token = "0x4000088")]
		[FieldOffset(Offset = "0x20")]
		private ECIEncoderSet encoders;

		[Token(Token = "0x4000089")]
		[FieldOffset(Offset = "0x28")]
		private ErrorCorrectionLevel ecLevel;

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x2EC7CAC", Offset = "0x2EC7CAC", VA = "0x2EC7CAC")]
		public MinimalEncoder(string stringToEncode, Encoding priorityCharset, bool isGS1, ErrorCorrectionLevel ecLevel)
		{
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x2EC7D50", Offset = "0x2EC7D50", VA = "0x2EC7D50")]
		public static ResultList encode(string stringToEncode, Version version, Encoding priorityCharset, bool isGS1, ErrorCorrectionLevel ecLevel)
		{
			return null;
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x2EC7E38", Offset = "0x2EC7E38", VA = "0x2EC7E38")]
		public ResultList encode(Version version)
		{
			return null;
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x2EC8870", Offset = "0x2EC8870", VA = "0x2EC8870")]
		public static VersionSize getVersionSize(Version version)
		{
			return default;
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x2EC834C", Offset = "0x2EC834C", VA = "0x2EC834C")]
		public static Version getVersion(VersionSize versionSize)
		{
			return null;
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x2EC889C", Offset = "0x2EC889C", VA = "0x2EC889C")]
		private static bool isNumeric(char c)
		{
			return default;
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x2EC88AC", Offset = "0x2EC88AC", VA = "0x2EC88AC")]
		private static bool isDoubleByteKanji(char c)
		{
			return default;
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x2EC8970", Offset = "0x2EC8970", VA = "0x2EC8970")]
		private static bool isAlphanumeric(char c)
		{
			return default;
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x2EC89F8", Offset = "0x2EC89F8", VA = "0x2EC89F8")]
		public bool canEncode(Mode mode, char c)
		{
			return default;
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x2EC8B04", Offset = "0x2EC8B04", VA = "0x2EC8B04")]
		private static int getCompactedOrdinal(Mode mode)
		{
			return default;
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x2EC8C0C", Offset = "0x2EC8C0C", VA = "0x2EC8C0C")]
		private void addEdge(Edge[][][] edges, int position, Edge edge)
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x2EC8CE8", Offset = "0x2EC8CE8", VA = "0x2EC8CE8")]
		private void addEdges(Version version, Edge[][][] edges, int from, Edge previous)
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x2EC842C", Offset = "0x2EC842C", VA = "0x2EC842C")]
		public ResultList encodeSpecificVersion(Version version)
		{
			return null;
		}
	}
}
