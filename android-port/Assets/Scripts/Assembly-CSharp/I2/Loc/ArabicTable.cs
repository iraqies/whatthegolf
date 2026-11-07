using System.Collections.Generic;
using Il2CppDummyDll;

namespace I2.Loc
{
	[Token(Token = "0x200132A")]
	internal class ArabicTable
	{
		[Token(Token = "0x40066A0")]
		[FieldOffset(Offset = "0x0")]
		private static List<ArabicMapping> mapList;

		[Token(Token = "0x40066A1")]
		[FieldOffset(Offset = "0x8")]
		private static ArabicTable arabicMapper;

		[Token(Token = "0x17000A19")]
		internal static ArabicTable ArabicMapper
		{
			[Token(Token = "0x6005969")]
			[Address(RVA = "0x141DC38", Offset = "0x141DC38", VA = "0x141DC38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005968")]
		[Address(RVA = "0x141D130", Offset = "0x141D130", VA = "0x141D130")]
		private ArabicTable()
		{
		}

		[Token(Token = "0x600596A")]
		[Address(RVA = "0x141DCAC", Offset = "0x141DCAC", VA = "0x141DCAC")]
		internal int Convert(int toBeConverted)
		{
			return default;
		}
	}
}
