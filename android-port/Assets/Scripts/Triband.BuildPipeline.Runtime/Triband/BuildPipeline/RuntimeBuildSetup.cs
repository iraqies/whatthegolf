using UnityEngine;

namespace Triband.BuildPipeline
{
	public class RuntimeBuildSetup : ScriptableObject
	{
		public const string ASSET_PATH = "Assets/Settings/RuntimeBuildSetup.asset";

		[SerializeField]
		private ConfigurablesList _configurables;

		[SerializeField]
		private BuildInfo _buildInfo;

		public ConfigurablesList configurables => _configurables;

		public BuildInfo buildInfo => _buildInfo;

		public static T LoadRuntimeBuildSetup<T>() where T : RuntimeBuildSetup
		{
			var r = Resources.Load<T>("RuntimeBuildSetup");
			if (r == null)
				r = ScriptableObject.CreateInstance<T>();
			return r;
		}
	}
}
