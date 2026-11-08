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
		public float ControllerSensitivity = 2f;
		public float clampAngle = 80f;
		public Vector2 clampInDegrees = new Vector2(360f, 180f);
		public bool lockCursor;
		public Vector2 sensitivity = new Vector2(2f, 2f);
		public Vector2 smoothing = new Vector2(3f, 3f);
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
		private Quaternion _lastRotation = Quaternion.identity;
		private const string HNAME = "Handheld";

		public override void Init()
		{
			base.Init();
			if (Controller == null) Controller = Ball;
			_lastRotation = Quaternion.Euler(rotationOffset);
		}

		private IEnumerator Setup() { yield break; }
		private void OnDestroy() { }
		private void InitPlayer() { }
		private void OnReset() { }
		public override Quaternion CalculateRotation() => _lastRotation;
		private bool IsUsingGyro() => false;
		public Quaternion CalculateRotation(float addUpMagnitude) => _lastRotation;

		protected override Vector3 CalculatePosition()
		{
			Transform t = GetFollowTarget();
			return t != null ? t.position + offset : transform.position;
		}

		private Quaternion GetSwitchGyro() => Quaternion.identity;
		public void SetFollowTarget(Transform target) { }
		public Transform GetFollowTarget() => Controller != null ? Controller.transform : (Ball != null ? Ball.transform : transform);
	}
}
