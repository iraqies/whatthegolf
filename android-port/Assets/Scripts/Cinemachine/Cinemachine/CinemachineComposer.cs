using Cinemachine.Utility;
using Il2CppDummyDll;
using UnityEngine;

namespace Cinemachine
{
	[Token(Token = "0x200003D")]
	public class CinemachineComposer : CinemachineComponentBase
	{
		[Token(Token = "0x200003E")]
		private struct FovCache
		{
			[Token(Token = "0x4000148")]
			[FieldOffset(Offset = "0x0")]
			public Rect mFovSoftGuideRect;

			[Token(Token = "0x4000149")]
			[FieldOffset(Offset = "0x10")]
			public Rect mFovHardGuideRect;

			[Token(Token = "0x400014A")]
			[FieldOffset(Offset = "0x20")]
			public float mFovH;

			[Token(Token = "0x400014B")]
			[FieldOffset(Offset = "0x24")]
			public float mFov;

			[Token(Token = "0x400014C")]
			[FieldOffset(Offset = "0x28")]
			private float mOrthoSizeOverDistance;

			[Token(Token = "0x400014D")]
			[FieldOffset(Offset = "0x2C")]
			private float mAspect;

			[Token(Token = "0x400014E")]
			[FieldOffset(Offset = "0x30")]
			private Rect mSoftGuideRect;

			[Token(Token = "0x400014F")]
			[FieldOffset(Offset = "0x40")]
			private Rect mHardGuideRect;

			[Token(Token = "0x600017E")]
			[Address(RVA = "0x190ECCC", Offset = "0x190ECCC", VA = "0x190ECCC")]
			public void UpdateCache(LensSettings lens, Rect softGuide, Rect hardGuide, float targetDistance)
			{
			}

			[Token(Token = "0x600017F")]
			[Address(RVA = "0x190EF8C", Offset = "0x190EF8C", VA = "0x190EF8C")]
			private Rect ScreenToFOV(Rect rScreen, float fov, float fovH, float aspect)
			{
				return default;
			}
		}

		[Token(Token = "0x4000132")]
		[FieldOffset(Offset = "0x50")]
		public Vector3 m_TrackedObjectOffset;

		[Token(Token = "0x4000133")]
		[FieldOffset(Offset = "0x5C")]
		[Attribute(Name = "RangeAttribute", RVA = "0x78830", Offset = "0x78830")]
		public float m_LookaheadTime;

		[Token(Token = "0x4000134")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "RangeAttribute", RVA = "0x78848", Offset = "0x78848")]
		public float m_LookaheadSmoothing;

		[Token(Token = "0x4000135")]
		[FieldOffset(Offset = "0x64")]
		public bool m_LookaheadIgnoreY;

