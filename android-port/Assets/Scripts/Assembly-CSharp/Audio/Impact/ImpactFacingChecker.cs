using UnityEngine;

namespace Audio.Impact
{
	public class ImpactFacingChecker : ImpactConditionBase
	{
		[SerializeField]
		private Vector3 ObjectDirection = Vector3.up;

		[SerializeField]
		private Vector3 MustFaceDirection = Vector3.up;

		[SerializeField]
		private float directionThreshold = 1f;

		public override bool CheckCondition(ImpactAsset asset, HitInfo info, float normalizedVelocity)
		{
			if (info.childHit == null)
				return true;
			Vector3 worldDir = info.childHit.transform.TransformDirection(ObjectDirection);
			return Vector3.Dot(worldDir, MustFaceDirection) >= 1f - directionThreshold;
		}
	}
}
