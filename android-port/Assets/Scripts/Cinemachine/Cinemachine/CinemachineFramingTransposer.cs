using Cinemachine.Utility;
using Il2CppDummyDll;
using UnityEngine;

namespace Cinemachine
{
	[Token(Token = "0x200003F")]
	public class CinemachineFramingTransposer : CinemachineComponentBase
	{
		[Token(Token = "0x2000040")]
		public enum FramingMode
		{
			[Token(Token = "0x4000176")]
			Horizontal = 0,
			[Token(Token = "0x4000177")]
			Vertical = 1,
			[Token(Token = "0x4000178")]
			HorizontalAndVertical = 2,
			[Token(Token = "0x4000179")]
			None = 3
		}

		[Token(Token = "0x2000041")]
		public enum AdjustmentMode
		{
			[Token(Token = "0x400017B")]
			ZoomOnly = 0,
			[Token(Token = "0x400017C")]
			DollyOnly = 1,
			[Token(Token = "0x400017D")]
			DollyThenZoom = 2
		}

		[Token(Token = "0x4000150")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "RangeAttribute", RVA = "0x78960", Offset = "0x78960")]
		public float m_LookaheadTime;

		[Token(Token = "0x4000151")]
		[FieldOffset(Offset = "0x54")]
		[Attribute(Name = "RangeAttribute", RVA = "0x78978", Offset = "0x78978")]
		public float m_LookaheadSmoothing;

		[Token(Token = "0x4000152")]
		[FieldOffset(Offset = "0x58")]
		public bool m_LookaheadIgnoreY;

		[Token(Token = "0x4000153")]
		[FieldOffset(Offset = "0x5C")]
		[Attribute(Name = "RangeAttribute", RVA = "0x78990", Offset = "0x78990")]
		public float m_XDamping;

