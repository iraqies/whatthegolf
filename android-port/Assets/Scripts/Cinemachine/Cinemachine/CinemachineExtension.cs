using System.Collections.Generic;
using UnityEngine;

namespace Cinemachine
{
	public abstract class CinemachineExtension : MonoBehaviour
	{
		protected const float Epsilon = 0.0001f;

		private CinemachineVirtualCameraBase m_vcamOwner;

		private Dictionary<ICinemachineCamera, object> mExtraState;

		public CinemachineVirtualCameraBase VirtualCamera => null;

		protected virtual void Awake()
		{
		}

		protected virtual void OnDestroy()
		{
		}

		protected virtual void ConnectToVcam(bool connect)
		{
		}

		public void InvokePostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime)
		{
		}

		protected abstract void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime);

		public virtual void OnTargetObjectWarped(Transform target, Vector3 positionDelta)
		{
		}

		public virtual bool OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime)
		{
			return false;
		}

		protected T GetExtraState<T>(ICinemachineCamera vcam) where T : class, new()
		{
			return null;
		}

		protected List<T> GetAllExtraStates<T>() where T : class, new()
		{
			return null;
		}
	}
}
