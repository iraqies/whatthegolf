using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000175")]
public class DonationUI : MonoBehaviour
{
	[Token(Token = "0x400069D")]
	[FieldOffset(Offset = "0x18")]
	public LobbyDonationMachine DonationMachine;

	[Token(Token = "0x400069E")]
	[FieldOffset(Offset = "0x20")]
	public UnlockablesManager UnlockablesManager;

	[Token(Token = "0x400069F")]
	[FieldOffset(Offset = "0x28")]
	public MultiplayerLobby Lobby;

	[Token(Token = "0x600066A")]
	[Address(RVA = "0x14319EC", Offset = "0x14319EC", VA = "0x14319EC")]
	private void Start()
	{
	}

	[Token(Token = "0x600066B")]
	[Address(RVA = "0x1431B74", Offset = "0x1431B74", VA = "0x1431B74")]
	private void OnMatchEnded(List<MultiplayerConfiguration.PlayerInfo> obj)
	{
	}

	[Token(Token = "0x600066C")]
	[Address(RVA = "0x1431B78", Offset = "0x1431B78", VA = "0x1431B78")]
	private void ContentUnlocked(UnlockableContentPackage package)
	{
	}

	[Token(Token = "0x600066D")]
	[Address(RVA = "0x1431B7C", Offset = "0x1431B7C", VA = "0x1431B7C")]
	public DonationUI()
	{
	}
}
