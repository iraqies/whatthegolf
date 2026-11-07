using UnityEngine;

namespace Triband.BuildPipeline
{
	public static class RuntimeBundlingSupport
	{
		public static T LoadAsset<T>(string assetPath) where T : Object
		{
			if (string.IsNullOrEmpty(assetPath)) return null;
			return Resources.Load<T>(assetPath);
		}
	}
}
