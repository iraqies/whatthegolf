using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Cinemachine
{
	[Token(Token = "0x2000038")]
	[DisallowMultipleComponent]
	[ExecuteAlways]
	public class CinemachineVirtualCamera : CinemachineVirtualCameraBase
	{
		[Token(Token = "0x2000039")]
		public delegate Transform CreatePipelineDelegate(CinemachineVirtualCamera vcam, string name, CinemachineComponentBase[] copyFrom);

		[Token(Token = "0x200003A")]
		public delegate void DestroyPipelineDelegate(GameObject pipeline);

		[Serializable]
		[Token(Token = "0x200003B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x781D4", Offset = "0x781D4")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4000129")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x400012A")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<CinemachineComponentBase> _003C_003E9__40_0;

			[Token(Token = "0x6000167")]
			[Address(RVA = "0x1911AD4", Offset = "0x1911AD4", VA = "0x1911AD4")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6000168")]
			[Address(RVA = "0x1911ADC", Offset = "0x1911ADC", VA = "0x1911ADC")]
			internal int _003CUpdateComponentPipeline_003Eb__40_0(CinemachineComponentBase c1, CinemachineComponentBase c2)
			{
				return default;
			}
		}

		[Token(Token = "0x400011B")]
		[FieldOffset(Offset = "0x60")]
		public Transform m_LookAt;

		[Token(Token = "0x400011C")]
		[FieldOffset(Offset = "0x68")]
		public Transform m_Follow;

		[Token(Token = "0x400011D")]
		[FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x78720", Offset = "0x78720")]
		public LensSettings m_Lens;

		[Token(Token = "0x400011E")]
		[FieldOffset(Offset = "0xA0")]
		public TransitionParams m_Transitions;

		[Token(Token = "0x400011F")]
		[FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x78758", Offset = "0x78758")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x78758", Offset = "0x78758")]
		[SerializeField]
		private BlendHint m_LegacyBlendHint;

		[Token(Token = "0x4000120")]
		public const string PipelineName = "cm";

		[Token(Token = "0x4000121")]
		[FieldOffset(Offset = "0x0")]
		public static CreatePipelineDelegate CreatePipelineOverride;

		[Token(Token = "0x4000122")]
		[FieldOffset(Offset = "0x8")]
		public static DestroyPipelineDelegate DestroyPipelineOverride;

		[Token(Token = "0x4000123")]
		[FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x787C8", Offset = "0x787C8")]
		private bool UserIsDragging__BackingField;

		[Token(Token = "0x4000124")]
		[FieldOffset(Offset = "0xB8")]
		private CameraState m_State;

		[Token(Token = "0x4000125")]
		[FieldOffset(Offset = "0x198")]
		private CinemachineComponentBase[] m_ComponentPipeline;

		[Token(Token = "0x4000126")]
		[FieldOffset(Offset = "0x1A0")]
		[SerializeField]
		private Transform m_ComponentOwner;

		[Token(Token = "0x4000127")]
		[FieldOffset(Offset = "0x1A8")]
		private Transform mCachedLookAtTarget;

		[Token(Token = "0x4000128")]
		[FieldOffset(Offset = "0x1B0")]
		private CinemachineVirtualCameraBase mCachedLookAtTargetVcam;

		[Token(Token = "0x17000044")]
		public override CameraState State
		{
			[Token(Token = "0x6000140")]
			[Address(RVA = "0x19064D4", Offset = "0x19064D4", VA = "0x19064D4", Slot = "19")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000045")]
		public override Transform LookAt
		{
			[Token(Token = "0x6000141")]
			[Address(RVA = "0x1906520", Offset = "0x1906520", VA = "0x1906520", Slot = "21")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000142")]
			[Address(RVA = "0x1906688", Offset = "0x1906688", VA = "0x1906688", Slot = "22")]
			set
			{
			}
		}

		[Token(Token = "0x17000046")]
		public override Transform Follow
		{
			[Token(Token = "0x6000143")]
			[Address(RVA = "0x1906690", Offset = "0x1906690", VA = "0x1906690", Slot = "23")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000144")]
			[Address(RVA = "0x19067F8", Offset = "0x19067F8", VA = "0x19067F8", Slot = "24")]
			set
			{
			}
		}

		[Token(Token = "0x17000047")]
		public bool UserIsDragging
		{
			[Token(Token = "0x6000154")]
			[Address(RVA = "0x1909520", Offset = "0x1909520", VA = "0x1909520")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x795F8", Offset = "0x795F8")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000155")]
			[Address(RVA = "0x1909528", Offset = "0x1909528", VA = "0x1909528")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79608", Offset = "0x79608")]
			set
			{
			}
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x1906800", Offset = "0x1906800", VA = "0x1906800", Slot = "27")]
		public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime)
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x1906F40", Offset = "0x1906F40", VA = "0x1906F40", Slot = "32")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x1907884", Offset = "0x1907884", VA = "0x1907884", Slot = "29")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x1907CE8", Offset = "0x1907CE8", VA = "0x1907CE8", Slot = "31")]
		protected override void OnValidate()
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x1907EFC", Offset = "0x1907EFC", VA = "0x1907EFC")]
		private void OnTransformChildrenChanged()
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x1907F04", Offset = "0x1907F04", VA = "0x1907F04")]
		private void Reset()
		{
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x1907F08", Offset = "0x1907F08", VA = "0x1907F08")]
		private void DestroyPipeline()
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x1908824", Offset = "0x1908824", VA = "0x1908824")]
		private Transform CreatePipeline(CinemachineVirtualCamera copyFrom)
		{
			return null;
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x1907764", Offset = "0x1907764", VA = "0x1907764")]
		public void InvalidateComponentPipeline()
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x1908DB0", Offset = "0x1908DB0", VA = "0x1908DB0")]
		public Transform GetComponentOwner()
		{
			return null;
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x19089B0", Offset = "0x19089B0", VA = "0x19089B0")]
		public CinemachineComponentBase[] GetComponentPipeline()
		{
			return null;
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x19077E4", Offset = "0x19077E4", VA = "0x19077E4")]
		public CinemachineComponentBase GetCinemachineComponent(CinemachineCore.Stage stage)
		{
			return null;
		}

		[Token(Token = "0x6000151")]
		public T GetCinemachineComponent<T>() where T : CinemachineComponentBase
		{
			return null;
		}

		[Token(Token = "0x6000152")]
		public T AddCinemachineComponent<T>() where T : CinemachineComponentBase
		{
			return null;
		}

		[Token(Token = "0x6000153")]
		public void DestroyCinemachineComponent<T>() where T : CinemachineComponentBase
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x1908DD4", Offset = "0x1908DD4", VA = "0x1908DD4")]
		private void UpdateComponentPipeline()
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x1909530", Offset = "0x1909530", VA = "0x1909530")]
		internal static void SetFlagsForHiddenChild(GameObject child)
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x1906A54", Offset = "0x1906A54", VA = "0x1906A54")]
		private CameraState CalculateNewState(Vector3 worldUp, float deltaTime)
		{
			return default;
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x1909630", Offset = "0x1909630", VA = "0x1909630")]
		private CinemachineCore.Stage AdvancePipelineStage(ref CameraState state, float deltaTime, CinemachineCore.Stage curStage, int maxStage, bool hasAim)
		{
			return default;
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x19098C8", Offset = "0x19098C8", VA = "0x19098C8")]
		internal void SetStateRawPosition(Vector3 pos)
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x19098D4", Offset = "0x19098D4", VA = "0x19098D4", Slot = "35")]
		public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta)
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x1909B24", Offset = "0x1909B24", VA = "0x1909B24", Slot = "28")]
		public override void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime)
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x190A104", Offset = "0x190A104", VA = "0x190A104")]
		public CinemachineVirtualCamera()
		{
		}
	}
}
