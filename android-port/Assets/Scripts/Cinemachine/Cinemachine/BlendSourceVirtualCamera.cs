using UnityEngine;

namespace Cinemachine
{
	internal class BlendSourceVirtualCamera : ICinemachineCamera
	{
		public CinemachineBlend Blend { get; set; }

		public string Name => null;

		public int Priority { get; }

		public Transform LookAt { get; }

		public Transform Follow { get; }

		public CameraState State { get; private set; }

		public GameObject VirtualCameraGameObject => null;

		public bool IsValid => false;

		public ICinemachineCamera ParentCamera => null;

		public BlendSourceVirtualCamera(CinemachineBlend blend)
		{
		}

		public bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false)
		{
			return false;
		}

		public void UpdateCameraState(Vector3 worldUp, float deltaTime)
		{
		}

		public void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime)
		{
		}
	}
}
