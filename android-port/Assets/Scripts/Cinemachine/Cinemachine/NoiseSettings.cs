using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Cinemachine
{
	[Token(Token = "0x2000073")]
	public sealed class NoiseSettings : SignalSourceAsset
	{
		[Serializable]
		[Token(Token = "0x2000074")]
		public struct NoiseParams
		{
			[Token(Token = "0x40002A5")]
			[FieldOffset(Offset = "0x0")]
			public float Frequency;

			[Token(Token = "0x40002A6")]
			[FieldOffset(Offset = "0x4")]
			public float Amplitude;

			[Token(Token = "0x40002A7")]
			[FieldOffset(Offset = "0x8")]
			public bool Constant;

			[Token(Token = "0x60002EB")]
			[Address(RVA = "0x1911CBC", Offset = "0x1911CBC", VA = "0x1911CBC")]
			public float GetValueAt(float time, float timeOffset)
			{
				return default;
			}
		}

		[Serializable]
		[Token(Token = "0x2000075")]
		public struct TransformNoiseParams
		{
			[Token(Token = "0x40002A8")]
			[FieldOffset(Offset = "0x0")]
			public NoiseParams X;

			[Token(Token = "0x40002A9")]
			[FieldOffset(Offset = "0xC")]
			public NoiseParams Y;

			[Token(Token = "0x40002AA")]
			[FieldOffset(Offset = "0x18")]
			public NoiseParams Z;

			[Token(Token = "0x60002EC")]
			[Address(RVA = "0x190B8C8", Offset = "0x190B8C8", VA = "0x190B8C8")]
			public Vector3 GetValueAt(float time, Vector3 timeOffsets)
			{
				return default;
			}
		}

		[Token(Token = "0x40002A3")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x79358", Offset = "0x79358")]
		public TransformNoiseParams[] PositionNoise;

		[Token(Token = "0x40002A4")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x79390", Offset = "0x79390")]
		public TransformNoiseParams[] OrientationNoise;

		[Token(Token = "0x170000CB")]
		public override float SignalDuration
		{
			[Token(Token = "0x60002E8")]
			[Address(RVA = "0x190BA1C", Offset = "0x190BA1C", VA = "0x190BA1C", Slot = "5")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x190B7EC", Offset = "0x190B7EC", VA = "0x190B7EC")]
		public static Vector3 GetCombinedFilterResults(TransformNoiseParams[] noiseParams, float time, Vector3 timeOffsets)
		{
			return default;
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x190BA24", Offset = "0x190BA24", VA = "0x190BA24", Slot = "6")]
		public override void GetSignal(float timeSinceSignalStart, out Vector3 pos, out Quaternion rot)
		{
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x190BBBC", Offset = "0x190BBBC", VA = "0x190BBBC")]
		public NoiseSettings()
		{
		}
	}
}
