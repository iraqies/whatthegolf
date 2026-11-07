using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using PlayFab;
using PlayFab.ClientModels;

[Token(Token = "0x20008D8")]
public class PlayfabLeaderboard : ILeaderboard
{
	[Token(Token = "0x20008D9")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41D20", Offset = "0x41D20")]
	private sealed class _003C_003Ec__DisplayClass7_0
	{
		[Token(Token = "0x400306E")]
		[FieldOffset(Offset = "0x10")]
		public int playerScore;

		[Token(Token = "0x400306F")]
		[FieldOffset(Offset = "0x18")]
		public Action<bool, int> didSuccedCallback;

		[Token(Token = "0x4003070")]
		[FieldOffset(Offset = "0x20")]
		public int retries;

		[Token(Token = "0x4003071")]
		[FieldOffset(Offset = "0x28")]
		public PlayfabLeaderboard _003C_003E4__this;

		[Token(Token = "0x60028F1")]
		[Address(RVA = "0x18294D0", Offset = "0x18294D0", VA = "0x18294D0")]
		public _003C_003Ec__DisplayClass7_0()
		{
		}

		[Token(Token = "0x60028F2")]
		[Address(RVA = "0x18294D8", Offset = "0x18294D8", VA = "0x18294D8")]
		internal void _003CSubmitScoreAsync_003Eb__0(UpdatePlayerStatisticsResult r)
		{
		}

		[Token(Token = "0x60028F3")]
		[Address(RVA = "0x18295B8", Offset = "0x18295B8", VA = "0x18295B8")]
		internal void _003CSubmitScoreAsync_003Eb__1(PlayFabError e)
		{
		}
	}

	[Token(Token = "0x20008DA")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41D30", Offset = "0x41D30")]
	private sealed class _003C_003Ec__DisplayClass15_0
	{
		[Token(Token = "0x4003072")]
		[FieldOffset(Offset = "0x10")]
		public Action<bool, LeaderboardEntry> playerDataCallback;

		[Token(Token = "0x4003073")]
		[FieldOffset(Offset = "0x18")]
		public PlayfabLeaderboard _003C_003E4__this;

		[Token(Token = "0x60028F4")]
		[Address(RVA = "0x182907C", Offset = "0x182907C", VA = "0x182907C")]
		public _003C_003Ec__DisplayClass15_0()
		{
		}

		[Token(Token = "0x60028F5")]
		[Address(RVA = "0x1829084", Offset = "0x1829084", VA = "0x1829084")]
		internal void _003CRequestPlayerData_003Eb__0(GetLeaderboardAroundPlayerResult result)
		{
		}

		[Token(Token = "0x60028F6")]
		[Address(RVA = "0x1829250", Offset = "0x1829250", VA = "0x1829250")]
		internal void _003CRequestPlayerData_003Eb__1(PlayFabError e)
		{
		}
	}

	[Token(Token = "0x20008DB")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41D40", Offset = "0x41D40")]
	private sealed class _003C_003Ec__DisplayClass17_0
	{
		[Token(Token = "0x4003074")]
		[FieldOffset(Offset = "0x10")]
		public Action<bool, DateTime> serverTimeCallback;

		[Token(Token = "0x4003075")]
		[FieldOffset(Offset = "0x18")]
		public PlayfabLeaderboard _003C_003E4__this;

		[Token(Token = "0x60028F7")]
		[Address(RVA = "0x1829324", Offset = "0x1829324", VA = "0x1829324")]
		public _003C_003Ec__DisplayClass17_0()
		{
		}

		[Token(Token = "0x60028F8")]
		[Address(RVA = "0x182932C", Offset = "0x182932C", VA = "0x182932C")]
		internal void _003CRequestServerTime_003Eb__0(GetTimeResult f)
		{
		}

		[Token(Token = "0x60028F9")]
		[Address(RVA = "0x1829398", Offset = "0x1829398", VA = "0x1829398")]
		internal void _003CRequestServerTime_003Eb__1(PlayFabError e)
		{
		}
	}

	[Token(Token = "0x4003069")]
	[FieldOffset(Offset = "0x10")]
	private Action<bool, List<LeaderboardEntry>> leaderboardCallback;

	[Token(Token = "0x400306A")]
	[FieldOffset(Offset = "0x18")]
	private Action<bool> loginSuccedCallback;

	[Token(Token = "0x400306B")]
	[FieldOffset(Offset = "0x20")]
	private string playerName;

	[Token(Token = "0x400306C")]
	[FieldOffset(Offset = "0x28")]
	private string playerPlayfabId;

	[Token(Token = "0x400306D")]
	[FieldOffset(Offset = "0x30")]
	private bool didReachServer;

	[Token(Token = "0x60028DD")]
	[Address(RVA = "0x15FD034", Offset = "0x15FD034", VA = "0x15FD034")]
	private string GetStatName(LeaderboardBoard board)
	{
		return null;
	}

	[Token(Token = "0x60028DE")]
	[Address(RVA = "0x15FD06C", Offset = "0x15FD06C", VA = "0x15FD06C")]
	private void HandlePlayFabError(PlayFabError error)
	{
	}

	[Token(Token = "0x60028DF")]
	[Address(RVA = "0x15FD09C", Offset = "0x15FD09C", VA = "0x15FD09C", Slot = "9")]
	public void SubmitScoreAsync(LeaderboardBoard board, int playerScore, Action<bool, int> didSuccedCallback, int retries)
	{
	}

	[Token(Token = "0x60028E0")]
	[Address(RVA = "0x15FD4A8", Offset = "0x15FD4A8", VA = "0x15FD4A8", Slot = "10")]
	public void RequestLeaderboard(LeaderboardBoard board, int entries, Action<bool, List<LeaderboardEntry>> _leaderboardCallback)
	{
	}

	[Token(Token = "0x60028E1")]
	[Address(RVA = "0x15FD7F0", Offset = "0x15FD7F0", VA = "0x15FD7F0")]
	private void GetLeaderboard(GetLeaderboardResult result)
	{
	}

	[Token(Token = "0x60028E2")]
	[Address(RVA = "0x15FDB58", Offset = "0x15FDB58", VA = "0x15FDB58")]
	private void RequestLeaderboardFailure(PlayFabError error)
	{
	}

	[Token(Token = "0x60028E3")]
	[Address(RVA = "0x15FDC5C", Offset = "0x15FDC5C", VA = "0x15FDC5C", Slot = "6")]
	public void Login(string id, string name, Action<bool> didSuccedCallback)
	{
	}

	[Token(Token = "0x60028E4")]
	[Address(RVA = "0x15FE080", Offset = "0x15FE080", VA = "0x15FE080")]
	private void OnLoginSuccess(LoginResult result)
	{
	}

	[Token(Token = "0x60028E5")]
	[Address(RVA = "0x15FE3FC", Offset = "0x15FE3FC", VA = "0x15FE3FC")]
	private void OnLoginFailure(PlayFabError error)
	{
	}

	[Token(Token = "0x60028E6")]
	[Address(RVA = "0x15FE14C", Offset = "0x15FE14C", VA = "0x15FE14C")]
	private void SetDisplayName()
	{
	}

	[Token(Token = "0x60028E7")]
	[Address(RVA = "0x15FE4FC", Offset = "0x15FE4FC", VA = "0x15FE4FC", Slot = "11")]
	public void RequestPlayerData(LeaderboardBoard board, Action<bool, LeaderboardEntry> playerDataCallback)
	{
	}

	[Token(Token = "0x60028E8")]
	[Address(RVA = "0x15FE868", Offset = "0x15FE868", VA = "0x15FE868", Slot = "7")]
	public bool CanRequestServerTime()
	{
		return default;
	}

	[Token(Token = "0x60028E9")]
	[Address(RVA = "0x15FE870", Offset = "0x15FE870", VA = "0x15FE870", Slot = "8")]
	public void RequestServerTime(Action<bool, DateTime> serverTimeCallback)
	{
	}

	[Token(Token = "0x60028EA")]
	[Address(RVA = "0x15FEB6C", Offset = "0x15FEB6C", VA = "0x15FEB6C", Slot = "4")]
	public bool IsConnected()
	{
		return default;
	}

	[Token(Token = "0x60028EB")]
	[Address(RVA = "0x15FEB74", Offset = "0x15FEB74", VA = "0x15FEB74", Slot = "5")]
	public bool IsLoggedIn()
	{
		return default;
	}

	[Token(Token = "0x60028EC")]
	[Address(RVA = "0x15FEB7C", Offset = "0x15FEB7C", VA = "0x15FEB7C", Slot = "12")]
	public void ShowLeaderBoard(LeaderboardBoard board)
	{
	}

	[Token(Token = "0x60028ED")]
	[Address(RVA = "0x15FEBF0", Offset = "0x15FEBF0", VA = "0x15FEBF0")]
	public PlayfabLeaderboard()
	{
	}

	[Token(Token = "0x60028EE")]
	[Address(RVA = "0x15FEBF8", Offset = "0x15FEBF8", VA = "0x15FEBF8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674A8", Offset = "0x674A8")]
	private void _003CRequestLeaderboard_003Eb__8_0(GetLeaderboardResult result)
	{
	}

	[Token(Token = "0x60028EF")]
	[Address(RVA = "0x15FEBFC", Offset = "0x15FEBFC", VA = "0x15FEBFC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674B8", Offset = "0x674B8")]
	private void _003CSetDisplayName_003Eb__14_0(UpdateUserTitleDisplayNameResult f)
	{
	}

	[Token(Token = "0x60028F0")]
	[Address(RVA = "0x15FECF0", Offset = "0x15FECF0", VA = "0x15FECF0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x674C8", Offset = "0x674C8")]
	private void _003CSetDisplayName_003Eb__14_1(PlayFabError e)
	{
	}
}
