using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.ProBuilder
{
	[Token(Token = "0x2000010")]
	internal static class MaterialUtility
	{
		[Token(Token = "0x400003C")]
		[FieldOffset(Offset = "0x0")]
		private static List<Material> s_MaterialArray;

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x2A4AC78", Offset = "0x2A4AC78", VA = "0x2A4AC78")]
		internal static int GetMaterialCount(Renderer renderer)
		{
			return default;
		}
	}
}
