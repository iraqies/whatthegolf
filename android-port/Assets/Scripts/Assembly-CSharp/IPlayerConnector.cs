using System;
using Il2CppDummyDll;

[Token(Token = "0x20000C0")]
public abstract class IPlayerConnector
{
	[Token(Token = "0x4000309")]
	[FieldOffset(Offset = "0x10")]
	public Action<int> OnPlayerConnected;

	[Token(Token = "0x400030A")]
	[FieldOffset(Offset = "0x18")]
	public Action<int, float> OnPlayerConnecting;

	[Token(Token = "0x400030B")]
	[FieldOffset(Offset = "0x20")]
	public Action<int> OnPlayerStoppedConnecting;

	[Token(Token = "0x400030C")]
	[FieldOffset(Offset = "0x28")]
	public Action<int> OnPlayerDisconnected;

	[Token(Token = "0x600034D")]
	public abstract void CheckForConnectingPlayers();

	[Token(Token = "0x600034E")]
	[Address(RVA = "0x14E2A44", Offset = "0x14E2A44", VA = "0x14E2A44")]
	protected IPlayerConnector()
	{
	}
}
