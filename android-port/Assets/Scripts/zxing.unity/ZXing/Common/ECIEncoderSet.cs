using System.Collections.Generic;
using System.Text;

namespace ZXing.Common
{
	public class ECIEncoderSet
	{
		private static List<Encoding> ENCODERS;

		private Encoding[] encoders;

		private int priorityEncoderIndex;

		public int Length => 0;

		static ECIEncoderSet()
		{
		}

		public ECIEncoderSet(string stringToEncode, Encoding priorityCharset, int fnc1)
		{
		}

		public static bool canEncode(Encoding encoding, char c)
		{
			return false;
		}

		public string getCharsetName(int index)
		{
			return null;
		}

		public Encoding getCharset(int index)
		{
			return null;
		}

		public int getECIValue(int encoderIndex)
		{
			return 0;
		}

		public int getPriorityEncoderIndex()
		{
			return 0;
		}

		public bool canEncode(char c, int encoderIndex)
		{
			return false;
		}

		public byte[] encode(char c, int encoderIndex)
		{
			return null;
		}

		public byte[] encode(string s, int encoderIndex)
		{
			return null;
		}

		public static Encoding Clone(Encoding encoding)
		{
			return null;
		}
	}
}
