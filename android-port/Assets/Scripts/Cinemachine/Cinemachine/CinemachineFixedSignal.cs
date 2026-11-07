using Il2CppDummyDll;
using UnityEngine;

namespace Cinemachine
{
	[Token(Token = "0x2000082")]
	public class CinemachineFixedSignal : SignalSourceAsset
	{
		[Token(Token = "0x40002DB")]
		[FieldOffset(Offset = "0x18")]
		public AnimationCurve m_XCurve;

		[Token(Token = "0x40002DC")]
		[FieldOffset(Offset = "0x20")]
		public AnimationCurve m_YCurve;

		[Token(Token = "0x40002DD")]
		[FieldOffset(Offset = "0x28")]
		public AnimationCurve m_ZCurve;

		[Token(Token = "0x170000CE")]
		public override float SignalDuration
		{
			[Token(Token = "0x6000315")]
			[Address(RVA = "0x18F1344", Offset = "0x18F1344", VA = "0x18F1344", Slot = "5")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x18F13A4", Offset = "0x18F13A4", VA = "0x18F13A4")]
		private float AxisDuration(AnimationCurve axis)
		{
			return default;
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x18F1460", Offset = "0x18F1460", VA = "0x18F1460", Slot = "6")]
		public override void GetSignal(float timeSinceSignalStart, out Vector3 pos, out Quaternion rot)
		{
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x18F1548", Offset = "0x18F1548", VA = "0x18F1548")]
		private float AxisValue(AnimationCurve axis, float time)
		{
			return default;
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0x18F15A4", Offset = "0x18F15A4", VA = "0x18F15A4")]
		public CinemachineFixedSignal()
		{
		}
	}
}
