using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using Audio.Rumble;
using Core;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Audio;

[Token(Token = "0x200037E")]
public class AudioManager : MonoBehaviour
{
	[Token(Token = "0x200037F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F524", Offset = "0x3F524")]
	private sealed class _003CFadeRoutine_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001338")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001339")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400133A")]
		[FieldOffset(Offset = "0x20")]
		public float time;

		[Token(Token = "0x400133B")]
		[FieldOffset(Offset = "0x28")]
		public AudioManager _003C_003E4__this;

		[Token(Token = "0x400133C")]
		[FieldOffset(Offset = "0x30")]
		public float sfxVolume;

		[Token(Token = "0x400133D")]
		[FieldOffset(Offset = "0x34")]
		public float musicVolume;

		[Token(Token = "0x400133E")]
		[FieldOffset(Offset = "0x38")]
		private float _003CmaxTime_003E5__2;

		[Token(Token = "0x400133F")]
		[FieldOffset(Offset = "0x3C")]
		private float _003CstartSFXVolume_003E5__3;

		[Token(Token = "0x4001340")]
		[FieldOffset(Offset = "0x40")]
		private float _003CstartMusicVolume_003E5__4;

		[Token(Token = "0x170001F7")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600109C")]
			[Address(RVA = "0x176FB6C", Offset = "0x176FB6C", VA = "0x176FB6C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170001F8")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600109E")]
			[Address(RVA = "0x176FBB4", Offset = "0x176FBB4", VA = "0x176FBB4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001099")]
		[Address(RVA = "0x176F97C", Offset = "0x176F97C", VA = "0x176F97C")]
		[DebuggerHidden]
		public _003CFadeRoutine_003Ed__41(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600109A")]
		[Address(RVA = "0x176F9A8", Offset = "0x176F9A8", VA = "0x176F9A8", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600109B")]
		[Address(RVA = "0x176F9AC", Offset = "0x176F9AC", VA = "0x176F9AC", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600109C")]
		[Address(RVA = "0x176FB6C", Offset = "0x176FB6C", VA = "0x176FB6C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600109D")]
		[Address(RVA = "0x176FB74", Offset = "0x176FB74", VA = "0x176FB74", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600109E")]
		[Address(RVA = "0x176FBB4", Offset = "0x176FBB4", VA = "0x176FBB4", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000380")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F534", Offset = "0x3F534")]
	private sealed class _003CFollow_003Ed__47 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001341")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001342")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001343")]
		[FieldOffset(Offset = "0x20")]
		public Transform trans;

		[Token(Token = "0x4001344")]
		[FieldOffset(Offset = "0x28")]
		public AudioSource src;

		[Token(Token = "0x4001345")]
		[FieldOffset(Offset = "0x30")]
		public float time;

		[Token(Token = "0x170001F9")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60010A2")]
			[Address(RVA = "0x176FD3C", Offset = "0x176FD3C", VA = "0x176FD3C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170001FA")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60010A4")]
			[Address(RVA = "0x176FD84", Offset = "0x176FD84", VA = "0x176FD84", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600109F")]
		[Address(RVA = "0x176FBBC", Offset = "0x176FBBC", VA = "0x176FBBC")]
		[DebuggerHidden]
		public _003CFollow_003Ed__47(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60010A0")]
		[Address(RVA = "0x176FBE8", Offset = "0x176FBE8", VA = "0x176FBE8", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60010A1")]
		[Address(RVA = "0x176FBEC", Offset = "0x176FBEC", VA = "0x176FBEC", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60010A2")]
		[Address(RVA = "0x176FD3C", Offset = "0x176FD3C", VA = "0x176FD3C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60010A3")]
		[Address(RVA = "0x176FD44", Offset = "0x176FD44", VA = "0x176FD44", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60010A4")]
		[Address(RVA = "0x176FD84", Offset = "0x176FD84", VA = "0x176FD84", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x400131F")]
	[FieldOffset(Offset = "0x0")]
	private static AudioManager instance;

	[Token(Token = "0x4001320")]
	[FieldOffset(Offset = "0x18")]
	public AudioSources shortEffects;

	[Token(Token = "0x4001321")]
	[FieldOffset(Offset = "0x20")]
	public AudioSources impactEffects;

	[Token(Token = "0x4001322")]
	[FieldOffset(Offset = "0x28")]
	public AudioSources uiEffects;

	[Token(Token = "0x4001323")]
	[FieldOffset(Offset = "0x30")]
	public AudioSources overworldSpatial;

	[Token(Token = "0x4001324")]
	[FieldOffset(Offset = "0x38")]
	public AudioSources ambientEffects;

	[Token(Token = "0x4001325")]
	[FieldOffset(Offset = "0x40")]
	public RumbleManager rumbleManager;

	[Token(Token = "0x4001326")]
	[FieldOffset(Offset = "0x48")]
	public GolfAudioManager golfAudioManager;

	[Token(Token = "0x4001327")]
	[FieldOffset(Offset = "0x50")]
	public AudioSources voices;

	[Token(Token = "0x4001328")]
	[FieldOffset(Offset = "0x58")]
	public AudioMixer musicMixer;

	[Token(Token = "0x4001329")]
	[FieldOffset(Offset = "0x60")]
	public AudioMixer sfxMixer;

	[Token(Token = "0x400132A")]
	[FieldOffset(Offset = "0x68")]
	public AudioMixerSnapshot snapshot3D;

	[Token(Token = "0x400132B")]
	[FieldOffset(Offset = "0x70")]
	public AudioMixerSnapshot snapshot2D;

	[Token(Token = "0x400132C")]
	[FieldOffset(Offset = "0x78")]
	private AmbientAudioPlayer ambient;

	[Token(Token = "0x400132D")]
	[FieldOffset(Offset = "0x80")]
	private GolfAudioManager golfAudio;

	[Token(Token = "0x400132E")]
	[FieldOffset(Offset = "0x88")]
	public MusicManager music;

	[Token(Token = "0x400132F")]
	[FieldOffset(Offset = "0x90")]
	public AmbientAudioPlayer AmbientPlayer;

	[Token(Token = "0x4001330")]
	[FieldOffset(Offset = "0x98")]
	private AudioMixerSnapshot lastMixerSnapshot;

	[Token(Token = "0x4001331")]
	[FieldOffset(Offset = "0xA0")]
	private Dictionary<int, AudioMaterialSettings> audioMatCache;

	[Token(Token = "0x4001332")]
	[FieldOffset(Offset = "0xA8")]
	public int matCacheCount;

	[Token(Token = "0x4001333")]
	[FieldOffset(Offset = "0xB0")]
	public uint[] downloadMusicStates;

	[Token(Token = "0x4001334")]
	public const string SFX_Volume = "SFX_Volume";

	[Token(Token = "0x4001335")]
	public const string Music_Volume = "Music_Volume";

	[Token(Token = "0x4001336")]
	[FieldOffset(Offset = "0xB8")]
	private float enableListenersTimer;

	[Token(Token = "0x4001337")]
	[FieldOffset(Offset = "0xC0")]
	private Coroutine fadeRoutine;

	[Token(Token = "0x170001F5")]
	public static AudioManager Instance
	{
		[Token(Token = "0x6001083")]
		[Address(RVA = "0x1425268", Offset = "0x1425268", VA = "0x1425268")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001F6")]
	public Dictionary<int, AudioMaterialSettings> AudioMatCache
	{
		[Token(Token = "0x6001084")]
		[Address(RVA = "0x142E1F8", Offset = "0x142E1F8", VA = "0x142E1F8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001085")]
	[Address(RVA = "0x142DFC8", Offset = "0x142DFC8", VA = "0x142DFC8")]
	public void Init()
	{
	}

	[Token(Token = "0x6001086")]
	[Address(RVA = "0x142E200", Offset = "0x142E200", VA = "0x142E200")]
	[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x6165C", Offset = "0x6165C")]
	public static void ResetOneshotAssets()
	{
	}

	[Token(Token = "0x6001087")]
	[Address(RVA = "0x142E300", Offset = "0x142E300", VA = "0x142E300")]
	private void Start()
	{
	}

	[Token(Token = "0x6001088")]
	[Address(RVA = "0x142E42C", Offset = "0x142E42C", VA = "0x142E42C")]
	private void Instance_OnLevelWillUnload()
	{
	}

	[Token(Token = "0x6001089")]
	[Address(RVA = "0x142E4A8", Offset = "0x142E4A8", VA = "0x142E4A8")]
	private void Instance_OnLevelLoaded(LevelData data)
	{
	}

	[Token(Token = "0x600108A")]
	[Address(RVA = "0x142E6EC", Offset = "0x142E6EC", VA = "0x142E6EC")]
	public void OnLevelDesignerPlayStart(Camera cam, Transform listenerFollowTarget)
	{
	}

	[Token(Token = "0x600108B")]
	[Address(RVA = "0x142E79C", Offset = "0x142E79C", VA = "0x142E79C")]
	public void OnLevelDesignerReset(Camera cam, Transform listenerFollowTarget)
	{
	}

	[Token(Token = "0x600108C")]
	[Address(RVA = "0x142E80C", Offset = "0x142E80C", VA = "0x142E80C")]
	public bool CheckMaterial(GameObject go, List<AudioMaterial> include, List<AudioMaterial> exclude, bool includeEmpty = false)
	{
		return default;
	}

	[Token(Token = "0x600108D")]
	[Address(RVA = "0x142EAB0", Offset = "0x142EAB0", VA = "0x142EAB0")]
	public bool CheckMaterial(out AudioMaterialSettings setting, GameObject go, List<AudioMaterial> include, List<AudioMaterial> exclude, bool includeEmpty = false)
	{
		return default;
	}

	[Token(Token = "0x600108E")]
	[Address(RVA = "0x142E5E0", Offset = "0x142E5E0", VA = "0x142E5E0")]
	private void UpdateMixerSettings(LevelData leveldata)
	{
	}

	[Token(Token = "0x600108F")]
	[Address(RVA = "0x142EE54", Offset = "0x142EE54", VA = "0x142EE54")]
	public void FadeAllOut(float time)
	{
	}

	[Token(Token = "0x6001090")]
	[Address(RVA = "0x142EFA0", Offset = "0x142EFA0", VA = "0x142EFA0")]
	public void FadeAllIn(float time)
	{
	}

	[Token(Token = "0x6001091")]
	[Address(RVA = "0x142EF08", Offset = "0x142EF08", VA = "0x142EF08")]
	private IEnumerator FadeRoutine(float sfxVolume, float musicVolume, float time)
	{
		return null;
	}

	[Token(Token = "0x6001092")]
	[Address(RVA = "0x142F104", Offset = "0x142F104", VA = "0x142F104")]
	public static void SetMusicGain(float volume)
	{
	}

	[Token(Token = "0x6001093")]
	[Address(RVA = "0x142F1BC", Offset = "0x142F1BC", VA = "0x142F1BC")]
	public static void SetSoundGain(float volume)
	{
	}

	[Token(Token = "0x6001094")]
	[Address(RVA = "0x142ED58", Offset = "0x142ED58", VA = "0x142ED58")]
	public void SetMixerSnapshot(AudioMixerSnapshot snapshot, float time = 0.4f)
	{
	}

	[Token(Token = "0x6001095")]
	[Address(RVA = "0x142F2AC", Offset = "0x142F2AC", VA = "0x142F2AC")]
	public void ResetMixerSnapshot(float time = 0.4f)
	{
	}

	[Token(Token = "0x6001096")]
	[Address(RVA = "0x142F2C8", Offset = "0x142F2C8", VA = "0x142F2C8")]
	public void AudioSourceFollowTransform(AudioSource src, Transform trans, float time)
	{
	}

	[Token(Token = "0x6001097")]
	[Address(RVA = "0x1427648", Offset = "0x1427648", VA = "0x1427648")]
	public IEnumerator Follow(AudioSource src, Transform trans, float time)
	{
		return null;
	}

	[Token(Token = "0x6001098")]
	[Address(RVA = "0x142F410", Offset = "0x142F410", VA = "0x142F410")]
	public AudioManager()
	{
	}
}
