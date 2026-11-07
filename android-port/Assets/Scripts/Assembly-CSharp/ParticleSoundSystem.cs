using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000F12")]
public class ParticleSoundSystem : MonoBehaviour
{
	[Token(Token = "0x4005150")]
	[FieldOffset(Offset = "0x18")]
	private ParticleSystem parentParticleSystem;

	[Token(Token = "0x4005151")]
	[FieldOffset(Offset = "0x20")]
	public PlayAudioClipSetting audioClipSetting;

	[Token(Token = "0x4005152")]
	[FieldOffset(Offset = "0x28")]
	private int currentNumberOfParticles;

	[Token(Token = "0x600466F")]
	[Address(RVA = "0x15DBC28", Offset = "0x15DBC28", VA = "0x15DBC28")]
	private void Start()
	{
	}

	[Token(Token = "0x6004670")]
	[Address(RVA = "0x15DBD28", Offset = "0x15DBD28", VA = "0x15DBD28")]
	private void Update()
	{
	}

	[Token(Token = "0x6004671")]
	[Address(RVA = "0x15DBD84", Offset = "0x15DBD84", VA = "0x15DBD84")]
	public ParticleSoundSystem()
	{
	}
}
