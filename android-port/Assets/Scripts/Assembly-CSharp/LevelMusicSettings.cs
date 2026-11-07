using System;
using Core;

[Serializable]
public class LevelMusicSettings
{
	public MusicData baseMusicData;

	public float RTCPStart;

	public bool isIncrementingRTCPAfterFirstShot;

	public float RTCPAfterFirstShot;

	public bool isIncrementingRTCPTowardsGoal;

	public float RTCPAtGoal;

	public bool isIncrementingRTPCOnEveryShot;

	public float RTPCIncrementPerShot;

	public bool isIncrementingOverTime;

	public float RTPCIncrementOverTime;

	public float RTPCMax;

	public bool isSwitchingToAlternativeMusicOnFirstShot;

	public MusicData alternativeMusic;

	public float alternativeMusicRTCP;

	public bool isSwitchingToBaseMusicOnFail;

	public bool isUsingCustomOverworldMusic;

	public OverworldMusicData customReturnMusic;
}
