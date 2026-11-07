using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.Utility
{
	[Serializable]
	[Token(Token = "0x2000048")]
	public class CurveControlledBob
	{
		[Token(Token = "0x400010C")]
		[FieldOffset(Offset = "0x10")]
		public float HorizontalBobRange;

		[Token(Token = "0x400010D")]
		[FieldOffset(Offset = "0x14")]
		public float VerticalBobRange;

		[Token(Token = "0x400010E")]
		[FieldOffset(Offset = "0x18")]
		public AnimationCurve Bobcurve;

		[Token(Token = "0x400010F")]
		[FieldOffset(Offset = "0x20")]
		public float VerticaltoHorizontalRatio;

		[Token(Token = "0x4000110")]
		[FieldOffset(Offset = "0x24")]
		private float m_CyclePositionX;

		[Token(Token = "0x4000111")]
		[FieldOffset(Offset = "0x28")]
		private float m_CyclePositionY;

		[Token(Token = "0x4000112")]
		[FieldOffset(Offset = "0x2C")]
		private float m_BobBaseInterval;

		[Token(Token = "0x4000113")]
		[FieldOffset(Offset = "0x30")]
		private Vector3 m_OriginalCameraPosition;

		[Token(Token = "0x4000114")]
		[FieldOffset(Offset = "0x3C")]
		private float m_Time;

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x13631DC", Offset = "0x13631DC", VA = "0x13631DC")]
		public void Setup(Camera camera, float bobBaseInterval)
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x1363270", Offset = "0x1363270", VA = "0x1363270")]
		public Vector3 DoHeadBob(float speed)
		{
			return default;
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x1363394", Offset = "0x1363394", VA = "0x1363394")]
		public CurveControlledBob()
		{
		}
	}
}
