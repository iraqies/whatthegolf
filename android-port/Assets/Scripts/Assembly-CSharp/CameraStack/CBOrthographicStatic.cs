using Core;
using UnityEngine;

namespace CameraStack
{
	public class CBOrthographicStatic : CameraBehaviorOrthographic
	{
		[SerializeField] private Transform trans;
		[SerializeField] private Vector3 desktopRotationOffset = new Vector3(0f, 0f, -90f);
		[SerializeField] public bool autoAdjustOrthographicSize = true;
		private Quaternion baseRotation;
		[SerializeField] protected float orthographicSizeLongDevice = 5f;
		public bool AdjustForLongPhones;

		private void Awake()
		{
			baseRotation = transform.rotation;
		}

		public override void Init()
		{
			if (CameraManager.Instance != null && CameraManager.Instance.MainCamera != null)
			{
				if (AdjustForLongPhones && CameraManager.Instance.MainCamera.aspect < 0.5f)
					orthographicSize = orthographicSizeLongDevice;
			}
			if (trans == null)
				trans = transform;
			if (baseRotation.x == 0f && baseRotation.y == 0f && baseRotation.z == 0f && baseRotation.w == 0f)
				baseRotation = transform.rotation;

			var cfg = PlatformSettings.Instance != null ? PlatformSettings.Instance.GetCurrent() : null;
			bool useRot = cfg == null || cfg.useRotatedOverworldAndCameraInLevels;
			if (!useRot)
			{
				transform.rotation = baseRotation * Quaternion.Euler(desktopRotationOffset);
				if (cfg != null && cfg.AdjustOrthoSizeForFourByThree > 0f)
					orthographicSize *= cfg.AdjustOrthoSizeForFourByThree;
			}
			base.Init();
		}

		protected override Vector3 CalculatePosition() => (trans != null ? trans : transform).position;
		public override Quaternion CalculateRotation() => (trans != null ? trans : transform).rotation;
	}
}
