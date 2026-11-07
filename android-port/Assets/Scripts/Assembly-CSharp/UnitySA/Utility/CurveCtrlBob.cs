using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnitySA.Utility
{
	[Serializable]
	[Token(Token = "0x2000F40")]
	public class CurveCtrlBob
	{
		[Token(Token = "0x4005266")]
		[FieldOffset(Offset = "0x10")]
		public float HorizontalBobRange;

		[Token(Token = "0x4005267")]
		[FieldOffset(Offset = "0x14")]
		public float VerticalBobRange;

		[Token(Token = "0x4005268")]
		[FieldOffset(Offset = "0x18")]
		public AnimationCurve Bobcurve;

		[Token(Token = "0x4005269")]
		[FieldOffset(Offset = "0x20")]
		public float VerticaltoHorizontalRatio;

		[Token(Token = "0x400526A")]
		[FieldOffset(Offset = "0x24")]
		private float m_CyclePositionX;

		[Token(Token = "0x400526B")]
		[FieldOffset(Offset = "0x28")]
		private float m_CyclePositionY;

		[Token(Token = "0x400526C")]
		[FieldOffset(Offset = "0x2C")]
		private float m_BobBaseInterval;

		[Token(Token = "0x400526D")]
		[FieldOffset(Offset = "0x30")]
		private Vector3 m_OriginalCameraPosition;

		[Token(Token = "0x400526E")]
		[FieldOffset(Offset = "0x3C")]
		private float m_Time;

		[Token(Token = "0x6004746")]
		[Address(RVA = "0x18C5EE0", Offset = "0x18C5EE0", VA = "0x18C5EE0")]
		public void Setup(Camera camera, float bobBaseInterval)
		{
		}

		[Token(Token = "0x6004747")]
		[Address(RVA = "0x18C5F74", Offset = "0x18C5F74", VA = "0x18C5F74")]
		public Vector3 DoHeadBob(float speed)
		{
			return default;
		}

		[Token(Token = "0x6004748")]
		[Address(RVA = "0x18C6098", Offset = "0x18C6098", VA = "0x18C6098")]
		public CurveCtrlBob()
		{
		}
	}
}
