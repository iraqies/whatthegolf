using System;
using Cinemachine;
using Core;
using UnityEngine;

namespace CameraStack
{
	public abstract class CameraBehavior : MonoBehaviour
	{
		public string PlatformName = string.Empty;
		[NonSerialized] public Camera[] cameras;
		public bool IsAttachedToCameraManager = true;
		private CinemachineVirtualCamera[] virtualCameras;

		public Camera[] Cameras
		{
			get
			{
				if (cameras == null)
				{
					if (IsAttachedToCameraManager)
						cameras = GetComponents<Camera>();
					else if (CameraManager.Instance != null)
						cameras = CameraManager.Instance.gameObject.GetComponentsInChildren<Camera>(true);
					if (cameras == null || cameras.Length == 0)
						cameras = GetComponentsInChildren<Camera>(true);
				}
				return cameras;
			}
			set => cameras = value;
		}

		public CinemachineVirtualCamera[] VirtualCameras
		{
			get
			{
				if (virtualCameras == null)
				{
					if (IsAttachedToCameraManager)
						virtualCameras = GetComponents<CinemachineVirtualCamera>();
					else if (CameraManager.Instance != null)
						virtualCameras = CameraManager.Instance.gameObject.GetComponentsInChildren<CinemachineVirtualCamera>(true);
					if (virtualCameras == null || virtualCameras.Length == 0)
						virtualCameras = GetComponentsInChildren<CinemachineVirtualCamera>(true);
				}
				return virtualCameras;
			}
			set => virtualCameras = value;
		}

		private GolfBallController _cachedBall;
		protected GolfBallController Ball
		{
			get
			{
				if (Level.Instance != null && Level.Instance.Ball != null && Level.Instance.Ball.gameObject.activeInHierarchy)
					return Level.Instance.Ball;
				if (_cachedBall == null || !_cachedBall.gameObject.activeInHierarchy)
					_cachedBall = FindObjectOfType<GolfBallController>();
				return _cachedBall;
			}
		}

		public Vector3 Position => CalculatePosition();
		public Quaternion Rotation => CalculateRotation();

		public void ResetCameras() => cameras = null;
		public virtual void Init() { }
		public virtual void Cleanup() { }
		public virtual void PreUpdate() { }
		public abstract Quaternion CalculateRotation();
		protected abstract Vector3 CalculatePosition();
		public virtual void OutOfBounds() { }
		public virtual void GoalComplete() { }
		public override string ToString() => name;
	}
}
