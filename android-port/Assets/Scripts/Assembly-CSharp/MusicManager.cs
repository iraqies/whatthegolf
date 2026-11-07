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

	private float musicSetInterval;

	private LevelMusicSettings currentMusicSettings;

	private LevelMusic currentLevelMusic;

	private float lastFirstShotTime;

	private float lastMusicStartTime;

	private float musicFadeVolume;

	private float musicUserVolume;

	private float musicVolume;

	private bool masterMute;

	private int strokecount;

	public string currentStateName;

	internal bool useTransition;

	public uint lastState { get; private set; }

	public void InitializeBank(Action callback = null, bool startsWithOnboarding = false)
	{
	}

	public void FailChallenge()
	{
	}

	public void CompleteChallenge()
	{
	}

	public void PostTrigger(uint trigger)
	{
	}

	public void PostTrigger(StingerData trigger)
	{
	}

	public void SetUserVolume(float userVolume)
	{
	}

	public void SetGain(float fadeVolume)
	{
	}

	private void UpdateMixerVolume()
	{
	}

	private IEnumerator SlowFixedUpdate()
	{
		return null;
	}

	public void OnLevelWillUnload()
	{
	}

	public void OnLevelLoaded()
	{
	}

	private void CurrentLevelMusic_OnAimtStart(int preStrokeCount)
	{
	}

	private void CurrentLevelMusic_OnStart()
	{
	}

	private void CurrentLevelMusic_OnShot(int preStrokeCount)
	{
	}

	private void CurrentLevelMusic_OnFail()
	{
	}

	private void CurrentLevelMusic_OnAimUpdate(bool isAiming)
	{
	}

	private void Update()
	{
	}

	public bool ToggleMuteMusic()
	{
		return false;
	}

	private void SetAiming(float value)
	{
	}

	public void SetOverwroldRTCP(uint rtcp, float rtcpValue)
	{
	}

	public void setRTCPRaw(uint rtcp, float rtcpValue, int time)
	{
	}

	public void SetLevelMusicRTPC(float rtpcValue, int time)
	{
	}

	public float GetLevelMusicRTPC()
	{
		return 0f;
	}

	public float GetRTPCValueRaw(uint rtpcID)
	{
		return 0f;
	}

	private void SetBasic(float value, int tweenTime)
	{
	}

	public void SetClosingIn(float value, int tweenTimeMs)
	{
	}

	public void InitializeMusic()
	{
	}

	public void InitializeMusic(uint initialState)
	{
	}

	public static string GetStateName(uint wwiseState)
	{
		return null;
	}

	public void SetState(uint wwiseState, bool fromLoading, Action onLoaded = null, bool ignoreTransition = false)
	{
	}

	public void SetStateChange(MusicData musicOverworldWithTransition)
	{
	}

	public void SetLevelMusic(LevelMusicSettings music, float rtcpStart, bool ignoreTransition = false, Action onLoaded = null)
	{
	}

	public void SetLevelMusic(LevelMusicSettings music, bool ignoreTransition = false, Action onLoaded = null)
	{
	}

	public bool IsReadyToPlay()
	{
		return false;
	}
}
