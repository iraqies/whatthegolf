using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20003D5")]
public class Sampler : MonoBehaviour
{
	[Token(Token = "0x4001504")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private StepSequencer _sequencer;

	[Token(Token = "0x4001505")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private AudioClip _audioClip;

	[Token(Token = "0x4001506")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "RangeAttribute", RVA = "0x4D2A4", Offset = "0x4D2A4")]
	[SerializeField]
	private double _attackTime;

	[Token(Token = "0x4001507")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "RangeAttribute", RVA = "0x4D2E4", Offset = "0x4D2E4")]
	[SerializeField]
	private double _releaseTime;

	[Token(Token = "0x4001508")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "RangeAttribute", RVA = "0x4D324", Offset = "0x4D324")]
	[SerializeField]
	private int _numVoices;

	[Token(Token = "0x4001509")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private SamplerVoice _samplerVoicePrefab;

	[Token(Token = "0x400150A")]
	[FieldOffset(Offset = "0x48")]
	private SamplerVoice[] _samplerVoices;

	[Token(Token = "0x400150B")]
	[FieldOffset(Offset = "0x50")]
	private int _nextVoiceIndex;

	[Token(Token = "0x600120B")]
	[Address(RVA = "0x1669970", Offset = "0x1669970", VA = "0x1669970")]
	public void SetRelease(double _release)
	{
	}

	[Token(Token = "0x600120C")]
	[Address(RVA = "0x1669978", Offset = "0x1669978", VA = "0x1669978")]
	private void Start()
	{
	}

	[Token(Token = "0x600120D")]
	[Address(RVA = "0x1669AFC", Offset = "0x1669AFC", VA = "0x1669AFC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600120E")]
	[Address(RVA = "0x1669BEC", Offset = "0x1669BEC", VA = "0x1669BEC")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600120F")]
	[Address(RVA = "0x1669CDC", Offset = "0x1669CDC", VA = "0x1669CDC")]
	private void HandleTicked(double tickTime, int midiNoteNumber, double duration)
	{
	}

	[Token(Token = "0x6001210")]
	[Address(RVA = "0x1669ED4", Offset = "0x1669ED4", VA = "0x1669ED4")]
	public Sampler()
	{
	}
}
