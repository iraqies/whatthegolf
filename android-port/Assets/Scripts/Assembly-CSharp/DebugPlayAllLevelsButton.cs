using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x20000BE")]
public class DebugPlayAllLevelsButton : MonoBehaviour
{
	[Token(Token = "0x40002FD")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Button btn;

	[Token(Token = "0x40002FE")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private MultiplayerLobby lobby;

	[Token(Token = "0x40002FF")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Button nextMusicState;

	[Token(Token = "0x4000300")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Button prevMusicState;

	[Token(Token = "0x4000301")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private TMP_Text currentMusicState;

	[Token(Token = "0x4000302")]
	[FieldOffset(Offset = "0x40")]
	private int musicStateIndex;

	[Token(Token = "0x4000303")]
	[FieldOffset(Offset = "0x48")]
	private uint[] musicStates;

	[Token(Token = "0x4000304")]
	[FieldOffset(Offset = "0x50")]
	private bool Debug;

	[Token(Token = "0x6000342")]
	[Address(RVA = "0x18D6D38", Offset = "0x18D6D38", VA = "0x18D6D38")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000343")]
	[Address(RVA = "0x18D6DBC", Offset = "0x18D6DBC", VA = "0x18D6DBC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000344")]
	[Address(RVA = "0x18D6ED8", Offset = "0x18D6ED8", VA = "0x18D6ED8")]
	private void ToggleDebug()
	{
	}

	[Token(Token = "0x6000345")]
	[Address(RVA = "0x18D6F84", Offset = "0x18D6F84", VA = "0x18D6F84")]
	private void NextMusicState()
	{
	}

	[Token(Token = "0x6000346")]
	[Address(RVA = "0x18D7118", Offset = "0x18D7118", VA = "0x18D7118")]
	private void PrevMusicState()
	{
	}

	[Token(Token = "0x6000347")]
	[Address(RVA = "0x18D6FBC", Offset = "0x18D6FBC", VA = "0x18D6FBC")]
	private void UpdateMusicState(bool playSelected = true)
	{
	}

	[Token(Token = "0x6000348")]
	[Address(RVA = "0x18D715C", Offset = "0x18D715C", VA = "0x18D715C")]
	private void Destroy(List<MultiplayerLobby.LobbyPlayer> l)
	{
	}

	[Token(Token = "0x6000349")]
	[Address(RVA = "0x18D72A0", Offset = "0x18D72A0", VA = "0x18D72A0")]
	public DebugPlayAllLevelsButton()
	{
	}
}