		[Token(Token = "0x4000136")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "RangeAttribute", RVA = "0x78860", Offset = "0x78860")]
		public float m_HorizontalDamping;

		[Token(Token = "0x4000137")]
		[FieldOffset(Offset = "0x6C")]
		[Attribute(Name = "RangeAttribute", RVA = "0x78878", Offset = "0x78878")]
		public float m_VerticalDamping;

		[Token(Token = "0x4000138")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "RangeAttribute", RVA = "0x78890", Offset = "0x78890")]
		public float m_ScreenX;

		[Token(Token = "0x4000139")]
		[FieldOffset(Offset = "0x74")]
		[Attribute(Name = "RangeAttribute", RVA = "0x788A8", Offset = "0x788A8")]
		public float m_ScreenY;

		[Token(Token = "0x400013A")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "RangeAttribute", RVA = "0x788C0", Offset = "0x788C0")]
		public float m_DeadZoneWidth;

		[Token(Token = "0x400013B")]
		[FieldOffset(Offset = "0x7C")]
		[Attribute(Name = "RangeAttribute", RVA = "0x788D8", Offset = "0x788D8")]
		public float m_DeadZoneHeight;

		[Token(Token = "0x400013C")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "RangeAttribute", RVA = "0x788F0", Offset = "0x788F0")]
		public float m_SoftZoneWidth;

		[Token(Token = "0x400013D")]
		[FieldOffset(Offset = "0x84")]
		[Attribute(Name = "RangeAttribute", RVA = "0x78908", Offset = "0x78908")]
		public float m_SoftZoneHeight;

		[Token(Token = "0x400013E")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "RangeAttribute", RVA = "0x78920", Offset = "0x78920")]
		public float m_BiasX;

		[Token(Token = "0x400013F")]
		[FieldOffset(Offset = "0x8C")]
		[Attribute(Name = "RangeAttribute", RVA = "0x78938", Offset = "0x78938")]
		public float m_BiasY;

		[Token(Token = "0x4000140")]
		[FieldOffset(Offset = "0x90")]
		public bool m_CenterOnActivate;

		[Token(Token = "0x4000141")]
		[FieldOffset(Offset = "0x94")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x78950", Offset = "0x78950")]
		private Vector3 TrackedPoint__BackingField;

		[Token(Token = "0x4000142")]
		[FieldOffset(Offset = "0xA0")]
		private Vector3 m_CameraPosPrevFrame;

		[Token(Token = "0x4000143")]
		[FieldOffset(Offset = "0xAC")]
		private Vector3 m_LookAtPrevFrame;

		[Token(Token = "0x4000144")]
		[FieldOffset(Offset = "0xB8")]
		private Vector2 m_ScreenOffsetPrevFrame;

		[Token(Token = "0x4000145")]
		[FieldOffset(Offset = "0xC0")]
		private Quaternion m_CameraOrientationPrevFrame;

		[Token(Token = "0x4000146")]
		[FieldOffset(Offset = "0xD0")]
		internal PositionPredictor m_Predictor;

		[Token(Token = "0x4000147")]
		[FieldOffset(Offset = "0xD8")]
		private FovCache mCache;

		[Token(Token = "0x1700004A")]
		public override bool IsValid
		{
			[Token(Token = "0x600016F")]
			[Address(RVA = "0x18ED8CC", Offset = "0x18ED8CC", VA = "0x18ED8CC", Slot = "4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700004B")]
		public override CinemachineCore.Stage Stage
		{
			[Token(Token = "0x6000170")]
			[Address(RVA = "0x18ED960", Offset = "0x18ED960", VA = "0x18ED960", Slot = "6")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700004C")]
		public Vector3 TrackedPoint
		{
			[Token(Token = "0x6000171")]
			[Address(RVA = "0x18ED968", Offset = "0x18ED968", VA = "0x18ED968")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x79618", Offset = "0x79618")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000172")]
			[Address(RVA = "0x18ED974", Offset = "0x18ED974", VA = "0x18ED974")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x79628", Offset = "0x79628")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004D")]
		internal Rect SoftGuideRect
		{
			[Token(Token = "0x6000177")]
			[Address(RVA = "0x18EE2B4", Offset = "0x18EE2B4", VA = "0x18EE2B4")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000178")]
			[Address(RVA = "0x18EE58C", Offset = "0x18EE58C", VA = "0x18EE58C")]
			set
			{
			}
		}

		[Token(Token = "0x1700004E")]
		internal Rect HardGuideRect
		{
			[Token(Token = "0x6000179")]
			[Address(RVA = "0x18EE300", Offset = "0x18EE300", VA = "0x18EE300")]
			get
			{
				return default;
			}
			[Token(Token = "0x600017A")]
			[Address(RVA = "0x18EE684", Offset = "0x18EE684", VA = "0x18EE684")]
			set
			{
			}
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x18ED980", Offset = "0x18ED980", VA = "0x18ED980", Slot = "10")]
		protected virtual Vector3 GetLookAtPointAndSetTrackedPoint(Vector3 lookAt, Vector3 up, float deltaTime)
		{
			return default;
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x18EDB44", Offset = "0x18EDB44", VA = "0x18EDB44", Slot = "9")]
		public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta)
		{
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x18EDC4C", Offset = "0x18EDC4C", VA = "0x18EDC4C", Slot = "5")]
		public override void PrePipelineMutateCameraState(ref CameraState curState, float deltaTime)
		{
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x18EDCD0", Offset = "0x18EDCD0", VA = "0x18EDCD0", Slot = "7")]
		public override void MutateCameraState(ref CameraState curState, float deltaTime)
		{
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x18EE394", Offset = "0x18EE394", VA = "0x18EE394")]
		private void RotateToScreenBounds(ref CameraState state, Rect screenRect, Vector3 trackedPoint, ref Quaternion rigOrientation, float fov, float fovH, float deltaTime)
		{
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x18EE814", Offset = "0x18EE814", VA = "0x18EE814")]
		private bool ClampVerticalBounds(ref Rect r, Vector3 dir, Vector3 up, float fov)
		{
			return default;
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x18EE94C", Offset = "0x18EE94C", VA = "0x18EE94C")]
		public CinemachineComposer()
		{
		}
	}
}
