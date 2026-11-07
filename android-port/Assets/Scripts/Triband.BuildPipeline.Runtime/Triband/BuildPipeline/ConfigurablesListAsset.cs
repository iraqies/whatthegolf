using UnityEngine;

namespace Triband.BuildPipeline
{
	public class ConfigurablesListAsset : ScriptableObject
	{
		[SerializeField]
		private ConfigurablesList _configurables;

		public ConfigurablesList configurables => _configurables;
	}
}
