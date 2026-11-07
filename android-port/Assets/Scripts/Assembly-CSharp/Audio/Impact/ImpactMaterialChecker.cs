using System.Collections.Generic;
using UnityEngine;

namespace Audio.Impact
{
	public class ImpactMaterialChecker : ImpactConditionBase
	{
		[SerializeField]
		private bool affectIncomingObjectSize;

		[SerializeField]
		private bool includeNonMaterial;

		[SerializeField]
		private List<AudioMaterial> mustIncludeMaterial;

		[SerializeField]
		private List<AudioMaterial> cannotIncludeMaterial;

		public override bool CheckCondition(ImpactAsset asset, HitInfo info, float normalizedVelocity)
		{
			return false;
		}
	}
}
