using Il2CppDummyDll;

namespace UnityEngine.ProBuilder
{
	[Token(Token = "0x2000012")]
	public static class Normals
	{
		[Token(Token = "0x400003D")]
		[FieldOffset(Offset = "0x0")]
		private static Vector3[] s_SmoothAvg;

		[Token(Token = "0x400003E")]
		[FieldOffset(Offset = "0x8")]
		private static float[] s_SmoothAvgCount;

		[Token(Token = "0x400003F")]
		[FieldOffset(Offset = "0x10")]
		private static int[] s_CachedIntArray;

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x2A4C354", Offset = "0x2A4C354", VA = "0x2A4C354")]
		private static void ClearIntArray(int count)
		{
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x2A4C47C", Offset = "0x2A4C47C", VA = "0x2A4C47C")]
		public static void CalculateTangents(ProBuilderMesh mesh)
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x2A4CE38", Offset = "0x2A4CE38", VA = "0x2A4CE38")]
		private static void CalculateHardNormals(ProBuilderMesh mesh)
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x2A4D2E8", Offset = "0x2A4D2E8", VA = "0x2A4D2E8")]
		public static void CalculateNormals(ProBuilderMesh mesh)
		{
		}
	}
}
