using UnityEngine;

namespace Audio.Impact
{
	public class ImpactChanceToPlay : ImpactConditionBase
	{
		[SerializeField]
		private float chance = 1f;

		public override bool CheckCondition(ImpactAsset asset, HitInfo info, float normalizedVelocity)
		{
			return UnityEngine.Random.value <= chance;
		}
	}
}
