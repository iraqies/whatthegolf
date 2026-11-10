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
			if (info.otherHit == null)
				return false;
			int layerBit = 1 << info.otherHit.layer;
			bool ok = true;
			if (useIncludedLayers)
				ok = (includeLayers.value & layerBit) != 0;
			if (useExcludeLayers)
				ok = ok && ((excludeLayers.value & layerBit) == 0);
			return ok;
		}
	}
}
