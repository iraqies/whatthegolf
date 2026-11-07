using Il2CppDummyDll;
using UnityEngine;

namespace Kilt
{
	[Token(Token = "0x2000088")]
	public static class DestroyUtils
	{
		[Token(Token = "0x6000268")]
		[Address(RVA = "0x13652AC", Offset = "0x13652AC", VA = "0x13652AC")]
		public static void Destroy(Object p_object, bool p_onlyDestroyInEditor = false)
		{
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x13652BC", Offset = "0x13652BC", VA = "0x13652BC")]
		public static void Destroy(Object p_object, float p_time, bool p_ignoreTimeScale = true, bool p_onlyDestroyInEditor = false)
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x136543C", Offset = "0x136543C", VA = "0x136543C")]
		public static void DestroyImmediate(Object p_object, bool p_onlyDestroyInEditor = false)
		{
		}
	}
}
