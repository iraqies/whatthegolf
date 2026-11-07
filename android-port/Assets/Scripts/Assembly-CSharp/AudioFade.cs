using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200037C")]
public class AudioFade : MonoBehaviour
{
	[Token(Token = "0x4001317")]
	[FieldOffset(Offset = "0x18")]
	private float m_volumeIncrement;

	[Token(Token = "0x4001318")]
	[FieldOffset(Offset = "0x1C")]
	private int m_sampleRate;

	[Token(Token = "0x4001319")]
	[FieldOffset(Offset = "0x20")]
	private float m_gain;

	[Token(Token = "0x400131A")]
	[FieldOffset(Offset = "0x24")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4CD00", Offset = "0x4CD00")]
	private bool Fading__BackingField;

	[Token(Token = "0x400131B")]
	[FieldOffset(Offset = "0x25")]
	private bool fadeOut;

	[Token(Token = "0x170001F4")]
	public bool Fading
	{
		[Token(Token = "0x6001077")]
		[Address(RVA = "0x142D554", Offset = "0x142D554", VA = "0x142D554")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6163C", Offset = "0x6163C")]
		get
		{
			return default;
		}
		[Token(Token = "0x6001078")]
		[Address(RVA = "0x142D55C", Offset = "0x142D55C", VA = "0x142D55C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6164C", Offset = "0x6164C")]
		private set
		{
		}
	}

	[Token(Token = "0x6001079")]
	[Address(RVA = "0x142D564", Offset = "0x142D564", VA = "0x142D564")]
	private void Start()
	{
	}

	[Token(Token = "0x600107A")]
	[Address(RVA = "0x142D58C", Offset = "0x142D58C", VA = "0x142D58C")]
	public void FadeIn(float time)
	{
	}

	[Token(Token = "0x600107B")]
	[Address(RVA = "0x142D5DC", Offset = "0x142D5DC", VA = "0x142D5DC")]
	public void FadeOut(float time)
	{
	}

	[Token(Token = "0x600107C")]
	[Address(RVA = "0x142D62C", Offset = "0x142D62C", VA = "0x142D62C")]
	public void Reset()
	{
	}

	[Token(Token = "0x600107D")]
	[Address(RVA = "0x142D63C", Offset = "0x142D63C", VA = "0x142D63C")]
	private void SetLevel()
	{
	}

	[Token(Token = "0x600107E")]
	[Address(RVA = "0x142D688", Offset = "0x142D688", VA = "0x142D688")]
	private void OnAudioFilterRead(float[] buffer, int numChannels)
	{
	}

	[Token(Token = "0x600107F")]
	[Address(RVA = "0x142D77C", Offset = "0x142D77C", VA = "0x142D77C")]
	public AudioFade()
	{
	}
}
