using System;
using Il2CppDummyDll;
using Unity.Collections;

namespace UnityEngine.U2D.Common
{
	[Token(Token = "0x2000002")]
	internal static class InternalEngineBridge
	{
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x2A3DC78", Offset = "0x2A3DC78", VA = "0x2A3DC78")]
		public static void SetLocalAABB(SpriteRenderer spriteRenderer, Bounds aabb)
		{
		}

		[Token(Token = "0x6000002")]
		[Address(RVA = "0x2A3DCAC", Offset = "0x2A3DCAC", VA = "0x2A3DCAC")]
		public static void SetDeformableBuffer(SpriteRenderer spriteRenderer, NativeArray<byte> src)
		{
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x2A3DCB4", Offset = "0x2A3DCB4", VA = "0x2A3DCB4")]
		public static bool IsUsingDeformableBuffer(SpriteRenderer spriteRenderer, IntPtr buffer)
		{
			return default;
		}
	}
}
