using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20000C1")]
public class LobbyAnimations : MonoBehaviour
{
	[Token(Token = "0x400030D")]
	[FieldOffset(Offset = "0x18")]
	public MultiplayerLobby Lobby;

	[Token(Token = "0x400030E")]
	[FieldOffset(Offset = "0x20")]
	public Animator HintAnimator;

	[Token(Token = "0x400030F")]
	[FieldOffset(Offset = "0x28")]
	public Animator FlagAnimator;

	[Token(Token = "0x600034F")]
	[Address(RVA = "0x153967C", Offset = "0x153967C", VA = "0x153967C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000350")]
	[Address(RVA = "0x15399A4", Offset = "0x15399A4", VA = "0x15399A4")]
	private void AllPlayerDisconnected()
	{
	}

	[Token(Token = "0x6000351")]
	[Address(RVA = "0x1539A00", Offset = "0x1539A00", VA = "0x1539A00")]
	private void PlayerDisconnected(MultiplayerLobby.LobbyPlayer player)
	{
	}

	[Token(Token = "0x6000352")]
	[Address(RVA = "0x1539B04", Offset = "0x1539B04", VA = "0x1539B04")]
	private void PlayerIsUnready(MultiplayerLobby.LobbyPlayer player)
	{
	}

	[Token(Token = "0x6000353")]
	[Address(RVA = "0x1539B08", Offset = "0x1539B08", VA = "0x1539B08")]
	private void PlayerReady(MultiplayerLobby.LobbyPlayer player)
	{
	}

	[Token(Token = "0x6000354")]
	[Address(RVA = "0x1539B0C", Offset = "0x1539B0C", VA = "0x1539B0C")]
	private void AllPlayersReady()
	{
	}

	[Token(Token = "0x6000355")]
	[Address(RVA = "0x1539B90", Offset = "0x1539B90", VA = "0x1539B90")]
	private void PlayerJoined(MultiplayerLobby.LobbyPlayer player)
	{
	}

	[Token(Token = "0x6000356")]
	[Address(RVA = "0x1539BEC", Offset = "0x1539BEC", VA = "0x1539BEC")]
	public LobbyAnimations()
	{
	}
}
