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
	private bool subscribedToLevelManager;

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

	public AudioSources sfx => shortEffects;
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

	private void EnsureLevelManagerSubscription()
	{
		if (!subscribedToLevelManager && LevelManager.Exists && LevelManager.Instance != null)
		{
			LevelManager.Instance.OnLevelLoaded -= Instance_OnLevelLoaded;
			LevelManager.Instance.OnLevelLoaded += Instance_OnLevelLoaded;
			LevelManager.Instance.OnLevelWillUnload -= Instance_OnLevelWillUnload;
			LevelManager.Instance.OnLevelWillUnload += Instance_OnLevelWillUnload;
			subscribedToLevelManager = true;
		}
	}

	public void Init()
	{
		instance = this;
		MainAudioListener.CreateInstanceIfNeeded();
		if (audioMatCache == null)
			audioMatCache = new Dictionary<int, AudioMaterialSettings>();
		transform.parent = null;
		DontDestroyOnLoad(gameObject);
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
		EnsureLevelManagerSubscription();
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
		EnsureLevelManagerSubscription();
		if (FindObjectOfType<AudioListener>() == null && Camera.main != null)
			Camera.main.gameObject.AddComponent<AudioListener>();
		AmbientPlayer?.InitializeNewScene();
		golfAudioManager?.InitializeNewScene();
		music?.OnLevelLoaded();
	}

	private void Start()
	{
		if (instance != null && instance != this)
		{
			Destroy(gameObject);
			return;
		}
		Init();
	}

	private void Instance_OnLevelWillUnload()
	{
		music?.OnLevelWillUnload();
		golfAudio?.OnLevelWillUnload();
		audioMatCache?.Clear();
		matCacheCount = 0;
	}

	private void Instance_OnLevelLoaded(LevelData data)
	{
		music?.OnLevelLoaded();
		ambient?.InitializeNewScene();
		golfAudio?.InitializeNewScene();
		if (audioMatCache != null)
		{
			audioMatCache.Clear();
			matCacheCount = audioMatCache.Count;
		}
		UpdateMixerSettings(data);
	}

	public void OnLevelDesignerPlayStart(Camera cam, Transform listenerFollowTarget)
	{
		golfAudio?.InitializeNewScene();
		audioMatCache?.Clear();
		matCacheCount = 0;
	}

	public void OnLevelDesignerReset(Camera cam, Transform listenerFollowTarget)
	{
		golfAudio?.OnLevelDesignerReset();
	}

	public bool CheckMaterial(GameObject go, List<AudioMaterial> include, List<AudioMaterial> exclude, bool includeEmpty = false)
	{
		return CheckMaterial(out _, go, include, exclude, includeEmpty);
	}

	public bool CheckMaterial(out AudioMaterialSettings setting, GameObject go, List<AudioMaterial> include, List<AudioMaterial> exclude, bool includeEmpty = false)
	{
		setting = null;
		if (go == null) return includeEmpty;
		int key = go.GetHashCode();
		if (audioMatCache != null && audioMatCache.ContainsKey(key))
		{
			setting = audioMatCache[key];
		}
		else
		{
			setting = go.GetComponent<AudioMaterialSettings>() ?? go.GetComponentInParent<AudioMaterialSettings>();
			if (audioMatCache != null)
			{
				audioMatCache.Add(key, setting);
				matCacheCount = audioMatCache.Count;
			}
		}

		if (setting == null)
			return includeEmpty;

		List<AudioMaterial> mats = setting.GetMaterials;
		if (mats == null)
			return includeEmpty;

		if (include != null && include.Count >= 1)
		{
			for (int i = 0; i < include.Count; i++)
			{
				if (!mats.Contains(include[i]))
					return false;
			}
		}

		if (exclude != null && exclude.Count >= 1)
		{
			for (int i = 0; i < exclude.Count; i++)
			{
				if (mats.Contains(exclude[i]))
					return false;
			}
		}

		return true;
	}

	private void UpdateMixerSettings(LevelData leveldata)
	{
		if (leveldata == null) return;
		AudioMixerSnapshot snap = leveldata.GetWindowType() == 0 ? snapshot2D : snapshot3D;
		SetMixerSnapshot(snap, 1f);
	}

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

	public void SetMixerSnapshot(AudioMixerSnapshot snapshot, float time = 0.4f)
	{
		if (snapshot != null)
		{
			if (snapshot.audioMixer == sfxMixer)
				lastMixerSnapshot = snapshot;
			snapshot.TransitionTo(time);
		}
	}

	public void ResetMixerSnapshot(float time = 0.4f)
	{
		if (snapshot3D != null)
			snapshot3D.TransitionTo(time);
	}

	public void AudioSourceFollowTransform(AudioSource src, Transform trans, float time)
	{
		if (time > 0.1f && src != null && trans != null)
			StartCoroutine(Follow(src, trans, time));
	}

	public IEnumerator Follow(AudioSource src, Transform trans, float time)
	{
		float elapsed = 0f;
		while (elapsed < time && src != null && trans != null)
		{
			src.transform.position = trans.position;
			elapsed += Time.deltaTime;
			yield return null;
		}
	}
}
