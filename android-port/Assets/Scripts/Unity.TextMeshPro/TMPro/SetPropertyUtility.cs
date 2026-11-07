using Il2CppDummyDll;
using UnityEngine;

namespace TMPro
{
	[Token(Token = "0x200003E")]
	internal static class SetPropertyUtility
	{
		[Token(Token = "0x6000224")]
		[Address(RVA = "0x2A7BA04", Offset = "0x2A7BA04", VA = "0x2A7BA04")]
		public static bool SetColor(ref Color currentValue, Color newValue)
		{
			return default;
		}

		[Token(Token = "0x6000225")]
		public static bool SetStruct<T>(ref T currentValue, T newValue) where T : struct
		{
			return default;
		}

		[Token(Token = "0x6000226")]
		public static bool SetClass<T>(ref T currentValue, T newValue) where T : class
		{
			return default;
		}
	}
}
