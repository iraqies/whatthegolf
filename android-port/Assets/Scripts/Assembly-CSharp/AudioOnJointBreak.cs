using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000385")]
public class AudioOnJointBreak : MonoBehaviour
{
	[Token(Token = "0x4001351")]
	[FieldOffset(Offset = "0x18")]
	public bool disableCollisionSFXBeforeBreak;

	[Token(Token = "0x4001352")]
	[FieldOffset(Offset = "0x20")]
	public AudioEventAsset sfxEventOnBreak;

	[Token(Token = "0x60010A9")]
	[Address(RVA = "0x150A988", Offset = "0x150A988", VA = "0x150A988")]
	private void Awake()
	{
	}

	[Token(Token = "0x60010AA")]
	[Address(RVA = "0x150AA54", Offset = "0x150AA54", VA = "0x150AA54")]
	private void OnJointBreak(float breakForce)
	{
	}

	[Token(Token = "0x60010AB")]
	[Address(RVA = "0x150A9A0", Offset = "0x150A9A0", VA = "0x150A9A0")]
	private void TrySetCollisionEnabled(bool enabled)
	{
	}

	[Token(Token = "0x60010AC")]
	[Address(RVA = "0x150AACC", Offset = "0x150AACC", VA = "0x150AACC")]
	public AudioOnJointBreak()
	{
	}
}
