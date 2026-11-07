using UnityEngine;

namespace Audio.Impact
{
	public class ImpactFacingChecker : ImpactConditionBase
	{
		[SerializeField]
		private Vector3 ObjectDirection;

		[SerializeField]
		private Vector3 MustFaceDirection;

		[SerializeField]
		private float directionThreshold;

		public override bool CheckCondition(ImpactAsset asset, HitInfo info, float normalizedVelocity)
		{
			return false;
		}
	}
}
