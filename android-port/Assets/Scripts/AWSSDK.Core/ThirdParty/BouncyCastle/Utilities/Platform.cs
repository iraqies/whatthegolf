using System.Collections;
using Il2CppDummyDll;

namespace ThirdParty.BouncyCastle.Utilities
{
	[Token(Token = "0x2000004")]
	internal abstract class Platform
	{
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x124873C", Offset = "0x124873C", VA = "0x124873C")]
		internal static IList CreateArrayList()
		{
			return null;
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x124C074", Offset = "0x124C074", VA = "0x124C074")]
		internal static IList CreateArrayList(int capacity)
		{
			return null;
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x12487F8", Offset = "0x12487F8", VA = "0x12487F8")]
		internal static IList CreateArrayList(ICollection collection)
		{
			return null;
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x124C0F0", Offset = "0x124C0F0", VA = "0x124C0F0")]
		internal static IList CreateArrayList(IEnumerable collection)
		{
			return null;
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x124C498", Offset = "0x124C498", VA = "0x124C498")]
		protected Platform()
		{
		}
	}
}
