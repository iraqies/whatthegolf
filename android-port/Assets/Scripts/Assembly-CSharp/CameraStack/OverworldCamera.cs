using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Core;
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

		public Camera[] Cameras => (_cameras != null && _cameras.Length > 0) ? _cameras : (_cameras = GetComponentsInChildren<Camera>(true));
		public Camera MainCamera => (Cameras != null && Cameras.Length > 0) ? Cameras[0] : (GetComponent<Camera>() ?? Camera.main);
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
			if (_cameras != null)
			{
				foreach (var cam in _cameras)
				{
					if (cam != null)
						cam.useOcclusionCulling = false;
				}
			}
			var currentCfg = PlatformSettings.Instance != null ? PlatformSettings.Instance.GetCurrent() : null;
			bool useMobile = currentCfg == null || currentCfg.IsMobile;
			CameraBehavior chosen = useMobile
				? (MobileCameraBehaviour != null ? MobileCameraBehaviour : StandaloneCameraBehaviour)
				: (StandaloneCameraBehaviour != null ? StandaloneCameraBehaviour : MobileCameraBehaviour);
			if (chosen == null) chosen = GetComponent<CameraBehavior>();
			if (chosen != null) SwitchBehavior(chosen);

			cameraSettings = GetComponentsInChildren<OverworldCameraSettings>(true).ToList();
			foreach (var cs in cameraSettings)
			{
				if (cs != null)
				{
					cs.OnSettingsUpdated -= OnCameraSettingsChanged;
					cs.OnSettingsUpdated += OnCameraSettingsChanged;
				}
			}
			var triggers = GetComponentsInChildren<OverworldCameraCenterTrigger>(true);
			if (triggers != null)
			{
				foreach (var tr in triggers)
				{
					if (tr != null && tr.inSettings != null && !cameraSettings.Contains(tr.inSettings))
					{
						cameraSettings.Add(tr.inSettings);
						tr.inSettings.OnSettingsUpdated -= OnCameraSettingsChanged;
						tr.inSettings.OnSettingsUpdated += OnCameraSettingsChanged;
					}
				}
			}
			if (defaultSettings != null)
			{
				defaultSettings.OnSettingsUpdated -= OnCameraSettingsChanged;
				defaultSettings.OnSettingsUpdated += OnCameraSettingsChanged;
				defaultSettings.SetValue(1f);
			}
			StartCoroutine(ResetCameraNextFrame());
		}

		private IEnumerator ResetCameraNextFrame()
		{
			yield return null;
			if (resetCamearaSettings != null)
				OnCameraSettingsChanged(resetCamearaSettings, 1f);
			else if (defaultSettings != null)
				OnCameraSettingsChanged(defaultSettings, 1f);
		}

		private void OnCameraSettingsChanged(OverworldCameraSettings settings, float pct)
		{
			if (ActiveBehavior == null || !(ActiveBehavior is CBOrthographicFollow2D ortho))
				return;
			if (settings == null)
				return;

			var currentCfg = PlatformSettings.Instance != null ? PlatformSettings.Instance.GetCurrent() : null;
			bool useMobile = currentCfg == null || currentCfg.IsMobile;

			OverworldCameraSettings.CameraData toData = useMobile ? (settings.IOSData ?? settings.PCTVData) : (settings.PCTVData ?? settings.IOSData);
			OverworldCameraSettings.CameraData fromData = null;
			if (defaultSettings != null)
				fromData = useMobile ? (defaultSettings.IOSData ?? defaultSettings.PCTVData) : (defaultSettings.PCTVData ?? defaultSettings.IOSData);
			if (fromData == null)
				fromData = toData;
			if (toData == null)
				return;

			float t = TweenFunctions.SmoothStep(pct);
			ortho.sideTrackPadding = Mathf.Lerp(fromData.sideTrackPadding, toData.sideTrackPadding, t);
			ortho.lowerTrackPadding = Mathf.Lerp(fromData.lowerTrackPadding, toData.lowerTrackPadding, t);
			ortho.upperTrackPadding = Mathf.Lerp(fromData.upperTrackPadding, toData.upperTrackPadding, t);
			float size = Mathf.Lerp(fromData.orthographicSize, toData.orthographicSize, t);
			if (size > 0.1f)
				ortho.SetOrthoSize(size);
			float tTween = TweenFunctions.SmoothStep(Mathf.Clamp01(pct * toData.tweenTimtweenTime));
			ortho.tweenTime = Mathf.Lerp(fromData.tweenTime, toData.tweenTime, tTween);
			ortho.lookAheadDistance = Mathf.Lerp(fromData.lookAhead, toData.lookAhead, t);
		}

		public void OnRoomEnter(CBOverworldRoomStatic camSettings)
		{
			if (ActiveBehavior is CBOrthographicFollow2D ortho && PuzzleRoomCameraBehaviour != null)
			{
				PuzzleRoomCameraBehaviour.SetOrthoSize(ortho.GetOrthoSize());
				if (camSettings != null)
					PuzzleRoomCameraBehaviour.roomCenter = camSettings.roomCenter;
				SwitchBehavior(PuzzleRoomCameraBehaviour);
			}
			else if (camSettings != null)
			{
				SwitchBehavior(camSettings);
			}
		}

		public void OnRoomExit()
		{
			var currentCfg = PlatformSettings.Instance != null ? PlatformSettings.Instance.GetCurrent() : null;
			bool useMobile = currentCfg == null || currentCfg.IsMobile;
			var b = useMobile
				? (MobileCameraBehaviour != null ? MobileCameraBehaviour : StandaloneCameraBehaviour)
				: (StandaloneCameraBehaviour != null ? StandaloneCameraBehaviour : MobileCameraBehaviour);
			if (b != null) SwitchBehavior(b);
		}

		private void LateUpdate()
		{
			m_OnPreLateUpdate?.Invoke();
			if (ActiveBehavior != null)
			{
				ActiveBehavior.PreUpdate();
				if (ActiveBehavior is CBOrthographicFollow2D ortho && OverworldBallManager.HasInstance && OverworldBallManager.Instance != null && OverworldBallManager.Instance.Ball != null && OverworldBallManager.Instance.Ball.rigidBody != null)
				{
					Vector2 vel = OverworldBallManager.Instance.Ball.rigidBody.velocity;
					lookAhead = new Vector3(vel.x, vel.y, 0f);
					ortho.lookAhead = lookAhead;
				}
				Vector3 pos = ActiveBehavior.Position;
				if (OverridePositionTransform != null && OverridePositionWeight > 0f)
				{
					float w = Mathf.Clamp01(OverridePositionWeight);
					pos.x = Mathf.Lerp(pos.x, OverridePositionTransform.position.x, w);
					pos.y = Mathf.Lerp(pos.y, OverridePositionTransform.position.y, w);
				}
				transform.position = pos;
				transform.rotation = ActiveBehavior.Rotation;
			}
		}

		public void SwitchBehavior(CameraBehavior newCameraBehavior)
		{
			if (newCameraBehavior == null) return;
			ActiveBehavior?.Cleanup();
			ActiveBehavior = newCameraBehavior;
			ActiveBehavior.Cameras = Cameras;
			ActiveBehavior.Init();
		}

		public void Shake(float duration, float speed, float magnitude)
		{
			if (shake == null)
				shake = GetComponentInChildren<PerlinShake>();
			if (shake != null)
			{
				shake.duration = duration;
				shake.speed = speed;
				shake.magnitude = magnitude;
				shake.Shake();
			}
		}

		public bool IsWorldPosNearScreen(Vector3 pos, float nearThreshold = 0.25f)
		{
			var cam = MainCamera;
			if (cam == null) return true;
			Vector3 vp = cam.WorldToViewportPoint(pos);
			return vp.x > -nearThreshold && vp.x < 1f + nearThreshold && vp.y > -nearThreshold && vp.y < 1f + nearThreshold;
		}
	}
}
