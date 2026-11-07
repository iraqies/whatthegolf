using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Cinemachine
{
	[Token(Token = "0x200006D")]
	public abstract class CinemachineVirtualCameraBase : MonoBehaviour, ICinemachineCamera
	{
		[Token(Token = "0x200006E")]
		public enum StandbyUpdateMode
		{
			[Token(Token = "0x400028E")]
			Never = 0,
			[Token(Token = "0x400028F")]
			Always = 1,
			[Token(Token = "0x4000290")]
			RoundRobin = 2
		}

		[Token(Token = "0x200006F")]
		public enum BlendHint
		{
			[Token(Token = "0x4000292")]
			None = 0,
			[Token(Token = "0x4000293")]
			SphericalPosition = 1,
			[Token(Token = "0x4000294")]
			CylindricalPosition = 2,
			[Token(Token = "0x4000295")]
			ScreenSpaceAimWhenTargetsDiffer = 3
		}

		[Serializable]
		[Token(Token = "0x2000070")]
		public struct TransitionParams
		{
			[Token(Token = "0x4000296")]
			[FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x792B4", Offset = "0x792B4")]
			public BlendHint m_BlendHint;

			[Token(Token = "0x4000297")]
			[FieldOffset(Offset = "0x4")]
			public bool m_InheritPosition;

			[Token(Token = "0x4000298")]
			[FieldOffset(Offset = "0x8")]
			public CinemachineBrain.VcamActivatedEvent m_OnCameraLive;
		}

		[Token(Token = "0x4000281")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public string[] m_ExcludedPropertiesInInspector;

		[Token(Token = "0x4000282")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		public CinemachineCore.Stage[] m_LockStageInInspector;

		[Token(Token = "0x4000283")]
		[FieldOffset(Offset = "0x28")]
		private int m_ValidatingStreamVersion;

		[Token(Token = "0x4000284")]
		[FieldOffset(Offset = "0x2C")]
		private bool m_OnValidateCalled;

		[Token(Token = "0x4000285")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private int m_StreamingVersion;

		[Token(Token = "0x4000286")]
		[FieldOffset(Offset = "0x34")]
		public int m_Priority;

		[Token(Token = "0x4000287")]
		[FieldOffset(Offset = "0x38")]
		public StandbyUpdateMode m_StandbyUpdate;

		[Token(Token = "0x4000288")]
		[FieldOffset(Offset = "0x40")]
		private List<CinemachineExtension> mExtensions;

		[Token(Token = "0x4000289")]
		[FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x792A4", Offset = "0x792A4")]
		private bool PreviousStateIsValid__BackingField;

		[Token(Token = "0x400028A")]
		[FieldOffset(Offset = "0x49")]
		private bool mSlaveStatusUpdated;

		[Token(Token = "0x400028B")]
		[FieldOffset(Offset = "0x50")]
		private CinemachineVirtualCameraBase m_parentVcam;

		[Token(Token = "0x400028C")]
		[FieldOffset(Offset = "0x58")]
		private int m_QueuePriority;

		[Token(Token = "0x170000B4")]
		public int ValidatingStreamVersion
		{
			[Token(Token = "0x60002A7")]
			[Address(RVA = "0x190776C", Offset = "0x190776C", VA = "0x190776C")]
			get
			{
				return default;
			}
			[Token(Token = "0x60002A8")]
			[Address(RVA = "0x190A2F0", Offset = "0x190A2F0", VA = "0x190A2F0")]
			private set
			{
			}
		}

		[Token(Token = "0x170000B5")]
		public string Name
		{
			[Token(Token = "0x60002AD")]
			[Address(RVA = "0x190A47C", Offset = "0x190A47C", VA = "0x190A47C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B6")]
		public virtual string Description
		{
			[Token(Token = "0x60002AE")]
			[Address(RVA = "0x190A484", Offset = "0x190A484", VA = "0x190A484", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B7")]
		public int Priority
		{
			[Token(Token = "0x60002AF")]
			[Address(RVA = "0x190A4C8", Offset = "0x190A4C8", VA = "0x190A4C8", Slot = "5")]
			get
			{
				return default;
			}
			[Token(Token = "0x60002B0")]
			[Address(RVA = "0x190A4D0", Offset = "0x190A4D0", VA = "0x190A4D0", Slot = "18")]
			set
			{
			}
		}

		[Token(Token = "0x170000B8")]
		public GameObject VirtualCameraGameObject
		{
			[Token(Token = "0x60002B2")]
			[Address(RVA = "0x190A4D8", Offset = "0x190A4D8", VA = "0x190A4D8", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B9")]
		public bool IsValid
		{
			[Token(Token = "0x60002B3")]
			[Address(RVA = "0x190A56C", Offset = "0x190A56C", VA = "0x190A56C", Slot = "10")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000BA")]
		public abstract CameraState State
		{
			[Token(Token = "0x60002B4")]
			get;
		}

		[Token(Token = "0x170000BB")]
		public ICinemachineCamera ParentCamera
		{
			[Token(Token = "0x60002B5")]
			[Address(RVA = "0x190A43C", Offset = "0x190A43C", VA = "0x190A43C", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BC")]
		public abstract Transform LookAt
		{
			[Token(Token = "0x60002B7")]
			get;
			[Token(Token = "0x60002B8")]
			set;
		}

		[Token(Token = "0x170000BD")]
		public abstract Transform Follow
		{
			[Token(Token = "0x60002B9")]
			get;
			[Token(Token = "0x60002BA")]
			set;
		}

		[Token(Token = "0x170000BE")]
		public virtual bool PreviousStateIsValid
		{
			[Token(Token = "0x60002BB")]
			[Address(RVA = "0x190A6C8", Offset = "0x190A6C8", VA = "0x190A6C8", Slot = "25")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79AA8", Offset = "0x79AA8")]
			get
			{
				return default;
			}
			[Token(Token = "0x60002BC")]
			[Address(RVA = "0x190A6D0", Offset = "0x190A6D0", VA = "0x190A6D0", Slot = "26")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79AB8", Offset = "0x79AB8")]
			set
			{
			}
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x190A2F8", Offset = "0x190A2F8", VA = "0x190A2F8", Slot = "15")]
		public virtual void AddExtension(CinemachineExtension extension)
		{
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x190A3CC", Offset = "0x190A3CC", VA = "0x190A3CC", Slot = "16")]
		public virtual void RemoveExtension(CinemachineExtension extension)
		{
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x19096CC", Offset = "0x19096CC", VA = "0x19096CC")]
		protected void InvokePostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState newState, float deltaTime)
		{
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x1909ED4", Offset = "0x1909ED4", VA = "0x1909ED4")]
		protected bool InvokeOnTransitionInExtensions(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime)
		{
			return default;
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x1906EF8", Offset = "0x1906EF8", VA = "0x1906EF8")]
		protected void ApplyPositionBlendMethod(ref CameraState state, BlendHint hint)
		{
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x190A6C0", Offset = "0x190A6C0", VA = "0x190A6C0", Slot = "20")]
		public virtual bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false)
		{
			return default;
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x190A058", Offset = "0x190A058", VA = "0x190A058", Slot = "13")]
		public void UpdateCameraState(Vector3 worldUp, float deltaTime)
		{
		}

		[Token(Token = "0x60002BE")]
		public abstract void InternalUpdateCameraState(Vector3 worldUp, float deltaTime);

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x1909E7C", Offset = "0x1909E7C", VA = "0x1909E7C", Slot = "28")]
		public virtual void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime)
		{
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x1907C6C", Offset = "0x1907C6C", VA = "0x1907C6C", Slot = "29")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x190A6D8", Offset = "0x190A6D8", VA = "0x190A6D8", Slot = "30")]
		protected virtual void OnTransformParentChanged()
		{
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x1907DEC", Offset = "0x1907DEC", VA = "0x1907DEC", Slot = "31")]
		protected virtual void OnValidate()
		{
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x1907290", Offset = "0x1907290", VA = "0x1907290", Slot = "32")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x190A890", Offset = "0x190A890", VA = "0x190A890", Slot = "33")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x190A914", Offset = "0x190A914", VA = "0x190A914", Slot = "34")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x190A5F4", Offset = "0x190A5F4", VA = "0x190A5F4")]
		private void UpdateSlaveStatus()
		{
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x1906528", Offset = "0x1906528", VA = "0x1906528")]
		protected Transform ResolveLookAt(Transform localLookAt)
		{
			return null;
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x1906698", Offset = "0x1906698", VA = "0x1906698")]
		protected Transform ResolveFollow(Transform localFollow)
		{
			return null;
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x190A77C", Offset = "0x190A77C", VA = "0x190A77C")]
		private void UpdateVcamPoolStatus()
		{
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x190A92C", Offset = "0x190A92C", VA = "0x190A92C")]
		public void MoveToTopOfPrioritySubqueue()
		{
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x1909A54", Offset = "0x1909A54", VA = "0x1909A54", Slot = "35")]
		public virtual void OnTargetObjectWarped(Transform target, Vector3 positionDelta)
		{
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x190A930", Offset = "0x190A930", VA = "0x190A930")]
		protected CinemachineBlend CreateBlend(ICinemachineCamera camA, ICinemachineCamera camB, CinemachineBlendDefinition blendDef, CinemachineBlend activeBlend)
		{
			return null;
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x1907510", Offset = "0x1907510", VA = "0x1907510")]
		protected CameraState PullStateFromVirtualCamera(Vector3 worldUp, ref LensSettings lens)
		{
			return default;
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x190A218", Offset = "0x190A218", VA = "0x190A218")]
		protected CinemachineVirtualCameraBase()
		{
		}
	}
}
