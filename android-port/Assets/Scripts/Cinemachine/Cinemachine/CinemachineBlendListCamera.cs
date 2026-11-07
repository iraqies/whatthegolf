using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Cinemachine
{
	[Token(Token = "0x2000009")]
	[DisallowMultipleComponent]
	[ExecuteAlways]
	public class CinemachineBlendListCamera : CinemachineVirtualCameraBase
	{
		[Serializable]
		[Token(Token = "0x200000A")]
		public struct Instruction
		{
			[Token(Token = "0x400001F")]
			[FieldOffset(Offset = "0x0")]
			public CinemachineVirtualCameraBase m_VirtualCamera;

			[Token(Token = "0x4000020")]
			[FieldOffset(Offset = "0x8")]
			public float m_Hold;

			[Token(Token = "0x4000021")]
			[FieldOffset(Offset = "0x10")]
			public CinemachineBlendDefinition m_Blend;
		}

		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x60")]
		public Transform m_LookAt;

		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x68")]
		public Transform m_Follow;

		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x70")]
		public bool m_ShowDebugText;

		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x71")]
		public bool m_Loop;

		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		internal CinemachineVirtualCameraBase[] m_ChildCameras;

		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x80")]
		public Instruction[] m_Instructions;

		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x78244", Offset = "0x78244")]
		private ICinemachineCamera LiveChild__BackingField;

		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x78254", Offset = "0x78254")]
		private ICinemachineCamera TransitioningFrom__BackingField;

		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x98")]
		private CameraState m_State;

		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x178")]
		private float mActivationTime;

		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x17C")]
		private int mCurrentInstruction;

		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x180")]
		private CinemachineBlend mActiveBlend;

		[Token(Token = "0x17000002")]
		public override string Description
		{
			[Token(Token = "0x6000012")]
			[Address(RVA = "0x18E1FE0", Offset = "0x18E1FE0", VA = "0x18E1FE0", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000003")]
		public ICinemachineCamera LiveChild
		{
			[Token(Token = "0x6000014")]
			[Address(RVA = "0x18E2150", Offset = "0x18E2150", VA = "0x18E2150")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79408", Offset = "0x79408")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000013")]
			[Address(RVA = "0x18E2148", Offset = "0x18E2148", VA = "0x18E2148")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x793F8", Offset = "0x793F8")]
			set
			{
			}
		}

		[Token(Token = "0x17000004")]
		public override CameraState State
		{
			[Token(Token = "0x6000016")]
			[Address(RVA = "0x18E2178", Offset = "0x18E2178", VA = "0x18E2178", Slot = "19")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000005")]
		public override Transform LookAt
		{
			[Token(Token = "0x6000017")]
			[Address(RVA = "0x18E21C8", Offset = "0x18E21C8", VA = "0x18E21C8", Slot = "21")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000018")]
			[Address(RVA = "0x18E21D4", Offset = "0x18E21D4", VA = "0x18E21D4", Slot = "22")]
			set
			{
			}
		}

		[Token(Token = "0x17000006")]
		public override Transform Follow
		{
			[Token(Token = "0x6000019")]
			[Address(RVA = "0x18E21DC", Offset = "0x18E21DC", VA = "0x18E21DC", Slot = "23")]
			get
			{
				return null;
			}
			[Token(Token = "0x600001A")]
			[Address(RVA = "0x18E21E8", Offset = "0x18E21E8", VA = "0x18E21E8", Slot = "24")]
			set
			{
			}
		}

		[Token(Token = "0x17000007")]
		private ICinemachineCamera TransitioningFrom
		{
			[Token(Token = "0x600001D")]
			[Address(RVA = "0x18E2548", Offset = "0x18E2548", VA = "0x18E2548")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79418", Offset = "0x79418")]
			get
			{
				return null;
			}
			[Token(Token = "0x600001E")]
			[Address(RVA = "0x18E2550", Offset = "0x18E2550", VA = "0x18E2550")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79428", Offset = "0x79428")]
			set
			{
			}
		}

		[Token(Token = "0x17000008")]
		public CinemachineVirtualCameraBase[] ChildCameras
		{
			[Token(Token = "0x6000024")]
			[Address(RVA = "0x18E3738", Offset = "0x18E3738", VA = "0x18E3738")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000009")]
		public bool IsBlending
		{
			[Token(Token = "0x6000025")]
			[Address(RVA = "0x18E375C", Offset = "0x18E375C", VA = "0x18E375C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x18E2158", Offset = "0x18E2158", VA = "0x18E2158", Slot = "20")]
		public override bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false)
		{
			return default;
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x18E21F0", Offset = "0x18E21F0", VA = "0x18E21F0", Slot = "35")]
		public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta)
		{
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x18E24A8", Offset = "0x18E24A8", VA = "0x18E24A8", Slot = "28")]
		public override void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime)
		{
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x18E2558", Offset = "0x18E2558", VA = "0x18E2558", Slot = "27")]
		public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime)
		{
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x18E2FA0", Offset = "0x18E2FA0", VA = "0x18E2FA0", Slot = "32")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x18E30FC", Offset = "0x18E30FC", VA = "0x18E30FC", Slot = "33")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x18E31E8", Offset = "0x18E31E8", VA = "0x18E31E8")]
		private void OnTransformChildrenChanged()
		{
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x18E31F4", Offset = "0x18E31F4", VA = "0x18E31F4")]
		private void OnGuiHandler()
		{
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x18E30F0", Offset = "0x18E30F0", VA = "0x18E30F0")]
		private void InvalidateListOfChildren()
		{
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x18E22C4", Offset = "0x18E22C4", VA = "0x18E22C4")]
		private void UpdateListOfChildren()
		{
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x18E376C", Offset = "0x18E376C", VA = "0x18E376C")]
		internal void ValidateInstructions()
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x18E2A4C", Offset = "0x18E2A4C", VA = "0x18E2A4C")]
		private void AdvanceCurrentInstruction(float deltaTime)
		{
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x18E390C", Offset = "0x18E390C", VA = "0x18E390C")]
		public CinemachineBlendListCamera()
		{
		}
	}
}
