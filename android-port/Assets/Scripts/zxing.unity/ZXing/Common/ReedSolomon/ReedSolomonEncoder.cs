using System.Collections.Generic;
using Il2CppDummyDll;

namespace ZXing.Common.ReedSolomon
{
	[Token(Token = "0x2000072")]
	public sealed class ReedSolomonEncoder
	{
		[Token(Token = "0x40001A3")]
		[FieldOffset(Offset = "0x10")]
		private readonly GenericGF field;

		[Token(Token = "0x40001A4")]
		[FieldOffset(Offset = "0x18")]
		private readonly IList<GenericGFPoly> cachedGenerators;

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x2ED2504", Offset = "0x2ED2504", VA = "0x2ED2504")]
		public ReedSolomonEncoder(GenericGF field)
		{
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x2ED2694", Offset = "0x2ED2694", VA = "0x2ED2694")]
		private GenericGFPoly buildGenerator(int degree)
		{
			return null;
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x2ED2AC4", Offset = "0x2ED2AC4", VA = "0x2ED2AC4")]
		public void encode(int[] toEncode, int ecBytes)
		{
		}
	}
}
