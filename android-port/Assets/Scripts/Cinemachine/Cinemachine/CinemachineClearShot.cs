using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Cinemachine
{
	[Token(Token = "0x2000012")]
	[ExecuteAlways]
	[DisallowMultipleComponent]
	public class CinemachineClearShot : CinemachineVirtualCameraBase
	{
		[Token(Token = "0x2000013")]
		private struct Pair
		{
			[Token(Token = "0x4000057")]
			[FieldOffset(Offset = "0x0")]
			public int a;

			[Token(Token = "0x4000058")]
			[FieldOffset(Offset = "0x4")]
			public float b;
		}

		[Serializable]
		[Token(Token = "0x2000014")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77FFC", Offset = "0x77FFC")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4000059")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x400005A")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<Pair> _003C_003E9__46_0;

			[Token(Token = "0x6000070")]
			[Address(RVA = "0x190EB74", Offset = "0x190EB74", VA = "0x190EB74")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6000071")]
			[Address(RVA = "0x190EB7C", Offset = "0x190EB7C", VA = "0x190EB7C")]
			internal int _003CRandomize_003Eb__46_0(Pair p1, Pair p2)
			{
				return default;
			}
		}

		[Token(Token = "0x4000045")]
		[FieldOffset(Offset = "0x60")]
		public Transform m_LookAt;

		[Token(Token = "0x4000046")]
		[FieldOffset(Offset = "0x68")]
		public Transform m_Follow;

		[Token(Token = "0x4000047")]
		[FieldOffset(Offset = "0x70")]
		public bool m_ShowDebugText;

		[Token(Token = "0x4000048")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		internal CinemachineVirtualCameraBase[] m_ChildCameras;

		[Token(Token = "0x4000049")]
		[FieldOffset(Offset = "0x80")]
		public float m_ActivateAfter;

		[Token(Token = "0x400004A")]
		[FieldOffset(Offset = "0x84")]
		public float m_MinDuration;

		[Token(Token = "0x400004B")]
		[FieldOffset(Offset = "0x88")]
		public bool m_RandomizeChoice;

		[Token(Token = "0x400004C")]
		[FieldOffset(Offset = "0x90")]
		public CinemachineBlendDefinition m_DefaultBlend;

		[Token(Token = "0x400004D")]
		[FieldOffset(Offset = "0xA0")]
		public CinemachineBlenderSettings m_CustomBlends;

		[Token(Token = "0x400004E")]
		[FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x78284", Offset = "0x78284")]
		private ICinemachineCamera LiveChild__BackingField;

		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0xB0")]
		private CameraState m_State;

		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0x190")]
		private float mActivationTime;

		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0x194")]
		private float mPendingActivationTime;

		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0x198")]
		private ICinemachineCamera mPendingCamera;

		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0x1A0")]
		private CinemachineBlend mActiveBlend;

		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0x1A8")]
		private bool mRandomizeNow;

		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0x1B0")]
		private CinemachineVirtualCameraBase[] m_RandomizedChilden;

		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0x1B8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x78294", Offset = "0x78294")]
		private ICinemachineCamera TransitioningFrom__BackingField;

		[Token(Token = "0x17000015")]
		public override string Description
		{
			[Token(Token = "0x6000054")]
			[Address(RVA = "0x18E7664", Offset = "0x18E7664", VA = "0x18E7664", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000016")]
		public ICinemachineCamera LiveChild
		{
			[Token(Token = "0x6000056")]
			[Address(RVA = "0x18E77D4", Offset = "0x18E77D4", VA = "0x18E77D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x794B8", Offset = "0x794B8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000055")]
			[Address(RVA = "0x18E77CC", Offset = "0x18E77CC", VA = "0x18E77CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x794A8", Offset = "0x794A8")]
			set
			{
			}
		}

		[Token(Token = "0x17000017")]
		public override CameraState State
		{
			[Token(Token = "0x6000057")]
			[Address(RVA = "0x18E77DC", Offset = "0x18E77DC", VA = "0x18E77DC", Slot = "19")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000018")]
		public override Transform LookAt
		{
			[Token(Token = "0x6000059")]
			[Address(RVA = "0x18E7838", Offset = "0x18E7838", VA = "0x18E7838", Slot = "21")]
			get
			{
				return null;
			}
			[Token(Token = "0x600005A")]
			[Address(RVA = "0x18E7844", Offset = "0x18E7844", VA = "0x18E7844", Slot = "22")]
			set
			{
			}
		}

		[Token(Token = "0x17000019")]
		public override Transform Follow
		{
			[Token(Token = "0x600005B")]
			[Address(RVA = "0x18E784C", Offset = "0x18E784C", VA = "0x18E784C", Slot = "23")]
			get
			{
				return null;
			}
			[Token(Token = "0x600005C")]
			[Address(RVA = "0x18E7858", Offset = "0x18E7858", VA = "0x18E7858", Slot = "24")]
			set
			{
			}
		}

		[Token(Token = "0x1700001A")]
		public bool IsBlending
		{
			[Token(Token = "0x6000063")]
			[Address(RVA = "0x18E8B68", Offset = "0x18E8B68", VA = "0x18E8B68")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700001B")]
		public CinemachineVirtualCameraBase[] ChildCameras
		{
			[Token(Token = "0x6000064")]
			[Address(RVA = "0x18E8B78", Offset = "0x18E8B78", VA = "0x18E8B78")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001C")]
		private ICinemachineCamera TransitioningFrom
		{
			[Token(Token = "0x600006C")]
			[Address(RVA = "0x18E8F28", Offset = "0x18E8F28", VA = "0x18E8F28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x794C8", Offset = "0x794C8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600006D")]
			[Address(RVA = "0x18E8F30", Offset = "0x18E8F30", VA = "0x18E8F30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x794D8", Offset = "0x794D8")]
			set
			{
			}
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x18E7818", Offset = "0x18E7818", VA = "0x18E7818", Slot = "20")]
		public override bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false)
		{
			return default;
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x18E7860", Offset = "0x18E7860", VA = "0x18E7860", Slot = "35")]
		public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta)
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x18E7B04", Offset = "0x18E7B04", VA = "0x18E7B04", Slot = "27")]
		public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime)
		{
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x18E877C", Offset = "0x18E877C", VA = "0x18E877C", Slot = "32")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x18E88E0", Offset = "0x18E88E0", VA = "0x18E88E0", Slot = "33")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x18E89CC", Offset = "0x18E89CC", VA = "0x18E89CC")]
		public void OnTransformChildrenChanged()
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x18E89DC", Offset = "0x18E89DC", VA = "0x18E89DC")]
		private void OnGuiHandler()
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x18E88D0", Offset = "0x18E88D0", VA = "0x18E88D0")]
		private void InvalidateListOfChildren()
		{
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x18E8B9C", Offset = "0x18E8B9C", VA = "0x18E8B9C")]
		public void ResetRandomization()
		{
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x18E7934", Offset = "0x18E7934", VA = "0x18E7934")]
		private void UpdateListOfChildren()
		{
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x18E7EEC", Offset = "0x18E7EEC", VA = "0x18E7EEC")]
		private ICinemachineCamera ChooseCurrentCamera(Vector3 worldUp)
		{
			return null;
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x18E8BAC", Offset = "0x18E8BAC", VA = "0x18E8BAC")]
		private CinemachineVirtualCameraBase[] Randomize(CinemachineVirtualCameraBase[] src)
		{
			return null;
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x18E84EC", Offset = "0x18E84EC", VA = "0x18E84EC")]
		private CinemachineBlendDefinition LookupBlend(ICinemachineCamera fromKey, ICinemachineCamera toKey)
		{
			return default;
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x18E8E80", Offset = "0x18E8E80", VA = "0x18E8E80", Slot = "28")]
		public override void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime)
		{
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x18E8F38", Offset = "0x18E8F38", VA = "0x18E8F38")]
		public CinemachineClearShot()
		{
		}
	}
}
