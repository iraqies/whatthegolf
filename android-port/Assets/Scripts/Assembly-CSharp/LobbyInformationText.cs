using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

[Token(Token = "0x2000157")]
public class LobbyInformationText : MonoBehaviour
{
	[Token(Token = "0x4000604")]
	[FieldOffset(Offset = "0x18")]
	public List<TextMeshProUGUI> TextFields;

	[Token(Token = "0x4000605")]
	[FieldOffset(Offset = "0x20")]
	public Transform TextContainer;

	[Token(Token = "0x4000606")]
	[FieldOffset(Offset = "0x28")]
	public MultiplayerLobby Lobby;

	[Token(Token = "0x4000607")]
	[FieldOffset(Offset = "0x30")]
	public PlayerColors PlayerColors;

	[Token(Token = "0x4000608")]
	[FieldOffset(Offset = "0x38")]
	public float FadeOutTime;

	[Token(Token = "0x4000609")]
	[FieldOffset(Offset = "0x3C")]
	public float TextTransitionTime;

	[Token(Token = "0x400060A")]
	[FieldOffset(Offset = "0x40")]
	private float fadeOutTimer;

	[Token(Token = "0x400060B")]
	[FieldOffset(Offset = "0x44")]
	private Vector3 currentScale;

	[Token(Token = "0x60005C2")]
	[Address(RVA = "0x153A030", Offset = "0x153A030", VA = "0x153A030")]
	private void Awake()
	{
	}

	[Token(Token = "0x60005C3")]
	[Address(RVA = "0x153A264", Offset = "0x153A264", VA = "0x153A264")]
	private void OnPlayerIsUnready(MultiplayerLobby.LobbyPlayer player)
	{
	}

	[Token(Token = "0x60005C4")]
	[Address(RVA = "0x153A480", Offset = "0x153A480", VA = "0x153A480")]
	private void OnPlayerIsReady(MultiplayerLobby.LobbyPlayer player)
	{
	}

	[Token(Token = "0x60005C5")]
	[Address(RVA = "0x153A538", Offset = "0x153A538", VA = "0x153A538")]
	private void OnPlayerDisconnected(MultiplayerLobby.LobbyPlayer player)
	{
	}

	[Token(Token = "0x60005C6")]
	[Address(RVA = "0x153A5F0", Offset = "0x153A5F0", VA = "0x153A5F0")]
	private void OnPlayerJoined(MultiplayerLobby.LobbyPlayer player)
	{
	}

	[Token(Token = "0x60005C7")]
	[Address(RVA = "0x153A31C", Offset = "0x153A31C", VA = "0x153A31C")]
	private void SetText(string text, Color color)
	{
	}

	[Token(Token = "0x60005C8")]
	[Address(RVA = "0x153A6A8", Offset = "0x153A6A8", VA = "0x153A6A8")]
	private void Update()
	{
	}

	[Token(Token = "0x60005C9")]
	[Address(RVA = "0x153A82C", Offset = "0x153A82C", VA = "0x153A82C")]
	public LobbyInformationText()
	{
	}
}
