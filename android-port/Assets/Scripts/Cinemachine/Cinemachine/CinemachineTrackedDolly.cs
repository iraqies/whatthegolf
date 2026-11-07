using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Cinemachine
{
	[Token(Token = "0x200004F")]
	public class CinemachineTrackedDolly : CinemachineComponentBase
	{
		[Token(Token = "0x2000050")]
		public enum CameraUpMode
		{
			[Token(Token = "0x40001CD")]
			Default = 0,
			[Token(Token = "0x40001CE")]
			Path = 1,
			[Token(Token = "0x40001CF")]
			PathNoRoll = 2,
			[Token(Token = "0x40001D0")]
			FollowTarget = 3,
			[Token(Token = "0x40001D1")]
			FollowTargetNoRoll = 4
		}

		[Serializable]
		[Token(Token = "0x2000051")]
		public struct AutoDolly
		{
			[Token(Token = "0x40001D2")]
			[FieldOffset(Offset = "0x0")]
			public bool m_Enabled;

			[Token(Token = "0x40001D3")]
			[FieldOffset(Offset = "0x4")]
			public float m_PositionOffset;

			[Token(Token = "0x40001D4")]
			[FieldOffset(Offset = "0x8")]
			public int m_SearchRadius;

			[Token(Token = "0x40001D5")]
			[FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x78E68", Offset = "0x78E68")]
			public int m_SearchResolution;

			[Token(Token = "0x60001D4")]
			[Address(RVA = "0x1904AB8", Offset = "0x1904AB8", VA = "0x1904AB8")]
			public AutoDolly(bool enabled, float positionOffset, int searchRadius, int stepsPerSegment)
			{
			}
		}

		[Token(Token = "0x40001BD")]
		[FieldOffset(Offset = "0x50")]
		public CinemachinePathBase m_Path;

		[Token(Token = "0x40001BE")]
		[FieldOffset(Offset = "0x58")]
		public float m_PathPosition;

		[Token(Token = "0x40001BF")]
		[FieldOffset(Offset = "0x5C")]
		public CinemachinePathBase.PositionUnits m_PositionUnits;

		[Token(Token = "0x40001C0")]
		[FieldOffset(Offset = "0x60")]
		public Vector3 m_PathOffset;

		[Token(Token = "0x40001C1")]
		[FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x78DD8", Offset = "0x78DD8")]
		public float m_XDamping;

		[Token(Token = "0x40001C2")]
		[FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x78DF0", Offset = "0x78DF0")]
		public float m_YDamping;

		[Token(Token = "0x40001C3")]
		[FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x78E08", Offset = "0x78E08")]
		public float m_ZDamping;

		[Token(Token = "0x40001C4")]
		[FieldOffset(Offset = "0x78")]
		public CameraUpMode m_CameraUp;

		[Token(Token = "0x40001C5")]
		[FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x78E20", Offset = "0x78E20")]
		public float m_PitchDamping;

		[Token(Token = "0x40001C6")]
		[FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x78E38", Offset = "0x78E38")]
		public float m_YawDamping;

		[Token(Token = "0x40001C7")]
		[FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x78E50", Offset = "0x78E50")]
		public float m_RollDamping;

		[Token(Token = "0x40001C8")]
		[FieldOffset(Offset = "0x88")]
		public AutoDolly m_AutoDolly;

		[Token(Token = "0x40001C9")]
		[FieldOffset(Offset = "0x98")]
		private float m_PreviousPathPosition;

		[Token(Token = "0x40001CA")]
		[FieldOffset(Offset = "0x9C")]
		private Quaternion m_PreviousOrientation;

		[Token(Token = "0x40001CB")]
		[FieldOffset(Offset = "0xAC")]
		private Vector3 m_PreviousCameraPosition;

		[Token(Token = "0x17000063")]
		public override bool IsValid
		{
			[Token(Token = "0x60001CE")]
			[Address(RVA = "0x1903C50", Offset = "0x1903C50", VA = "0x1903C50", Slot = "4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000064")]
		public override CinemachineCore.Stage Stage
		{
			[Token(Token = "0x60001CF")]
			[Address(RVA = "0x1903CE0", Offset = "0x1903CE0", VA = "0x1903CE0", Slot = "6")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000065")]
		private Vector3 AngularDamping
		{
			[Token(Token = "0x60001D2")]
			[Address(RVA = "0x19048E8", Offset = "0x19048E8", VA = "0x19048E8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x1903CE8", Offset = "0x1903CE8", VA = "0x1903CE8", Slot = "7")]
		public override void MutateCameraState(ref CameraState curState, float deltaTime)
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x19046F0", Offset = "0x19046F0", VA = "0x19046F0")]
		private Quaternion GetCameraOrientationAtPathPoint(Quaternion pathOrientation, Vector3 up)
		{
			return default;
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x1904A50", Offset = "0x1904A50", VA = "0x1904A50")]
		public CinemachineTrackedDolly()
		{
		}
	}
}
