using Il2CppDummyDll;
using UnityEngine;

namespace Cinemachine
{
	[Token(Token = "0x2000062")]
	public abstract class CinemachineComponentBase : MonoBehaviour
	{
		[Token(Token = "0x4000247")]
		protected const float Epsilon = 0.0001f;

		[Token(Token = "0x4000248")]
		[FieldOffset(Offset = "0x18")]
		private CinemachineVirtualCameraBase m_vcamOwner;

		[Token(Token = "0x4000249")]
		[FieldOffset(Offset = "0x20")]
		private Transform mCachedFollowTarget;

		[Token(Token = "0x400024A")]
		[FieldOffset(Offset = "0x28")]
		private CinemachineVirtualCameraBase mCachedFollowTargetVcam;

		[Token(Token = "0x400024B")]
		[FieldOffset(Offset = "0x30")]
		private ICinemachineTargetGroup mCachedFollowTargetGroup;

		[Token(Token = "0x400024C")]
		[FieldOffset(Offset = "0x38")]
		private Transform mCachedLookAtTarget;

		[Token(Token = "0x400024D")]
		[FieldOffset(Offset = "0x40")]
		private CinemachineVirtualCameraBase mCachedLookAtTargetVcam;

		[Token(Token = "0x400024E")]
		[FieldOffset(Offset = "0x48")]
		private ICinemachineTargetGroup mCachedLookAtTargetGroup;

		[Token(Token = "0x1700009B")]
		public CinemachineVirtualCameraBase VirtualCamera
		{
			[Token(Token = "0x600024C")]
			[Address(RVA = "0x18ECAC8", Offset = "0x18ECAC8", VA = "0x18ECAC8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009C")]
		public Transform FollowTarget
		{
			[Token(Token = "0x600024D")]
			[Address(RVA = "0x18ECC24", Offset = "0x18ECC24", VA = "0x18ECC24")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009D")]
		public Transform LookAtTarget
		{
			[Token(Token = "0x600024E")]
			[Address(RVA = "0x18ECCD8", Offset = "0x18ECCD8", VA = "0x18ECCD8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009E")]
		public ICinemachineTargetGroup AbstractFollowTargetGroup
		{
			[Token(Token = "0x6000250")]
			[Address(RVA = "0x18ECE70", Offset = "0x18ECE70", VA = "0x18ECE70")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009F")]
		public CinemachineTargetGroup FollowTargetGroup
		{
			[Token(Token = "0x6000251")]
			[Address(RVA = "0x18ECF0C", Offset = "0x18ECF0C", VA = "0x18ECF0C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A0")]
		public Vector3 FollowTargetPosition
		{
			[Token(Token = "0x6000252")]
			[Address(RVA = "0x18ECF94", Offset = "0x18ECF94", VA = "0x18ECF94")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000A1")]
		public Quaternion FollowTargetRotation
		{
			[Token(Token = "0x6000253")]
			[Address(RVA = "0x18ED0F8", Offset = "0x18ED0F8", VA = "0x18ED0F8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000A2")]
		public ICinemachineTargetGroup AbstractLookAtTargetGroup
		{
			[Token(Token = "0x6000255")]
			[Address(RVA = "0x18ED3BC", Offset = "0x18ED3BC", VA = "0x18ED3BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A3")]
		public CinemachineTargetGroup LookAtTargetGroup
		{
			[Token(Token = "0x6000256")]
			[Address(RVA = "0x18ED458", Offset = "0x18ED458", VA = "0x18ED458")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A4")]
		public Vector3 LookAtTargetPosition
		{
			[Token(Token = "0x6000257")]
			[Address(RVA = "0x18ED4E0", Offset = "0x18ED4E0", VA = "0x18ED4E0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000A5")]
		public Quaternion LookAtTargetRotation
		{
			[Token(Token = "0x6000258")]
			[Address(RVA = "0x18ED644", Offset = "0x18ED644", VA = "0x18ED644")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000A6")]
		public CameraState VcamState
		{
			[Token(Token = "0x6000259")]
			[Address(RVA = "0x18ED7D4", Offset = "0x18ED7D4", VA = "0x18ED7D4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000A7")]
		public abstract bool IsValid
		{
			[Token(Token = "0x600025A")]
			get;
		}

		[Token(Token = "0x170000A8")]
		public abstract CinemachineCore.Stage Stage
		{
			[Token(Token = "0x600025C")]
			get;
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x18ECD8C", Offset = "0x18ECD8C", VA = "0x18ECD8C")]
		private void UpdateFollowTargetCache()
		{
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x18ED2D8", Offset = "0x18ED2D8", VA = "0x18ED2D8")]
		private void UpdateLookAtTargetCache()
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x18ED8BC", Offset = "0x18ED8BC", VA = "0x18ED8BC", Slot = "5")]
		public virtual void PrePipelineMutateCameraState(ref CameraState curState, float deltaTime)
		{
		}

		[Token(Token = "0x600025D")]
		public abstract void MutateCameraState(ref CameraState curState, float deltaTime);

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x18ED8C0", Offset = "0x18ED8C0", VA = "0x18ED8C0", Slot = "8")]
		public virtual bool OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime, ref CinemachineVirtualCameraBase.TransitionParams transitionParams)
		{
			return default;
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x18ED8C8", Offset = "0x18ED8C8", VA = "0x18ED8C8", Slot = "9")]
		public virtual void OnTargetObjectWarped(Transform target, Vector3 positionDelta)
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x18E124C", Offset = "0x18E124C", VA = "0x18E124C")]
		protected CinemachineComponentBase()
		{
		}
	}
}
