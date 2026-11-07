using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000562")]
public class HighscoreList : MonoBehaviour
{
	[Token(Token = "0x2000563")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40494", Offset = "0x40494")]
	private sealed class _003CCheckConnection_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001BC9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001BCA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001BCB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HighscoreList _003C_003E4__this;

		[Token(Token = "0x170002B1")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60018AD")]
			[Address(RVA = "0x17BACA0", Offset = "0x17BACA0", VA = "0x17BACA0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170002B2")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60018AF")]
			[Address(RVA = "0x17BACE8", Offset = "0x17BACE8", VA = "0x17BACE8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60018AA")]
		[Address(RVA = "0x17BAB64", Offset = "0x17BAB64", VA = "0x17BAB64")]
		[DebuggerHidden]
		public _003CCheckConnection_003Ed__22(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60018AB")]
		[Address(RVA = "0x17BAB90", Offset = "0x17BAB90", VA = "0x17BAB90", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60018AC")]
		[Address(RVA = "0x17BAB94", Offset = "0x17BAB94", VA = "0x17BAB94", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60018AD")]
		[Address(RVA = "0x17BACA0", Offset = "0x17BACA0", VA = "0x17BACA0", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60018AE")]
		[Address(RVA = "0x17BACA8", Offset = "0x17BACA8", VA = "0x17BACA8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60018AF")]
		[Address(RVA = "0x17BACE8", Offset = "0x17BACE8", VA = "0x17BACE8", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000564")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x404A4", Offset = "0x404A4")]
	private struct _003CRefreshList_003Ed__31 : IAsyncStateMachine
	{
		[Token(Token = "0x4001BCC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x4001BCD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x4001BCE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public HighscoreList _003C_003E4__this;

		[Token(Token = "0x4001BCF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float delay;

		[Token(Token = "0x4001BD0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TaskAwaiter _003C_003Eu__1;

		[Token(Token = "0x60018B0")]
		[Address(RVA = "0x17BB948", Offset = "0x17BB948", VA = "0x17BB948", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x60018B1")]
		[Address(RVA = "0x17BBD60", Offset = "0x17BBD60", VA = "0x17BBD60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x2000565")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x404B4", Offset = "0x404B4")]
	private sealed class _003C_003Ec__DisplayClass33_0
	{
		[Token(Token = "0x4001BD1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LeaderboardEntry playerEntry;

		[Token(Token = "0x4001BD2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public HighscoreList _003C_003E4__this;

		[Token(Token = "0x60018B2")]
		[Address(RVA = "0x17BAA30", Offset = "0x17BAA30", VA = "0x17BAA30")]
		public _003C_003Ec__DisplayClass33_0()
		{
		}
	}

	[Token(Token = "0x2000566")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x404C4", Offset = "0x404C4")]
	private sealed class _003C_003Ec__DisplayClass33_1
	{
		[Token(Token = "0x4001BD3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool gotPlayerData;

		[Token(Token = "0x4001BD4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public _003C_003Ec__DisplayClass33_0 CS_0024_003C_003E8__locals1;

		[Token(Token = "0x60018B3")]
		[Address(RVA = "0x17BAA38", Offset = "0x17BAA38", VA = "0x17BAA38")]
		public _003C_003Ec__DisplayClass33_1()
		{
		}

		[Token(Token = "0x60018B4")]
		[Address(RVA = "0x17BAA40", Offset = "0x17BAA40", VA = "0x17BAA40")]
		internal void _003CProcessLeaderboard_003Eb__1(bool succes, LeaderboardEntry entry)
		{
		}
	}

	[Token(Token = "0x2000567")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x404D4", Offset = "0x404D4")]
	private sealed class _003C_003Ec__DisplayClass33_2
	{
		[Token(Token = "0x4001BD5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int i1;

		[Token(Token = "0x4001BD6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public _003C_003Ec__DisplayClass33_0 CS_0024_003C_003E8__locals2;

		[Token(Token = "0x60018B5")]
		[Address(RVA = "0x17BAA64", Offset = "0x17BAA64", VA = "0x17BAA64")]
		public _003C_003Ec__DisplayClass33_2()
		{
		}

		[Token(Token = "0x60018B6")]
		[Address(RVA = "0x17BAA6C", Offset = "0x17BAA6C", VA = "0x17BAA6C")]
		internal void _003CProcessLeaderboard_003Eb__2(float t)
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000568")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x404E4", Offset = "0x404E4")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4001BD7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4001BD8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<LeaderboardEntry, bool> _003C_003E9__33_0;

		[Token(Token = "0x60018B8")]
		[Address(RVA = "0x17BAA10", Offset = "0x17BAA10", VA = "0x17BAA10")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x60018B9")]
		[Address(RVA = "0x17BAA18", Offset = "0x17BAA18", VA = "0x17BAA18")]
		internal bool _003CProcessLeaderboard_003Eb__33_0(LeaderboardEntry e)
		{
			return default;
		}
	}

	[Token(Token = "0x2000569")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x404F4", Offset = "0x404F4")]
	private sealed class _003CProcessLeaderboard_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001BD9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001BDA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001BDB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HighscoreList _003C_003E4__this;

		[Token(Token = "0x4001BDC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<LeaderboardEntry> leaderboard;

		[Token(Token = "0x4001BDD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass33_1 _003C_003E8__1;

		[Token(Token = "0x4001BDE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private _003C_003Ec__DisplayClass33_0 _003C_003E8__2;

		[Token(Token = "0x4001BDF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool _003CplayerInLeaderboard_003E5__2;

		[Token(Token = "0x4001BE0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private int _003Ci_003E5__3;

		[Token(Token = "0x4001BE1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<LeaderboardEntry>.Enumerator _003C_003E7__wrap3;

		[Token(Token = "0x170002B3")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60018BE")]
			[Address(RVA = "0x17BB8F8", Offset = "0x17BB8F8", VA = "0x17BB8F8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170002B4")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60018C0")]
			[Address(RVA = "0x17BB940", Offset = "0x17BB940", VA = "0x17BB940", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60018BA")]
		[Address(RVA = "0x17BACF0", Offset = "0x17BACF0", VA = "0x17BACF0")]
		[DebuggerHidden]
		public _003CProcessLeaderboard_003Ed__33(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60018BB")]
		[Address(RVA = "0x17BAD1C", Offset = "0x17BAD1C", VA = "0x17BAD1C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60018BC")]
		[Address(RVA = "0x17BADF0", Offset = "0x17BADF0", VA = "0x17BADF0", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60018BD")]
		[Address(RVA = "0x17BAD94", Offset = "0x17BAD94", VA = "0x17BAD94")]
		private void _003C_003Em__Finally1()
		{
		}

		[Token(Token = "0x60018BE")]
		[Address(RVA = "0x17BB8F8", Offset = "0x17BB8F8", VA = "0x17BB8F8", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60018BF")]
		[Address(RVA = "0x17BB900", Offset = "0x17BB900", VA = "0x17BB900", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60018C0")]
		[Address(RVA = "0x17BB940", Offset = "0x17BB940", VA = "0x17BB940", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x200056A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40504", Offset = "0x40504")]
	private sealed class _003C_003Ec__DisplayClass38_0
	{
		[Token(Token = "0x4001BE2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public System.Random rnd;

		[Token(Token = "0x60018C1")]
		[Address(RVA = "0x17BAB1C", Offset = "0x17BAB1C", VA = "0x17BAB1C")]
		public _003C_003Ec__DisplayClass38_0()
		{
		}

		[Token(Token = "0x60018C2")]
		[Address(RVA = "0x17BAB24", Offset = "0x17BAB24", VA = "0x17BAB24")]
		internal int _003CGenerateName_003Eb__0(string item)
		{
			return default;
		}

		[Token(Token = "0x60018C3")]
		[Address(RVA = "0x17BAB44", Offset = "0x17BAB44", VA = "0x17BAB44")]
		internal int _003CGenerateName_003Eb__1(string item)
		{
			return default;
		}
	}

	[Token(Token = "0x4001BB3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public LeaderboardBoard board;

	[Token(Token = "0x4001BB4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int entries;

	[Token(Token = "0x4001BB5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int extraCount;

	[Token(Token = "0x4001BB6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public DailyChallengeScoreEntry YourBest;

	[Token(Token = "0x4001BB7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Animator YourScoreArrow;

	[Token(Token = "0x4001BB8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool RefreshOnEnable;

	[Token(Token = "0x4001BB9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject EntryPrefab;

	[Token(Token = "0x4001BBA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Transform EntriesRoot;

	[Token(Token = "0x4001BBB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public TextMeshProUGUI NoConnectionText;

	[Token(Token = "0x4001BBC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public TextMeshProUGUI title;

	[Token(Token = "0x4001BBD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public TextMeshProLocalized titleLocalized;

	[Token(Token = "0x4001BBE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Color EntryColorEven;

	[Token(Token = "0x4001BBF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Color EntryColorOdd;

	[Token(Token = "0x4001BC0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public ScrollRect ScrollRect;

	[Token(Token = "0x4001BC1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private List<DailyChallengeScoreEntry> Scores;

	[Token(Token = "0x4001BC2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private Task runnningRoutine;

	[Token(Token = "0x4001BC3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private CancellationTokenSource cts;

	[Token(Token = "0x4001BC4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private int retries;

	[Token(Token = "0x4001BC5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	private bool _haveEntriesBeenInitialized;

	[Token(Token = "0x4001BC6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private string[,] names;

	[Token(Token = "0x4001BC7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private List<string> forenames;

	[Token(Token = "0x4001BC8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private List<string> surnames;

	[Token(Token = "0x6001894")]
	[Address(RVA = "0x14C9A88", Offset = "0x14C9A88", VA = "0x14C9A88")]
	public void RefreshEntryColors(Color newColor)
	{
	}

	[Token(Token = "0x6001895")]
	[Address(RVA = "0x14C9C10", Offset = "0x14C9C10", VA = "0x14C9C10")]
	private bool ShouldRefresh()
	{
		return default;
	}

	[Token(Token = "0x6001896")]
	[Address(RVA = "0x14C9C3C", Offset = "0x14C9C3C", VA = "0x14C9C3C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6001897")]
	[Address(RVA = "0x14C9CF8", Offset = "0x14C9CF8", VA = "0x14C9CF8")]
	private IEnumerator CheckConnection()
	{
		return null;
	}

	[Token(Token = "0x6001898")]
	[Address(RVA = "0x14C9E40", Offset = "0x14C9E40", VA = "0x14C9E40")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001899")]
	[Address(RVA = "0x14C9F90", Offset = "0x14C9F90", VA = "0x14C9F90")]
	public void InitEntries()
	{
	}

	[Token(Token = "0x600189A")]
	[Address(RVA = "0x14C9E64", Offset = "0x14C9E64", VA = "0x14C9E64")]
	private void SetTitle()
	{
	}

	[Token(Token = "0x600189B")]
	[Address(RVA = "0x14CA130", Offset = "0x14CA130", VA = "0x14CA130")]
	public void Reset()
	{
	}

	[Token(Token = "0x600189C")]
	[Address(RVA = "0x14C9D6C", Offset = "0x14C9D6C", VA = "0x14C9D6C")]
	public void StartRefreshLeaderboard(float delay = 0f)
	{
	}

	[Token(Token = "0x600189D")]
	[Address(RVA = "0x14CA358", Offset = "0x14CA358", VA = "0x14CA358")]
	public void RefreshInstant()
	{
	}

	[Token(Token = "0x600189E")]
	[Address(RVA = "0x14CA458", Offset = "0x14CA458", VA = "0x14CA458")]
	private void ResetEntries()
	{
	}

	[Token(Token = "0x600189F")]
	[Address(RVA = "0x14CA2B0", Offset = "0x14CA2B0", VA = "0x14CA2B0")]
	private void RefreshList(float delay = 0f)
	{
	}

	[Token(Token = "0x60018A0")]
	[Address(RVA = "0x14CA64C", Offset = "0x14CA64C", VA = "0x14CA64C")]
	private void GetLeaderboard(bool success, List<LeaderboardEntry> leaderboard)
	{
	}

	[Token(Token = "0x60018A1")]
	[Address(RVA = "0x14CAA60", Offset = "0x14CAA60", VA = "0x14CAA60")]
	private IEnumerator ProcessLeaderboard(List<LeaderboardEntry> leaderboard)
	{
		return null;
	}

	[Token(Token = "0x60018A2")]
	[Address(RVA = "0x14CAAD8", Offset = "0x14CAAD8", VA = "0x14CAAD8")]
	private void InitNameGenerator()
	{
	}

	[Token(Token = "0x60018A3")]
	[Address(RVA = "0x14CAB68", Offset = "0x14CAB68", VA = "0x14CAB68")]
	private string GenerateName()
	{
		return null;
	}

	[Token(Token = "0x60018A4")]
	[Address(RVA = "0x14CAEF0", Offset = "0x14CAEF0", VA = "0x14CAEF0")]
	private void FillInExtras(List<LeaderboardEntry> leaderboard)
	{
	}

	[Token(Token = "0x60018A5")]
	[Address(RVA = "0x14CB188", Offset = "0x14CB188", VA = "0x14CB188")]
	private int CalcTotalPar()
	{
		return default;
	}

	[Token(Token = "0x60018A6")]
	[Address(RVA = "0x14CB494", Offset = "0x14CB494", VA = "0x14CB494")]
	private void SortAndReindex(List<LeaderboardEntry> leaderboard)
	{
	}

	[Token(Token = "0x60018A7")]
	[Address(RVA = "0x14CB5B8", Offset = "0x14CB5B8", VA = "0x14CB5B8")]
	private int LeaderboardEntryComparer(LeaderboardEntry e1, LeaderboardEntry e2)
	{
		return default;
	}

	[Token(Token = "0x60018A8")]
	[Address(RVA = "0x14CB628", Offset = "0x14CB628", VA = "0x14CB628")]
	public void UpdateInput(float deltaTime)
	{
	}

	[Token(Token = "0x60018A9")]
	[Address(RVA = "0x14CB77C", Offset = "0x14CB77C", VA = "0x14CB77C")]
	public HighscoreList()
	{
	}
}
