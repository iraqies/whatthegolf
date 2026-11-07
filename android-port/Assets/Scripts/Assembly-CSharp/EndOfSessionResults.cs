using System;
using System.Collections.Generic;
using System.Linq;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000125")]
public class EndOfSessionResults : MonoBehaviour
{
	[Token(Token = "0x2000126")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DB90", Offset = "0x3DB90")]
	private sealed class _003C_003Ec__DisplayClass3_0
	{
		[Token(Token = "0x4000523")]
		[FieldOffset(Offset = "0x10")]
		public IOrderedEnumerable<MultiplayerConfiguration.PlayerInfo> sortedPlayerList;

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x179EF88", Offset = "0x179EF88", VA = "0x179EF88")]
		public _003C_003Ec__DisplayClass3_0()
		{
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x179EF90", Offset = "0x179EF90", VA = "0x179EF90")]
		internal bool _003CAnnounceWinner_003Eb__1(MultiplayerConfiguration.PlayerInfo p)
		{
			return default;
		}
	}

	[Serializable]
	[Token(Token = "0x2000127")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DBA0", Offset = "0x3DBA0")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4000524")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4000525")]
		[FieldOffset(Offset = "0x8")]
		public static Func<MultiplayerConfiguration.PlayerInfo, int> _003C_003E9__3_0;

		[Token(Token = "0x4000526")]
		[FieldOffset(Offset = "0x10")]
		public static Func<MultiplayerConfiguration.PlayerInfo, MultiplayerConfiguration.PlayerInfo> _003C_003E9__3_2;

		[Token(Token = "0x6000514")]
		[Address(RVA = "0x179EF60", Offset = "0x179EF60", VA = "0x179EF60")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0x179EF68", Offset = "0x179EF68", VA = "0x179EF68")]
		internal int _003CAnnounceWinner_003Eb__3_0(MultiplayerConfiguration.PlayerInfo p)
		{
			return default;
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0x179EF80", Offset = "0x179EF80", VA = "0x179EF80")]
		internal MultiplayerConfiguration.PlayerInfo _003CAnnounceWinner_003Eb__3_2(MultiplayerConfiguration.PlayerInfo p)
		{
			return null;
		}
	}

	[Token(Token = "0x4000521")]
	[FieldOffset(Offset = "0x18")]
	public TextMeshProLocalized WinnerLabel;

	[Token(Token = "0x4000522")]
	[FieldOffset(Offset = "0x20")]
	public List<TextMeshProLocalized> WinnerScore;

	[Token(Token = "0x600050E")]
	[Address(RVA = "0x144412C", Offset = "0x144412C", VA = "0x144412C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600050F")]
	[Address(RVA = "0x14441E4", Offset = "0x14441E4", VA = "0x14441E4")]
	private void AnnounceWinner(MultiplayerLevelInfo info)
	{
	}

	[Token(Token = "0x6000510")]
	[Address(RVA = "0x1444750", Offset = "0x1444750", VA = "0x1444750")]
	public EndOfSessionResults()
	{
	}
}
