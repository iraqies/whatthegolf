using Audio;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20003AE")]
[Attribute(Name = "RequireComponent", RVA = "0x3F72C", Offset = "0x3F72C")]
public class OnboardingMusic : MonoBehaviour
{
	[Token(Token = "0x400144C")]
	[FieldOffset(Offset = "0x18")]
	public AmbientAudio onboardingAmbient;

	[Token(Token = "0x400144D")]
	[FieldOffset(Offset = "0x20")]
	public LevelMusicSettings onboardingMusic;

	[Token(Token = "0x400144E")]
	[FieldOffset(Offset = "0x28")]
	public bool useSettingFromLevelData;

	[Token(Token = "0x400144F")]
	[FieldOffset(Offset = "0x30")]
	private Onboarding onboarding;

	[Token(Token = "0x6001171")]
	[Address(RVA = "0x159BA0C", Offset = "0x159BA0C", VA = "0x159BA0C")]
	private void Start()
	{
	}

	[Token(Token = "0x6001172")]
	[Address(RVA = "0x159BD98", Offset = "0x159BD98", VA = "0x159BD98")]
	private void Onboarding_OnReadyForMusic()
	{
	}

	[Token(Token = "0x6001173")]
	[Address(RVA = "0x159BEC4", Offset = "0x159BEC4", VA = "0x159BEC4")]
	private void Onboarding_OnOnboardingCompleted()
	{
	}

	[Token(Token = "0x6001174")]
	[Address(RVA = "0x159C0C4", Offset = "0x159C0C4", VA = "0x159C0C4")]
	private void Onboarding_OnOnboardingLevelChanged(LevelData level)
	{
	}

	[Token(Token = "0x6001175")]
	[Address(RVA = "0x159C130", Offset = "0x159C130", VA = "0x159C130")]
	private void Onboarding_OnboardingProgressChanged(float pct, int levelIndex)
	{
	}

	[Token(Token = "0x6001176")]
	[Address(RVA = "0x159C1A0", Offset = "0x159C1A0", VA = "0x159C1A0")]
	public OnboardingMusic()
	{
	}

	[Token(Token = "0x6001177")]
	[Address(RVA = "0x159C1A8", Offset = "0x159C1A8", VA = "0x159C1A8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6199C", Offset = "0x6199C")]
	private void _003COnboarding_OnReadyForMusic_003Eb__5_0()
	{
	}
}
