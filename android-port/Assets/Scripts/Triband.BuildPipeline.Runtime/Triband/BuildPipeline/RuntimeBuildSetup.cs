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

		public ConfigurablesList configurables => null;

		public BuildInfo buildInfo => null;

		public static T LoadRuntimeBuildSetup<T>() where T : RuntimeBuildSetup
		{
			return null;
		}
	}
}
