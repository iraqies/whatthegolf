using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Cinemachine
{
	[Token(Token = "0x2000020")]
	[DisallowMultipleComponent]
	[ExecuteAlways]
	public class CinemachineFreeLook : CinemachineVirtualCameraBase
	{
		[Serializable]
		[Token(Token = "0x2000021")]
		public struct Orbit
		{
			[Token(Token = "0x40000B8")]
			[FieldOffset(Offset = "0x0")]
			public float m_Height;

			[Token(Token = "0x40000B9")]
			[FieldOffset(Offset = "0x4")]
			public float m_Radius;

			[Token(Token = "0x60000C4")]
			[Address(RVA = "0x1910830", Offset = "0x1910830", VA = "0x1910830")]
			public Orbit(float h, float r)
			{
			}
		}

		[Token(Token = "0x2000022")]
		public delegate CinemachineVirtualCamera CreateRigDelegate(CinemachineFreeLook vcam, string name, CinemachineVirtualCamera copyFrom);

		[Token(Token = "0x2000023")]
		public delegate void DestroyRigDelegate(GameObject rig);

		[Token(Token = "0x400009A")]
		[FieldOffset(Offset = "0x60")]
		public Transform m_LookAt;

		[Token(Token = "0x400009B")]
		[FieldOffset(Offset = "0x68")]
		public Transform m_Follow;

		[Token(Token = "0x400009C")]
		[FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x784D0", Offset = "0x784D0")]
		public bool m_CommonLens;

		[Token(Token = "0x400009D")]
		[FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x78508", Offset = "0x78508")]
		public LensSettings m_Lens;

		[Token(Token = "0x400009E")]
		[FieldOffset(Offset = "0xA0")]
		public TransitionParams m_Transitions;

		[Token(Token = "0x400009F")]
		[FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x78540", Offset = "0x78540")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x78540", Offset = "0x78540")]
		private BlendHint m_LegacyBlendHint;

		[Token(Token = "0x40000A0")]
		[FieldOffset(Offset = "0xB8")]
		public AxisState m_YAxis;

		[Token(Token = "0x40000A1")]
		[FieldOffset(Offset = "0x110")]
		public AxisState.Recentering m_YAxisRecentering;

		[Token(Token = "0x40000A2")]
		[FieldOffset(Offset = "0x130")]
		public AxisState m_XAxis;

		[Token(Token = "0x40000A3")]
		[FieldOffset(Offset = "0x188")]
		public CinemachineOrbitalTransposer.Heading m_Heading;

		[Token(Token = "0x40000A4")]
		[FieldOffset(Offset = "0x194")]
		public AxisState.Recentering m_RecenterToTargetHeading;

		[Token(Token = "0x40000A5")]
		[FieldOffset(Offset = "0x1B0")]
		public CinemachineTransposer.BindingMode m_BindingMode;

		[Token(Token = "0x40000A6")]
		[FieldOffset(Offset = "0x1B4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x785B0", Offset = "0x785B0")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x785B0", Offset = "0x785B0")]
		public float m_SplineCurvature;

		[Token(Token = "0x40000A7")]
		[FieldOffset(Offset = "0x1B8")]
		public Orbit[] m_Orbits;

		[Token(Token = "0x40000A8")]
		[FieldOffset(Offset = "0x1C0")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x78604", Offset = "0x78604")]
		[SerializeField]
		private float m_LegacyHeadingBias;

		[Token(Token = "0x40000A9")]
		[FieldOffset(Offset = "0x1C4")]
		private bool mUseLegacyRigDefinitions;

		[Token(Token = "0x40000AA")]
		[FieldOffset(Offset = "0x1C5")]
		private bool mIsDestroyed;

		[Token(Token = "0x40000AB")]
		[FieldOffset(Offset = "0x1C8")]
		private CameraState m_State;

		[Token(Token = "0x40000AC")]
		[FieldOffset(Offset = "0x2A8")]
		[SerializeField]
		private CinemachineVirtualCamera[] m_Rigs;

		[Token(Token = "0x40000AD")]
		[FieldOffset(Offset = "0x2B0")]
		private CinemachineOrbitalTransposer[] mOrbitals;

		[Token(Token = "0x40000AE")]
		[FieldOffset(Offset = "0x2B8")]
		private CinemachineBlend mBlendA;

		[Token(Token = "0x40000AF")]
		[FieldOffset(Offset = "0x2C0")]
		private CinemachineBlend mBlendB;

		[Token(Token = "0x40000B0")]
		[FieldOffset(Offset = "0x0")]
		public static CreateRigDelegate CreateRigOverride;

		[Token(Token = "0x40000B1")]
		[FieldOffset(Offset = "0x8")]
		public static DestroyRigDelegate DestroyRigOverride;

		[Token(Token = "0x40000B2")]
		[FieldOffset(Offset = "0x2C8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x78660", Offset = "0x78660")]
		private float CachedXAxisHeading__BackingField;

		[Token(Token = "0x40000B3")]
		[FieldOffset(Offset = "0x2D0")]
		private Orbit[] m_CachedOrbits;

		[Token(Token = "0x40000B4")]
		[FieldOffset(Offset = "0x2D8")]
		private float m_CachedTension;

		[Token(Token = "0x40000B5")]
		[FieldOffset(Offset = "0x2E0")]
		private Vector4[] m_CachedKnots;

		[Token(Token = "0x40000B6")]
		[FieldOffset(Offset = "0x2E8")]
		private Vector4[] m_CachedCtrl1;

		[Token(Token = "0x40000B7")]
		[FieldOffset(Offset = "0x2F0")]
		private Vector4[] m_CachedCtrl2;

		[Token(Token = "0x17000022")]
		public static string[] RigNames
		{
			[Token(Token = "0x60000A5")]
			[Address(RVA = "0x18F39A0", Offset = "0x18F39A0", VA = "0x18F39A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000023")]
		public override bool PreviousStateIsValid
		{
			[Token(Token = "0x60000AA")]
			[Address(RVA = "0x18F41F0", Offset = "0x18F41F0", VA = "0x18F41F0", Slot = "25")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000AB")]
			[Address(RVA = "0x18F41F8", Offset = "0x18F41F8", VA = "0x18F41F8", Slot = "26")]
			set
			{
			}
		}

		[Token(Token = "0x17000024")]
		public override CameraState State
		{
			[Token(Token = "0x60000AC")]
			[Address(RVA = "0x18F4284", Offset = "0x18F4284", VA = "0x18F4284", Slot = "19")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000025")]
		public override Transform LookAt
		{
			[Token(Token = "0x60000AD")]
			[Address(RVA = "0x18F42C4", Offset = "0x18F42C4", VA = "0x18F42C4", Slot = "21")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000AE")]
			[Address(RVA = "0x18F42D0", Offset = "0x18F42D0", VA = "0x18F42D0", Slot = "22")]
			set
			{
			}
		}

		[Token(Token = "0x17000026")]
		public override Transform Follow
		{
			[Token(Token = "0x60000AF")]
			[Address(RVA = "0x18F42D8", Offset = "0x18F42D8", VA = "0x18F42D8", Slot = "23")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000B0")]
			[Address(RVA = "0x18F42E4", Offset = "0x18F42E4", VA = "0x18F42E4", Slot = "24")]
			set
			{
			}
		}

		[Token(Token = "0x17000027")]
		private float CachedXAxisHeading
		{
			[Token(Token = "0x60000BB")]
			[Address(RVA = "0x18F6804", Offset = "0x18F6804", VA = "0x18F6804")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79508", Offset = "0x79508")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000BC")]
			[Address(RVA = "0x18F680C", Offset = "0x18F680C", VA = "0x18F680C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79518", Offset = "0x79518")]
			set
			{
			}
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x18F36A8", Offset = "0x18F36A8", VA = "0x18F36A8", Slot = "31")]
		protected override void OnValidate()
		{
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x18F377C", Offset = "0x18F377C", VA = "0x18F377C")]
		public CinemachineVirtualCamera GetRig(int i)
		{
			return null;
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x18F3AD8", Offset = "0x18F3AD8", VA = "0x18F3AD8", Slot = "32")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x18F3B04", Offset = "0x18F3B04", VA = "0x18F3B04", Slot = "29")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x18F3C60", Offset = "0x18F3C60", VA = "0x18F3C60")]
		private void OnTransformChildrenChanged()
		{
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x18F3C68", Offset = "0x18F3C68", VA = "0x18F3C68")]
		private void Reset()
		{
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x18F42EC", Offset = "0x18F42EC", VA = "0x18F42EC", Slot = "20")]
		public override bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false)
		{
			return default;
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x18F4428", Offset = "0x18F4428", VA = "0x18F4428", Slot = "35")]
		public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta)
		{
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x18F44FC", Offset = "0x18F44FC", VA = "0x18F44FC", Slot = "27")]
		public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime)
		{
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x18F4E94", Offset = "0x18F4E94", VA = "0x18F4E94", Slot = "28")]
		public override void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime)
		{
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x18F55AC", Offset = "0x18F55AC", VA = "0x18F55AC")]
		private float GetYAxisClosestValue(Vector3 cameraPos, Vector3 up)
		{
			return default;
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x18F3774", Offset = "0x18F3774", VA = "0x18F3774")]
		private void InvalidateRigCache()
		{
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x18F3C6C", Offset = "0x18F3C6C", VA = "0x18F3C6C")]
		private void DestroyRigs()
		{
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x18F5AA4", Offset = "0x18F5AA4", VA = "0x18F5AA4")]
		private CinemachineVirtualCamera[] CreateRigs(CinemachineVirtualCamera[] copyFrom)
		{
			return null;
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x18F37DC", Offset = "0x18F37DC", VA = "0x18F37DC")]
		private void UpdateRigCache()
		{
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x18F5F58", Offset = "0x18F5F58", VA = "0x18F5F58")]
		private int LocateExistingRigs(string[] rigNames, bool forceOrbital)
		{
			return default;
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x18F6814", Offset = "0x18F6814", VA = "0x18F6814")]
		private float UpdateXAxisHeading(CinemachineOrbitalTransposer orbital, float deltaTime, Vector3 up)
		{
			return default;
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x18F4A30", Offset = "0x18F4A30", VA = "0x18F4A30")]
		private void PushSettingsToRigs()
		{
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x18F43FC", Offset = "0x18F43FC", VA = "0x18F43FC")]
		private float GetYAxisValue()
		{
			return default;
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x18F4890", Offset = "0x18F4890", VA = "0x18F4890")]
		private CameraState CalculateNewState(Vector3 worldUp, float deltaTime)
		{
			return default;
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x18F590C", Offset = "0x18F590C", VA = "0x18F590C")]
		public Vector3 GetLocalPositionForCameraFromInput(float t)
		{
			return default;
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x18F6ACC", Offset = "0x18F6ACC", VA = "0x18F6ACC")]
		private void UpdateCachedSpline()
		{
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x18F6E54", Offset = "0x18F6E54", VA = "0x18F6E54")]
		public CinemachineFreeLook()
		{
		}
	}
}
