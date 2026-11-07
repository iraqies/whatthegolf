using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

[Token(Token = "0x2000F34")]
public class WinSceneUI : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000F35")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x457A0", Offset = "0x457A0")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4005228")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4005229")]
		[FieldOffset(Offset = "0x8")]
		public static Action<AnimateRectTransform> _003C_003E9__15_0;

		[Token(Token = "0x400522A")]
		[FieldOffset(Offset = "0x10")]
		public static Action<AnimateRectTransform> _003C_003E9__15_1;

		[Token(Token = "0x400522B")]
		[FieldOffset(Offset = "0x18")]
		public static Action<AnimateRectTransform> _003C_003E9__21_0;

		[Token(Token = "0x400522C")]
		[FieldOffset(Offset = "0x20")]
		public static Action<AnimateRectTransform> _003C_003E9__21_1;

		[Token(Token = "0x400522D")]
		[FieldOffset(Offset = "0x28")]
		public static Action<AnimateRectTransform> _003C_003E9__21_2;

		[Token(Token = "0x400522E")]
		[FieldOffset(Offset = "0x30")]
		public static Action<AnimateRectTransform> _003C_003E9__21_3;

		[Token(Token = "0x6004714")]
		[Address(RVA = "0x187835C", Offset = "0x187835C", VA = "0x187835C")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6004715")]
		[Address(RVA = "0x1878364", Offset = "0x1878364", VA = "0x1878364")]
		internal void _003CLockUI_003Eb__15_0(AnimateRectTransform g)
		{
		}

		[Token(Token = "0x6004716")]
		[Address(RVA = "0x1878388", Offset = "0x1878388", VA = "0x1878388")]
		internal void _003CLockUI_003Eb__15_1(AnimateRectTransform g)
		{
		}

		[Token(Token = "0x6004717")]
		[Address(RVA = "0x18783AC", Offset = "0x18783AC", VA = "0x18783AC")]
		internal void _003CInit_003Eb__21_0(AnimateRectTransform g)
		{
		}

		[Token(Token = "0x6004718")]
		[Address(RVA = "0x18783D0", Offset = "0x18783D0", VA = "0x18783D0")]
		internal void _003CInit_003Eb__21_1(AnimateRectTransform g)
		{
		}

		[Token(Token = "0x6004719")]
		[Address(RVA = "0x18783F4", Offset = "0x18783F4", VA = "0x18783F4")]
		internal void _003CInit_003Eb__21_2(AnimateRectTransform t)
		{
		}

		[Token(Token = "0x600471A")]
		[Address(RVA = "0x1878418", Offset = "0x1878418", VA = "0x1878418")]
		internal void _003CInit_003Eb__21_3(AnimateRectTransform t)
		{
		}
	}

	[Token(Token = "0x2000F36")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x457B0", Offset = "0x457B0")]
	private sealed class _003CUnlockPrizeAfter_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400522F")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4005230")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4005231")]
		[FieldOffset(Offset = "0x20")]
		public WinSceneUI _003C_003E4__this;

		[Token(Token = "0x1700075A")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600471E")]
			[Address(RVA = "0x1878674", Offset = "0x1878674", VA = "0x1878674", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700075B")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6004720")]
			[Address(RVA = "0x18786BC", Offset = "0x18786BC", VA = "0x18786BC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600471B")]
		[Address(RVA = "0x187858C", Offset = "0x187858C", VA = "0x187858C")]
		[DebuggerHidden]
		public _003CUnlockPrizeAfter_003Ed__17(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600471C")]
		[Address(RVA = "0x18785B8", Offset = "0x18785B8", VA = "0x18785B8", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600471D")]
		[Address(RVA = "0x18785BC", Offset = "0x18785BC", VA = "0x18785BC", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600471E")]
		[Address(RVA = "0x1878674", Offset = "0x1878674", VA = "0x1878674", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600471F")]
		[Address(RVA = "0x187867C", Offset = "0x187867C", VA = "0x187867C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6004720")]
		[Address(RVA = "0x18786BC", Offset = "0x18786BC", VA = "0x18786BC", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000F37")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x457C0", Offset = "0x457C0")]
	private sealed class _003C_003Ec__DisplayClass19_0
	{
		[Token(Token = "0x4005232")]
		[FieldOffset(Offset = "0x10")]
		public bool usingController;

		[Token(Token = "0x4005233")]
		[FieldOffset(Offset = "0x11")]
		public bool leaderboards;

		[Token(Token = "0x6004721")]
		[Address(RVA = "0x187843C", Offset = "0x187843C", VA = "0x187843C")]
		public _003C_003Ec__DisplayClass19_0()
		{
		}

		[Token(Token = "0x6004722")]
		[Address(RVA = "0x1878444", Offset = "0x1878444", VA = "0x1878444")]
		internal void _003CSetUI_003Eb__0(AnimateRectTransform g)
		{
		}

		[Token(Token = "0x6004723")]
		[Address(RVA = "0x1878474", Offset = "0x1878474", VA = "0x1878474")]
		internal void _003CSetUI_003Eb__1(AnimateRectTransform g)
		{
		}

		[Token(Token = "0x6004724")]
		[Address(RVA = "0x187849C", Offset = "0x187849C", VA = "0x187849C")]
		internal void _003CSetUI_003Eb__2(AnimateRectTransform t)
		{
		}

		[Token(Token = "0x6004725")]
		[Address(RVA = "0x18784C4", Offset = "0x18784C4", VA = "0x18784C4")]
		internal void _003CSetUI_003Eb__3(AnimateRectTransform t)
		{
		}
	}

	[Token(Token = "0x2000F38")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x457D0", Offset = "0x457D0")]
	private sealed class _003C_003Ec__DisplayClass26_0
	{
		[Token(Token = "0x4005234")]
		[FieldOffset(Offset = "0x10")]
		public bool open;

		[Token(Token = "0x4005235")]
		[FieldOffset(Offset = "0x11")]
		public bool isController;

		[Token(Token = "0x6004726")]
		[Address(RVA = "0x1878510", Offset = "0x1878510", VA = "0x1878510")]
		public _003C_003Ec__DisplayClass26_0()
		{
		}

		[Token(Token = "0x6004727")]
		[Address(RVA = "0x1878518", Offset = "0x1878518", VA = "0x1878518")]
		internal void _003CSetLeaderBoardBtn_003Eb__0(AnimateRectTransform t)
		{
		}

		[Token(Token = "0x6004728")]
		[Address(RVA = "0x1878540", Offset = "0x1878540", VA = "0x1878540")]
		internal void _003CSetLeaderBoardBtn_003Eb__1(AnimateRectTransform t)
		{
		}
	}

	[Token(Token = "0x4005219")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private PrizeController prizeController;

	[Token(Token = "0x400521A")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private DailyChallengeQuickMenu dailyQuickMenu;

	[Token(Token = "0x400521B")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private TextMeshProLocalized HighscoreTitle;

	[Token(Token = "0x400521C")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private TextMeshProUGUI HighscoreTimeLeft;

	[Token(Token = "0x400521D")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private List<AnimateRectTransform> ActiveOnLeaderboardShow;

	[Token(Token = "0x400521E")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private List<AnimateRectTransform> DeactiveOnLeaderboardShow;

	[Token(Token = "0x400521F")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private HighscoreList HighscoreList;

	[Token(Token = "0x4005220")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private List<AnimateRectTransform> UIToDeactivateOnUsingController;

	[Token(Token = "0x4005221")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private List<AnimateRectTransform> UIToActivateOnUsingController;

	[Token(Token = "0x4005222")]
	[FieldOffset(Offset = "0x60")]
	private bool HasSentAnalytics;

	[Token(Token = "0x4005223")]
	[FieldOffset(Offset = "0x61")]
	public bool isShowingLeaderboards;

	[Token(Token = "0x4005224")]
	[FieldOffset(Offset = "0x62")]
	private bool p_usingController;

	[Token(Token = "0x4005225")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private AnimateRectTransform UnlockButton;

	[Token(Token = "0x4005226")]
	[FieldOffset(Offset = "0x70")]
	private bool hasUnlocked;

	[Token(Token = "0x4005227")]
	[FieldOffset(Offset = "0x78")]
	private DailyPrize prizeToUnlock;

	[Token(Token = "0x6004705")]
	[Address(RVA = "0x17548E8", Offset = "0x17548E8", VA = "0x17548E8")]
	public void LockUI(DailyPrize prizeToUnlock)
	{
	}

	[Token(Token = "0x6004706")]
	[Address(RVA = "0x1754B30", Offset = "0x1754B30", VA = "0x1754B30")]
	public void Unlock()
	{
	}

	[Token(Token = "0x6004707")]
	[Address(RVA = "0x1754C90", Offset = "0x1754C90", VA = "0x1754C90")]
	private IEnumerator UnlockPrizeAfter()
	{
		return null;
	}

	[Token(Token = "0x6004708")]
	[Address(RVA = "0x1754D04", Offset = "0x1754D04", VA = "0x1754D04")]
	public void InitUI()
	{
	}

	[Token(Token = "0x6004709")]
	[Address(RVA = "0x1754D80", Offset = "0x1754D80", VA = "0x1754D80")]
	private void SetUI(bool leaderboards, bool usingController)
	{
	}

	[Token(Token = "0x600470A")]
	[Address(RVA = "0x1754F60", Offset = "0x1754F60", VA = "0x1754F60")]
	private void SetHighscoreTitle(bool isSpecial)
	{
	}

	[Token(Token = "0x600470B")]
	[Address(RVA = "0x1755090", Offset = "0x1755090", VA = "0x1755090")]
	public void Init(bool isSpecial)
	{
	}

	[Token(Token = "0x600470C")]
	[Address(RVA = "0x175554C", Offset = "0x175554C", VA = "0x175554C")]
	private void Update()
	{
	}

	[Token(Token = "0x600470D")]
	[Address(RVA = "0x1755724", Offset = "0x1755724", VA = "0x1755724")]
	public void ToggleLeaderboards()
	{
	}

	[Token(Token = "0x600470E")]
	[Address(RVA = "0x1755790", Offset = "0x1755790", VA = "0x1755790")]
	private void ShowLeaderboards()
	{
	}

	[Token(Token = "0x600470F")]
	[Address(RVA = "0x17556D4", Offset = "0x17556D4", VA = "0x17556D4")]
	private void HideLeaderBoards()
	{
	}

	[Token(Token = "0x6004710")]
	[Address(RVA = "0x17558A8", Offset = "0x17558A8", VA = "0x17558A8")]
	private void SetLeaderBoardBtn(bool open)
	{
	}

	[Token(Token = "0x6004711")]
	[Address(RVA = "0x1755A28", Offset = "0x1755A28", VA = "0x1755A28")]
	protected void RefreshNextChallangeText()
	{
	}

	[Token(Token = "0x6004712")]
	[Address(RVA = "0x1755D84", Offset = "0x1755D84", VA = "0x1755D84")]
	public WinSceneUI()
	{
	}
}
