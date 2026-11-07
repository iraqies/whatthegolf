using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20003D7")]
public class SimpleSampler : MonoBehaviour
{
	[Token(Token = "0x400150F")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private SimpleStepSequencer _sequencer;

	[Token(Token = "0x4001510")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private AudioClip _audioClip;

	[Token(Token = "0x4001511")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "RangeAttribute", RVA = "0x4D394", Offset = "0x4D394")]
	[SerializeField]
	private int _numVoices;

	[Token(Token = "0x4001512")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private SimpleSamplerVoice _samplerVoicePrefab;

	[Token(Token = "0x4001513")]
	[FieldOffset(Offset = "0x38")]
	private SimpleSamplerVoice[] _samplerVoices;

	[Token(Token = "0x4001514")]
	[FieldOffset(Offset = "0x40")]
	private int _nextVoiceIndex;

	[Token(Token = "0x6001215")]
	[Address(RVA = "0x16AEE48", Offset = "0x16AEE48", VA = "0x16AEE48")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001216")]
	[Address(RVA = "0x16AEFCC", Offset = "0x16AEFCC", VA = "0x16AEFCC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6001217")]
	[Address(RVA = "0x16AF1C0", Offset = "0x16AF1C0", VA = "0x16AF1C0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6001218")]
	[Address(RVA = "0x16AF3B4", Offset = "0x16AF3B4", VA = "0x16AF3B4")]
	private void HandleTicked(double tickTime)
	{
	}

	[Token(Token = "0x6001219")]
	[Address(RVA = "0x16AF4A4", Offset = "0x16AF4A4", VA = "0x16AF4A4")]
	public SimpleSampler()
	{
	}
}
