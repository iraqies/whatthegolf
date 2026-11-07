using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Cinemachine
{
	[Serializable]
	[Token(Token = "0x2000083")]
	public class CinemachineImpulseDefinition
	{
		[Token(Token = "0x2000084")]
		public enum RepeatMode
		{
			[Token(Token = "0x40002EA")]
			Stretch = 0,
			[Token(Token = "0x40002EB")]
			Loop = 1
		}

		[Token(Token = "0x2000085")]
		private class SignalSource : ISignalSource6D
		{
			[Token(Token = "0x40002EC")]
			[FieldOffset(Offset = "0x10")]
			private CinemachineImpulseDefinition m_Def;

			[Token(Token = "0x40002ED")]
			[FieldOffset(Offset = "0x18")]
			private Vector3 m_Velocity;

			[Token(Token = "0x40002EE")]
			[FieldOffset(Offset = "0x24")]
			private float m_StartTimeOffset;

			[Token(Token = "0x170000CF")]
			public float SignalDuration
			{
				[Token(Token = "0x600031E")]
				[Address(RVA = "0x19108D4", Offset = "0x19108D4", VA = "0x19108D4", Slot = "5")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x600031D")]
			[Address(RVA = "0x1910838", Offset = "0x1910838", VA = "0x1910838")]
			public SignalSource(CinemachineImpulseDefinition def, Vector3 velocity)
			{
			}

			[Token(Token = "0x600031F")]
			[Address(RVA = "0x1910900", Offset = "0x1910900", VA = "0x1910900", Slot = "4")]
			public void GetSignal(float timeSinceSignalStart, out Vector3 pos, out Quaternion rot)
			{
			}
		}

		[Token(Token = "0x40002DE")]
		[FieldOffset(Offset = "0x10")]
		public int m_ImpulseChannel;

		[Token(Token = "0x40002DF")]
		[FieldOffset(Offset = "0x18")]
		public SignalSourceAsset m_RawSignal;

		[Token(Token = "0x40002E0")]
		[FieldOffset(Offset = "0x20")]
		public float m_AmplitudeGain;

		[Token(Token = "0x40002E1")]
		[FieldOffset(Offset = "0x24")]
		public float m_FrequencyGain;

		[Token(Token = "0x40002E2")]
		[FieldOffset(Offset = "0x28")]
		public RepeatMode m_RepeatMode;

		[Token(Token = "0x40002E3")]
		[FieldOffset(Offset = "0x2C")]
		public bool m_Randomize;

		[Token(Token = "0x40002E4")]
		[FieldOffset(Offset = "0x30")]
		public CinemachineImpulseManager.EnvelopeDefinition m_TimeEnvelope;

		[Token(Token = "0x40002E5")]
		[FieldOffset(Offset = "0x50")]
		public float m_ImpactRadius;

		[Token(Token = "0x40002E6")]
		[FieldOffset(Offset = "0x54")]
		public CinemachineImpulseManager.ImpulseEvent.DirectionMode m_DirectionMode;

		[Token(Token = "0x40002E7")]
		[FieldOffset(Offset = "0x58")]
		public CinemachineImpulseManager.ImpulseEvent.DissipationMode m_DissipationMode;

		[Token(Token = "0x40002E8")]
		[FieldOffset(Offset = "0x5C")]
		public float m_DissipationDistance;

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x18F8464", Offset = "0x18F8464", VA = "0x18F8464")]
		public void OnValidate()
		{
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x18F84B0", Offset = "0x18F84B0", VA = "0x18F84B0")]
		public void CreateEvent(Vector3 position, Vector3 velocity)
		{
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x18F892C", Offset = "0x18F892C", VA = "0x18F892C")]
		public CinemachineImpulseDefinition()
		{
		}
	}
}
