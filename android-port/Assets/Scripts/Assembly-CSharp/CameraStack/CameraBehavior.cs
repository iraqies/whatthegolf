using System;
using Cinemachine;
using Core;
using UnityEngine;

namespace CameraStack
{
	public abstract class CameraBehavior : MonoBehaviour
	{
		public string PlatformName;

		[NonSerialized]
		public Camera[] cameras;

		public bool IsAttachedToCameraManager;

		private CinemachineVirtualCamera[] virtualCameras;

		public Camera[] Cameras
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public CinemachineVirtualCamera[] VirtualCameras
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected GolfBallController Ball => null;

		public Vector3 Position => default;

		public Quaternion Rotation => default;

		public void ResetCameras()
		{
		}

		public virtual void Init()
		{
		}

		public virtual void Cleanup()
		{
		}

		public virtual void PreUpdate()
		{
		}

		public abstract Quaternion CalculateRotation();

		protected abstract Vector3 CalculatePosition();

		public virtual void OutOfBounds()
		{
		}

		public virtual void GoalComplete()
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
