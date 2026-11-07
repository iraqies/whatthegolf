using UnityEngine;

namespace Cinemachine
{
	public interface ICinemachineCamera
	{
		string Name { get; }

		int Priority { get; }

		Transform LookAt { get; }

		Transform Follow { get; }

		CameraState State { get; }

		GameObject VirtualCameraGameObject { get; }

		bool IsValid { get; }

		ICinemachineCamera ParentCamera { get; }

		bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false);

		void UpdateCameraState(Vector3 worldUp, float deltaTime);

		void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime);
	}
}
