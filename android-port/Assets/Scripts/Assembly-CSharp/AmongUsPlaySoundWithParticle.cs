using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000E08")]
public class AmongUsPlaySoundWithParticle : MonoBehaviour
{
	[Token(Token = "0x4004C56")]
	[FieldOffset(Offset = "0x18")]
	public ClipSettingsCollection clipCollection;

	[Token(Token = "0x4004C57")]
	[FieldOffset(Offset = "0x20")]
	public Transform position;

	[Token(Token = "0x4004C58")]
	[FieldOffset(Offset = "0x28")]
	private ParticleSystem particle;

	[Token(Token = "0x4004C59")]
	[FieldOffset(Offset = "0x30")]
	private bool played;

	[Token(Token = "0x60041FD")]
	[Address(RVA = "0x140FEA0", Offset = "0x140FEA0", VA = "0x140FEA0")]
	private void Start()
	{
	}

	[Token(Token = "0x60041FE")]
	[Address(RVA = "0x140FF6C", Offset = "0x140FF6C", VA = "0x140FF6C")]
	private void DefaultSetPos()
	{
	}

	[Token(Token = "0x60041FF")]
	[Address(RVA = "0x1410000", Offset = "0x1410000", VA = "0x1410000")]
	private void Update()
	{
	}

	[Token(Token = "0x6004200")]
	[Address(RVA = "0x1410068", Offset = "0x1410068", VA = "0x1410068")]
	public void Play()
	{
	}

	[Token(Token = "0x6004201")]
	[Address(RVA = "0x1410128", Offset = "0x1410128", VA = "0x1410128")]
	public AmongUsPlaySoundWithParticle()
	{
	}
}
