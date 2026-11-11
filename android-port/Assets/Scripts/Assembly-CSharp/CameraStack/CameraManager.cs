using System;
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
		public CameraBehavior CurrentBehaviour => ActiveBehavior;
		public CameraBehavior CurrentCameraBehavior => ActiveBehavior;
		public bool Is2D { set => _is2D = value; }

		public void FollowTarget(Transform target)
		{
			if (ActiveBehavior is CBFollow follow)
			{
				follow.FollowTarget = target;
			}
		}

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
			if (_cameras == null || _cameras.Length == 0)
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

			var shakeGo = new GameObject("Shake");
			shakeGo.transform.SetParent(transform, true);
			shakeGo.transform.localPosition = Vector3.zero;
			shakeGo.transform.localRotation = Quaternion.identity;
			shake = shakeGo.AddComponent<PerlinShake>();

			if (_cameras == null || _cameras.Length == 0)
				_cameras = GetComponentsInChildren<Camera>(true);
			if (_cameras != null)
			{
				for (int i = 0; i < _cameras.Length; i++)
				{
					if (_cameras[i] == null) continue;
					_cameras[i].transform.SetParent(shakeGo.transform, true);
					_cameras[i].useOcclusionCulling = false;
				}
			}

			if (Level.HasInstance && Level.Instance != null)
			{
				Level.Instance.OnComplete -= OnGoal;
				Level.Instance.OnComplete += OnGoal;
				Level.Instance.OnReset -= OnReset;
				Level.Instance.OnReset += OnReset;
			}
			if (LevelManager.Exists && LevelManager.Instance != null)
			{
				LevelManager.Instance.ChallengeSelected -= OnChallengeSelected;
				LevelManager.Instance.ChallengeSelected += OnChallengeSelected;
			}
		}

		private void OnDestroy()
		{
			if (LevelManager.Exists && LevelManager.Instance != null)
			{
				LevelManager.Instance.ChallengeSelected -= OnChallengeSelected;
			}
			if (Level.HasInstance && Level.Instance != null)
			{
				Level.Instance.OnComplete -= OnGoal;
				Level.Instance.OnReset -= OnReset;
			}
			if (_instance == this) _instance = null;
		}

		private void OnChallengeSelected(string id)
		{
			if (!string.IsNullOrEmpty(id))
			{
				var lc = FindObjectOfType<LevelChallenges>();
				if (lc != null && lc.Challenges != null)
				{
					Challenge found = null;
					for (int i = 0; i < lc.Challenges.Count; i++)
					{
						if (lc.Challenges[i] != null && lc.Challenges[i].ID == id)
						{
							found = lc.Challenges[i];
							break;
						}
					}
					if (found != null && (found.CustomCameraBehaviour != null || found.CustomDesktopOverrideBehaviour != null))
					{
						if (found.CustomCameraBehaviour != null)
							OnPlayCameraBehavior = found.CustomCameraBehaviour;
						else if (OnChallengeCameraBehavior != null)
							OnPlayCameraBehavior = OnChallengeCameraBehavior;

						if (found.CustomDesktopOverrideBehaviour != null)
							DesktopCameraOverrideBehaviour = found.CustomDesktopOverrideBehaviour;
						else if (DesktopChallengeCameraOverrideBehaviour != null)
							DesktopCameraOverrideBehaviour = DesktopChallengeCameraOverrideBehaviour;
					}
				}
			}
			SetCurrentBehaviour();
			OnReset();
			_started = true;
		}

		public void SetCurrentBehaviour()
		{
			bool useRot = PlatformSettings.Instance != null && PlatformSettings.Instance.GetCurrent() != null && PlatformSettings.Instance.GetCurrent().useRotatedOverworldAndCameraInLevels;
			CameraBehavior next = (useRot || DesktopCameraOverrideBehaviour == null) ? OnPlayCameraBehavior : DesktopCameraOverrideBehaviour;
			if (next == null) next = OnPlayCameraBehavior ?? DesktopCameraOverrideBehaviour ?? GetComponent<CameraBehavior>();
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

		private void Update()
		{
			if (ActiveBehavior == null) return;
			ActiveBehavior.PreUpdate();
			Vector3 pos = ActiveBehavior.Position;
			if (!float.IsNaN(pos.x))
				transform.position = ActiveBehavior.Position;
			transform.rotation = ActiveBehavior.Rotation;
			ActiveBehavior.transform.position = transform.position;
			ActiveBehavior.transform.rotation = transform.rotation;
		}

		public void SwitchBehavior(CameraBehavior newCameraBehavior)
		{
			if (ActiveBehavior != null)
				ActiveBehavior.Cleanup();
			ActiveBehavior = newCameraBehavior;
			if (ActiveBehavior != null)
			{
				ActiveBehavior.IsAttachedToCameraManager = (ActiveBehavior.gameObject == gameObject);
				if (!ActiveBehavior.IsAttachedToCameraManager)
					ActiveBehavior.transform.SetParent(transform, true);
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
			var b = OnPlayCameraBehavior ?? ActiveBehavior;
			if (b == null) return;
			b.Init();
			b.OutOfBounds();
			transform.position = b.Position;
			transform.rotation = b.Rotation;
		}

		public void Shake(float duration, float speed, float magnitude)
		{
			if (shake == null)
				shake = gameObject.GetComponentInChildren<PerlinShake>();
			if (shake != null)
			{
				shake.duration = duration;
				shake.speed = speed;
				shake.magnitude = magnitude;
				shake.Shake();
			}
		}

		public void StopShake()
		{
			if (shake != null)
				shake.StopShake();
		}

		public void DirectionalShake(float duration, float speed, Vector3 dir, Vector3 pos, float magnitude)
		{
			Shake(duration, speed, magnitude);
		}

		public void PerlinShake(float duration, float speed, float magnitude, Vector3 pos = default)
		{
			Shake(duration, speed, magnitude);
		}

		public float GetShakeMagnitude() => shake != null ? shake.magnitude : 0f;
		private void OnDrawGizmosSelected() { }
	}
}
