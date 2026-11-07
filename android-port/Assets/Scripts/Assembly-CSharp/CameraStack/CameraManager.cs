using System;
using System.Runtime.CompilerServices;
using Core;
using UnityEngine;

namespace CameraStack
{
	public class CameraManager : MonoBehaviour
	{
		private static CameraManager _instance;

		[CompilerGenerated]
		private Action<CameraBehavior> m_OnActiveBehaviourChanged;

		private Camera[] _cameras;

		public bool useGyroSense;

		[SerializeField]
		public CameraBehavior OnPlayCameraBehavior;

		[SerializeField]
		public CameraBehavior DesktopCameraOverrideBehaviour;

		public bool challengeSetup;

		[SerializeField]
		public CameraBehavior OnChallengeCameraBehavior;

		[SerializeField]
		public CameraBehavior DesktopChallengeCameraOverrideBehaviour;

		private bool _started;

		private bool? _is2D;

		private PerlinShake shake;

		private GyroShake gyro;

		private bool activeBehaviourAttachedToThis;

		public float gyroSenseMagnitude;

		public static CameraManager Instance => null;

		public Camera[] Cameras => null;

		public Camera MainCamera => null;

		public CameraBehavior ActiveBehavior { get; private set; }

		public bool Is2D
		{
			set
			{
			}
		}

		public event Action<CameraBehavior> OnActiveBehaviourChanged
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

		public void Reset()
		{
		}

		public void SetChallengeBehaviour(CameraBehavior arg1, CameraBehavior arg2)
		{
		}

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnChallengeSelected(string id)
		{
		}

		public void SetCurrentBehaviour()
		{
		}

		private void Start()
		{
		}

		private void StartCheckingForAirPlay()
		{
		}

		private void OnReset()
		{
		}

		private void Update()
		{
		}

		public void SwitchBehavior(CameraBehavior newCameraBehavior)
		{
		}

		private void OnGoal(Level.CompletedState s)
		{
		}

		public void ManualUpdate()
		{
		}

		public void Shake(float duration, float speed, float magnitude)
		{
		}

		public void StopShake()
		{
		}

		public float GetShakeMagnitude()
		{
			return 0f;
		}

		private void OnDrawGizmosSelected()
		{
		}
	}
}
