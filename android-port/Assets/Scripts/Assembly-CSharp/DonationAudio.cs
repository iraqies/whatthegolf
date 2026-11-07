using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000174")]
public class DonationAudio : MonoBehaviour
{
	[Token(Token = "0x400069C")]
	[FieldOffset(Offset = "0x18")]
	public LobbyDonationMachine DonationMachine;

	[Token(Token = "0x6000666")]
	[Address(RVA = "0x1431874", Offset = "0x1431874", VA = "0x1431874")]
	private void Start()
	{
	}

	[Token(Token = "0x6000667")]
	[Address(RVA = "0x14319DC", Offset = "0x14319DC", VA = "0x14319DC")]
	private void ContentUnlocked(UnlockableContentPackage obj)
	{
	}

	[Token(Token = "0x6000668")]
	[Address(RVA = "0x14319E0", Offset = "0x14319E0", VA = "0x14319E0")]
	private void OnNoCoinsAvailable()
	{
	}

	[Token(Token = "0x6000669")]
	[Address(RVA = "0x14319E4", Offset = "0x14319E4", VA = "0x14319E4")]
	public DonationAudio()
	{
	}
}
