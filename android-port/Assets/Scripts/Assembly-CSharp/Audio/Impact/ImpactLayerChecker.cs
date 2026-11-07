using UnityEngine;

namespace Audio.Impact
{
	public class ImpactLayerChecker : ImpactConditionBase
	{
		[SerializeField]
		private bool useIncludedLayers;

		[SerializeField]
		private LayerMask includeLayers;

		[SerializeField]
		private bool useExcludeLayers;

		[SerializeField]
		private LayerMask excludeLayers;

		public override bool CheckCondition(ImpactAsset asset, HitInfo info, float normalizedVelocity)
		{
			return false;
		}
	}
}
