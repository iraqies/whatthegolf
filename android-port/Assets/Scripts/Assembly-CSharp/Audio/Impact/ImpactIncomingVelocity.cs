using UnityEngine;

namespace Audio.Impact
{
	public class ImpactIncomingVelocity : ImpactConditionBase
	{
		[SerializeField]
		private Vector3 direction;

		[SerializeField]
		private bool localAxis;

		[SerializeField]
		private float directionThreshold;

		public override bool CheckCondition(ImpactAsset asset, HitInfo info, float normalizedVelocity)
		{
			return false;
		}
	}
}
