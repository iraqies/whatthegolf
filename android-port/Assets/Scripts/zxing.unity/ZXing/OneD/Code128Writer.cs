using System.Collections.Generic;
using Il2CppDummyDll;

namespace ZXing.OneD
{
	[Token(Token = "0x200003B")]
	public sealed class Code128Writer : OneDimensionalCodeWriter
	{
		[Token(Token = "0x200003C")]
		private enum CType
		{
			[Token(Token = "0x40000F8")]
			UNCODABLE = 0,
			[Token(Token = "0x40000F9")]
			ONE_DIGIT = 1,
			[Token(Token = "0x40000FA")]
			TWO_DIGITS = 2,
			[Token(Token = "0x40000FB")]
			FNC_1 = 3
		}

		[Token(Token = "0x40000F5")]
		[FieldOffset(Offset = "0x14")]
		private bool forceCodesetB;

		[Token(Token = "0x40000F6")]
		[FieldOffset(Offset = "0x0")]
		private static readonly IList<BarcodeFormat> supportedWriteFormats;

		[Token(Token = "0x17000036")]
		protected override IList<BarcodeFormat> SupportedWriteFormats
		{
			[Token(Token = "0x6000168")]
			[Address(RVA = "0x2EACA3C", Offset = "0x2EACA3C", VA = "0x2EACA3C", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x2EACAA0", Offset = "0x2EACAA0", VA = "0x2EACAA0", Slot = "6")]
		public override bool[] encode(string contents)
		{
			return null;
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x2EACAB0", Offset = "0x2EACAB0", VA = "0x2EACAB0", Slot = "7")]
		public override bool[] encode(string contents, IDictionary<EncodeHintType, object> hints)
		{
			return null;
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x2EACBD8", Offset = "0x2EACBD8", VA = "0x2EACBD8")]
		private int check(string contents, IDictionary<EncodeHintType, object> hints)
		{
			return default;
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x2EACF90", Offset = "0x2EACF90", VA = "0x2EACF90")]
		private bool[] encodeFast(string contents, int forcedCodeSet)
		{
			return null;
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x2EAD6F0", Offset = "0x2EAD6F0", VA = "0x2EAD6F0")]
		internal static bool[] produceResult(List<int[]> patterns, int checkSum)
		{
			return null;
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x2EADAD4", Offset = "0x2EADAD4", VA = "0x2EADAD4")]
		private static CType findCType(string value, int start)
		{
			return default;
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x2EAD2F8", Offset = "0x2EAD2F8", VA = "0x2EAD2F8")]
		private int chooseCode(string value, int start, int oldCode)
		{
			return default;
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x2EADB70", Offset = "0x2EADB70", VA = "0x2EADB70")]
		public Code128Writer()
		{
		}
	}
}
