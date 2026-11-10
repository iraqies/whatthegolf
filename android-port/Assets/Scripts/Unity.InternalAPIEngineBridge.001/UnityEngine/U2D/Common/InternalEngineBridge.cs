using System;
using Unity.Collections;
using UnityEngine.U2D;

namespace UnityEngine.U2D.Common
{
	public static class InternalEngineBridge
	{
		public static void SetLocalAABB(SpriteRenderer spriteRenderer, Bounds aabb)
		{
			if (spriteRenderer != null)
				spriteRenderer.SetLocalAABB(aabb);
		}

		public static void SetDeformableBuffer(SpriteRenderer spriteRenderer, NativeArray<byte> src)
		{
			if (spriteRenderer != null && src.IsCreated)
				spriteRenderer.SetDeformableBuffer(src);
		}

		public static bool IsUsingDeformableBuffer(SpriteRenderer spriteRenderer, IntPtr buffer)
		{
			return spriteRenderer != null && spriteRenderer.IsUsingDeformableBuffer(buffer);
		}
	}
}
