using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace CameraStack
{
	public class OverworldCamera : MonoBehaviour
	{
		private Action m_OnPreLateUpdate;
		private Camera[] _cameras;
		public static OverworldCamera Instance;
		public Transform OverridePositionTransform;
		public float OverridePositionWeight;
		[SerializeField] private CameraBehavior MobileCameraBehaviour;
		[SerializeField] private CameraBehavior StandaloneCameraBehaviour;
		[SerializeField] private CBOverworldRoomStatic PuzzleRoomCameraBehaviour;
		private PerlinShake shake;
		private List<OverworldCameraSettings> cameraSettings = new List<OverworldCameraSettings>();
		private GyroShakeOverworld gyro;
		public OverworldCameraSettings defaultSettings;
		public OverworldCameraSettings resetCamearaSettings;
		private float currentCameraSettingsTweenTime;
		private Vector3 lastBallPosition;
		private Vector3 lookAhead;

		public Camera[] Cameras => _cameras ?? (_cameras = GetComponentsInChildren<Camera>(true));
		public Camera MainCamera => GetComponent<Camera>() ?? (Cameras.Length > 0 ? Cameras[0] : Camera.main);
		public CameraBehavior ActiveBehavior { get; private set; }

		public event Action OnPreLateUpdate
		{
			add => m_OnPreLateUpdate = (Action)Delegate.Combine(m_OnPreLateUpdate, value);
			remove => m_OnPreLateUpdate = (Action)Delegate.Remove(m_OnPreLateUpdate, value);
		}

		[RuntimeInitializeOnLoadMethod]
		private static void Init()
		{
			Instance = null;
		}

		private void Awake()
		{
			Instance = this;
			_cameras = GetComponentsInChildren<Camera>(true);
			ActiveBehavior = MobileCameraBehaviour != null ? MobileCameraBehaviour : StandaloneCameraBehaviour;
		}

		private IEnumerator ResetCameraNextFrame()
		{
			yield return null;
		}

		private void OnCameraSettingsChanged(OverworldCameraSettings settings, float pct) { }
		public void OnRoomEnter(CBOverworldRoomStatic camSettings) { }
		public void OnRoomExit() { }

		private void LateUpdate()
		{
			m_OnPreLateUpdate?.Invoke();
			Transform target = OverridePositionTransform;
			if (target == null && OverworldManager2d.HasInstance)
			{
				var ow = OverworldManager2d.Instance;
				if (ow.cameraTarget != null) target = ow.cameraTarget;
				else if (ow.ball != null) target = ow.ball.transform;
			}
			if (target != null)
			{
				Vector3 desired = new Vector3(target.position.x, target.position.y, transform.position.z);
				transform.position = Vector3.Lerp(transform.position, desired, Time.unscaledDeltaTime * 6f);
			}
		}

		public void SwitchBehavior(CameraBehavior newCameraBehavior) => ActiveBehavior = newCameraBehavior;
		public void Shake(float duration, float speed, float magnitude) { }

		public bool IsWorldPosNearScreen(Vector3 pos, float nearThreshold = 0.25f) => true;
	}
}
