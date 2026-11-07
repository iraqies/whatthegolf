using System;
using Unity.Collections;

namespace UnityEngine.U2D.Common
{
	internal static class InternalEngineBridge
	{
		public static void SetLocalAABB(SpriteRenderer spriteRenderer, Bounds aabb)
		{
		}

		public static void SetDeformableBuffer(SpriteRenderer spriteRenderer, NativeArray<byte> src)
		{
		}

		public static bool IsUsingDeformableBuffer(SpriteRenderer spriteRenderer, IntPtr buffer)
		{
			return false;
		}
	}
}
