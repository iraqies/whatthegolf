using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20003D6")]
[Attribute(Name = "RequireComponent", RVA = "0x3F7E4", Offset = "0x3F7E4")]
public class SamplerVoice : MonoBehaviour
{
	[Token(Token = "0x400150C")]
	[FieldOffset(Offset = "0x18")]
	private readonly ASREnvelope _envelope;

	[Token(Token = "0x400150D")]
	[FieldOffset(Offset = "0x20")]
	private AudioSource _audioSource;

	[Token(Token = "0x400150E")]
	[FieldOffset(Offset = "0x28")]
	private uint _samplesUntilEnvelopeTrigger;

	[Token(Token = "0x6001211")]
	[Address(RVA = "0x1669EE4", Offset = "0x1669EE4", VA = "0x1669EE4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001212")]
	[Address(RVA = "0x1669DCC", Offset = "0x1669DCC", VA = "0x1669DCC")]
	public void Play(AudioClip audioClip, float pitch, double startTime, double attackTime, double sustainTime, double releaseTime)
	{
	}

	[Token(Token = "0x6001213")]
	[Address(RVA = "0x1669F40", Offset = "0x1669F40", VA = "0x1669F40")]
	private void OnAudioFilterRead(float[] buffer, int numChannels)
	{
	}

	[Token(Token = "0x6001214")]
	[Address(RVA = "0x166A034", Offset = "0x166A034", VA = "0x166A034")]
	public SamplerVoice()
	{
	}
}
