using System.Collections.Generic;
using System.Text.RegularExpressions;
using Il2CppDummyDll;
using ZXing.Common;

namespace ZXing.OneD
{
	[Token(Token = "0x200004A")]
	public abstract class OneDimensionalCodeWriter : Writer
	{
		[Token(Token = "0x4000123")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Regex NUMERIC;

		[Token(Token = "0x4000124")]
		[FieldOffset(Offset = "0x10")]
		private int defaultMargin;

		[Token(Token = "0x1700003D")]
		protected abstract IList<BarcodeFormat> SupportedWriteFormats
		{
			[Token(Token = "0x600019A")]
			get;
		}

		[Token(Token = "0x1700003E")]
		public int DefaultMargin
		{
			[Token(Token = "0x60001A1")]
			[Address(RVA = "0x2ECA78C", Offset = "0x2ECA78C", VA = "0x2ECA78C")]
			get
			{
				return default;
			}
			[Token(Token = "0x60001A2")]
			[Address(RVA = "0x2ECA794", Offset = "0x2ECA794", VA = "0x2ECA794")]
			internal set
			{
			}
		}

		[Token(Token = "0x600019B")]
		public abstract bool[] encode(string contents);

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x2ECA0F0", Offset = "0x2ECA0F0", VA = "0x2ECA0F0", Slot = "7")]
		public virtual bool[] encode(string contents, IDictionary<EncodeHintType, object> hints)
		{
			return null;
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x2ECA0FC", Offset = "0x2ECA0FC", VA = "0x2ECA0FC", Slot = "8")]
		public virtual BitMatrix encode(string contents, BarcodeFormat format, int width, int height, IDictionary<EncodeHintType, object> hints)
		{
			return null;
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x2ECA5FC", Offset = "0x2ECA5FC", VA = "0x2ECA5FC")]
		private static BitMatrix renderResult(bool[] code, int width, int height, int sidesMargin, bool noPadding)
		{
			return null;
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x2EC0008", Offset = "0x2EC0008", VA = "0x2EC0008")]
		protected static void checkNumeric(string contents)
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x2EC00E4", Offset = "0x2EC00E4", VA = "0x2EC00E4")]
		protected static int appendPattern(bool[] target, int pos, int[] pattern, bool startColor)
		{
			return default;
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x2EC0224", Offset = "0x2EC0224", VA = "0x2EC0224")]
		protected OneDimensionalCodeWriter()
		{
		}
	}
}
