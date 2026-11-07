using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001D6")]
public class PlayAudioClipOnTrigger : MonoBehaviour
{
	[Token(Token = "0x4000885")]
	[FieldOffset(Offset = "0x18")]
	public ClipSettingsCollection Clips;

	[Token(Token = "0x4000886")]
	[FieldOffset(Offset = "0x20")]
	public LayerMask AcceptedLayers;

	[Token(Token = "0x4000887")]
	[FieldOffset(Offset = "0x24")]
	public float PlayDelay;

	[Token(Token = "0x4000888")]
	[FieldOffset(Offset = "0x28")]
	private float delayTimer;

	[Token(Token = "0x600083A")]
	[Address(RVA = "0x15E9310", Offset = "0x15E9310", VA = "0x15E9310")]
	private void Update()
	{
	}

	[Token(Token = "0x600083B")]
	[Address(RVA = "0x15E9350", Offset = "0x15E9350", VA = "0x15E9350")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600083C")]
	[Address(RVA = "0x15E93EC", Offset = "0x15E93EC", VA = "0x15E93EC")]
	public PlayAudioClipOnTrigger()
	{
	}
}
