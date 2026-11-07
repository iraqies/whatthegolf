using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Cinemachine
{
	[Token(Token = "0x2000087")]
	public class CinemachineImpulseManager
	{
		[Serializable]
		[Token(Token = "0x2000088")]
		public struct EnvelopeDefinition
		{
			[Token(Token = "0x40002F6")]
			[FieldOffset(Offset = "0x0")]
			public AnimationCurve m_AttackShape;

			[Token(Token = "0x40002F7")]
			[FieldOffset(Offset = "0x8")]
			public AnimationCurve m_DecayShape;

			[Token(Token = "0x40002F8")]
			[FieldOffset(Offset = "0x10")]
			public float m_AttackTime;

			[Token(Token = "0x40002F9")]
			[FieldOffset(Offset = "0x14")]
			public float m_SustainTime;

			[Token(Token = "0x40002FA")]
			[FieldOffset(Offset = "0x18")]
			public float m_DecayTime;

			[Token(Token = "0x40002FB")]
			[FieldOffset(Offset = "0x1C")]
			public bool m_ScaleWithImpact;

			[Token(Token = "0x40002FC")]
			[FieldOffset(Offset = "0x1D")]
			public bool m_HoldForever;

			[Token(Token = "0x170000D3")]
			public float Duration
			{
				[Token(Token = "0x600032A")]
				[Address(RVA = "0x1910A94", Offset = "0x1910A94", VA = "0x1910A94")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x6000329")]
			[Address(RVA = "0x1910AB4", Offset = "0x1910AB4", VA = "0x1910AB4")]
			public static EnvelopeDefinition Default()
			{
				return default;
			}

			[Token(Token = "0x600032B")]
			[Address(RVA = "0x1910AE4", Offset = "0x1910AE4", VA = "0x1910AE4")]
			public float GetValueAt(float offset)
			{
				return default;
			}

			[Token(Token = "0x600032C")]
			[Address(RVA = "0x1910CB0", Offset = "0x1910CB0", VA = "0x1910CB0")]
			public void Clear()
			{
			}

			[Token(Token = "0x600032D")]
			[Address(RVA = "0x1910CC0", Offset = "0x1910CC0", VA = "0x1910CC0")]
			public void Validate()
			{
			}
		}

		[Token(Token = "0x2000089")]
		public class ImpulseEvent
		{
			[Token(Token = "0x200008A")]
			public enum DirectionMode
			{
				[Token(Token = "0x4000307")]
				Fixed = 0,
				[Token(Token = "0x4000308")]
				RotateTowardSource = 1
			}

			[Token(Token = "0x200008B")]
			public enum DissipationMode
			{
				[Token(Token = "0x400030A")]
				LinearDecay = 0,
				[Token(Token = "0x400030B")]
				SoftDecay = 1,
				[Token(Token = "0x400030C")]
				ExponentialDecay = 2
			}

			[Token(Token = "0x40002FD")]
			[FieldOffset(Offset = "0x10")]
			public float m_StartTime;

			[Token(Token = "0x40002FE")]
			[FieldOffset(Offset = "0x18")]
			public EnvelopeDefinition m_Envelope;

			[Token(Token = "0x40002FF")]
			[FieldOffset(Offset = "0x38")]
			public ISignalSource6D m_SignalSource;

			[Token(Token = "0x4000300")]
			[FieldOffset(Offset = "0x40")]
			public Vector3 m_Position;

			[Token(Token = "0x4000301")]
			[FieldOffset(Offset = "0x4C")]
			public float m_Radius;

			[Token(Token = "0x4000302")]
			[FieldOffset(Offset = "0x50")]
			public DirectionMode m_DirectionMode;

			[Token(Token = "0x4000303")]
			[FieldOffset(Offset = "0x54")]
			public int m_Channel;

			[Token(Token = "0x4000304")]
			[FieldOffset(Offset = "0x58")]
			public DissipationMode m_DissipationMode;

			[Token(Token = "0x4000305")]
			[FieldOffset(Offset = "0x5C")]
			public float m_DissipationDistance;

			[Token(Token = "0x170000D4")]
			public bool Expired
			{
				[Token(Token = "0x600032E")]
				[Address(RVA = "0x1910D18", Offset = "0x1910D18", VA = "0x1910D18")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x600032F")]
			[Address(RVA = "0x1910D84", Offset = "0x1910D84", VA = "0x1910D84")]
			public float DistanceDecay(float distance)
			{
				return default;
			}

			[Token(Token = "0x6000330")]
			[Address(RVA = "0x1910EB0", Offset = "0x1910EB0", VA = "0x1910EB0")]
			public bool GetDecayedSignal(Vector3 listenerPosition, bool use2D, out Vector3 pos, out Quaternion rot)
			{
				return default;
			}

			[Token(Token = "0x6000331")]
			[Address(RVA = "0x1911208", Offset = "0x1911208", VA = "0x1911208")]
			public void Clear()
			{
			}

			[Token(Token = "0x6000332")]
			[Address(RVA = "0x191125C", Offset = "0x191125C", VA = "0x191125C")]
			internal ImpulseEvent()
			{
			}
		}

		[Token(Token = "0x40002F2")]
		[FieldOffset(Offset = "0x0")]
		private static CinemachineImpulseManager sInstance;

		[Token(Token = "0x40002F3")]
		[FieldOffset(Offset = "0x10")]
		private List<ImpulseEvent> m_ExpiredEvents;

		[Token(Token = "0x40002F4")]
		[FieldOffset(Offset = "0x18")]
		private List<ImpulseEvent> m_ActiveEvents;

		[Token(Token = "0x40002F5")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x793D8", Offset = "0x793D8")]
		private bool IgnoreTimeScale__BackingField;

		[Token(Token = "0x170000D0")]
		public static CinemachineImpulseManager Instance
		{
			[Token(Token = "0x6000323")]
			[Address(RVA = "0x18F8714", Offset = "0x18F8714", VA = "0x18F8714")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D1")]
		public bool IgnoreTimeScale
		{
			[Token(Token = "0x6000325")]
			[Address(RVA = "0x18F8DF0", Offset = "0x18F8DF0", VA = "0x18F8DF0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79B58", Offset = "0x79B58")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000D2")]
		private float CurrentTime
		{
			[Token(Token = "0x6000326")]
			[Address(RVA = "0x18F8DF8", Offset = "0x18F8DF8", VA = "0x18F8DF8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0x18F8DE8", Offset = "0x18F8DE8", VA = "0x18F8DE8")]
		private CinemachineImpulseManager()
		{
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x18F8B14", Offset = "0x18F8B14", VA = "0x18F8B14")]
		public bool GetImpulseAt(Vector3 listenerLocation, bool distance2D, int channelMask, out Vector3 pos, out Quaternion rot)
		{
			return default;
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0x18F878C", Offset = "0x18F878C", VA = "0x18F878C")]
		public ImpulseEvent NewImpulseEvent()
		{
			return null;
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x18F8840", Offset = "0x18F8840", VA = "0x18F8840")]
		public void AddImpulseEvent(ImpulseEvent e)
		{
		}
	}
}
