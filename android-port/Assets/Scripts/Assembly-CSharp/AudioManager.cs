using System.Collections;
using System.Collections.Generic;
using Audio;
using Audio.Rumble;
using Core;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
	private static AudioManager instance;

	public AudioSources shortEffects;

	public AudioSources impactEffects;

	public AudioSources uiEffects;

	public AudioSources overworldSpatial;

	public AudioSources ambientEffects;

	public RumbleManager rumbleManager;

	public GolfAudioManager golfAudioManager;

	public AudioSources voices;

	public AudioMixer musicMixer;

	public AudioMixer sfxMixer;

	public AudioMixerSnapshot snapshot3D;

	public AudioMixerSnapshot snapshot2D;

	private AmbientAudioPlayer ambient;

	private GolfAudioManager golfAudio;

	public MusicManager music;

	public AmbientAudioPlayer AmbientPlayer;

	private AudioMixerSnapshot lastMixerSnapshot;

	private Dictionary<int, AudioMaterialSettings> audioMatCache;

	public int matCacheCount;

	public uint[] downloadMusicStates;

	public const string SFX_Volume = "SFX_Volume";

	public const string Music_Volume = "Music_Volume";

	private float enableListenersTimer;

	private Coroutine fadeRoutine;

	public static AudioManager Instance => null;

	public Dictionary<int, AudioMaterialSettings> AudioMatCache => null;

	public void Init()
	{
	}

	[RuntimeInitializeOnLoadMethod]
	public static void ResetOneshotAssets()
	{
	}

	private void Start()
	{
	}

	private void Instance_OnLevelWillUnload()
	{
	}

	private void Instance_OnLevelLoaded(LevelData data)
	{
	}

	public void OnLevelDesignerPlayStart(Camera cam, Transform listenerFollowTarget)
	{
	}

	public void OnLevelDesignerReset(Camera cam, Transform listenerFollowTarget)
	{
	}

	public bool CheckMaterial(GameObject go, List<AudioMaterial> include, List<AudioMaterial> exclude, bool includeEmpty = false)
	{
		return false;
	}

	public bool CheckMaterial(out AudioMaterialSettings setting, GameObject go, List<AudioMaterial> include, List<AudioMaterial> exclude, bool includeEmpty = false)
	{
		setting = null;
		return false;
	}

	private void UpdateMixerSettings(LevelData leveldata)
	{
	}

	public void FadeAllOut(float time)
	{
	}

	public void FadeAllIn(float time)
	{
	}

	private IEnumerator FadeRoutine(float sfxVolume, float musicVolume, float time)
	{
		return null;
	}

	public static void SetMusicGain(float volume)
	{
	}

	public static void SetSoundGain(float volume)
	{
	}

	public void SetMixerSnapshot(AudioMixerSnapshot snapshot, float time = 0.4f)
	{
	}

	public void ResetMixerSnapshot(float time = 0.4f)
	{
	}

	public void AudioSourceFollowTransform(AudioSource src, Transform trans, float time)
	{
	}

	public IEnumerator Follow(AudioSource src, Transform trans, float time)
	{
		return null;
	}
}
