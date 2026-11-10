using System.Collections.Generic;
using UnityEngine;

namespace Audio.Impact
{
	public class ImpactMaterialChecker : ImpactConditionBase
	{
		[SerializeField]
		private bool affectIncomingObjectSize;

		[SerializeField]
		private bool includeNonMaterial = true;

		[SerializeField]
		private List<AudioMaterial> mustIncludeMaterial;

		[SerializeField]
		private List<AudioMaterial> cannotIncludeMaterial;

		public override bool CheckCondition(ImpactAsset asset, HitInfo info, float normalizedVelocity)
		{
			if (AudioManager.Instance == null)
				return true;
			bool matched = AudioManager.Instance.CheckMaterial(out AudioMaterialSettings setting, info.otherHit, mustIncludeMaterial, cannotIncludeMaterial, includeNonMaterial);
			if (affectIncomingObjectSize && asset != null)
			{
				asset.CurrentIncomingObjectSize = setting != null ? SizeModifier.NewModifier(setting.objectWeight) : SizeModifier.Medium;
			}
			bool hasMust = mustIncludeMaterial != null && mustIncludeMaterial.Count > 0;
			bool hasCannot = cannotIncludeMaterial != null && cannotIncludeMaterial.Count > 0;
			if (!hasMust && !hasCannot)
				return true;
			return matched;
		}
	}
}
