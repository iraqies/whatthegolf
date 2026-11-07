using UnityEngine;

namespace CameraStack
{
	public class CBFollowClamped : CBFollow
	{
		[SerializeField]
		protected bool clampX;

		[SerializeField]
		protected float minX;

		[SerializeField]
		protected float maxX;

		[SerializeField]
		protected bool clampY;

		[SerializeField]
		protected float minY;

		[SerializeField]
		protected float maxY;

		[SerializeField]
		protected bool clampZ;

		[SerializeField]
		protected float minZ;

		[SerializeField]
		protected float maxZ;

		protected override Vector3 ballAtElevation => default;

		private Vector3 Clamp(Vector3 position)
		{
			return default;
		}

		protected override Vector3 CalculatePosition()
		{
			return default;
		}

		private void OnDrawGizmos()
		{
		}
	}
}
