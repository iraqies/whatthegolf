using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace CameraStack
{
	public class OverworldCamera : MonoBehaviour
	{
		[CompilerGenerated]
		private Action m_OnPreLateUpdate;

		private Camera[] _cameras;

		public static OverworldCamera Instance;

		public Transform OverridePositionTransform;

		public float OverridePositionWeight;

		[SerializeField]
		private CameraBehavior MobileCameraBehaviour;

		[SerializeField]
		private CameraBehavior StandaloneCameraBehaviour;

		[SerializeField]
		private CBOverworldRoomStatic PuzzleRoomCameraBehaviour;

		private PerlinShake shake;

		private List<OverworldCameraSettings> cameraSettings;

		private GyroShakeOverworld gyro;

		public OverworldCameraSettings defaultSettings;

		public OverworldCameraSettings resetCamearaSettings;

		private float currentCameraSettingsTweenTime;

		private Vector3 lastBallPosition;

		private Vector3 lookAhead;

		public Camera[] Cameras => null;

		public Camera MainCamera => null;

		public CameraBehavior ActiveBehavior { get; private set; }

		public event Action OnPreLateUpdate
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		[RuntimeInitializeOnLoadMethod]
		private static void Init()
		{
		}

		private void Awake()
		{
		}

		private IEnumerator ResetCameraNextFrame()
		{
			return null;
		}

		private void OnCameraSettingsChanged(OverworldCameraSettings settings, float pct)
		{
		}

		public void OnRoomEnter(CBOverworldRoomStatic camSettings)
		{
		}

		public void OnRoomExit()
		{
		}

		private void LateUpdate()
		{
		}

		public void SwitchBehavior(CameraBehavior newCameraBehavior)
		{
		}

		public void Shake(float duration, float speed, float magnitude)
		{
		}

		public bool IsWorldPosNearScreen(Vector3 pos, float nearThreshold = 0.25f)
		{
			return false;
		}
	}
}
