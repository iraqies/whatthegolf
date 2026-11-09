using System;
using System.Collections;
using Core;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
	public string bankName;
	private bool isLoaded;
	private uint playingId;
	private float nextMusicSet;
	private float musicSetInterval = 0.2f;
	private LevelMusicSettings currentMusicSettings;
	private LevelMusic currentLevelMusic;
	private float lastFirstShotTime;
	private float lastMusicStartTime;
	private float musicFadeVolume = 1f;
	private float musicUserVolume = 1f;
	private float musicVolume = 1f;
	private bool masterMute;
	private int strokecount;
	public string currentStateName;
	internal bool useTransition;
	public uint currentStateID;
	private WwisePlayer wwisePlayer;

	public uint lastState { get; private set; }

	private void EnsurePlayer()
	{
		if (wwisePlayer == null)
			wwisePlayer = WwisePlayer.Instance ?? GetComponent<WwisePlayer>() ?? GetComponentInChildren<WwisePlayer>(true);
	}

	public void InitializeBank(Action callback = null, bool startsWithOnboarding = false)
	{
		EnsurePlayer();
		isLoaded = true;
		callback?.Invoke();
	}

	public void InitializeMusic(uint initialState)
	{
		EnsurePlayer();
		lastMusicStartTime = Time.time;
		SetState(initialState, false, null, false);
	}

	public void InitializeMusic()
	{
		EnsurePlayer();
		lastMusicStartTime = Time.time;
		AkSoundEngine.PostEvent(3991942870u, gameObject);
	}

	public bool IsReadyToPlay() => true;

	public void CompleteChallenge()
	{
		AkSoundEngine.PostTrigger(AK.TRIGGERS.WIN_LEVEL, gameObject);
	}

	public void FailChallenge()
	{
		AkSoundEngine.PostTrigger(AK.TRIGGERS.OFF_THE_MAP_SHORT, gameObject);
	}

	public void PostTrigger(StingerData trigger)
	{
		if (trigger != null)
			AkSoundEngine.PostTrigger(trigger.stingerID, gameObject);
	}

	public void PostTrigger(uint trigger)
	{
		AkSoundEngine.PostTrigger(trigger, gameObject);
	}

	public void OnLevelLoaded()
	{
		EnsurePlayer();
		currentLevelMusic = FindObjectOfType<LevelMusic>();
		if (currentLevelMusic != null)
		{
			if (!currentLevelMusic.isInitialized && Level.HasInstance && Level.Instance != null)
			{
				currentLevelMusic.InitializeForCurrentLevel(Level.Instance.Goal, Level.Instance.Ball, Level.Instance);
			}
			CurrentLevelMusic_OnIntialized();
			currentLevelMusic.OnStart -= CurrentLevelMusic_OnStart;
			currentLevelMusic.OnStart += CurrentLevelMusic_OnStart;
			currentLevelMusic.OnShoot -= CurrentLevelMusic_OnShot;
			currentLevelMusic.OnShoot += CurrentLevelMusic_OnShot;
			currentLevelMusic.OnFail -= CurrentLevelMusic_OnFail;
			currentLevelMusic.OnFail += CurrentLevelMusic_OnFail;
			currentLevelMusic.OnAimtStart -= CurrentLevelMusic_OnAimtStart;
			currentLevelMusic.OnAimtStart += CurrentLevelMusic_OnAimtStart;
			currentLevelMusic.OnAimUpdate -= CurrentLevelMusic_OnAimUpdate;
			currentLevelMusic.OnAimUpdate += CurrentLevelMusic_OnAimUpdate;
		}
		if (Level.HasInstance && Level.Instance != null)
		{
			Level.Instance.OnFail -= FallbackLevel_OnFail;
			Level.Instance.OnFail += FallbackLevel_OnFail;
		}
	}

	private void FallbackLevel_OnFail(GolfBallController arg1, string arg2, Level.State state)
	{
		if (currentLevelMusic != null && currentLevelMusic.isInitialized)
			return;
		if (state is Level.FailState fs && !fs.PlayFailSFX)
			return;
		CurrentLevelMusic_OnFail();
	}

	public void OnLevelWillUnload()
	{
		AkSoundEngine.ResetRTPCValue(3695994288u, gameObject, 0, 200f, 4);
		if (currentLevelMusic != null)
		{
			currentLevelMusic.OnStart -= CurrentLevelMusic_OnStart;
			currentLevelMusic.OnShoot -= CurrentLevelMusic_OnShot;
			currentLevelMusic.OnFail -= CurrentLevelMusic_OnFail;
			currentLevelMusic.OnAimtStart -= CurrentLevelMusic_OnAimtStart;
			currentLevelMusic.OnAimUpdate -= CurrentLevelMusic_OnAimUpdate;
		}
		if (Level.HasInstance && Level.Instance != null)
		{
			Level.Instance.OnFail -= FallbackLevel_OnFail;
		}
	}

	private void Start()
	{
		EnsurePlayer();
		AkSoundEngine.PostEvent(4258653052u, gameObject);
		AkSoundEngine.PostEvent(3991942870u, gameObject);
		AkSoundEngine.SetState(694173914u, 2607556080u);
		currentStateID = 2607556080u;
		lastState = 2607556080u;
	}

	private void CurrentLevelMusic_OnIntialized()
	{
		EnsurePlayer();
		if (currentLevelMusic == null) return;
		if (currentLevelMusic.overrideLevelState && !string.IsNullOrEmpty(currentLevelMusic.customWwiseMusicState))
		{
			SetState(currentLevelMusic.customWwiseMusicState);
			return;
		}
		uint stateId = ConvertToStateId(currentLevelMusic.musicPreset);
		if (stateId != 0)
			SetState(stateId);
	}

	private void CurrentLevelMusic_OnAimUpdate(bool isAiming)
	{
	}

	private void CurrentLevelMusic_OnAimtStart(int preStrokeCount)
	{
		AkSoundEngine.PostTrigger(AK.TRIGGERS.START_AIM, gameObject);
	}

	private void CurrentLevelMusic_OnFail()
	{
		EnsurePlayer();
		AkSoundEngine.PostTrigger(AK.TRIGGERS.OFF_THE_MAP_SHORT, gameObject);
		if (currentMusicSettings != null && currentMusicSettings.isSwitchingToBaseMusicOnFail && currentMusicSettings.baseMusicData != null)
		{
			SetState(currentMusicSettings.baseMusicData.state, false, null, false);
		}
	}

	private void CurrentLevelMusic_OnGoal()
	{
	}

	private void CurrentLevelMusic_OnShot(int preStrokeCount)
	{
		strokecount = preStrokeCount + 1;
		if (preStrokeCount == 0)
		{
			lastFirstShotTime = Time.time;
			AkSoundEngine.PostTrigger(AK.TRIGGERS.TEE, gameObject);
			if (currentMusicSettings != null && currentMusicSettings.isSwitchingToAlternativeMusicOnFirstShot && currentMusicSettings.alternativeMusic != null)
			{
				SetState(currentMusicSettings.alternativeMusic.state, false, null, false);
			}
		}
		else
		{
			AkSoundEngine.PostTrigger(AK.TRIGGERS.PUTT, gameObject);
		}
		AkSoundEngine.PostTrigger(AK.TRIGGERS.STROKE, gameObject);
	}

	private void CurrentLevelMusic_OnStart()
	{
		strokecount = 0;
		AkSoundEngine.PostTrigger(AK.TRIGGERS.RESET_ROUND, gameObject);
	}

	private void Update()
	{
	}

	private uint ConvertToStateId(LevelMusic.LevelMusicPreset musicPreset)
	{
		switch (musicPreset)
		{
			case LevelMusic.LevelMusicPreset.Silent: return 1171021210u;
			case LevelMusic.LevelMusicPreset.Lab: return 318868755u;
			case LevelMusic.LevelMusicPreset.Green: return 3525279660u;
			case LevelMusic.LevelMusicPreset.Sport: return 4118986117u;
			case LevelMusic.LevelMusicPreset.Gravity: return 3118824634u;
			case LevelMusic.LevelMusicPreset.Toast: return 1463504632u;
			case LevelMusic.LevelMusicPreset.Blue: return 1995628048u;
			case LevelMusic.LevelMusicPreset.Portal: return 3369439804u;
			case LevelMusic.LevelMusicPreset.Secret: return 3712611991u;
			case LevelMusic.LevelMusicPreset.Factory: return 2266810402u;
			case LevelMusic.LevelMusicPreset.Desert: return 1850388778u;
			case LevelMusic.LevelMusicPreset.Western: return 2817946958u;
			case LevelMusic.LevelMusicPreset.Winter: return 2376621319u;
			case LevelMusic.LevelMusicPreset.Hell: return 2954777512u;
			case LevelMusic.LevelMusicPreset.Space: return 881962004u;
			case LevelMusic.LevelMusicPreset.Computer: return 3882369967u;
			default: return 0u;
		}
	}

	public static string GetStateName(uint wwiseState) => wwiseState.ToString();
	public float GetLevelMusicRTPC() => 0f;
	public float GetRTPCValueRaw(uint rtpcID) => 0f;
	public void SetClosingIn(float value, int tweenTimeMs) { }
	public void SetLevelMusicRTPC(float rtpcValue, int time) => AkSoundEngine.SetRTPCValue(3695994288u, rtpcValue);
	public void SetOverwroldRTCP(uint rtcp, float rtcpValue) => AkSoundEngine.SetRTPCValue(rtcp, rtcpValue);
	public void setRTCPRaw(uint rtcp, float rtcpValue, int time) => AkSoundEngine.SetRTPCValue(rtcp, rtcpValue);

	public void SetLevelMusic(LevelMusicSettings music, float rtcpStart, bool ignoreTransition = false, Action onLoaded = null)
	{
		currentMusicSettings = music;
		lastMusicStartTime = Time.time;
		if (music != null && music.baseMusicData != null)
		{
			SetState(music.baseMusicData.state, false, onLoaded, ignoreTransition);
		}
		else
		{
			onLoaded?.Invoke();
		}
	}

	public void SetLevelMusic(LevelMusicSettings music, bool ignoreTransition = false, Action onLoaded = null)
	{
		SetLevelMusic(music, music != null ? music.RTCPStart : 0f, ignoreTransition, onLoaded);
	}

	public void SetStateChange(MusicData musicOverworldWithTransition)
	{
		if (musicOverworldWithTransition != null)
			SetState(musicOverworldWithTransition.state, false, null, false);
	}

	public void PlayFinalBattleMusic() => SetState("Final_Battle");
	public void SetMenuMusic() => SetState(2607556080u);
	public void StopMusic() => AkSoundEngine.PostEvent(4258653052u, gameObject);

	public void SetState(string state)
	{
		if (string.IsNullOrEmpty(state)) return;
		currentStateName = state;
		SetState(AkSoundEngine.GetIDFromString(state));
	}

	public void SetState(uint stateID)
	{
		SetState(stateID, false, null, false);
	}

	public void SetState(uint wwiseState, bool fromLoading, Action onLoaded = null, bool ignoreTransition = false)
	{
		EnsurePlayer();
		currentStateID = wwiseState;
		lastState = wwiseState;
		AkSoundEngine.SetState(694173914u, wwiseState);
		onLoaded?.Invoke();
	}

	public void SetGain(float fadeVolume)
	{
		musicFadeVolume = fadeVolume;
		FadeVolume(musicFadeVolume * musicUserVolume, 0f);
	}

	public void FadeVolume(float volume, float fadeSeconds = 0f)
	{
		EnsurePlayer();
		if (wwisePlayer != null && wwisePlayer.CurrentSource != null)
			wwisePlayer.CurrentSource.volume = Mathf.Clamp01(volume);
	}

	public void ResetVolume(float fadeSeconds = 0f) => FadeVolume(1f, fadeSeconds);

	public void SetUserVolume(float userVolume)
	{
		musicUserVolume = userVolume;
		FadeVolume(musicFadeVolume * musicUserVolume, 0f);
	}

	public bool ToggleMuteMusic()
	{
		masterMute = !masterMute;
		FadeVolume(masterMute ? 0f : (musicFadeVolume * musicUserVolume), 0f);
		return masterMute;
	}
}
