using UnityEngine;

namespace Audio.Impact
{
	public class ImpactChanceToPlay : ImpactConditionBase
	{
		[SerializeField]
		private float chance;

		public override bool CheckCondition(ImpactAsset asset, HitInfo info, float normalizedVelocity)
		{
			return false;
		}
	}
}
