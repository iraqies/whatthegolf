using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using CameraStack;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Events;

[Token(Token = "0x20009CB")]
public class IntroTunnelInOverworld : MonoBehaviour
{
	[Token(Token = "0x20009CC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x426F0", Offset = "0x426F0")]
	private sealed class _003CListenForNewBalls_003Ed__48 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40035E0")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40035E1")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40035E2")]
		[FieldOffset(Offset = "0x20")]
		public IntroTunnelInOverworld _003C_003E4__this;

		[Token(Token = "0x170004C1")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002E19")]
			[Address(RVA = "0x17CA3C4", Offset = "0x17CA3C4", VA = "0x17CA3C4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170004C2")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002E1B")]
			[Address(RVA = "0x17CA40C", Offset = "0x17CA40C", VA = "0x17CA40C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002E16")]
		[Address(RVA = "0x17CA2A8", Offset = "0x17CA2A8", VA = "0x17CA2A8")]
		[DebuggerHidden]
		public _003CListenForNewBalls_003Ed__48(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002E17")]
		[Address(RVA = "0x17CA2D4", Offset = "0x17CA2D4", VA = "0x17CA2D4", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002E18")]
		[Address(RVA = "0x17CA2D8", Offset = "0x17CA2D8", VA = "0x17CA2D8", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6002E19")]
		[Address(RVA = "0x17CA3C4", Offset = "0x17CA3C4", VA = "0x17CA3C4", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002E1A")]
		[Address(RVA = "0x17CA3CC", Offset = "0x17CA3CC", VA = "0x17CA3CC", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6002E1B")]
		[Address(RVA = "0x17CA40C", Offset = "0x17CA40C", VA = "0x17CA40C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x20009CD")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42700", Offset = "0x42700")]
	private sealed class _003C_003Ec__DisplayClass49_0
	{
		[Token(Token = "0x40035E3")]
		[FieldOffset(Offset = "0x10")]
		public IntroTunnelInOverworld _003C_003E4__this;

		[Token(Token = "0x40035E4")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 bulgeScale;

		[Token(Token = "0x40035E5")]
		[FieldOffset(Offset = "0x24")]
		public Vector3 ballShootOutStart;

		[Token(Token = "0x40035E6")]
		[FieldOffset(Offset = "0x30")]
		public Vector3 ballButtonTarget;

		[Token(Token = "0x40035E7")]
		[FieldOffset(Offset = "0x40")]
		public Action<int> _003C_003E9__14;

		[Token(Token = "0x6002E1C")]
		[Address(RVA = "0x17C974C", Offset = "0x17C974C", VA = "0x17C974C")]
		public _003C_003Ec__DisplayClass49_0()
		{
		}

		[Token(Token = "0x6002E1D")]
		[Address(RVA = "0x17C9754", Offset = "0x17C9754", VA = "0x17C9754")]
		internal void _003CPlayAnimationRoutine_003Eb__0(float t)
		{
		}

		[Token(Token = "0x6002E1E")]
		[Address(RVA = "0x17C9784", Offset = "0x17C9784", VA = "0x17C9784")]
		internal void _003CPlayAnimationRoutine_003Eb__8(float t)
		{
		}

		[Token(Token = "0x6002E1F")]
		[Address(RVA = "0x17C97BC", Offset = "0x17C97BC", VA = "0x17C97BC")]
		internal void _003CPlayAnimationRoutine_003Eb__10(float t)
		{
		}

		[Token(Token = "0x6002E20")]
		[Address(RVA = "0x17C97EC", Offset = "0x17C97EC", VA = "0x17C97EC")]
		internal void _003CPlayAnimationRoutine_003Eb__1(float t)
		{
		}

		[Token(Token = "0x6002E21")]
		[Address(RVA = "0x17C98EC", Offset = "0x17C98EC", VA = "0x17C98EC")]
		internal void _003CPlayAnimationRoutine_003Eb__14(int i)
		{
		}

		[Token(Token = "0x6002E22")]
		[Address(RVA = "0x17C9984", Offset = "0x17C9984", VA = "0x17C9984")]
		internal void _003CPlayAnimationRoutine_003Eb__2(float time)
		{
		}

		[Token(Token = "0x6002E23")]
		[Address(RVA = "0x17C9A28", Offset = "0x17C9A28", VA = "0x17C9A28")]
		internal void _003CPlayAnimationRoutine_003Eb__4(float t)
		{
		}

		[Token(Token = "0x6002E24")]
		[Address(RVA = "0x17C9A60", Offset = "0x17C9A60", VA = "0x17C9A60")]
		internal void _003CPlayAnimationRoutine_003Eb__5(float time)
		{
		}

		[Token(Token = "0x6002E25")]
		[Address(RVA = "0x17C9B88", Offset = "0x17C9B88", VA = "0x17C9B88")]
		internal void _003CPlayAnimationRoutine_003Eb__6(float time)
		{
		}
	}

	[Token(Token = "0x20009CE")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42710", Offset = "0x42710")]
	private sealed class _003C_003Ec__DisplayClass49_1
	{
		[Token(Token = "0x40035E8")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 bulgeLocalScale;

		[Token(Token = "0x40035E9")]
		[FieldOffset(Offset = "0x20")]
		public _003C_003Ec__DisplayClass49_0 CS_0024_003C_003E8__locals1;

		[Token(Token = "0x40035EA")]
		[FieldOffset(Offset = "0x28")]
		public Action<int> _003C_003E9__11;

		[Token(Token = "0x6002E26")]
		[Address(RVA = "0x17C9C44", Offset = "0x17C9C44", VA = "0x17C9C44")]
		public _003C_003Ec__DisplayClass49_1()
		{
		}

		[Token(Token = "0x6002E27")]
		[Address(RVA = "0x17C9C4C", Offset = "0x17C9C4C", VA = "0x17C9C4C")]
		internal void _003CPlayAnimationRoutine_003Eb__7(float t)
		{
		}

		[Token(Token = "0x6002E28")]
		[Address(RVA = "0x17C9DE8", Offset = "0x17C9DE8", VA = "0x17C9DE8")]
		internal void _003CPlayAnimationRoutine_003Eb__11(int i)
		{
		}
	}

	[Token(Token = "0x20009CF")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42720", Offset = "0x42720")]
	private sealed class _003C_003Ec__DisplayClass49_2
	{
		[Token(Token = "0x40035EB")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 currentBulgeScale;

		[Token(Token = "0x40035EC")]
		[FieldOffset(Offset = "0x20")]
		public _003C_003Ec__DisplayClass49_1 CS_0024_003C_003E8__locals2;

		[Token(Token = "0x6002E29")]
		[Address(RVA = "0x17CA154", Offset = "0x17CA154", VA = "0x17CA154")]
		public _003C_003Ec__DisplayClass49_2()
		{
		}

		[Token(Token = "0x6002E2A")]
		[Address(RVA = "0x17CA15C", Offset = "0x17CA15C", VA = "0x17CA15C")]
		internal void _003CPlayAnimationRoutine_003Eb__12(float time)
		{
		}

		[Token(Token = "0x6002E2B")]
		[Address(RVA = "0x17CA210", Offset = "0x17CA210", VA = "0x17CA210")]
		internal void _003CPlayAnimationRoutine_003Eb__13(float time)
		{
		}
	}

	[Serializable]
	[Token(Token = "0x20009D0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42730", Offset = "0x42730")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x40035ED")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x40035EE")]
		[FieldOffset(Offset = "0x8")]
		public static Action<int> _003C_003E9__49_9;

		[Token(Token = "0x40035EF")]
		[FieldOffset(Offset = "0x10")]
		public static Action<AudioSource> _003C_003E9__49_3;

		[Token(Token = "0x6002E2D")]
		[Address(RVA = "0x17C9718", Offset = "0x17C9718", VA = "0x17C9718")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6002E2E")]
		[Address(RVA = "0x17C9720", Offset = "0x17C9720", VA = "0x17C9720")]
		internal void _003CPlayAnimationRoutine_003Eb__49_9(int i)
		{
		}

		[Token(Token = "0x6002E2F")]
		[Address(RVA = "0x17C9724", Offset = "0x17C9724", VA = "0x17C9724")]
		internal void _003CPlayAnimationRoutine_003Eb__49_3(AudioSource s)
		{
		}
	}

	[Token(Token = "0x20009D1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42740", Offset = "0x42740")]
	private sealed class _003CPlayAnimationRoutine_003Ed__49 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40035F0")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40035F1")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40035F2")]
		[FieldOffset(Offset = "0x20")]
		public IntroTunnelInOverworld _003C_003E4__this;

		[Token(Token = "0x40035F3")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass49_0 _003C_003E8__1;

		[Token(Token = "0x40035F4")]
		[FieldOffset(Offset = "0x30")]
		public Func<bool> OnABitBeforeLogo;

		[Token(Token = "0x40035F5")]
		[FieldOffset(Offset = "0x38")]
		private _003C_003Ec__DisplayClass49_1 _003C_003E8__2;

		[Token(Token = "0x40035F6")]
		[FieldOffset(Offset = "0x40")]
		public Func<bool> OnReachedLogo;

		[Token(Token = "0x40035F7")]
		[FieldOffset(Offset = "0x48")]
		public Action OnCompleted;

		[Token(Token = "0x40035F8")]
		[FieldOffset(Offset = "0x50")]
		private Collider2D _003CballCollider_003E5__2;

		[Token(Token = "0x170004C3")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002E33")]
			[Address(RVA = "0x17CB1B0", Offset = "0x17CB1B0", VA = "0x17CB1B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170004C4")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002E35")]
			[Address(RVA = "0x17CB1F8", Offset = "0x17CB1F8", VA = "0x17CB1F8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002E30")]
		[Address(RVA = "0x17CA414", Offset = "0x17CA414", VA = "0x17CA414")]
		[DebuggerHidden]
		public _003CPlayAnimationRoutine_003Ed__49(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002E31")]
		[Address(RVA = "0x17CA440", Offset = "0x17CA440", VA = "0x17CA440", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002E32")]
		[Address(RVA = "0x17CA444", Offset = "0x17CA444", VA = "0x17CA444", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6002E33")]
		[Address(RVA = "0x17CB1B0", Offset = "0x17CB1B0", VA = "0x17CB1B0", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002E34")]
		[Address(RVA = "0x17CB1B8", Offset = "0x17CB1B8", VA = "0x17CB1B8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6002E35")]
		[Address(RVA = "0x17CB1F8", Offset = "0x17CB1F8", VA = "0x17CB1F8", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x40035BA")]
	[FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4FEAC", Offset = "0x4FEAC")]
	private Action m_OnAtLogo;

	[Token(Token = "0x40035BB")]
	[FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4FEBC", Offset = "0x4FEBC")]
	private Action m_OnStartAtLogo;

	[Token(Token = "0x40035BC")]
	[FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4FECC", Offset = "0x4FECC")]
	private Action m_OnAtEndOfTunnel;

	[Token(Token = "0x40035BD")]
	[FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4FEDC", Offset = "0x4FEDC")]
	private Action m_OnPreAtLogo;

	[Token(Token = "0x40035BE")]
	[FieldOffset(Offset = "0x38")]
	public Transform ballBulge;

	[Token(Token = "0x40035BF")]
	[FieldOffset(Offset = "0x40")]
	public Transform cameraEndPosition;

	[Token(Token = "0x40035C0")]
	[FieldOffset(Offset = "0x48")]
	public ParticleSystem particlesOnShootOut;

	[Token(Token = "0x40035C1")]
	[FieldOffset(Offset = "0x50")]
	public List<IntroSinger> singers;

	[Token(Token = "0x40035C2")]
	[FieldOffset(Offset = "0x58")]
	public List<Transform> pathFromLogo;

	[Token(Token = "0x40035C3")]
	[FieldOffset(Offset = "0x60")]
	public List<Transform> pathToLogo;

	[Token(Token = "0x40035C4")]
	[FieldOffset(Offset = "0x68")]
	public Transform buttonPosition;

	[Token(Token = "0x40035C5")]
	[FieldOffset(Offset = "0x70")]
	public Transform logoBox;

	[Token(Token = "0x40035C6")]
	[FieldOffset(Offset = "0x78")]
	public AudioSource srcOnMove;

	[Token(Token = "0x40035C7")]
	[FieldOffset(Offset = "0x80")]
	public uint wwiseStateAfterIntro;

	[Token(Token = "0x40035C8")]
	[FieldOffset(Offset = "0x88")]
	public AudioClip sfxOnShootOut;

	[Token(Token = "0x40035C9")]
	[FieldOffset(Offset = "0x90")]
	public ClipSettingsCollection SFX_OnPipeTurn;

	[Token(Token = "0x40035CA")]
	[FieldOffset(Offset = "0x98")]
	public ClipSettingsCollection SFX_OnPopOut;

	[Token(Token = "0x40035CB")]
	[FieldOffset(Offset = "0xA0")]
	public ClipSettingsCollection SFX_OnPopIn;

	[Token(Token = "0x40035CC")]
	[FieldOffset(Offset = "0xA8")]
	public AudioClip sfxOnLogoPipeJump;

	[Token(Token = "0x40035CD")]
	[FieldOffset(Offset = "0xB0")]
	public AudioClip sfxOnLogoPipeLand;

	[Token(Token = "0x40035CE")]
	[FieldOffset(Offset = "0xB8")]
	public AudioMixerSnapshot introSnapshot;

	[Token(Token = "0x40035CF")]
	[FieldOffset(Offset = "0xC0")]
	public AudioMixerSnapshot snapshotAfterIntro;

	[Token(Token = "0x40035D0")]
	[FieldOffset(Offset = "0xC8")]
	public float tweenTime;

	[Token(Token = "0x40035D1")]
	[FieldOffset(Offset = "0xCC")]
	public float tweenTimeAtLogo;

	[Token(Token = "0x40035D2")]
	[FieldOffset(Offset = "0xD0")]
	public float tweenTimeToLogo;

	[Token(Token = "0x40035D3")]
	[FieldOffset(Offset = "0xD4")]
	public float shootoutVelocity;

	[Token(Token = "0x40035D4")]
	[FieldOffset(Offset = "0xD8")]
	public float moveLoopVolume;

	[Token(Token = "0x40035D5")]
	[FieldOffset(Offset = "0xDC")]
	public bool ActivateColliderEarly;

	[Token(Token = "0x40035D6")]
	[FieldOffset(Offset = "0xDD")]
	public bool IsSnowIntro;

	[Token(Token = "0x40035D7")]
	[FieldOffset(Offset = "0xDE")]
	public bool RecoilFromHittingTarget;

	[Token(Token = "0x40035D8")]
	[FieldOffset(Offset = "0xDF")]
	[SerializeField]
	private bool centerCameraOnBallDuringShootOut;

	[Token(Token = "0x40035D9")]
	[FieldOffset(Offset = "0xE0")]
	public CBOrthographicFollow2D followCamera;

	[Token(Token = "0x40035DA")]
	[FieldOffset(Offset = "0xE8")]
	private int lastPipeIndex;

	[Token(Token = "0x40035DB")]
	[FieldOffset(Offset = "0xF0")]
	private OverworldBall2D ball;

	[Token(Token = "0x40035DC")]
	[FieldOffset(Offset = "0xF8")]
	private bool startAtLogo;

	[Token(Token = "0x40035DD")]
	[FieldOffset(Offset = "0xF9")]
	private bool startedMusic;

	[Token(Token = "0x40035DE")]
	[FieldOffset(Offset = "0xFA")]
	private bool didListen;

	[Token(Token = "0x40035DF")]
	[FieldOffset(Offset = "0x100")]
	public UnityEvent OnLogoBreak;

	[Token(Token = "0x1400004B")]
	public event Action OnAtLogo
	{
		[Token(Token = "0x6002E05")]
		[Address(RVA = "0x14F4360", Offset = "0x14F4360", VA = "0x14F4360")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x687F8", Offset = "0x687F8")]
		add
		{
		}
		[Token(Token = "0x6002E06")]
		[Address(RVA = "0x14F4404", Offset = "0x14F4404", VA = "0x14F4404")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68808", Offset = "0x68808")]
		remove
		{
		}
	}

	[Token(Token = "0x1400004C")]
	public event Action OnStartAtLogo
	{
		[Token(Token = "0x6002E07")]
		[Address(RVA = "0x14F1950", Offset = "0x14F1950", VA = "0x14F1950")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68818", Offset = "0x68818")]
		add
		{
		}
		[Token(Token = "0x6002E08")]
		[Address(RVA = "0x14F44A8", Offset = "0x14F44A8", VA = "0x14F44A8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68828", Offset = "0x68828")]
		remove
		{
		}
	}

	[Token(Token = "0x1400004D")]
	public event Action OnAtEndOfTunnel
	{
		[Token(Token = "0x6002E09")]
		[Address(RVA = "0x14F1BF8", Offset = "0x14F1BF8", VA = "0x14F1BF8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68838", Offset = "0x68838")]
		add
		{
		}
		[Token(Token = "0x6002E0A")]
		[Address(RVA = "0x14F454C", Offset = "0x14F454C", VA = "0x14F454C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68848", Offset = "0x68848")]
		remove
		{
		}
	}

	[Token(Token = "0x1400004E")]
	public event Action OnPreAtLogo
	{
		[Token(Token = "0x6002E0B")]
		[Address(RVA = "0x14F4240", Offset = "0x14F4240", VA = "0x14F4240")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68858", Offset = "0x68858")]
		add
		{
		}
		[Token(Token = "0x6002E0C")]
		[Address(RVA = "0x14F45F0", Offset = "0x14F45F0", VA = "0x14F45F0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68868", Offset = "0x68868")]
		remove
		{
		}
	}

	[Token(Token = "0x6002E0D")]
	[Address(RVA = "0x14F4694", Offset = "0x14F4694", VA = "0x14F4694")]
	public void Init(bool _startAtLogo = false)
	{
	}

	[Token(Token = "0x6002E0E")]
	[Address(RVA = "0x14F4824", Offset = "0x14F4824", VA = "0x14F4824")]
	public OverworldBall2D GetBall()
	{
		return null;
	}

	[Token(Token = "0x6002E0F")]
	[Address(RVA = "0x14F49B0", Offset = "0x14F49B0", VA = "0x14F49B0")]
	private IEnumerator ListenForNewBalls()
	{
		return null;
	}

	[Token(Token = "0x6002E10")]
	[Address(RVA = "0x14F4A24", Offset = "0x14F4A24", VA = "0x14F4A24")]
	public IEnumerator PlayAnimationRoutine(Action OnCompleted, Func<bool> OnReachedLogo, Func<bool> OnABitBeforeLogo)
	{
		return null;
	}

	[Token(Token = "0x6002E11")]
	[Address(RVA = "0x14F4AB4", Offset = "0x14F4AB4", VA = "0x14F4AB4")]
	private void Instance_OnNewBall1(Transmogrif.BALLSHAPES obj)
	{
	}

	[Token(Token = "0x6002E12")]
	[Address(RVA = "0x14F4AE8", Offset = "0x14F4AE8", VA = "0x14F4AE8")]
	private void Instance_OnNewBall(Transmogrif.BALLSHAPES obj)
	{
	}

	[Token(Token = "0x6002E13")]
	[Address(RVA = "0x14F4B28", Offset = "0x14F4B28", VA = "0x14F4B28")]
	private void SetPositionOnPath(List<Transform> path, float pct, Action<int> OnChangedIndex, bool lerpCameraX = false)
	{
	}

	[Token(Token = "0x6002E14")]
	[Address(RVA = "0x14F4934", Offset = "0x14F4934", VA = "0x14F4934")]
	private void SetCameraCenter(Vector3 target)
	{
	}

	[Token(Token = "0x6002E15")]
	[Address(RVA = "0x14F4FDC", Offset = "0x14F4FDC", VA = "0x14F4FDC")]
	public IntroTunnelInOverworld()
	{
	}
}
