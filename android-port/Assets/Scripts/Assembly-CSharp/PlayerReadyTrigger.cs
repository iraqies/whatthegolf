using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x20000E6")]
public class PlayerReadyTrigger : MonoBehaviour
{
	[Token(Token = "0x40003C1")]
	[FieldOffset(Offset = "0x18")]
	private MultiplayerPlayList _playlist;

	[Token(Token = "0x40003C2")]
	[FieldOffset(Offset = "0x20")]
	private UnityAction<MultiplayerPlayList, int> _onPlayerReady;

	[Token(Token = "0x40003C3")]
	[FieldOffset(Offset = "0x28")]
	private UnityAction<MultiplayerPlayList, int> _onPlayerUnready;

	[Token(Token = "0x60003ED")]
	[Address(RVA = "0x15FB4C8", Offset = "0x15FB4C8", VA = "0x15FB4C8")]
	public void Configure(MultiplayerPlayList playlist, UnityAction<MultiplayerPlayList, int> onPlayerReady, UnityAction<MultiplayerPlayList, int> onPlayerUnready)
	{
	}

	[Token(Token = "0x60003EE")]
	[Address(RVA = "0x15FB5FC", Offset = "0x15FB5FC", VA = "0x15FB5FC")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60003EF")]
	[Address(RVA = "0x15FB6F8", Offset = "0x15FB6F8", VA = "0x15FB6F8")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x60003F0")]
	[Address(RVA = "0x15FB7F4", Offset = "0x15FB7F4", VA = "0x15FB7F4")]
	public PlayerReadyTrigger()
	{
	}
}
