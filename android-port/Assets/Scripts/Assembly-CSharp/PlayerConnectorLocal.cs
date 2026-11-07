using System.Collections.Generic;
using Il2CppDummyDll;
using Rewired;

[Token(Token = "0x20000E5")]
public class PlayerConnectorLocal : IPlayerConnector
{
	[Token(Token = "0x40003BF")]
	[FieldOffset(Offset = "0x30")]
	public float TimeToConnect;

	[Token(Token = "0x40003C0")]
	[FieldOffset(Offset = "0x38")]
	private Dictionary<Player, float> connectTimers;

	[Token(Token = "0x60003EB")]
	[Address(RVA = "0x15F7EFC", Offset = "0x15F7EFC", VA = "0x15F7EFC", Slot = "4")]
	public override void CheckForConnectingPlayers()
	{
	}

	[Token(Token = "0x60003EC")]
	[Address(RVA = "0x15F8690", Offset = "0x15F8690", VA = "0x15F8690")]
	public PlayerConnectorLocal()
	{
	}
}
