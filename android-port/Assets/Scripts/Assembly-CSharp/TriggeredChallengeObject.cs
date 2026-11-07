using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000465")]
public class TriggeredChallengeObject : ChallengeTriggerBase
{
	[Token(Token = "0x40017C7")]
	[FieldOffset(Offset = "0x20")]
	public string triggerTag;

	[Token(Token = "0x40017C8")]
	[FieldOffset(Offset = "0x28")]
	public bool useAttachedRigid;

	[Token(Token = "0x40017C9")]
	[FieldOffset(Offset = "0x30")]
	public AudioEventAsset sfxEventOnTrigger;

	[Token(Token = "0x600147E")]
	[Address(RVA = "0x172F1D4", Offset = "0x172F1D4", VA = "0x172F1D4")]
	public void Init()
	{
	}

	[Token(Token = "0x600147F")]
	[Address(RVA = "0x172F2D0", Offset = "0x172F2D0", VA = "0x172F2D0")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6001480")]
	[Address(RVA = "0x172F3EC", Offset = "0x172F3EC", VA = "0x172F3EC")]
	private void OnTriggerEnter2D(Collider2D collision)
	{
	}

	[Token(Token = "0x6001481")]
	[Address(RVA = "0x172F4F4", Offset = "0x172F4F4", VA = "0x172F4F4")]
	public TriggeredChallengeObject()
	{
	}
}
