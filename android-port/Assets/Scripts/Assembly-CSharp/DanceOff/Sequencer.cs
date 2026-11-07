using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Core;
using Il2CppDummyDll;
using UnityEngine;

namespace DanceOff
{
	[Token(Token = "0x20011F9")]
	public class Sequencer : MonoBehaviour
	{
		[Token(Token = "0x20011FA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x48424", Offset = "0x48424")]
		private sealed class _003CStart_003Ed__40 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40060BF")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40060C0")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x40060C1")]
			[FieldOffset(Offset = "0x20")]
			public Sequencer _003C_003E4__this;

			[Token(Token = "0x17000912")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6005299")]
				[Address(RVA = "0x1842530", Offset = "0x1842530", VA = "0x1842530", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000913")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x600529B")]
				[Address(RVA = "0x1842578", Offset = "0x1842578", VA = "0x1842578", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6005296")]
			[Address(RVA = "0x18420D0", Offset = "0x18420D0", VA = "0x18420D0")]
			[DebuggerHidden]
			public _003CStart_003Ed__40(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6005297")]
			[Address(RVA = "0x18420FC", Offset = "0x18420FC", VA = "0x18420FC", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6005298")]
			[Address(RVA = "0x1842100", Offset = "0x1842100", VA = "0x1842100", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6005299")]
			[Address(RVA = "0x1842530", Offset = "0x1842530", VA = "0x1842530", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x600529A")]
			[Address(RVA = "0x1842538", Offset = "0x1842538", VA = "0x1842538", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x600529B")]
			[Address(RVA = "0x1842578", Offset = "0x1842578", VA = "0x1842578", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x20011FB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x48434", Offset = "0x48434")]
		private sealed class _003C_003Ec__DisplayClass43_0
		{
			[Token(Token = "0x40060C2")]
			[FieldOffset(Offset = "0x10")]
			public float volume;

			[Token(Token = "0x600529C")]
			[Address(RVA = "0x18420A8", Offset = "0x18420A8", VA = "0x18420A8")]
			public _003C_003Ec__DisplayClass43_0()
			{
			}

			[Token(Token = "0x600529D")]
			[Address(RVA = "0x18420B0", Offset = "0x18420B0", VA = "0x18420B0")]
			internal void _003CCheckForHit_003Eb__0(AudioSource source)
			{
			}
		}

		[Token(Token = "0x40060A0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Track track;

		[Token(Token = "0x40060A1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private double timeBeforeStart;

		[Token(Token = "0x40060A2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform indicatorsRoot;

		[Token(Token = "0x40060A3")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Dancer dancer;

		[Token(Token = "0x40060A4")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Vector3 beatSpacing;

		[Token(Token = "0x40060A5")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float hitRadius;

		[Token(Token = "0x40060A6")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private AudioSource loopAudioSource;

		[Token(Token = "0x40060A7")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GolfGoal golfGoal;

		[Token(Token = "0x40060A8")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private ParticleSystem leftParticleEmitter;

		[Token(Token = "0x40060A9")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private ParticleSystem rightParticleEmitter;

		[Token(Token = "0x40060AA")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private ParticleSystem centerParticleEmitter;

		[Token(Token = "0x40060AB")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ParticleSystem endParticleEmitter;

		[Token(Token = "0x40060AC")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private AnimationCurve indicatorBeatAnimationCurve;

		[Token(Token = "0x40060AD")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private AnimationCurve indicatorSwingAnimationCurve;

		[Token(Token = "0x40060AE")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private float indicatorSwingTimeNormalizer;

		[Token(Token = "0x40060AF")]
		[FieldOffset(Offset = "0x8C")]
		[SerializeField]
		private float indicatorSwingAmplitude;

		[Token(Token = "0x40060B0")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private AudioClip cheeringSfx;

		[Token(Token = "0x40060B1")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private AnimationCurve cheeringVolumeOverTime;

		[Token(Token = "0x40060B2")]
		[FieldOffset(Offset = "0xA0")]
		private double startTime;

		[Token(Token = "0x40060B3")]
		[FieldOffset(Offset = "0xA8")]
		private double time;

		[Token(Token = "0x40060B4")]
		[FieldOffset(Offset = "0xB0")]
		private double timePerBeat;

		[Token(Token = "0x40060B5")]
		[FieldOffset(Offset = "0xB8")]
		private Level level;

		[Token(Token = "0x40060B6")]
		[FieldOffset(Offset = "0xC0")]
		private List<DanceMoveIndicator> indicators;

		[Token(Token = "0x40060B7")]
		[FieldOffset(Offset = "0xC8")]
		public Material[] IndicatorMaterials;

		[Token(Token = "0x40060B8")]
		[FieldOffset(Offset = "0xD0")]
		private int materialPickID;

		[Token(Token = "0x40060B9")]
		[FieldOffset(Offset = "0xD8")]
		private TimeControl timeControl;

		[Token(Token = "0x40060BA")]
		[FieldOffset(Offset = "0xE0")]
		private float elapsedPauseTime;

		[Token(Token = "0x40060BB")]
		[FieldOffset(Offset = "0xE4")]
		private bool wasPaused;

		[Token(Token = "0x40060BC")]
		[FieldOffset(Offset = "0xE8")]
		private float beat;

		[Token(Token = "0x40060BD")]
		[FieldOffset(Offset = "0xF0")]
		private double hitRadiusDuration;

		[Token(Token = "0x40060BE")]
		[FieldOffset(Offset = "0xF8")]
		private IndicatorEffects effects;

		[Token(Token = "0x1700090E")]
		public double StartTime
		{
			[Token(Token = "0x6005289")]
			[Address(RVA = "0x16896E8", Offset = "0x16896E8", VA = "0x16896E8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700090F")]
		public double Time
		{
			[Token(Token = "0x600528A")]
			[Address(RVA = "0x16896F0", Offset = "0x16896F0", VA = "0x16896F0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000910")]
		public double TimePerBeat
		{
			[Token(Token = "0x600528B")]
			[Address(RVA = "0x16896F8", Offset = "0x16896F8", VA = "0x16896F8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000911")]
		public float Beat
		{
			[Token(Token = "0x600528C")]
			[Address(RVA = "0x1689700", Offset = "0x1689700", VA = "0x1689700")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x600528D")]
		[Address(RVA = "0x1689708", Offset = "0x1689708", VA = "0x1689708")]
		private void Awake()
		{
		}

		[Token(Token = "0x600528E")]
		[Address(RVA = "0x16897B0", Offset = "0x16897B0", VA = "0x16897B0")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x600528F")]
		[Address(RVA = "0x1689824", Offset = "0x1689824", VA = "0x1689824")]
		private void HandlePausing()
		{
		}

		[Token(Token = "0x6005290")]
		[Address(RVA = "0x1689944", Offset = "0x1689944", VA = "0x1689944")]
		private void Lose()
		{
		}

		[Token(Token = "0x6005291")]
		[Address(RVA = "0x1689A08", Offset = "0x1689A08", VA = "0x1689A08")]
		public void CheckForHit(Vector2 dir)
		{
		}

		[Token(Token = "0x6005292")]
		[Address(RVA = "0x1689CBC", Offset = "0x1689CBC", VA = "0x1689CBC")]
		private bool CheckForMiss()
		{
			return default;
		}

		[Token(Token = "0x6005293")]
		[Address(RVA = "0x1689D84", Offset = "0x1689D84", VA = "0x1689D84")]
		private void UpdateIndicators()
		{
		}

		[Token(Token = "0x6005294")]
		[Address(RVA = "0x1689E2C", Offset = "0x1689E2C", VA = "0x1689E2C")]
		private void UpdateIndicator(DanceMoveIndicator indicator)
		{
		}

		[Token(Token = "0x6005295")]
		[Address(RVA = "0x1689F60", Offset = "0x1689F60", VA = "0x1689F60")]
		public Sequencer()
		{
		}
	}
}
