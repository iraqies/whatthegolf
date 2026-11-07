using UnityEngine;

namespace Triband.Core.ObjectUtils
{
	public static class GameObjectExtensions
	{
		public static void SafeDestroy(this GameObject gameObject)
		{
			if (gameObject == null) return;
			if (Application.isPlaying)
				Object.Destroy(gameObject);
			else
				Object.DestroyImmediate(gameObject);
		}
	}
}
