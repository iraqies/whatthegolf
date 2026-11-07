using System;
using Cinemachine.Utility;
using Il2CppDummyDll;
using UnityEngine;

namespace Cinemachine
{
	[Token(Token = "0x2000047")]
	public class CinemachineOrbitalTransposer : CinemachineTransposer
	{
		[Serializable]
		[Token(Token = "0x2000048")]
		public struct Heading
		{
			[Token(Token = "0x2000049")]
			public enum HeadingDefinition
			{
				[Token(Token = "0x40001AB")]
				PositionDelta = 0,
				[Token(Token = "0x40001AC")]
				Velocity = 1,
				[Token(Token = "0x40001AD")]
				TargetForward = 2,
				[Token(Token = "0x40001AE")]
				WorldForward = 3
			}

			[Token(Token = "0x40001A7")]
			[FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x78CF4", Offset = "0x78CF4")]
			public HeadingDefinition m_Definition;

			[Token(Token = "0x40001A8")]
			[FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x78D2C", Offset = "0x78D2C")]
			public int m_VelocityFilterStrength;

			[Token(Token = "0x40001A9")]
			[FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x78D44", Offset = "0x78D44")]
			[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x78D44", Offset = "0x78D44")]
			public float m_Bias;

			[Token(Token = "0x60001B9")]
			[Address(RVA = "0x19113A0", Offset = "0x19113A0", VA = "0x19113A0")]
			public Heading(HeadingDefinition def, int filterStrength, float bias)
			{
			}
		}

		[Token(Token = "0x200004A")]
		internal delegate float UpdateHeadingDelegate(CinemachineOrbitalTransposer orbital, float deltaTime, Vector3 up);

		[Serializable]
		[Token(Token = "0x200004B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x781E4", Offset = "0x781E4")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x40001AF")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x40001B0")]
			[FieldOffset(Offset = "0x8")]
			public static UpdateHeadingDelegate _003C_003E9__34_0;

			[Token(Token = "0x60001BF")]
			[Address(RVA = "0x19112C4", Offset = "0x19112C4", VA = "0x19112C4")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x60001C0")]
			[Address(RVA = "0x19112CC", Offset = "0x19112CC", VA = "0x19112CC")]
			internal float _003C_002Ector_003Eb__34_0(CinemachineOrbitalTransposer orbital, float deltaTime, Vector3 up)
			{
				return default;
			}
		}

		[Token(Token = "0x4000198")]
		[FieldOffset(Offset = "0xB8")]
		public Heading m_Heading;

		[Token(Token = "0x4000199")]
		[FieldOffset(Offset = "0xC4")]
		public AxisState.Recentering m_RecenterToTargetHeading;

		[Token(Token = "0x400019A")]
		[FieldOffset(Offset = "0xE0")]
		public AxisState m_XAxis;

		[Token(Token = "0x400019B")]
		[FieldOffset(Offset = "0x138")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x78BF0", Offset = "0x78BF0")]
		[SerializeField]
		private float m_LegacyRadius;

		[Token(Token = "0x400019C")]
		[FieldOffset(Offset = "0x13C")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x78C3C", Offset = "0x78C3C")]
		private float m_LegacyHeightOffset;

		[Token(Token = "0x400019D")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x78C88", Offset = "0x78C88")]
		private float m_LegacyHeadingBias;

		[Token(Token = "0x400019E")]
		[FieldOffset(Offset = "0x144")]
		public bool m_HeadingIsSlave;

		[Token(Token = "0x400019F")]
		[FieldOffset(Offset = "0x148")]
		internal UpdateHeadingDelegate HeadingUpdater;

		[Token(Token = "0x40001A0")]
		[FieldOffset(Offset = "0x150")]
		private Vector3 mLastTargetPosition;

		[Token(Token = "0x40001A1")]
		[FieldOffset(Offset = "0x160")]
		private HeadingTracker mHeadingTracker;

		[Token(Token = "0x40001A2")]
		[FieldOffset(Offset = "0x168")]
		private Rigidbody mTargetRigidBody;

		[Token(Token = "0x40001A3")]
		[FieldOffset(Offset = "0x170")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x78CD4", Offset = "0x78CD4")]
		private Transform PreviousTarget__BackingField;

		[Token(Token = "0x40001A4")]
		[FieldOffset(Offset = "0x178")]
		private Quaternion mHeadingPrevFrame;

		[Token(Token = "0x40001A5")]
		[FieldOffset(Offset = "0x188")]
		private Vector3 mOffsetPrevFrame;

		[Token(Token = "0x40001A6")]
		[FieldOffset(Offset = "0x194")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x78CE4", Offset = "0x78CE4")]
		private float LastHeading__BackingField;

		[Token(Token = "0x1700005D")]
		private Transform PreviousTarget
		{
			[Token(Token = "0x60001AD")]
			[Address(RVA = "0x18FAC34", Offset = "0x18FAC34", VA = "0x18FAC34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x796F8", Offset = "0x796F8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001AE")]
			[Address(RVA = "0x18FAC3C", Offset = "0x18FAC3C", VA = "0x18FAC3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79708", Offset = "0x79708")]
			set
			{
			}
		}

		[Token(Token = "0x1700005E")]
		private float LastHeading
		{
			[Token(Token = "0x60001B2")]
			[Address(RVA = "0x18FAE88", Offset = "0x18FAE88", VA = "0x18FAE88")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79718", Offset = "0x79718")]
			get
			{
				return default;
			}
			[Token(Token = "0x60001B3")]
			[Address(RVA = "0x18FAE90", Offset = "0x18FAE90", VA = "0x18FAE90")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79728", Offset = "0x79728")]
			set
			{
			}
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x18FA794", Offset = "0x18FA794", VA = "0x18FA794", Slot = "10")]
		protected override void OnValidate()
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x18FA87C", Offset = "0x18FA87C", VA = "0x18FA87C")]
		public float UpdateHeading(float deltaTime, Vector3 up, ref AxisState axis)
		{
			return default;
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x18F6994", Offset = "0x18F6994", VA = "0x18F6994")]
		public float UpdateHeading(float deltaTime, Vector3 up, ref AxisState axis, ref AxisState.Recentering recentering, bool isLive)
		{
			return default;
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x18FAC00", Offset = "0x18FAC00", VA = "0x18FAC00")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x18FAC44", Offset = "0x18FAC44", VA = "0x18FAC44", Slot = "9")]
		public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta)
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x18FAD2C", Offset = "0x18FAD2C", VA = "0x18FAD2C", Slot = "8")]
		public override bool OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime, ref CinemachineVirtualCameraBase.TransitionParams transitionParams)
		{
			return default;
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x18F533C", Offset = "0x18F533C", VA = "0x18F533C")]
		public float GetAxisClosestValue(Vector3 cameraPos, Vector3 up)
		{
			return default;
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x18FAE98", Offset = "0x18FAE98", VA = "0x18FAE98", Slot = "7")]
		public override void MutateCameraState(ref CameraState curState, float deltaTime)
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x18FB2F8", Offset = "0x18FB2F8", VA = "0x18FB2F8", Slot = "11")]
		public override Vector3 GetTargetCameraPosition(Vector3 worldUp)
		{
			return default;
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x18FB438", Offset = "0x18FB438", VA = "0x18FB438")]
		private static string GetFullName(GameObject current)
		{
			return null;
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x18FA888", Offset = "0x18FA888", VA = "0x18FA888")]
		private float GetTargetHeading(float currentHeading, Quaternion targetOrientation)
		{
			return default;
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x18FB5B8", Offset = "0x18FB5B8", VA = "0x18FB5B8")]
		public CinemachineOrbitalTransposer()
		{
		}
	}
}
