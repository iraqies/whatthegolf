using System;
using Core;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x2000934")]
public class LevelMusicSettings
{
	[Token(Token = "0x4003233")]
	[FieldOffset(Offset = "0x10")]
	public MusicData baseMusicData;

	[Token(Token = "0x4003234")]
	[FieldOffset(Offset = "0x18")]
	public float RTCPStart;

	[Token(Token = "0x4003235")]
	[FieldOffset(Offset = "0x1C")]
	public bool isIncrementingRTCPAfterFirstShot;

	[Token(Token = "0x4003236")]
	[FieldOffset(Offset = "0x20")]
	public float RTCPAfterFirstShot;

	[Token(Token = "0x4003237")]
	[FieldOffset(Offset = "0x24")]
	public bool isIncrementingRTCPTowardsGoal;

	[Token(Token = "0x4003238")]
	[FieldOffset(Offset = "0x28")]
	public float RTCPAtGoal;

	[Token(Token = "0x4003239")]
	[FieldOffset(Offset = "0x2C")]
	public bool isIncrementingRTPCOnEveryShot;

	[Token(Token = "0x400323A")]
	[FieldOffset(Offset = "0x30")]
	public float RTPCIncrementPerShot;

	[Token(Token = "0x400323B")]
	[FieldOffset(Offset = "0x34")]
	public bool isIncrementingOverTime;

	[Token(Token = "0x400323C")]
	[FieldOffset(Offset = "0x38")]
	public float RTPCIncrementOverTime;

	[Token(Token = "0x400323D")]
	[FieldOffset(Offset = "0x3C")]
	public float RTPCMax;

	[Token(Token = "0x400323E")]
	[FieldOffset(Offset = "0x40")]
	public bool isSwitchingToAlternativeMusicOnFirstShot;

	[Token(Token = "0x400323F")]
	[FieldOffset(Offset = "0x48")]
	public MusicData alternativeMusic;

	[Token(Token = "0x4003240")]
	[FieldOffset(Offset = "0x50")]
	public float alternativeMusicRTCP;

	[Token(Token = "0x4003241")]
	[FieldOffset(Offset = "0x54")]
	public bool isSwitchingToBaseMusicOnFail;

	[Token(Token = "0x4003242")]
	[FieldOffset(Offset = "0x55")]
	public bool isUsingCustomOverworldMusic;

	[Token(Token = "0x4003243")]
	[FieldOffset(Offset = "0x58")]
	public OverworldMusicData customReturnMusic;

	[Token(Token = "0x6002A9E")]
	[Address(RVA = "0x15308B4", Offset = "0x15308B4", VA = "0x15308B4")]
	public LevelMusicSettings()
	{
	}
}
