using System.Collections.Generic;
using System.Text;
using Il2CppDummyDll;

namespace ZXing.Common
{
	[Token(Token = "0x200006A")]
	public class ECIEncoderSet
	{
		[Token(Token = "0x400017D")]
		[FieldOffset(Offset = "0x0")]
		private static List<Encoding> ENCODERS;

		[Token(Token = "0x400017E")]
		[FieldOffset(Offset = "0x10")]
		private Encoding[] encoders;

		[Token(Token = "0x400017F")]
		[FieldOffset(Offset = "0x18")]
		private int priorityEncoderIndex;

		[Token(Token = "0x1700005C")]
		public int Length
		{
			[Token(Token = "0x600027A")]
			[Address(RVA = "0x2EB30F0", Offset = "0x2EB30F0", VA = "0x2EB30F0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x2EB1E00", Offset = "0x2EB1E00", VA = "0x2EB1E00")]
		static ECIEncoderSet()
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x2EB2680", Offset = "0x2EB2680", VA = "0x2EB2680")]
		public ECIEncoderSet(string stringToEncode, Encoding priorityCharset, int fnc1)
		{
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x2EB2FCC", Offset = "0x2EB2FCC", VA = "0x2EB2FCC")]
		public static bool canEncode(Encoding encoding, char c)
		{
			return default;
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x2EB310C", Offset = "0x2EB310C", VA = "0x2EB310C")]
		public string getCharsetName(int index)
		{
			return null;
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x2EB31A0", Offset = "0x2EB31A0", VA = "0x2EB31A0")]
		public Encoding getCharset(int index)
		{
			return null;
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x2EB321C", Offset = "0x2EB321C", VA = "0x2EB321C")]
		public int getECIValue(int encoderIndex)
		{
			return default;
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x2EB32CC", Offset = "0x2EB32CC", VA = "0x2EB32CC")]
		public int getPriorityEncoderIndex()
		{
			return default;
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x2EB32D4", Offset = "0x2EB32D4", VA = "0x2EB32D4")]
		public bool canEncode(char c, int encoderIndex)
		{
			return default;
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x2EB33BC", Offset = "0x2EB33BC", VA = "0x2EB33BC")]
		public byte[] encode(char c, int encoderIndex)
		{
			return null;
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x2EB34AC", Offset = "0x2EB34AC", VA = "0x2EB34AC")]
		public byte[] encode(string s, int encoderIndex)
		{
			return null;
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x2EB25D8", Offset = "0x2EB25D8", VA = "0x2EB25D8")]
		public static Encoding Clone(Encoding encoding)
		{
			return null;
		}
	}
}
