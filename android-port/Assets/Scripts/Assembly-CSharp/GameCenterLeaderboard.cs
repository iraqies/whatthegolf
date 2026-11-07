using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Apple.GameKit.Leaderboards;
using Il2CppDummyDll;

[Token(Token = "0x2000CA0")]
public class GameCenterLeaderboard : ILeaderboard
{
	[Token(Token = "0x2000CA1")]
	private class LeaderboardRequest
	{
		[Token(Token = "0x40044E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LeaderboardBoard board;

		[Token(Token = "0x40044E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int entries;

		[Token(Token = "0x40044E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Action<bool, List<LeaderboardEntry>> callback;

		[Token(Token = "0x6003BCF")]
		[Address(RVA = "0x17AEB3C", Offset = "0x17AEB3C", VA = "0x17AEB3C")]
		public LeaderboardRequest()
		{
		}
	}

	[Token(Token = "0x2000CA2")]
	private class PostScoreRequest
	{
		[Token(Token = "0x40044E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LeaderboardBoard board;

		[Token(Token = "0x40044E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int score;

		[Token(Token = "0x40044E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Action<bool, int> callback;

		[Token(Token = "0x40044EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int retries;

		[Token(Token = "0x6003BD0")]
		[Address(RVA = "0x17AEB44", Offset = "0x17AEB44", VA = "0x17AEB44")]
		public PostScoreRequest()
		{
		}
	}

	[Token(Token = "0x2000CA3")]
	private enum Reason
	{
		[Token(Token = "0x40044EC")]
		NOT_SUPPORTED = 0,
		[Token(Token = "0x40044ED")]
		OTHER = 1,
		[Token(Token = "0x40044EE")]
		IS_EXPIRED = 2,
		[Token(Token = "0x40044EF")]
		SUCCESS = 3,
		[Token(Token = "0x40044F0")]
		NOT_AUTHENTICATED = 4
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000CA4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x442A8", Offset = "0x442A8")]
	private struct _003CProcessLeaderboardRequestQueue_003Ed__10 : IAsyncStateMachine
	{
		[Token(Token = "0x40044F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x40044F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x40044F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool firstFinished;

		[Token(Token = "0x40044F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private LeaderboardRequest _003Cr_003E5__2;

		[Token(Token = "0x40044F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private GKLeaderboardTimeScope _003CtimeScope_003E5__3;

		[Token(Token = "0x40044F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TaskAwaiter<bool> _003C_003Eu__1;

		[Token(Token = "0x40044F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TaskAwaiter<GKLoadLeaderboardScoresResponse> _003C_003Eu__2;

		[Token(Token = "0x6003BD1")]
		[Address(RVA = "0x17AD85C", Offset = "0x17AD85C", VA = "0x17AD85C", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6003BD2")]
		[Address(RVA = "0x17ADF5C", Offset = "0x17ADF5C", VA = "0x17ADF5C", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000CA5")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x442B8", Offset = "0x442B8")]
	private struct _003CShowLeaderboardErrorsIfAny_003Ed__11 : IAsyncStateMachine
	{
		[Token(Token = "0x40044F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x40044F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		[Token(Token = "0x40044FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LeaderboardBoard b;

		[Token(Token = "0x40044FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TaskAwaiter<Reason> _003C_003Eu__1;

		[Token(Token = "0x6003BD3")]
		[Address(RVA = "0x17AE854", Offset = "0x17AE854", VA = "0x17AE854", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6003BD4")]
		[Address(RVA = "0x17AEAE0", Offset = "0x17AEAE0", VA = "0x17AEAE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x2000CA6")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x442C8", Offset = "0x442C8")]
	private sealed class _003C_003Ec__DisplayClass13_0
	{
		[Token(Token = "0x40044FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string id;

		[Token(Token = "0x6003BD5")]
		[Address(RVA = "0x17AD000", Offset = "0x17AD000", VA = "0x17AD000")]
		public _003C_003Ec__DisplayClass13_0()
		{
		}

		[Token(Token = "0x6003BD6")]
		[Address(RVA = "0x17AD008", Offset = "0x17AD008", VA = "0x17AD008")]
		internal bool _003CCheckLeaderboardActive_003Eb__0(GKLeaderboard b)
		{
			return default;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000CA7")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x442D8", Offset = "0x442D8")]
	private struct _003CCheckLeaderboardActive_003Ed__13 : IAsyncStateMachine
	{
		[Token(Token = "0x40044FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x40044FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<Reason> _003C_003Et__builder;

		[Token(Token = "0x40044FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string id;

		[Token(Token = "0x4004500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass13_0 _003C_003E8__1;

		[Token(Token = "0x4004501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TaskAwaiter<IEnumerable<GKLeaderboard>> _003C_003Eu__1;

		[Token(Token = "0x6003BD7")]
		[Address(RVA = "0x17AD01C", Offset = "0x17AD01C", VA = "0x17AD01C", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6003BD8")]
		[Address(RVA = "0x17AD800", Offset = "0x17AD800", VA = "0x17AD800", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000CA8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x442E8", Offset = "0x442E8")]
	private struct _003CProcessSubmitScoreRequestQueue_003Ed__16 : IAsyncStateMachine
	{
		[Token(Token = "0x4004502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x4004503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x4004504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool firstFinished;

		[Token(Token = "0x4004505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private PostScoreRequest _003Cr_003E5__2;

		[Token(Token = "0x4004506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string _003CleaderboardId_003E5__3;

		[Token(Token = "0x4004507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TaskAwaiter<bool> _003C_003Eu__1;

		[Token(Token = "0x4004508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TaskAwaiter _003C_003Eu__2;

		[Token(Token = "0x6003BD9")]
		[Address(RVA = "0x17ADF68", Offset = "0x17ADF68", VA = "0x17ADF68", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6003BDA")]
		[Address(RVA = "0x17AE6A4", Offset = "0x17AE6A4", VA = "0x17AE6A4", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000CA9")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x442F8", Offset = "0x442F8")]
	private struct _003CShowLeaderBoard_003Ed__27 : IAsyncStateMachine
	{
		[Token(Token = "0x4004509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x400450A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x400450B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LeaderboardBoard board;

		[Token(Token = "0x400450C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TaskAwaiter _003C_003Eu__1;

		[Token(Token = "0x6003BDB")]
		[Address(RVA = "0x17AE6B0", Offset = "0x17AE6B0", VA = "0x17AE6B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6003BDC")]
		[Address(RVA = "0x17AE848", Offset = "0x17AE848", VA = "0x17AE848", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x40044E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Dictionary<string, LeaderboardEntry> m_cachedPlayerScoresByLeaderboard;

	[Token(Token = "0x40044E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static RequestQueue<LeaderboardRequest> m_leaderboardRequestQueue;

	[Token(Token = "0x40044E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static RequestQueue<PostScoreRequest> m_postScoreRequestQueue;

	[Token(Token = "0x6003BB7")]
	[Address(RVA = "0x147CE5C", Offset = "0x147CE5C", VA = "0x147CE5C")]
	private static void OnRetrieveScores_Failed(string error)
	{
	}

	[Token(Token = "0x6003BB8")]
	[Address(RVA = "0x147D0FC", Offset = "0x147D0FC", VA = "0x147D0FC")]
	private static void OnRetrieveScores_Loaded(GKLoadLeaderboardScoresResponse result, string leaderboard)
	{
	}

	[Token(Token = "0x6003BB9")]
	[Address(RVA = "0x147D55C", Offset = "0x147D55C", VA = "0x147D55C")]
	private static void OnSubmitScore_Failed(string error)
	{
	}

	[Token(Token = "0x6003BBA")]
	[Address(RVA = "0x147D7B8", Offset = "0x147D7B8", VA = "0x147D7B8")]
	private static void OnSubitScore_Success(string message)
	{
	}

	[Token(Token = "0x6003BBB")]
	[Address(RVA = "0x147D978", Offset = "0x147D978", VA = "0x147D978", Slot = "6")]
	public void Login(string id, string name, Action<bool> didSuccedCallback)
	{
	}

	[Token(Token = "0x6003BBC")]
	[Address(RVA = "0x147D060", Offset = "0x147D060", VA = "0x147D060")]
	private static void ProcessLeaderboardRequestQueue(bool firstFinished)
	{
	}

	[Token(Token = "0x6003BBD")]
	[Address(RVA = "0x147D97C", Offset = "0x147D97C", VA = "0x147D97C")]
	private static Task<bool> ShowLeaderboardErrorsIfAny(LeaderboardBoard b)
	{
		return null;
	}

	[Token(Token = "0x6003BBE")]
	[Address(RVA = "0x147DA88", Offset = "0x147DA88", VA = "0x147DA88")]
	private static Task<Reason> CheckLeaderboardActive(string id)
	{
		return null;
	}

	[Token(Token = "0x6003BBF")]
	[Address(RVA = "0x147D4D8", Offset = "0x147D4D8", VA = "0x147D4D8")]
	private static LeaderboardEntry FromScore(GKLeaderboardScore s, bool isPlayer)
	{
		return null;
	}

	[Token(Token = "0x6003BC0")]
	[Address(RVA = "0x147DB98", Offset = "0x147DB98", VA = "0x147DB98", Slot = "10")]
	public void RequestLeaderboard(LeaderboardBoard board, int entries, Action<bool, List<LeaderboardEntry>> leaderboardCallback)
	{
	}

	[Token(Token = "0x6003BC1")]
	[Address(RVA = "0x147D71C", Offset = "0x147D71C", VA = "0x147D71C")]
	private static void ProcessSubmitScoreRequestQueue(bool firstFinished)
	{
	}

	[Token(Token = "0x6003BC2")]
	[Address(RVA = "0x147DDAC", Offset = "0x147DDAC", VA = "0x147DDAC")]
	public static bool isRecurringLeaderboardsSupported()
	{
		return default;
	}

	[Token(Token = "0x6003BC3")]
	[Address(RVA = "0x147DE24", Offset = "0x147DE24", VA = "0x147DE24")]
	private static int getMajor(string s)
	{
		return default;
	}

	[Token(Token = "0x6003BC4")]
	[Address(RVA = "0x147DEE0", Offset = "0x147DEE0", VA = "0x147DEE0")]
	public static void ShowDialogUpdateSystem()
	{
	}

	[Token(Token = "0x6003BC5")]
	[Address(RVA = "0x147DF40", Offset = "0x147DF40", VA = "0x147DF40")]
	private static void ShowDialog(Reason r, bool force = false)
	{
	}

	[Token(Token = "0x6003BC6")]
	[Address(RVA = "0x147E0EC", Offset = "0x147E0EC", VA = "0x147E0EC", Slot = "9")]
	public void SubmitScoreAsync(LeaderboardBoard board, int score, Action<bool, int> didSuccedCallback, int retries = 5)
	{
	}

	[Token(Token = "0x6003BC7")]
	[Address(RVA = "0x147E24C", Offset = "0x147E24C", VA = "0x147E24C", Slot = "11")]
	public void RequestPlayerData(LeaderboardBoard board, Action<bool, LeaderboardEntry> playerDataCallback)
	{
	}

	[Token(Token = "0x6003BC8")]
	[Address(RVA = "0x147E33C", Offset = "0x147E33C", VA = "0x147E33C", Slot = "7")]
	public bool CanRequestServerTime()
	{
		return default;
	}

	[Token(Token = "0x6003BC9")]
	[Address(RVA = "0x147E344", Offset = "0x147E344", VA = "0x147E344", Slot = "8")]
	public void RequestServerTime(Action<bool, DateTime> serverTimeCallback)
	{
	}

	[Token(Token = "0x6003BCA")]
	[Address(RVA = "0x147E348", Offset = "0x147E348", VA = "0x147E348", Slot = "4")]
	public bool IsConnected()
	{
		return default;
	}

	[Token(Token = "0x6003BCB")]
	[Address(RVA = "0x147E350", Offset = "0x147E350", VA = "0x147E350", Slot = "5")]
	public bool IsLoggedIn()
	{
		return default;
	}

	[Token(Token = "0x6003BCC")]
	[Address(RVA = "0x147E358", Offset = "0x147E358", VA = "0x147E358", Slot = "12")]
	public void ShowLeaderBoard(LeaderboardBoard board)
	{
	}

	[Token(Token = "0x6003BCD")]
	[Address(RVA = "0x147E3F4", Offset = "0x147E3F4", VA = "0x147E3F4")]
	public GameCenterLeaderboard()
	{
	}
}
