using UnityEngine;

namespace CameraStack
{
	public class CBOrthographicStatic : CameraBehaviorOrthographic
	{
		[SerializeField]
		private Transform trans;

		[SerializeField]
		private Vector3 desktopRotationOffset;

		[SerializeField]
		public bool autoAdjustOrthographicSize;

		private Quaternion baseRotation;

		[SerializeField]
		protected float orthographicSizeLongDevice;

		public bool AdjustForLongPhones;

		private void Awake()
		{
		}

		public override void Init()
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
