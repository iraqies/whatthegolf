using UnityEngine;

namespace CameraStack
{
	public class CBFollowClamped : CBFollow
	{
		[SerializeField] protected bool clampX;
		[SerializeField] protected float minX;
		[SerializeField] protected float maxX;
		[SerializeField] protected bool clampY;
		[SerializeField] protected float minY;
		[SerializeField] protected float maxY;
		[SerializeField] protected bool clampZ;
		[SerializeField] protected float minZ;
		[SerializeField] protected float maxZ;

		protected override Vector3 ballAtElevation => Clamp(base.ballAtElevation);

		private Vector3 Clamp(Vector3 position)
		{
			if (clampX && maxX > minX) position.x = Mathf.Clamp(position.x, minX, maxX);
			if (clampY && maxY > minY) position.y = Mathf.Clamp(position.y, minY, maxY);
			if (clampZ && maxZ > minZ) position.z = Mathf.Clamp(position.z, minZ, maxZ);
			return position;
		}

		protected override Vector3 CalculatePosition() => Clamp(base.CalculatePosition());
		private void OnDrawGizmos() { }
	}
}
