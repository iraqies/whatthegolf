using System.Collections;
using System.Collections.Generic;
using Audio;
using Audio.Rumble;
using Core;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

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
	private Dictionary<int, AudioMaterialSettings> audioMatCache = new Dictionary<int, AudioMaterialSettings>();
	public int matCacheCount;
	public uint[] downloadMusicStates;
	public const string SFX_Volume = "SFX_Volume";
	public const string Music_Volume = "Music_Volume";
	private float enableListenersTimer;
	private Coroutine fadeRoutine;

	public static AudioManager Instance
	{
		get
		{
			if (instance == null)
			{
				instance = FindObjectOfType<AudioManager>();
				if (instance == null)
				{
					var prefab = Resources.Load<AudioManager>("Prefabs/Audiomanager")
						?? Resources.Load<AudioManager>("Prefabs/AudioManager")
						?? Resources.Load<AudioManager>("Audiomanager");
					if (prefab != null)
					{
						instance = Instantiate(prefab);
					}
					else
					{
						var go = new GameObject("AudioManager");
						instance = go.AddComponent<AudioManager>();
					}
					DontDestroyOnLoad(instance.gameObject);
					instance.Init();
				}
			}
			return instance;
		}
	}

	public Dictionary<int, AudioMaterialSettings> AudioMatCache => audioMatCache;

	private AudioSources EnsurePool(ref AudioSources field, string childName)
	{
		if (field != null) return field;
		var t = transform.Find(childName);
		if (t != null) field = t.GetComponent<AudioSources>();
		if (field == null)
		{
			var go = new GameObject(childName);
			go.transform.SetParent(transform, false);
			field = go.AddComponent<AudioSources>();
		}
		return field;
	}

	public void Init()
	{
		instance = this;
		EnsurePool(ref shortEffects, "short");
		EnsurePool(ref impactEffects, "impacts");
		EnsurePool(ref uiEffects, "uiSFX");
		EnsurePool(ref overworldSpatial, "overworldSpatial");
		EnsurePool(ref ambientEffects, "ambientShort");
		EnsurePool(ref voices, "nonScaled");
		if (AmbientPlayer == null)
			AmbientPlayer = GetComponentInChildren<AmbientAudioPlayer>(true) ?? gameObject.AddComponent<AmbientAudioPlayer>();
		ambient = AmbientPlayer;
		if (golfAudioManager == null)
			golfAudioManager = GetComponentInChildren<GolfAudioManager>(true);
		golfAudio = golfAudioManager;
		if (music == null)
			music = GetComponentInChildren<MusicManager>(true) ?? gameObject.AddComponent<MusicManager>();
		AudioListener.volume = 1f;
		AudioListener.pause = false;
	}

	[RuntimeInitializeOnLoadMethod]
	public static void ResetOneshotAssets()
	{
		instance = null;
	}

	private void Awake()
	{
		if (instance != null && instance != this)
		{
			Destroy(gameObject);
			return;
		}
		instance = this;
		DontDestroyOnLoad(gameObject);
		Init();
		SceneManager.sceneLoaded += OnSceneLoaded;
	}

	private void OnDestroy()
	{
		SceneManager.sceneLoaded -= OnSceneLoaded;
	}

	private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
	{
		if (FindObjectOfType<AudioListener>() == null && Camera.main != null)
			Camera.main.gameObject.AddComponent<AudioListener>();
		AmbientPlayer?.InitializeNewScene();
		golfAudioManager?.InitializeNewScene();
	}

	private void Start() => Init();
	private void Instance_OnLevelWillUnload() => music?.OnLevelWillUnload();
	private void Instance_OnLevelLoaded(LevelData data) => music?.OnLevelLoaded();
	public void OnLevelDesignerPlayStart(Camera cam, Transform listenerFollowTarget) { }
	public void OnLevelDesignerReset(Camera cam, Transform listenerFollowTarget) { }

	public bool CheckMaterial(GameObject go, List<AudioMaterial> include, List<AudioMaterial> exclude, bool includeEmpty = false) => true;

	public bool CheckMaterial(out AudioMaterialSettings setting, GameObject go, List<AudioMaterial> include, List<AudioMaterial> exclude, bool includeEmpty = false)
	{
		setting = go != null ? go.GetComponentInParent<AudioMaterialSettings>() : null;
		return true;
	}

	private void UpdateMixerSettings(LevelData leveldata) { }
	public void FadeAllOut(float time) { }
	public void FadeAllIn(float time) { }

	private IEnumerator FadeRoutine(float sfxVolume, float musicVolume, float time)
	{
		yield break;
	}

	public static void SetMusicGain(float volume)
	{
		if (Instance != null && Instance.music != null)
			Instance.music.SetUserVolume(volume);
	}

	public static void SetSoundGain(float volume)
	{
		AudioListener.volume = Mathf.Clamp01(volume);
	}

	public void SetMixerSnapshot(AudioMixerSnapshot snapshot, float time = 0.4f) { }
	public void ResetMixerSnapshot(float time = 0.4f) { }
	public void AudioSourceFollowTransform(AudioSource src, Transform trans, float time) { }

	public IEnumerator Follow(AudioSource src, Transform trans, float time)
	{
		yield break;
	}
}
