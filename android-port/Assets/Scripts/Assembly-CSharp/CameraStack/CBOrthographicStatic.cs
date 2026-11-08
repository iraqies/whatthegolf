using UnityEngine;

namespace CameraStack
{
	public class CBOrthographicStatic : CameraBehaviorOrthographic
	{
		[SerializeField] private Transform trans;
		[SerializeField] private Vector3 desktopRotationOffset;
		[SerializeField] public bool autoAdjustOrthographicSize;
		private Quaternion baseRotation;
		[SerializeField] protected float orthographicSizeLongDevice;
		public bool AdjustForLongPhones;

		private void Awake()
		{
			if (trans == null) trans = transform;
			baseRotation = trans.rotation;
		}

		public override void Init()
		{
			base.Init();
			if (trans == null) trans = transform;
			baseRotation = trans.rotation;
		}

		protected override Vector3 CalculatePosition() => (trans != null ? trans : transform).position;
		public override Quaternion CalculateRotation() => (trans != null ? trans : transform).rotation;
	}
}
