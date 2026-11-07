using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20003D8")]
[Attribute(Name = "RequireComponent", RVA = "0x3F84C", Offset = "0x3F84C")]
public class SimpleSamplerVoice : MonoBehaviour
{
	[Token(Token = "0x4001515")]
	[FieldOffset(Offset = "0x18")]
	private AudioSource _audioSource;

	[Token(Token = "0x600121A")]
	[Address(RVA = "0x16AF458", Offset = "0x16AF458", VA = "0x16AF458")]
	public void Play(AudioClip audioClip, double startTime)
	{
	}

	[Token(Token = "0x600121B")]
	[Address(RVA = "0x16AF4B4", Offset = "0x16AF4B4", VA = "0x16AF4B4")]
	private void Awake()
	{
	}

	[Token(Token = "0x600121C")]
	[Address(RVA = "0x16AF510", Offset = "0x16AF510", VA = "0x16AF510")]
	public SimpleSamplerVoice()
	{
	}
}
