using System.Collections;
using Core;
using UnityEngine;

namespace CameraStack
{
	public class CBPerspecitveGyroscope : CameraBehaviorPerspective, ICameraBehaviourFollowing
	{
		public Vector3 offset;

		public Vector3 rotationOffset;

		public Transform gyroTransform;

		public float ControllerSensitivity;

		public float clampAngle;

		public Vector2 clampInDegrees;

		public bool lockCursor;

		public Vector2 sensitivity;

		public Vector2 smoothing;

		public Vector2 targetDirection;

		public GolfBallController Controller;

		public bool FreeLookWhileAiming;

		public bool AutoHideArrow;

		public bool LookAtFlagOnStart;

		public FPGHelper HelperPrefab;

		private Quaternion startOffset;

		private float baseControllerSensitivity;

		private Vector2 _mouseAbsolute;

		private Vector2 _smoothMouse;

		private bool initialized;

		private TimeControl _timeControll;

		private Quaternion _lastRotation;

		private const string HNAME = "Handheld";

		public override void Init()
		{
		}

		private IEnumerator Setup()
		{
			return null;
		}

		private void OnDestroy()
		{
		}

		private void InitPlayer()
		{
		}

		private void OnReset()
		{
		}

		public override Quaternion CalculateRotation()
		{
			return default;
		}

		private bool IsUsingGyro()
		{
			return false;
		}

		public Quaternion CalculateRotation(float addUpMagnitude)
		{
			return default;
		}

		protected override Vector3 CalculatePosition()
		{
			return default;
		}

		private Quaternion GetSwitchGyro()
		{
			return default;
		}

		public void SetFollowTarget(Transform target)
		{
		}

		public Transform GetFollowTarget()
		{
			return null;
		}
	}
}
