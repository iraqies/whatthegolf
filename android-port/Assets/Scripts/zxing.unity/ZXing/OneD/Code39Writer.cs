using System.Collections.Generic;
using Il2CppDummyDll;

namespace ZXing.OneD
{
	[Token(Token = "0x2000041")]
	public sealed class Code39Writer : OneDimensionalCodeWriter
	{
		[Token(Token = "0x400010F")]
		[FieldOffset(Offset = "0x0")]
		private static readonly IList<BarcodeFormat> supportedWriteFormats;

		[Token(Token = "0x17000037")]
		protected override IList<BarcodeFormat> SupportedWriteFormats
		{
			[Token(Token = "0x600017A")]
			[Address(RVA = "0x2EADD74", Offset = "0x2EADD74", VA = "0x2EADD74", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x2EADDD8", Offset = "0x2EADDD8", VA = "0x2EADDD8", Slot = "6")]
		public override bool[] encode(string contents)
		{
			return null;
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x2EAE70C", Offset = "0x2EAE70C", VA = "0x2EAE70C")]
		private static void toIntArray(int a, int[] toReturn)
		{
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x2EAE354", Offset = "0x2EAE354", VA = "0x2EAE354")]
		private static string tryToConvertToExtendedMode(string contents)
		{
			return null;
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x2EAE764", Offset = "0x2EAE764", VA = "0x2EAE764")]
		public Code39Writer()
		{
		}
	}
}
