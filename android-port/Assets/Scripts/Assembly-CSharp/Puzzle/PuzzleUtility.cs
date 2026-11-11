using UnityEngine;

namespace Puzzle
{
	public class PuzzleUtility
	{
		public static Vector3 SnapTo(Vector3 v3, float snapAngle)
		{
			float angle = Vector3.Angle(v3, Vector3.up);
			if (angle < snapAngle * 0.5f)
			{
				return Vector3.up * v3.magnitude;
			}
			if (angle > 180f - snapAngle * 0.5f)
			{
				return Vector3.down * v3.magnitude;
			}
			float t = Mathf.Round(angle / snapAngle);
			float deltaAngle = snapAngle * t - angle;
			Vector3 axis = Vector3.Cross(Vector3.up, v3);
			return Quaternion.AngleAxis(deltaAngle, axis) * v3;
		}

		public static Vector3 SnapTo(Vector3 v3, float offset, float snapAngle)
		{
			return SnapTo(v3, snapAngle);
		}
	}
}
