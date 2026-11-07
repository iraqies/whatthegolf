using System;
using Cinemachine;
using Core;
using UnityEngine;

namespace CameraStack
{
	public abstract class CameraBehavior : MonoBehaviour
	{
		public string PlatformName;
		[NonSerialized] public Camera[] cameras;
		public bool IsAttachedToCameraManager;
		private CinemachineVirtualCamera[] virtualCameras;

		public Camera[] Cameras
		{
			get => cameras ?? (cameras = GetComponentsInChildren<Camera>(true));
			set => cameras = value;
		}

		public CinemachineVirtualCamera[] VirtualCameras
		{
			get => virtualCameras ?? (virtualCameras = GetComponentsInChildren<CinemachineVirtualCamera>(true));
			set => virtualCameras = value;
		}

		protected GolfBallController Ball => Level.HasInstance ? Level.Instance.Ball : FindObjectOfType<GolfBallController>();
		public Vector3 Position => CalculatePosition();
		public Quaternion Rotation => CalculateRotation();

		public void ResetCameras() { }
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
