using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Cinemachine
{
	[Token(Token = "0x2000069")]
	public abstract class CinemachineExtension : MonoBehaviour
	{
		[Token(Token = "0x400026F")]
		protected const float Epsilon = 0.0001f;

		[Token(Token = "0x4000270")]
		[FieldOffset(Offset = "0x18")]
		private CinemachineVirtualCameraBase m_vcamOwner;

		[Token(Token = "0x4000271")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<ICinemachineCamera, object> mExtraState;

		[Token(Token = "0x170000AE")]
		public CinemachineVirtualCameraBase VirtualCamera
		{
			[Token(Token = "0x6000284")]
			[Address(RVA = "0x18E9EC0", Offset = "0x18E9EC0", VA = "0x18E9EC0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x18F0CE4", Offset = "0x18F0CE4", VA = "0x18F0CE4", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x18E92B4", Offset = "0x18E92B4", VA = "0x18E92B4", Slot = "5")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x18F0CF4", Offset = "0x18F0CF4", VA = "0x18F0CF4", Slot = "6")]
		protected virtual void ConnectToVcam(bool connect)
		{
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x18F0E50", Offset = "0x18F0E50", VA = "0x18F0E50")]
		public void InvokePostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime)
		{
		}

		[Token(Token = "0x6000289")]
		protected abstract void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime);

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x18F0E5C", Offset = "0x18F0E5C", VA = "0x18F0E5C", Slot = "8")]
		public virtual void OnTargetObjectWarped(Transform target, Vector3 positionDelta)
		{
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x18F0E60", Offset = "0x18F0E60", VA = "0x18F0E60", Slot = "9")]
		public virtual bool OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime)
		{
			return default;
		}

		[Token(Token = "0x600028C")]
		protected T GetExtraState<T>(ICinemachineCamera vcam) where T : class, new()
		{
			return null;
		}

		[Token(Token = "0x600028D")]
		protected List<T> GetAllExtraStates<T>() where T : class, new()
		{
			return null;
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x18E765C", Offset = "0x18E765C", VA = "0x18E765C")]
		protected CinemachineExtension()
		{
		}
	}
}
