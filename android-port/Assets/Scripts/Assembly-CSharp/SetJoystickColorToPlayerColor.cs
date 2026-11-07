using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20000E7")]
public class SetJoystickColorToPlayerColor : MonoBehaviour
{
	[Token(Token = "0x40003C4")]
	[FieldOffset(Offset = "0x18")]
	public MultiplayerLobby Lobby;

	[Token(Token = "0x60003F1")]
	[Address(RVA = "0x168D0D8", Offset = "0x168D0D8", VA = "0x168D0D8")]
	private void Start()
	{
	}

	[Token(Token = "0x60003F2")]
	[Address(RVA = "0x168D600", Offset = "0x168D600", VA = "0x168D600")]
	private void OnPlayerDisconnected(MultiplayerLobby.LobbyPlayer player)
	{
	}

	[Token(Token = "0x60003F3")]
	[Address(RVA = "0x168DA58", Offset = "0x168DA58", VA = "0x168DA58")]
	private void OnPlayerJoined(MultiplayerLobby.LobbyPlayer player)
	{
	}

	[Token(Token = "0x60003F4")]
	[Address(RVA = "0x168D630", Offset = "0x168D630", VA = "0x168D630")]
	private void SetJoystickColor(int playerIndex, Color color)
	{
	}

	[Token(Token = "0x60003F5")]
	[Address(RVA = "0x168DAB8", Offset = "0x168DAB8", VA = "0x168DAB8")]
	public SetJoystickColorToPlayerColor()
	{
	}
}
