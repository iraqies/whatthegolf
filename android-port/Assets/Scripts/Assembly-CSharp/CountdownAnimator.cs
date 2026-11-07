using System;
using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20000BB")]
public class CountdownAnimator : MonoBehaviour
{
	[Token(Token = "0x40002EF")]
	[FieldOffset(Offset = "0x18")]
	public Animator Animator;

	[Token(Token = "0x40002F0")]
	[FieldOffset(Offset = "0x20")]
	public Vector2 AmountOfBeepsBetween;

	[Token(Token = "0x40002F1")]
	[FieldOffset(Offset = "0x28")]
	public string LastAnimationStateName;

	[Token(Token = "0x40002F2")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private ClipSettingsCollection BeepClip;

	[Token(Token = "0x40002F3")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private ClipSettingsCollection LastBeepClip;

	[Token(Token = "0x40002F4")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private ClipSettingsCollection IntroClip;

	[Token(Token = "0x40002F5")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private ClipSettingsCollection OutroClip;

	[Token(Token = "0x40002F6")]
	[FieldOffset(Offset = "0x50")]
	public Action OnBeep;

	[Token(Token = "0x40002F7")]
	[FieldOffset(Offset = "0x58")]
	public Action OnLastBeep;

	[Token(Token = "0x6000337")]
	[Address(RVA = "0x18BA6B8", Offset = "0x18BA6B8", VA = "0x18BA6B8")]
	public void PlayBeep()
	{
	}

	[Token(Token = "0x6000338")]
	[Address(RVA = "0x18BA714", Offset = "0x18BA714", VA = "0x18BA714")]
	public void LastBeep()
	{
	}

	[Token(Token = "0x6000339")]
	[Address(RVA = "0x18BA770", Offset = "0x18BA770", VA = "0x18BA770")]
	public void PlayIntroSound()
	{
	}

	[Token(Token = "0x600033A")]
	[Address(RVA = "0x18BA7AC", Offset = "0x18BA7AC", VA = "0x18BA7AC")]
	public void PlayOutroSound()
	{
	}

	[Token(Token = "0x600033B")]
	[Address(RVA = "0x18BA7E8", Offset = "0x18BA7E8", VA = "0x18BA7E8")]
	public CountdownAnimator()
	{
	}
}
