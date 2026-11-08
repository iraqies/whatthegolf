using UnityEngine;

namespace CameraStack
{
	public class CBOrthographicConstantMove : CameraBehaviorOrthographic
	{
		[SerializeField] private Transform trans;
		[SerializeField] private Vector3 desktopRotationOffset;
		[SerializeField] public bool autoAdjustOrthographicSize;
		[SerializeField] public Vector3 moveSpeed;
		[SerializeField] public float rampUpTime;
		private float rampUpTimer;
		private Vector3 _pos;

		private void Awake()
		{
			if (trans == null) trans = transform;
			_pos = trans.position;
		}

		public override void Init()
		{
			base.Init();
			if (trans == null) trans = transform;
			_pos = trans.position;
			rampUpTimer = 0f;
		}

		protected override Vector3 CalculatePosition()
		{
			rampUpTimer += Time.deltaTime;
			float factor = rampUpTime > 0.01f ? Mathf.Clamp01(rampUpTimer / rampUpTime) : 1f;
			_pos += moveSpeed * (factor * Time.deltaTime);
			return _pos;
		}

		public override Quaternion CalculateRotation() => (trans != null ? trans : transform).rotation;
	}
}