		[Token(Token = "0x4000154")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "RangeAttribute", RVA = "0x789A8", Offset = "0x789A8")]
		public float m_YDamping;

		[Token(Token = "0x4000155")]
		[FieldOffset(Offset = "0x64")]
		[Attribute(Name = "RangeAttribute", RVA = "0x789C0", Offset = "0x789C0")]
		public float m_ZDamping;

		[Token(Token = "0x4000156")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "RangeAttribute", RVA = "0x789D8", Offset = "0x789D8")]
		public float m_ScreenX;

		[Token(Token = "0x4000157")]
		[FieldOffset(Offset = "0x6C")]
		[Attribute(Name = "RangeAttribute", RVA = "0x789F0", Offset = "0x789F0")]
		public float m_ScreenY;

		[Token(Token = "0x4000158")]
		[FieldOffset(Offset = "0x70")]
		public float m_CameraDistance;

		[Token(Token = "0x4000159")]
		[FieldOffset(Offset = "0x74")]
		[Attribute(Name = "RangeAttribute", RVA = "0x78A08", Offset = "0x78A08")]
		public float m_DeadZoneWidth;

		[Token(Token = "0x400015A")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "RangeAttribute", RVA = "0x78A20", Offset = "0x78A20")]
		public float m_DeadZoneHeight;

		[Token(Token = "0x400015B")]
		[FieldOffset(Offset = "0x7C")]
		[Attribute(Name = "FormerlySerializedAsAttribute", RVA = "0x78A38", Offset = "0x78A38")]
		public float m_DeadZoneDepth;

		[Token(Token = "0x400015C")]
		[FieldOffset(Offset = "0x80")]
		public bool m_UnlimitedSoftZone;

		[Token(Token = "0x400015D")]
		[FieldOffset(Offset = "0x84")]
		[Attribute(Name = "RangeAttribute", RVA = "0x78A70", Offset = "0x78A70")]
		public float m_SoftZoneWidth;

		[Token(Token = "0x400015E")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "RangeAttribute", RVA = "0x78A88", Offset = "0x78A88")]
		public float m_SoftZoneHeight;

		[Token(Token = "0x400015F")]
		[FieldOffset(Offset = "0x8C")]
		[Attribute(Name = "RangeAttribute", RVA = "0x78AA0", Offset = "0x78AA0")]
		public float m_BiasX;

		[Token(Token = "0x4000160")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "RangeAttribute", RVA = "0x78AB8", Offset = "0x78AB8")]
		public float m_BiasY;

		[Token(Token = "0x4000161")]
		[FieldOffset(Offset = "0x94")]
		public bool m_CenterOnActivate;

		[Token(Token = "0x4000162")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "FormerlySerializedAsAttribute", RVA = "0x78AD0", Offset = "0x78AD0")]
		public FramingMode m_GroupFramingMode;

		[Token(Token = "0x4000163")]
		[FieldOffset(Offset = "0x9C")]
		public AdjustmentMode m_AdjustmentMode;

		[Token(Token = "0x4000164")]
		[FieldOffset(Offset = "0xA0")]
		public float m_GroupFramingSize;

		[Token(Token = "0x4000165")]
		[FieldOffset(Offset = "0xA4")]
		public float m_MaxDollyIn;

		[Token(Token = "0x4000166")]
		[FieldOffset(Offset = "0xA8")]
		public float m_MaxDollyOut;

		[Token(Token = "0x4000167")]
		[FieldOffset(Offset = "0xAC")]
		public float m_MinimumDistance;

		[Token(Token = "0x4000168")]
		[FieldOffset(Offset = "0xB0")]
		public float m_MaximumDistance;

		[Token(Token = "0x4000169")]
		[FieldOffset(Offset = "0xB4")]
		[Attribute(Name = "RangeAttribute", RVA = "0x78B08", Offset = "0x78B08")]
		public float m_MinimumFOV;

		[Token(Token = "0x400016A")]
		[FieldOffset(Offset = "0xB8")]
		[Attribute(Name = "RangeAttribute", RVA = "0x78B24", Offset = "0x78B24")]
		public float m_MaximumFOV;

		[Token(Token = "0x400016B")]
		[FieldOffset(Offset = "0xBC")]
		public float m_MinimumOrthoSize;

		[Token(Token = "0x400016C")]
		[FieldOffset(Offset = "0xC0")]
		public float m_MaximumOrthoSize;

		[Token(Token = "0x400016D")]
		private const float kMinimumCameraDistance = 0.01f;

		[Token(Token = "0x400016E")]
		[FieldOffset(Offset = "0xC4")]
		private Vector3 m_PreviousCameraPosition;

		[Token(Token = "0x400016F")]
		[FieldOffset(Offset = "0xD0")]
		private PositionPredictor m_Predictor;

		[Token(Token = "0x4000170")]
		[FieldOffset(Offset = "0xD8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x78B40", Offset = "0x78B40")]
		private Vector3 TrackedPoint__BackingField;

		[Token(Token = "0x4000171")]
		[FieldOffset(Offset = "0xE4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x78B50", Offset = "0x78B50")]
		private bool InheritingPosition__BackingField;

		[Token(Token = "0x4000172")]
		[FieldOffset(Offset = "0xE8")]
		private float m_prevFOV;

		[Token(Token = "0x4000173")]
		[FieldOffset(Offset = "0xEC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x78B60", Offset = "0x78B60")]
		private Bounds LastBounds__BackingField;

		[Token(Token = "0x4000174")]
		[FieldOffset(Offset = "0x104")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x78B70", Offset = "0x78B70")]
		private Matrix4x4 LastBoundsMatrix__BackingField;

		[Token(Token = "0x1700004F")]
		internal Rect SoftGuideRect
		{
			[Token(Token = "0x6000180")]
			[Address(RVA = "0x18F188C", Offset = "0x18F188C", VA = "0x18F188C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000181")]
			[Address(RVA = "0x18F18D8", Offset = "0x18F18D8", VA = "0x18F18D8")]
			set
			{
			}
		}

		[Token(Token = "0x17000050")]
		internal Rect HardGuideRect
		{
			[Token(Token = "0x6000182")]
			[Address(RVA = "0x18F19D0", Offset = "0x18F19D0", VA = "0x18F19D0")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000183")]
			[Address(RVA = "0x18F1A64", Offset = "0x18F1A64", VA = "0x18F1A64")]
			set
			{
			}
		}

		[Token(Token = "0x17000051")]
		public override bool IsValid
		{
			[Token(Token = "0x6000185")]
			[Address(RVA = "0x18F1D08", Offset = "0x18F1D08", VA = "0x18F1D08", Slot = "4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000052")]
		public override CinemachineCore.Stage Stage
		{
			[Token(Token = "0x6000186")]
			[Address(RVA = "0x18F1DA0", Offset = "0x18F1DA0", VA = "0x18F1DA0", Slot = "6")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000053")]
		public Vector3 TrackedPoint
		{
			[Token(Token = "0x6000187")]
			[Address(RVA = "0x18F1DA8", Offset = "0x18F1DA8", VA = "0x18F1DA8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x79638", Offset = "0x79638")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000188")]
			[Address(RVA = "0x18F1DB4", Offset = "0x18F1DB4", VA = "0x18F1DB4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x79648", Offset = "0x79648")]
			private set
			{
			}
		}

		[Token(Token = "0x17000054")]
		private bool InheritingPosition
		{
			[Token(Token = "0x600018B")]
			[Address(RVA = "0x18F1FF4", Offset = "0x18F1FF4", VA = "0x18F1FF4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x79658", Offset = "0x79658")]
			get
			{
				return default;
			}
			[Token(Token = "0x600018C")]
			[Address(RVA = "0x18F1FFC", Offset = "0x18F1FFC", VA = "0x18F1FFC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x79668", Offset = "0x79668")]
			set
			{
			}
		}

		[Token(Token = "0x17000055")]
		public Bounds LastBounds
		{
			[Token(Token = "0x600018F")]
			[Address(RVA = "0x18F21E0", Offset = "0x18F21E0", VA = "0x18F21E0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x79678", Offset = "0x79678")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000190")]
			[Address(RVA = "0x18F21F4", Offset = "0x18F21F4", VA = "0x18F21F4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x79688", Offset = "0x79688")]
			private set
			{
			}
		}

		[Token(Token = "0x17000056")]
		public Matrix4x4 LastBoundsMatrix
		{
			[Token(Token = "0x6000191")]
			[Address(RVA = "0x18F2208", Offset = "0x18F2208", VA = "0x18F2208")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x79698", Offset = "0x79698")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000192")]
			[Address(RVA = "0x18F2220", Offset = "0x18F2220", VA = "0x18F2220")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x796A8", Offset = "0x796A8")]
			private set
			{
			}
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x18F1BF4", Offset = "0x18F1BF4", VA = "0x18F1BF4")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x18F1DC0", Offset = "0x18F1DC0", VA = "0x18F1DC0", Slot = "9")]
		public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta)
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x18F1ED4", Offset = "0x18F1ED4", VA = "0x18F1ED4", Slot = "8")]
		public override bool OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime, ref CinemachineVirtualCameraBase.TransitionParams transitionParams)
		{
			return default;
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x18F2004", Offset = "0x18F2004", VA = "0x18F2004")]
		private Rect ScreenToOrtho(Rect rScreen, float orthoSize, float aspect)
		{
			return default;
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x18F20E0", Offset = "0x18F20E0", VA = "0x18F20E0")]
		private Vector3 OrthoOffsetToScreenBounds(Vector3 targetPos2D, Rect screenRect)
		{
			return default;
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x18F2238", Offset = "0x18F2238", VA = "0x18F2238", Slot = "7")]
		public override void MutateCameraState(ref CameraState curState, float deltaTime)
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x18F3098", Offset = "0x18F3098", VA = "0x18F3098")]
		private float GetTargetHeight(Vector2 boundsSize)
		{
			return default;
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x18F2D2C", Offset = "0x18F2D2C", VA = "0x18F2D2C")]
		private Vector3 ComputeGroupBounds(ICinemachineTargetGroup group, ref CameraState curState)
		{
			return default;
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x18F3184", Offset = "0x18F3184", VA = "0x18F3184")]
		private static Bounds GetScreenSpaceGroupBoundingBox(ICinemachineTargetGroup group, ref Vector3 pos, Quaternion orientation)
		{
			return default;
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x18F35A0", Offset = "0x18F35A0", VA = "0x18F35A0")]
		public CinemachineFramingTransposer()
		{
		}
	}
}
