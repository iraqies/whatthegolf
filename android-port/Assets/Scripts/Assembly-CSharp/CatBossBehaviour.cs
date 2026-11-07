using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20007D1")]
public class CatBossBehaviour : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20007D2")]
	public class BossEvent
	{
		[Token(Token = "0x4002982")]
		[FieldOffset(Offset = "0x10")]
		public string TriggerName;

		[Token(Token = "0x4002983")]
		[FieldOffset(Offset = "0x18")]
		public float Weight;

		[Token(Token = "0x4002984")]
		[FieldOffset(Offset = "0x1C")]
		public int EventsBeforeAvailable;

		[Token(Token = "0x4002985")]
		[FieldOffset(Offset = "0x20")]
		public int SkipsLeft;

		[Token(Token = "0x4002986")]
		[FieldOffset(Offset = "0x24")]
		public bool HasCustomMovement;

		[Token(Token = "0x4002987")]
		[FieldOffset(Offset = "0x28")]
		public AnimationCurve MovementCurve;

		[Token(Token = "0x4002988")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4ED6C", Offset = "0x4ED6C")]
		public float NormalizedEventStartPosition;

		[Token(Token = "0x4002989")]
		[FieldOffset(Offset = "0x34")]
		public float EventSpeedMod;

		[Token(Token = "0x60023DC")]
		[Address(RVA = "0x17827E8", Offset = "0x17827E8", VA = "0x17827E8")]
		public BossEvent()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x20007D3")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41640", Offset = "0x41640")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x400298A")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x400298B")]
		[FieldOffset(Offset = "0x8")]
		public static Action<Level.CompletedState> _003C_003E9__32_0;

		[Token(Token = "0x400298C")]
		[FieldOffset(Offset = "0x10")]
		public static Action _003C_003E9__32_1;

		[Token(Token = "0x400298D")]
		[FieldOffset(Offset = "0x18")]
		public static Action<AudioSource> _003C_003E9__37_0;

		[Token(Token = "0x400298E")]
		[FieldOffset(Offset = "0x20")]
		public static Func<BossEvent, bool> _003C_003E9__38_0;

		[Token(Token = "0x400298F")]
		[FieldOffset(Offset = "0x28")]
		public static Action<BossEvent> _003C_003E9__38_1;

		[Token(Token = "0x4002990")]
		[FieldOffset(Offset = "0x30")]
		public static Func<BossEvent, float> _003C_003E9__38_2;

		[Token(Token = "0x4002991")]
		[FieldOffset(Offset = "0x38")]
		public static Action<float> _003C_003E9__40_0;

		[Token(Token = "0x4002992")]
		[FieldOffset(Offset = "0x40")]
		public static Action<AudioSource> _003C_003E9__43_0;

		[Token(Token = "0x4002993")]
		[FieldOffset(Offset = "0x48")]
		public static Action<float> _003C_003E9__43_1;

		[Token(Token = "0x4002994")]
		[FieldOffset(Offset = "0x50")]
		public static Action<AudioSource> _003C_003E9__44_0;

		[Token(Token = "0x4002995")]
		[FieldOffset(Offset = "0x58")]
		public static Action<AudioSource> _003C_003E9__45_0;

		[Token(Token = "0x4002996")]
		[FieldOffset(Offset = "0x60")]
		public static Action<AudioSource> _003C_003E9__46_0;

		[Token(Token = "0x4002997")]
		[FieldOffset(Offset = "0x68")]
		public static Action<AudioSource> _003C_003E9__47_0;

		[Token(Token = "0x60023DE")]
		[Address(RVA = "0x1781C84", Offset = "0x1781C84", VA = "0x1781C84")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x60023DF")]
		[Address(RVA = "0x1781C8C", Offset = "0x1781C8C", VA = "0x1781C8C")]
		internal void _003CAwake_003Eb__32_0(Level.CompletedState s)
		{
		}

		[Token(Token = "0x60023E0")]
		[Address(RVA = "0x1781CD8", Offset = "0x1781CD8", VA = "0x1781CD8")]
		internal void _003CAwake_003Eb__32_1()
		{
		}

		[Token(Token = "0x60023E1")]
		[Address(RVA = "0x1781D24", Offset = "0x1781D24", VA = "0x1781D24")]
		internal void _003CDelayedScreenShake_003Eb__37_0(AudioSource s)
		{
		}

		[Token(Token = "0x60023E2")]
		[Address(RVA = "0x1781D74", Offset = "0x1781D74", VA = "0x1781D74")]
		internal bool _003CGetNextEvent_003Eb__38_0(BossEvent e)
		{
			return default;
		}

		[Token(Token = "0x60023E3")]
		[Address(RVA = "0x1781D94", Offset = "0x1781D94", VA = "0x1781D94")]
		internal void _003CGetNextEvent_003Eb__38_1(BossEvent e)
		{
		}

		[Token(Token = "0x60023E4")]
		[Address(RVA = "0x1781DB4", Offset = "0x1781DB4", VA = "0x1781DB4")]
		internal float _003CGetNextEvent_003Eb__38_2(BossEvent e)
		{
			return default;
		}

		[Token(Token = "0x60023E5")]
		[Address(RVA = "0x1781DCC", Offset = "0x1781DCC", VA = "0x1781DCC")]
		internal void _003CTakeDamage_003Eb__40_0(float t)
		{
		}

		[Token(Token = "0x60023E6")]
		[Address(RVA = "0x1781DD0", Offset = "0x1781DD0", VA = "0x1781DD0")]
		internal void _003CPlayDragClip_003Eb__43_0(AudioSource m)
		{
		}

		[Token(Token = "0x60023E7")]
		[Address(RVA = "0x1781E18", Offset = "0x1781E18", VA = "0x1781E18")]
		internal void _003CPlayDragClip_003Eb__43_1(float t)
		{
		}

		[Token(Token = "0x60023E8")]
		[Address(RVA = "0x1781E1C", Offset = "0x1781E1C", VA = "0x1781E1C")]
		internal void _003CPlayFallClip_003Eb__44_0(AudioSource m)
		{
		}

		[Token(Token = "0x60023E9")]
		[Address(RVA = "0x1781E6C", Offset = "0x1781E6C", VA = "0x1781E6C")]
		internal void _003CPlaySwooshClip_003Eb__45_0(AudioSource m)
		{
		}

		[Token(Token = "0x60023EA")]
		[Address(RVA = "0x1781EBC", Offset = "0x1781EBC", VA = "0x1781EBC")]
		internal void _003CPlaySmashRecoverClip_003Eb__46_0(AudioSource s)
		{
		}

		[Token(Token = "0x60023EB")]
		[Address(RVA = "0x1781EE4", Offset = "0x1781EE4", VA = "0x1781EE4")]
		internal void _003CPlayAnticipationClip_003Eb__47_0(AudioSource s)
		{
		}
	}

	[Token(Token = "0x20007D4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41650", Offset = "0x41650")]
	private sealed class _003CDelayedScreenShake_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002998")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002999")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400299A")]
		[FieldOffset(Offset = "0x20")]
		public CatBossBehaviour _003C_003E4__this;

		[Token(Token = "0x170003ED")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60023EF")]
			[Address(RVA = "0x1782534", Offset = "0x1782534", VA = "0x1782534", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170003EE")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60023F1")]
			[Address(RVA = "0x178257C", Offset = "0x178257C", VA = "0x178257C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60023EC")]
		[Address(RVA = "0x1782010", Offset = "0x1782010", VA = "0x1782010")]
		[DebuggerHidden]
		public _003CDelayedScreenShake_003Ed__37(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60023ED")]
		[Address(RVA = "0x178203C", Offset = "0x178203C", VA = "0x178203C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60023EE")]
		[Address(RVA = "0x1782040", Offset = "0x1782040", VA = "0x1782040", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60023EF")]
		[Address(RVA = "0x1782534", Offset = "0x1782534", VA = "0x1782534", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60023F0")]
		[Address(RVA = "0x178253C", Offset = "0x178253C", VA = "0x178253C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60023F1")]
		[Address(RVA = "0x178257C", Offset = "0x178257C", VA = "0x178257C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x20007D5")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41660", Offset = "0x41660")]
	private sealed class _003C_003Ec__DisplayClass39_0
	{
		[Token(Token = "0x400299B")]
		[FieldOffset(Offset = "0x10")]
		public CatBossBehaviour _003C_003E4__this;

		[Token(Token = "0x400299C")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 startPos;

		[Token(Token = "0x400299D")]
		[FieldOffset(Offset = "0x24")]
		public Vector3 endPos;

		[Token(Token = "0x60023F2")]
		[Address(RVA = "0x1781F34", Offset = "0x1781F34", VA = "0x1781F34")]
		public _003C_003Ec__DisplayClass39_0()
		{
		}

		[Token(Token = "0x60023F3")]
		[Address(RVA = "0x1781F3C", Offset = "0x1781F3C", VA = "0x1781F3C")]
		internal void _003CStartEvent_003Eb__0(float t)
		{
		}
	}

	[Token(Token = "0x20007D6")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41670", Offset = "0x41670")]
	private sealed class _003CStartEvent_003Ed__39 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400299E")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400299F")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40029A0")]
		[FieldOffset(Offset = "0x20")]
		public CatBossBehaviour _003C_003E4__this;

		[Token(Token = "0x170003EF")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60023F7")]
			[Address(RVA = "0x1782798", Offset = "0x1782798", VA = "0x1782798", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170003F0")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60023F9")]
			[Address(RVA = "0x17827E0", Offset = "0x17827E0", VA = "0x17827E0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60023F4")]
		[Address(RVA = "0x1782584", Offset = "0x1782584", VA = "0x1782584")]
		[DebuggerHidden]
		public _003CStartEvent_003Ed__39(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60023F5")]
		[Address(RVA = "0x17825B0", Offset = "0x17825B0", VA = "0x17825B0", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60023F6")]
		[Address(RVA = "0x17825B4", Offset = "0x17825B4", VA = "0x17825B4", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60023F7")]
		[Address(RVA = "0x1782798", Offset = "0x1782798", VA = "0x1782798", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60023F8")]
		[Address(RVA = "0x17827A0", Offset = "0x17827A0", VA = "0x17827A0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60023F9")]
		[Address(RVA = "0x17827E0", Offset = "0x17827E0", VA = "0x17827E0", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x20007D7")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41680", Offset = "0x41680")]
	private sealed class _003C_003Ec__DisplayClass43_0
	{
		[Token(Token = "0x40029A1")]
		[FieldOffset(Offset = "0x10")]
		public AudioSource dragSource;

		[Token(Token = "0x60023FA")]
		[Address(RVA = "0x1781FEC", Offset = "0x1781FEC", VA = "0x1781FEC")]
		public _003C_003Ec__DisplayClass43_0()
		{
		}

		[Token(Token = "0x60023FB")]
		[Address(RVA = "0x1781FF4", Offset = "0x1781FF4", VA = "0x1781FF4")]
		internal void _003CPlayDragClip_003Eb__2(float s)
		{
		}
	}

	[Token(Token = "0x4002964")]
	[FieldOffset(Offset = "0x18")]
	public List<BossEvent> BossEvents;

	[Token(Token = "0x4002965")]
	[FieldOffset(Offset = "0x20")]
	public Vector2 LeftRightRanges;

	[Token(Token = "0x4002966")]
	[FieldOffset(Offset = "0x28")]
	public Vector2 DelayRange;

	[Token(Token = "0x4002967")]
	[FieldOffset(Offset = "0x30")]
	public float MovementSpeedMod;

	[Token(Token = "0x4002968")]
	[FieldOffset(Offset = "0x38")]
	public BossIntro Intro;

	[Token(Token = "0x4002969")]
	[FieldOffset(Offset = "0x40")]
	public GolfBallController Controller;

	[Token(Token = "0x400296A")]
	[FieldOffset(Offset = "0x48")]
	public int Health;

	[Token(Token = "0x400296B")]
	[FieldOffset(Offset = "0x50")]
	public ParticleSystem HurtParticles;

	[Token(Token = "0x400296C")]
	[FieldOffset(Offset = "0x58")]
	public List<AudioClip> HurtClips;

	[Token(Token = "0x400296D")]
	[FieldOffset(Offset = "0x60")]
	public List<GameObject> HurtObjects;

	[Token(Token = "0x400296E")]
	[FieldOffset(Offset = "0x68")]
	public List<Rigidbody> Drops;

	[Token(Token = "0x400296F")]
	[FieldOffset(Offset = "0x70")]
	public List<AudioClip> SmashClips;

	[Token(Token = "0x4002970")]
	[FieldOffset(Offset = "0x78")]
	public List<AudioClip> CatIntroClips;

	[Token(Token = "0x4002971")]
	[FieldOffset(Offset = "0x80")]
	public List<AudioClip> CatPeekingClips;

	[Token(Token = "0x4002972")]
	[FieldOffset(Offset = "0x88")]
	public List<AudioClip> SwooshClips;

	[Token(Token = "0x4002973")]
	[FieldOffset(Offset = "0x90")]
	public List<AudioClip> CatDraggingClips;

	[Token(Token = "0x4002974")]
	[FieldOffset(Offset = "0x98")]
	public List<AudioClip> AnticipationClips;

	[Token(Token = "0x4002975")]
	[FieldOffset(Offset = "0xA0")]
	public AudioClip SmashRecoverClip;

	[Token(Token = "0x4002976")]
	[FieldOffset(Offset = "0xA8")]
	public AudioClip CatFallClip;

	[Token(Token = "0x4002977")]
	[FieldOffset(Offset = "0xB0")]
	public AudioClip ExplosionClip;

	[Token(Token = "0x4002978")]
	[FieldOffset(Offset = "0xB8")]
	public Explosion2D FlagSpawnParticles;

	[Token(Token = "0x4002979")]
	[FieldOffset(Offset = "0xC0")]
	public GameObject Flag;

	[Token(Token = "0x400297A")]
	[FieldOffset(Offset = "0xC8")]
	private Animator animator;

	[Token(Token = "0x400297B")]
	[FieldOffset(Offset = "0xD0")]
	private float delay;

	[Token(Token = "0x400297C")]
	[FieldOffset(Offset = "0xD4")]
	private float movementTime;

	[Token(Token = "0x400297D")]
	[FieldOffset(Offset = "0xD8")]
	private float eventTime;

	[Token(Token = "0x400297E")]
	[FieldOffset(Offset = "0xE0")]
	private BossEvent currentEvent;

	[Token(Token = "0x400297F")]
	[FieldOffset(Offset = "0xE8")]
	private int direction;

	[Token(Token = "0x4002980")]
	[FieldOffset(Offset = "0xEC")]
	private int startHealth;

	[Token(Token = "0x4002981")]
	[FieldOffset(Offset = "0x0")]
	private static bool hasPlayedIntro;

	[Token(Token = "0x60023C8")]
	[Address(RVA = "0x188E01C", Offset = "0x188E01C", VA = "0x188E01C")]
	[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x6636C", Offset = "0x6636C")]
	private static void Init()
	{
	}

	[Token(Token = "0x60023C9")]
	[Address(RVA = "0x188E068", Offset = "0x188E068", VA = "0x188E068")]
	private void Awake()
	{
	}

	[Token(Token = "0x60023CA")]
	[Address(RVA = "0x188E434", Offset = "0x188E434", VA = "0x188E434")]
	private void Start()
	{
	}

	[Token(Token = "0x60023CB")]
	[Address(RVA = "0x188E61C", Offset = "0x188E61C", VA = "0x188E61C")]
	private void OnReset()
	{
	}

	[Token(Token = "0x60023CC")]
	[Address(RVA = "0x188E9C0", Offset = "0x188E9C0", VA = "0x188E9C0")]
	private void Update()
	{
	}

	[Token(Token = "0x60023CD")]
	[Address(RVA = "0x188F290", Offset = "0x188F290", VA = "0x188F290")]
	public void DoScreenShake()
	{
	}

	[Token(Token = "0x60023CE")]
	[Address(RVA = "0x188F30C", Offset = "0x188F30C", VA = "0x188F30C")]
	private IEnumerator DelayedScreenShake()
	{
		return null;
	}

	[Token(Token = "0x60023CF")]
	[Address(RVA = "0x188ED60", Offset = "0x188ED60", VA = "0x188ED60")]
	private BossEvent GetNextEvent()
	{
		return null;
	}

	[Token(Token = "0x60023D0")]
	[Address(RVA = "0x188F21C", Offset = "0x188F21C", VA = "0x188F21C")]
	private IEnumerator StartEvent()
	{
		return null;
	}

	[Token(Token = "0x60023D1")]
	[Address(RVA = "0x188F380", Offset = "0x188F380", VA = "0x188F380")]
	public void TakeDamage()
	{
	}

	[Token(Token = "0x60023D2")]
	[Address(RVA = "0x188F5F0", Offset = "0x188F5F0", VA = "0x188F5F0")]
	public void PlayPeekClip()
	{
	}

	[Token(Token = "0x60023D3")]
	[Address(RVA = "0x188F62C", Offset = "0x188F62C", VA = "0x188F62C")]
	public void PlayIntro()
	{
	}

	[Token(Token = "0x60023D4")]
	[Address(RVA = "0x188F6F4", Offset = "0x188F6F4", VA = "0x188F6F4")]
	public void PlayDragClip()
	{
	}

	[Token(Token = "0x60023D5")]
	[Address(RVA = "0x188FA08", Offset = "0x188FA08", VA = "0x188FA08")]
	public void PlayFallClip()
	{
	}

	[Token(Token = "0x60023D6")]
	[Address(RVA = "0x188FB54", Offset = "0x188FB54", VA = "0x188FB54")]
	public void PlaySwooshClip()
	{
	}

	[Token(Token = "0x60023D7")]
	[Address(RVA = "0x188FCA4", Offset = "0x188FCA4", VA = "0x188FCA4")]
	public void PlaySmashRecoverClip()
	{
	}

	[Token(Token = "0x60023D8")]
	[Address(RVA = "0x188FDF0", Offset = "0x188FDF0", VA = "0x188FDF0")]
	public void PlayAnticipationClip(int index)
	{
	}

	[Token(Token = "0x60023D9")]
	[Address(RVA = "0x188FFAC", Offset = "0x188FFAC", VA = "0x188FFAC")]
	public CatBossBehaviour()
	{
	}

	[Token(Token = "0x60023DA")]
	[Address(RVA = "0x188FFD0", Offset = "0x188FFD0", VA = "0x188FFD0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x66380", Offset = "0x66380")]
	private void _003CTakeDamage_003Eb__40_1()
	{
	}

	[Token(Token = "0x60023DB")]
	[Address(RVA = "0x18900D4", Offset = "0x18900D4", VA = "0x18900D4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x66390", Offset = "0x66390")]
	private void _003CPlayIntro_003Eb__42_0()
	{
	}
}
