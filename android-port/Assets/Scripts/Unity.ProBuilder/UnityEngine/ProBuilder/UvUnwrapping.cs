using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace UnityEngine.ProBuilder
{
	[Token(Token = "0x2000025")]
	internal static class UvUnwrapping
	{
		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Vector2 s_TempVector2;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly List<int> s_IndexBuffer;

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x2A54E24", Offset = "0x2A54E24", VA = "0x2A54E24")]
		internal static void Unwrap(ProBuilderMesh mesh, Face face, [Optional] Vector3 projection)
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x2A54F5C", Offset = "0x2A54F5C", VA = "0x2A54F5C")]
		internal static void ProjectTextureGroup(ProBuilderMesh mesh, int group, AutoUnwrapSettings unwrapSettings)
		{
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x2A5A420", Offset = "0x2A5A420", VA = "0x2A5A420")]
		private static void ApplyUVSettings(Vector2[] uvs, IList<int> indexes, AutoUnwrapSettings uvSettings)
		{
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x2A5B08C", Offset = "0x2A5B08C", VA = "0x2A5B08C")]
		private static void StretchUVs(Vector2[] uvs, IList<int> indexes)
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x2A5ADE4", Offset = "0x2A5ADE4", VA = "0x2A5ADE4")]
		private static void FitUVs(Vector2[] uvs, IList<int> indexes)
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x2A5B330", Offset = "0x2A5B330", VA = "0x2A5B330")]
		private static void ApplyUVAnchor(Vector2[] uvs, IList<int> indexes, AutoUnwrapSettings.Anchor anchor)
		{
		}
	}
}
