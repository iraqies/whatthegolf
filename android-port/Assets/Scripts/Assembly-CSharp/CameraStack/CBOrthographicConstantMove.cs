using UnityEngine;

namespace CameraStack
{
	public class CBOrthographicConstantMove : CameraBehaviorOrthographic
	{
		[SerializeField]
		private Transform trans;

		[SerializeField]
		private Vector3 desktopRotationOffset;

		[SerializeField]
		public bool autoAdjustOrthographicSize;

		[SerializeField]
		public Vector3 moveSpeed;

		[SerializeField]
		public float rampUpTime;

		private float rampUpTimer;

		private void Awake()
		{
		}

		protected override Vector3 CalculatePosition()
		{
			return default;
		}

		public override Quaternion CalculateRotation()
		{
			return default;
		}
	}
}
