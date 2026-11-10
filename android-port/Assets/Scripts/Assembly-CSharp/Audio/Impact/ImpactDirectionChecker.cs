using UnityEngine;

namespace Audio.Impact
{
	public class ImpactDirectionChecker : ImpactConditionBase
	{
		[SerializeField]
		private Vector3 direction = Vector3.right;

		[SerializeField]
		private bool localAxis;

		[SerializeField]
		private float directionThreshold = 1f;

		public override bool CheckCondition(ImpactAsset asset, HitInfo info, float normalizedVelocity)
		{
			if (info.childHit == null)
				return true;
			Vector3 dir = localAxis ? info.childHit.transform.TransformDirection(direction) : direction;
			Vector3 toPoint = (info.point - info.childHit.transform.position).normalized;
			return Vector3.Dot(dir, toPoint) >= 1f - directionThreshold;
		}
	}
}
