using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20000BC")]
public class CrownSpawner : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20000BD")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D850", Offset = "0x3D850")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x40002FB")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x40002FC")]
		[FieldOffset(Offset = "0x8")]
		public static Func<MultiplayerConfiguration.PlayerInfo, bool> _003C_003E9__4_0;

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x1793434", Offset = "0x1793434", VA = "0x1793434")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x179343C", Offset = "0x179343C", VA = "0x179343C")]
		internal bool _003CMatchEnded_003Eb__4_0(MultiplayerConfiguration.PlayerInfo p)
		{
			return default;
		}
	}

	[Token(Token = "0x40002F8")]
	[FieldOffset(Offset = "0x18")]
	public MultiplayerLobby Lobby;

	[Token(Token = "0x40002F9")]
	[FieldOffset(Offset = "0x20")]
	public GameObject CrownPrefab;

	[Token(Token = "0x40002FA")]
	[FieldOffset(Offset = "0x28")]
	private Dictionary<int, int> crownsWon;

	[Token(Token = "0x600033C")]
	[Address(RVA = "0x18C2AD4", Offset = "0x18C2AD4", VA = "0x18C2AD4")]
	private void Awake()
	{
	}

	[Token(Token = "0x600033D")]
	[Address(RVA = "0x18C2BF8", Offset = "0x18C2BF8", VA = "0x18C2BF8")]
	private void MatchEnded(List<MultiplayerConfiguration.PlayerInfo> players)
	{
	}

	[Token(Token = "0x600033E")]
	[Address(RVA = "0x18C2FC4", Offset = "0x18C2FC4", VA = "0x18C2FC4")]
	public CrownSpawner()
	{
	}
}
