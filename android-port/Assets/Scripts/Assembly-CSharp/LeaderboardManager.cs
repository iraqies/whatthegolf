using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20008C8")]
public class LeaderboardManager : MonoBehaviour, ILeaderboard
{
	[Serializable]
	[Token(Token = "0x20008C9")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41C50", Offset = "0x41C50")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x400302A")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x400302B")]
		[FieldOffset(Offset = "0x8")]
		public static Action<bool> _003C_003E9__11_0;

		[Token(Token = "0x6002898")]
		[Address(RVA = "0x17CF434", Offset = "0x17CF434", VA = "0x17CF434")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6002899")]
		[Address(RVA = "0x17CF43C", Offset = "0x17CF43C", VA = "0x17CF43C")]
		internal void _003CPostInit_003Eb__11_0(bool success)
		{
		}
	}

	[Token(Token = "0x20008CA")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41C60", Offset = "0x41C60")]
	private sealed class _003C_003Ec__DisplayClass13_0
	{
		[Token(Token = "0x400302C")]
		[FieldOffset(Offset = "0x10")]
		public bool isSuccess;

		[Token(Token = "0x400302D")]
		[FieldOffset(Offset = "0x11")]
		public bool isWaiting;

		[Token(Token = "0x600289A")]
		[Address(RVA = "0x17CF4EC", Offset = "0x17CF4EC", VA = "0x17CF4EC")]
		public _003C_003Ec__DisplayClass13_0()
		{
		}

		[Token(Token = "0x600289B")]
		[Address(RVA = "0x17CF4F4", Offset = "0x17CF4F4", VA = "0x17CF4F4")]
		internal void _003CTryLoginBeforeCall_003Eb__0(bool succes)
		{
		}
	}

	[Token(Token = "0x20008CB")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41C70", Offset = "0x41C70")]
	private sealed class _003CTryLoginBeforeCall_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400302E")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400302F")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4003030")]
		[FieldOffset(Offset = "0x20")]
		public LeaderboardManager _003C_003E4__this;

		[Token(Token = "0x4003031")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass13_0 _003C_003E8__1;

		[Token(Token = "0x4003032")]
		[FieldOffset(Offset = "0x30")]
		public Action<bool> OnResult;

		[Token(Token = "0x4003033")]
		[FieldOffset(Offset = "0x38")]
		private bool _003CisLoginSucces_003E5__2;

		[Token(Token = "0x4003034")]
		[FieldOffset(Offset = "0x3C")]
		private int _003CmaxRetriesWhenTryingOnlineCall_003E5__3;

		[Token(Token = "0x4003035")]
		[FieldOffset(Offset = "0x40")]
		private float _003CmaxWait_003E5__4;

		[Token(Token = "0x4003036")]
		[FieldOffset(Offset = "0x44")]
		private float _003CstartTime_003E5__5;

		[Token(Token = "0x4003037")]
		[FieldOffset(Offset = "0x48")]
		private int _003CretryCount_003E5__6;

		[Token(Token = "0x4003038")]
		[FieldOffset(Offset = "0x4C")]
		private bool _003CisWaitingForLoginOrTimeout_003E5__7;

		[Token(Token = "0x1700044A")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600289F")]
			[Address(RVA = "0x17CFE9C", Offset = "0x17CFE9C", VA = "0x17CFE9C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700044B")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60028A1")]
			[Address(RVA = "0x17CFEE4", Offset = "0x17CFEE4", VA = "0x17CFEE4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600289C")]
		[Address(RVA = "0x17CF9BC", Offset = "0x17CF9BC", VA = "0x17CF9BC")]
		[DebuggerHidden]
		public _003CTryLoginBeforeCall_003Ed__13(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600289D")]
		[Address(RVA = "0x17CF9E8", Offset = "0x17CF9E8", VA = "0x17CF9E8", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600289E")]
		[Address(RVA = "0x17CF9EC", Offset = "0x17CF9EC", VA = "0x17CF9EC", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600289F")]
		[Address(RVA = "0x17CFE9C", Offset = "0x17CFE9C", VA = "0x17CFE9C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60028A0")]
		[Address(RVA = "0x17CFEA4", Offset = "0x17CFEA4", VA = "0x17CFEA4", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60028A1")]
		[Address(RVA = "0x17CFEE4", Offset = "0x17CFEE4", VA = "0x17CFEE4", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x20008CC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41C80", Offset = "0x41C80")]
	private sealed class _003C_003Ec__DisplayClass15_0
	{
		[Token(Token = "0x4003039")]
		[FieldOffset(Offset = "0x10")]
		public LeaderboardManager _003C_003E4__this;

		[Token(Token = "0x400303A")]
		[FieldOffset(Offset = "0x18")]
		public LeaderboardBoard board;

		[Token(Token = "0x400303B")]
		[FieldOffset(Offset = "0x1C")]
		public int playerScore;

		[Token(Token = "0x400303C")]
		[FieldOffset(Offset = "0x20")]
		public Action<bool, int> didSuccedCallback;

		[Token(Token = "0x60028A2")]
		[Address(RVA = "0x17CF500", Offset = "0x17CF500", VA = "0x17CF500")]
		public _003C_003Ec__DisplayClass15_0()
		{
		}

		[Token(Token = "0x60028A3")]
		[Address(RVA = "0x17CF508", Offset = "0x17CF508", VA = "0x17CF508")]
		internal void _003CSubmitScoreAsync_003Eb__0(bool success)
		{
		}
	}

	[Token(Token = "0x20008CD")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41C90", Offset = "0x41C90")]
	private sealed class _003C_003Ec__DisplayClass17_0
	{
		[Token(Token = "0x400303D")]
		[FieldOffset(Offset = "0x10")]
		public LeaderboardManager _003C_003E4__this;

		[Token(Token = "0x400303E")]
		[FieldOffset(Offset = "0x18")]
		public LeaderboardBoard board;

		[Token(Token = "0x400303F")]
		[FieldOffset(Offset = "0x1C")]
		public int entries;

		[Token(Token = "0x4003040")]
		[FieldOffset(Offset = "0x20")]
		public Action<bool, List<LeaderboardEntry>> leaderboardCallback;

		[Token(Token = "0x60028A4")]
		[Address(RVA = "0x17CF628", Offset = "0x17CF628", VA = "0x17CF628")]
		public _003C_003Ec__DisplayClass17_0()
		{
		}

		[Token(Token = "0x60028A5")]
		[Address(RVA = "0x17CF630", Offset = "0x17CF630", VA = "0x17CF630")]
		internal void _003CRequestLeaderboard_003Eb__0(bool success)
		{
		}
	}

	[Token(Token = "0x20008CE")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41CA0", Offset = "0x41CA0")]
	private sealed class _003C_003Ec__DisplayClass18_0
	{
		[Token(Token = "0x4003041")]
		[FieldOffset(Offset = "0x10")]
		public LeaderboardManager _003C_003E4__this;

		[Token(Token = "0x4003042")]
		[FieldOffset(Offset = "0x18")]
		public LeaderboardBoard board;

		[Token(Token = "0x4003043")]
		[FieldOffset(Offset = "0x20")]
		public Action<bool, LeaderboardEntry> playerDataCallback;

		[Token(Token = "0x60028A6")]
		[Address(RVA = "0x17CF74C", Offset = "0x17CF74C", VA = "0x17CF74C")]
		public _003C_003Ec__DisplayClass18_0()
		{
		}

		[Token(Token = "0x60028A7")]
		[Address(RVA = "0x17CF754", Offset = "0x17CF754", VA = "0x17CF754")]
		internal void _003CRequestPlayerData_003Eb__0(bool success)
		{
		}
	}

	[Token(Token = "0x20008CF")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41CB0", Offset = "0x41CB0")]
	private sealed class _003C_003Ec__DisplayClass20_0
	{
		[Token(Token = "0x4003044")]
		[FieldOffset(Offset = "0x10")]
		public LeaderboardManager _003C_003E4__this;

		[Token(Token = "0x4003045")]
		[FieldOffset(Offset = "0x18")]
		public Action<bool, DateTime> serverTimeCallback;

		[Token(Token = "0x60028A8")]
		[Address(RVA = "0x17CF86C", Offset = "0x17CF86C", VA = "0x17CF86C")]
		public _003C_003Ec__DisplayClass20_0()
		{
		}

		[Token(Token = "0x60028A9")]
		[Address(RVA = "0x17CF874", Offset = "0x17CF874", VA = "0x17CF874")]
		internal void _003CRequestServerTime_003Eb__0(bool success)
		{
		}
	}

	[Token(Token = "0x4003023")]
	[FieldOffset(Offset = "0x0")]
	private static LeaderboardManager _instance;

	[Token(Token = "0x4003024")]
	[FieldOffset(Offset = "0x18")]
	private LeaderboardEntry player;

	[Token(Token = "0x4003025")]
	[FieldOffset(Offset = "0x8")]
	public static readonly int lowestPossibleScore;

	[Token(Token = "0x4003026")]
	[FieldOffset(Offset = "0x20")]
	public string playerName;

	[Token(Token = "0x4003027")]
	[FieldOffset(Offset = "0x28")]
	public string playerId;

	[Token(Token = "0x4003028")]
	[FieldOffset(Offset = "0x30")]
	public ILeaderboard platformLeaderboard;

	[Token(Token = "0x4003029")]
	[FieldOffset(Offset = "0x38")]
	private bool didInit;

	[Token(Token = "0x17000449")]
	public static LeaderboardManager Instance
	{
		[Token(Token = "0x6002884")]
		[Address(RVA = "0x15207AC", Offset = "0x15207AC", VA = "0x15207AC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002885")]
	[Address(RVA = "0x1520B20", Offset = "0x1520B20", VA = "0x1520B20")]
	private void Start()
	{
	}

	[Token(Token = "0x6002886")]
	[Address(RVA = "0x1520948", Offset = "0x1520948", VA = "0x1520948")]
	private void Init()
	{
	}

	[Token(Token = "0x6002887")]
	[Address(RVA = "0x1520B30", Offset = "0x1520B30", VA = "0x1520B30")]
	private void PostInit()
	{
	}

	[Token(Token = "0x6002888")]
	[Address(RVA = "0x15211F8", Offset = "0x15211F8", VA = "0x15211F8", Slot = "12")]
	public void ShowLeaderBoard(LeaderboardBoard board)
	{
	}

	[Token(Token = "0x6002889")]
	[Address(RVA = "0x15212C0", Offset = "0x15212C0", VA = "0x15212C0")]
	private IEnumerator TryLoginBeforeCall(Action<bool> OnResult)
	{
		return null;
	}

	[Token(Token = "0x600288A")]
	[Address(RVA = "0x152133C", Offset = "0x152133C", VA = "0x152133C")]
	public string GetPlayerId()
	{
		return null;
	}

	[Token(Token = "0x600288B")]
	[Address(RVA = "0x1521344", Offset = "0x1521344", VA = "0x1521344", Slot = "9")]
	public void SubmitScoreAsync(LeaderboardBoard board, int playerScore, Action<bool, int> didSuccedCallback, int retries = 5)
	{
	}

	[Token(Token = "0x600288C")]
	[Address(RVA = "0x1520D3C", Offset = "0x1520D3C", VA = "0x1520D3C", Slot = "6")]
	public void Login(string id, string name, Action<bool> didSuccedCallback)
	{
	}

	[Token(Token = "0x600288D")]
	[Address(RVA = "0x1521734", Offset = "0x1521734", VA = "0x1521734", Slot = "10")]
	public void RequestLeaderboard(LeaderboardBoard board, int entries, Action<bool, List<LeaderboardEntry>> leaderboardCallback)
	{
	}

	[Token(Token = "0x600288E")]
	[Address(RVA = "0x1521928", Offset = "0x1521928", VA = "0x1521928", Slot = "11")]
	public void RequestPlayerData(LeaderboardBoard board, Action<bool, LeaderboardEntry> playerDataCallback)
	{
	}

	[Token(Token = "0x600288F")]
	[Address(RVA = "0x1521AB4", Offset = "0x1521AB4", VA = "0x1521AB4", Slot = "7")]
	public bool CanRequestServerTime()
	{
		return default;
	}

	[Token(Token = "0x6002890")]
	[Address(RVA = "0x1521B78", Offset = "0x1521B78", VA = "0x1521B78", Slot = "8")]
	public void RequestServerTime(Action<bool, DateTime> serverTimeCallback)
	{
	}

	[Token(Token = "0x6002891")]
	[Address(RVA = "0x1521DA8", Offset = "0x1521DA8", VA = "0x1521DA8", Slot = "4")]
	public bool IsConnected()
	{
		return default;
	}

	[Token(Token = "0x6002892")]
	[Address(RVA = "0x1521670", Offset = "0x1521670", VA = "0x1521670", Slot = "5")]
	public bool IsLoggedIn()
	{
		return default;
	}

	[Token(Token = "0x6002893")]
	[Address(RVA = "0x1521E68", Offset = "0x1521E68", VA = "0x1521E68")]
	private void PrintLeaderboard(bool succes, List<LeaderboardEntry> leaderboard)
	{
	}

	[Token(Token = "0x6002894")]
	[Address(RVA = "0x15220E8", Offset = "0x15220E8", VA = "0x15220E8")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6002895")]
	[Address(RVA = "0x152212C", Offset = "0x152212C", VA = "0x152212C")]
	public LeaderboardManager()
	{
	}
}
