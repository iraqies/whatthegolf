using System;
using System.Runtime.CompilerServices;
using Core;
using UnityEngine;

namespace CameraStack
{
	public class CameraManager : MonoBehaviour
	{
		private static CameraManager _instance;
		private Action<CameraBehavior> m_OnActiveBehaviourChanged;
		private Camera[] _cameras;
		public bool useGyroSense;
		[SerializeField] public CameraBehavior OnPlayCameraBehavior;
		[SerializeField] public CameraBehavior DesktopCameraOverrideBehaviour;
		public bool challengeSetup;
		[SerializeField] public CameraBehavior OnChallengeCameraBehavior;
		[SerializeField] public CameraBehavior DesktopChallengeCameraOverrideBehaviour;
		private bool _started;
		private bool? _is2D;
		private PerlinShake shake;
		private GyroShake gyro;
		private bool activeBehaviourAttachedToThis;
		public float gyroSenseMagnitude;

		public static CameraManager Instance => _instance ?? (_instance = FindObjectOfType<CameraManager>());
		public Camera[] Cameras => _cameras ?? (_cameras = GetComponentsInChildren<Camera>(true));
		public Camera MainCamera => GetComponent<Camera>() ?? (Cameras.Length > 0 ? Cameras[0] : Camera.main);
		public CameraBehavior ActiveBehavior { get; private set; }
		public bool Is2D { set => _is2D = value; }

		public event Action<CameraBehavior> OnActiveBehaviourChanged
		{
			add => m_OnActiveBehaviourChanged = (Action<CameraBehavior>)Delegate.Combine(m_OnActiveBehaviourChanged, value);
			remove => m_OnActiveBehaviourChanged = (Action<CameraBehavior>)Delegate.Remove(m_OnActiveBehaviourChanged, value);
		}

		public void Reset() => OnReset();

		public void SetChallengeBehaviour(CameraBehavior arg1, CameraBehavior arg2)
		{
			OnChallengeCameraBehavior = arg1;
			DesktopChallengeCameraOverrideBehaviour = arg2;
		}

		private void Awake()
		{
			_instance = this;
			_cameras = GetComponentsInChildren<Camera>(true);
			if (challengeSetup)
			{
				if (OnChallengeCameraBehavior != null)
					OnPlayCameraBehavior = OnChallengeCameraBehavior;
				if (DesktopChallengeCameraOverrideBehaviour != null)
					DesktopCameraOverrideBehaviour = DesktopChallengeCameraOverrideBehaviour;
				SetCurrentBehaviour();
				challengeSetup = false;
			}
			if (Level.HasInstance && Level.Instance != null)
			{
				Level.Instance.OnComplete -= OnGoal;
				Level.Instance.OnComplete += OnGoal;
				Level.Instance.OnReset -= OnReset;
				Level.Instance.OnReset += OnReset;
			}
		}

		private void OnDestroy()
		{
			if (Level.HasInstance && Level.Instance != null)
			{
				Level.Instance.OnComplete -= OnGoal;
				Level.Instance.OnReset -= OnReset;
			}
			if (_instance == this) _instance = null;
		}

		private void OnChallengeSelected(string id) { }

		public void SetCurrentBehaviour()
		{
			var next = OnPlayCameraBehavior != null ? OnPlayCameraBehavior : DesktopCameraOverrideBehaviour;
			if (next == null) next = GetComponent<CameraBehavior>();
			if (next != null) SwitchBehavior(next);
		}

		private void Start()
		{
			if (!_started)
			{
				SetCurrentBehaviour();
				OnReset();
				_started = true;
			}
		}

		private void StartCheckingForAirPlay() { }

		private void OnReset()
		{
			if (ActiveBehavior == null) return;
			for (int i = 0; i < 200; i++)
			{
				ActiveBehavior.OutOfBounds();
				transform.position = ActiveBehavior.Position;
				transform.rotation = ActiveBehavior.Rotation;
				ActiveBehavior.transform.position = transform.position;
				ActiveBehavior.transform.rotation = transform.rotation;
			}
		}

		private void Update() => ManualUpdate();

		public void SwitchBehavior(CameraBehavior newCameraBehavior)
		{
			if (ActiveBehavior != null)
				ActiveBehavior.Cleanup();
			ActiveBehavior = newCameraBehavior;
			if (ActiveBehavior != null)
			{
				ActiveBehavior.IsAttachedToCameraManager = (ActiveBehavior.gameObject == gameObject);
				if (!ActiveBehavior.IsAttachedToCameraManager)
					ActiveBehavior.transform.SetParent(transform);
				ActiveBehavior.Cameras = Cameras;
				ActiveBehavior.Init();
				m_OnActiveBehaviourChanged?.Invoke(ActiveBehavior);
				if (MainAudioListener.Instance != null)
					MainAudioListener.Instance.OnCameraBehaviourChanged(ActiveBehavior);
			}
		}

		private void OnGoal(Level.CompletedState s) => ActiveBehavior?.GoalComplete();

		public void ManualUpdate()
		{
			if (ActiveBehavior == null) return;
			ActiveBehavior.PreUpdate();
			Vector3 pos = ActiveBehavior.Position;
			if (!float.IsNaN(pos.x) && !float.IsNaN(pos.y) && !float.IsNaN(pos.z))
				transform.position = pos;
			transform.rotation = ActiveBehavior.Rotation;
			ActiveBehavior.transform.position = transform.position;
			ActiveBehavior.transform.rotation = transform.rotation;
		}

		public void Shake(float duration, float speed, float magnitude) { }
		public void StopShake() { }
		public float GetShakeMagnitude() => 0f;
		private void OnDrawGizmosSelected() { }
	}
}
