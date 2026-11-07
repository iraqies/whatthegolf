using System.Collections.Generic;
using Il2CppDummyDll;

namespace ZXing.OneD
{
	[Token(Token = "0x2000043")]
	public class Code93Writer : OneDimensionalCodeWriter
	{
		[Token(Token = "0x4000113")]
		[FieldOffset(Offset = "0x0")]
		private static readonly IList<BarcodeFormat> supportedWriteFormats;

		[Token(Token = "0x17000038")]
		protected override IList<BarcodeFormat> SupportedWriteFormats
		{
			[Token(Token = "0x6000181")]
			[Address(RVA = "0x2EAE98C", Offset = "0x2EAE98C", VA = "0x2EAE98C", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x2EAE9F0", Offset = "0x2EAE9F0", VA = "0x2EAE9F0", Slot = "6")]
		public override bool[] encode(string contents)
		{
			return null;
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x2EAF1C0", Offset = "0x2EAF1C0", VA = "0x2EAF1C0")]
		private static int appendPattern(bool[] target, int pos, int a)
		{
			return default;
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x2EAF220", Offset = "0x2EAF220", VA = "0x2EAF220")]
		private static int computeChecksumIndex(string contents, int maxWeight)
		{
			return default;
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x2EAEE50", Offset = "0x2EAEE50", VA = "0x2EAEE50")]
		internal static string convertToExtended(string contents)
		{
			return null;
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x2EAF30C", Offset = "0x2EAF30C", VA = "0x2EAF30C")]
		public Code93Writer()
		{
		}
	}
}
