using Il2CppDummyDll;

namespace UnityEngine.UI
{
	[Token(Token = "0x200005E")]
	internal static class SetPropertyUtility
	{
		[Token(Token = "0x6000425")]
		[Address(RVA = "0x2C39BC0", Offset = "0x2C39BC0", VA = "0x2C39BC0")]
		public static bool SetColor(ref Color currentValue, Color newValue)
		{
			return default;
		}

		[Token(Token = "0x6000426")]
		public static bool SetStruct<T>(ref T currentValue, T newValue) where T : struct
		{
			return default;
		}

		[Token(Token = "0x6000427")]
		public static bool SetClass<T>(ref T currentValue, T newValue) where T : class
		{
			return default;
		}
	}
}
