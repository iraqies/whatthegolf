using UnityEngine;

namespace CameraStack
{
	public class CBOrbit : CameraBehaviorPerspective
	{
		[SerializeField]
		private Vector3 target;

		[SerializeField]
		private float distance;

		[SerializeField]
		private float speed;

		private float angle;

		private void Awake()
		{
		}

		public override Quaternion CalculateRotation()
		{
			return default;
		}

		protected override Vector3 CalculatePosition()
		{
			return default;
		}
	}
}
