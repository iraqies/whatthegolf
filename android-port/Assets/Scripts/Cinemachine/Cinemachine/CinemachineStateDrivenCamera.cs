using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Cinemachine
{
	[Token(Token = "0x200002B")]
	[DisallowMultipleComponent]
	[ExecuteAlways]
	public class CinemachineStateDrivenCamera : CinemachineVirtualCameraBase
	{
		[Serializable]
		[Token(Token = "0x200002C")]
		public struct Instruction
		{
			[Token(Token = "0x40000EB")]
			[FieldOffset(Offset = "0x0")]
			public int m_FullHash;

			[Token(Token = "0x40000EC")]
			[FieldOffset(Offset = "0x8")]
			public CinemachineVirtualCameraBase m_VirtualCamera;

			[Token(Token = "0x40000ED")]
			[FieldOffset(Offset = "0x10")]
			public float m_ActivateAfter;

			[Token(Token = "0x40000EE")]
			[FieldOffset(Offset = "0x14")]
			public float m_MinDuration;
		}

		[Serializable]
		[Token(Token = "0x200002D")]
		internal struct ParentHash
		{
			[Token(Token = "0x40000EF")]
			[FieldOffset(Offset = "0x0")]
			public int m_Hash;

			[Token(Token = "0x40000F0")]
			[FieldOffset(Offset = "0x4")]
			public int m_ParentHash;
		}

		[Token(Token = "0x200002E")]
		private struct HashPair
		{
			[Token(Token = "0x40000F1")]
			[FieldOffset(Offset = "0x0")]
			public int parentHash;

			[Token(Token = "0x40000F2")]
			[FieldOffset(Offset = "0x4")]
			public int hash;
		}

		[Token(Token = "0x40000D5")]
		[FieldOffset(Offset = "0x60")]
		public Transform m_LookAt;

		[Token(Token = "0x40000D6")]
		[FieldOffset(Offset = "0x68")]
		public Transform m_Follow;

		[Token(Token = "0x40000D7")]
		[FieldOffset(Offset = "0x70")]
		public Animator m_AnimatedTarget;

		[Token(Token = "0x40000D8")]
		[FieldOffset(Offset = "0x78")]
		public int m_LayerIndex;

		[Token(Token = "0x40000D9")]
		[FieldOffset(Offset = "0x7C")]
		public bool m_ShowDebugText;

		[Token(Token = "0x40000DA")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		internal CinemachineVirtualCameraBase[] m_ChildCameras;

		[Token(Token = "0x40000DB")]
		[FieldOffset(Offset = "0x88")]
		public Instruction[] m_Instructions;

		[Token(Token = "0x40000DC")]
		[FieldOffset(Offset = "0x90")]
		public CinemachineBlendDefinition m_DefaultBlend;

		[Token(Token = "0x40000DD")]
		[FieldOffset(Offset = "0xA0")]
		public CinemachineBlenderSettings m_CustomBlends;

		[Token(Token = "0x40000DE")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		internal ParentHash[] m_ParentHash;

		[Token(Token = "0x40000DF")]
		[FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x786C0", Offset = "0x786C0")]
		private ICinemachineCamera LiveChild__BackingField;

		[Token(Token = "0x40000E0")]
		[FieldOffset(Offset = "0xB8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x786D0", Offset = "0x786D0")]
		private ICinemachineCamera TransitioningFrom__BackingField;

		[Token(Token = "0x40000E1")]
		[FieldOffset(Offset = "0xC0")]
		private CameraState m_State;

		[Token(Token = "0x40000E2")]
		[FieldOffset(Offset = "0x1A0")]
		private Dictionary<AnimationClip, List<HashPair>> mHashCache;

		[Token(Token = "0x40000E3")]
		[FieldOffset(Offset = "0x1A8")]
		private float mActivationTime;

		[Token(Token = "0x40000E4")]
		[FieldOffset(Offset = "0x1B0")]
		private Instruction mActiveInstruction;

		[Token(Token = "0x40000E5")]
		[FieldOffset(Offset = "0x1C8")]
		private float mPendingActivationTime;

		[Token(Token = "0x40000E6")]
		[FieldOffset(Offset = "0x1D0")]
		private Instruction mPendingInstruction;

		[Token(Token = "0x40000E7")]
		[FieldOffset(Offset = "0x1E8")]
		private CinemachineBlend mActiveBlend;

		[Token(Token = "0x40000E8")]
		[FieldOffset(Offset = "0x1F0")]
		private Dictionary<int, int> mInstructionDictionary;

		[Token(Token = "0x40000E9")]
		[FieldOffset(Offset = "0x1F8")]
		private Dictionary<int, int> mStateParentLookup;

		[Token(Token = "0x40000EA")]
		[FieldOffset(Offset = "0x200")]
		private List<AnimatorClipInfo> m_clipInfoList;

		[Token(Token = "0x17000036")]
		public override string Description
		{
			[Token(Token = "0x60000FF")]
			[Address(RVA = "0x18FEE70", Offset = "0x18FEE70", VA = "0x18FEE70", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000037")]
		public ICinemachineCamera LiveChild
		{
			[Token(Token = "0x6000101")]
			[Address(RVA = "0x18FEFEC", Offset = "0x18FEFEC", VA = "0x18FEFEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79598", Offset = "0x79598")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000100")]
			[Address(RVA = "0x18FEFE4", Offset = "0x18FEFE4", VA = "0x18FEFE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79588", Offset = "0x79588")]
			set
			{
			}
		}

		[Token(Token = "0x17000038")]
		public override CameraState State
		{
			[Token(Token = "0x6000103")]
			[Address(RVA = "0x18FF018", Offset = "0x18FF018", VA = "0x18FF018", Slot = "19")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000039")]
		public override Transform LookAt
		{
			[Token(Token = "0x6000104")]
			[Address(RVA = "0x18FF054", Offset = "0x18FF054", VA = "0x18FF054", Slot = "21")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000105")]
			[Address(RVA = "0x18FF060", Offset = "0x18FF060", VA = "0x18FF060", Slot = "22")]
			set
			{
			}
		}

		[Token(Token = "0x1700003A")]
		public override Transform Follow
		{
			[Token(Token = "0x6000106")]
			[Address(RVA = "0x18FF068", Offset = "0x18FF068", VA = "0x18FF068", Slot = "23")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000107")]
			[Address(RVA = "0x18FF074", Offset = "0x18FF074", VA = "0x18FF074", Slot = "24")]
			set
			{
			}
		}

		[Token(Token = "0x1700003B")]
		private ICinemachineCamera TransitioningFrom
		{
			[Token(Token = "0x600010A")]
			[Address(RVA = "0x18FF3D0", Offset = "0x18FF3D0", VA = "0x18FF3D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x795A8", Offset = "0x795A8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600010B")]
			[Address(RVA = "0x18FF3D8", Offset = "0x18FF3D8", VA = "0x18FF3D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x795B8", Offset = "0x795B8")]
			set
			{
			}
		}

		[Token(Token = "0x1700003C")]
		public CinemachineVirtualCameraBase[] ChildCameras
		{
			[Token(Token = "0x6000111")]
			[Address(RVA = "0x1900410", Offset = "0x1900410", VA = "0x1900410")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003D")]
		public bool IsBlending
		{
			[Token(Token = "0x6000112")]
			[Address(RVA = "0x1900434", Offset = "0x1900434", VA = "0x1900434")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x18FEFF4", Offset = "0x18FEFF4", VA = "0x18FEFF4", Slot = "20")]
		public override bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false)
		{
			return default;
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x18FF07C", Offset = "0x18FF07C", VA = "0x18FF07C", Slot = "35")]
		public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta)
		{
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x18FF344", Offset = "0x18FF344", VA = "0x18FF344", Slot = "28")]
		public override void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime)
		{
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x18FF3E0", Offset = "0x18FF3E0", VA = "0x18FF3E0", Slot = "27")]
		public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime)
		{
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x1900020", Offset = "0x1900020", VA = "0x1900020", Slot = "32")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x190017C", Offset = "0x190017C", VA = "0x190017C", Slot = "33")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x1900268", Offset = "0x1900268", VA = "0x1900268")]
		public void OnTransformChildrenChanged()
		{
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x1900274", Offset = "0x1900274", VA = "0x1900274")]
		private void OnGuiHandler()
		{
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x1900444", Offset = "0x1900444", VA = "0x1900444")]
		public static int CreateFakeHash(int parentHash, AnimationClip clip)
		{
			return default;
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x19004DC", Offset = "0x19004DC", VA = "0x19004DC")]
		private int LookupFakeHash(int parentHash, AnimationClip clip)
		{
			return default;
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x1900170", Offset = "0x1900170", VA = "0x1900170")]
		private void InvalidateListOfChildren()
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x18FF150", Offset = "0x18FF150", VA = "0x18FF150")]
		private void UpdateListOfChildren()
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x19006E8", Offset = "0x19006E8", VA = "0x19006E8")]
		internal void ValidateInstructions()
		{
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x18FF878", Offset = "0x18FF878", VA = "0x18FF878")]
		private CinemachineVirtualCameraBase ChooseCurrentCamera()
		{
			return null;
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x1900974", Offset = "0x1900974", VA = "0x1900974")]
		private int GetClipHash(int hash, List<AnimatorClipInfo> clips)
		{
			return default;
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x18FFD8C", Offset = "0x18FFD8C", VA = "0x18FFD8C")]
		private CinemachineBlendDefinition LookupBlend(ICinemachineCamera fromKey, ICinemachineCamera toKey)
		{
			return default;
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x1900B10", Offset = "0x1900B10", VA = "0x1900B10")]
		public CinemachineStateDrivenCamera()
		{
		}
	}
}
