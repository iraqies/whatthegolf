using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x20008D4")]
public class MainMenuLeaderboards : MonoBehaviour
{
	[Token(Token = "0x20008D5")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41CF0", Offset = "0x41CF0")]
	private sealed class _003CShow_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400305D")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400305E")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400305F")]
		[FieldOffset(Offset = "0x20")]
		public MainMenuLeaderboards _003C_003E4__this;

		[Token(Token = "0x4003060")]
		[FieldOffset(Offset = "0x28")]
		public Action closeAction;

		[Token(Token = "0x17000451")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60028CE")]
			[Address(RVA = "0x17F29FC", Offset = "0x17F29FC", VA = "0x17F29FC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000452")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60028D0")]
			[Address(RVA = "0x17F2A44", Offset = "0x17F2A44", VA = "0x17F2A44", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60028CB")]
		[Address(RVA = "0x17F2854", Offset = "0x17F2854", VA = "0x17F2854")]
		[DebuggerHidden]
		public _003CShow_003Ed__9(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60028CC")]
		[Address(RVA = "0x17F2880", Offset = "0x17F2880", VA = "0x17F2880", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60028CD")]
		[Address(RVA = "0x17F2884", Offset = "0x17F2884", VA = "0x17F2884", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60028CE")]
		[Address(RVA = "0x17F29FC", Offset = "0x17F29FC", VA = "0x17F29FC", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60028CF")]
		[Address(RVA = "0x17F2A04", Offset = "0x17F2A04", VA = "0x17F2A04", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60028D0")]
		[Address(RVA = "0x17F2A44", Offset = "0x17F2A44", VA = "0x17F2A44", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x20008D6")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41D00", Offset = "0x41D00")]
	private sealed class _003CChangeLeaderboard_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4003061")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4003062")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4003063")]
		[FieldOffset(Offset = "0x20")]
		public MainMenuLeaderboards _003C_003E4__this;

		[Token(Token = "0x4003064")]
		[FieldOffset(Offset = "0x28")]
		public LeaderboardBoard newBoard;

		[Token(Token = "0x17000453")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60028D4")]
			[Address(RVA = "0x17F25BC", Offset = "0x17F25BC", VA = "0x17F25BC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000454")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60028D6")]
			[Address(RVA = "0x17F2604", Offset = "0x17F2604", VA = "0x17F2604", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60028D1")]
		[Address(RVA = "0x17F24E8", Offset = "0x17F24E8", VA = "0x17F24E8")]
		[DebuggerHidden]
		public _003CChangeLeaderboard_003Ed__16(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60028D2")]
		[Address(RVA = "0x17F2514", Offset = "0x17F2514", VA = "0x17F2514", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60028D3")]
		[Address(RVA = "0x17F2518", Offset = "0x17F2518", VA = "0x17F2518", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60028D4")]
		[Address(RVA = "0x17F25BC", Offset = "0x17F25BC", VA = "0x17F25BC", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60028D5")]
		[Address(RVA = "0x17F25C4", Offset = "0x17F25C4", VA = "0x17F25C4", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60028D6")]
		[Address(RVA = "0x17F2604", Offset = "0x17F2604", VA = "0x17F2604", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x20008D7")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41D10", Offset = "0x41D10")]
	private sealed class _003CHideRoutine_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4003065")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4003066")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4003067")]
		[FieldOffset(Offset = "0x20")]
		public MainMenuLeaderboards _003C_003E4__this;

		[Token(Token = "0x4003068")]
		[FieldOffset(Offset = "0x28")]
		private float _003Cd_003E5__2;

		[Token(Token = "0x17000455")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60028DA")]
			[Address(RVA = "0x17F2804", Offset = "0x17F2804", VA = "0x17F2804", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000456")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60028DC")]
			[Address(RVA = "0x17F284C", Offset = "0x17F284C", VA = "0x17F284C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60028D7")]
		[Address(RVA = "0x17F260C", Offset = "0x17F260C", VA = "0x17F260C")]
		[DebuggerHidden]
		public _003CHideRoutine_003Ed__18(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60028D8")]
		[Address(RVA = "0x17F2638", Offset = "0x17F2638", VA = "0x17F2638", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60028D9")]
		[Address(RVA = "0x17F263C", Offset = "0x17F263C", VA = "0x17F263C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60028DA")]
		[Address(RVA = "0x17F2804", Offset = "0x17F2804", VA = "0x17F2804", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60028DB")]
		[Address(RVA = "0x17F280C", Offset = "0x17F280C", VA = "0x17F280C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60028DC")]
		[Address(RVA = "0x17F284C", Offset = "0x17F284C", VA = "0x17F284C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4003054")]
	[FieldOffset(Offset = "0x18")]
	public CompletionLeaderboard Leaderboard;

	[Token(Token = "0x4003055")]
	[FieldOffset(Offset = "0x20")]
	public HighscoreList Highscore;

	[Token(Token = "0x4003056")]
	[FieldOffset(Offset = "0x28")]
	public RectTransform Rect;

	[Token(Token = "0x4003057")]
	[FieldOffset(Offset = "0x30")]
	public List<RectTransform> Selectables;

	[Token(Token = "0x4003058")]
	[FieldOffset(Offset = "0x38")]
	public ScrollRect HighscoreScrollRect;

	[Token(Token = "0x4003059")]
	[FieldOffset(Offset = "0x40")]
	private LeaderboardBoard leaderboardType;

	[Token(Token = "0x400305A")]
	[FieldOffset(Offset = "0x44")]
	private bool waitForInputReset;

	[Token(Token = "0x400305B")]
	[FieldOffset(Offset = "0x48")]
	private int handTarget;

	[Token(Token = "0x400305C")]
	[FieldOffset(Offset = "0x50")]
	private Action closeAction;

	[Token(Token = "0x60028BE")]
	[Address(RVA = "0x1559914", Offset = "0x1559914", VA = "0x1559914")]
	public IEnumerator Show(Action closeAction)
	{
		return null;
	}

	[Token(Token = "0x60028BF")]
	[Address(RVA = "0x155998C", Offset = "0x155998C", VA = "0x155998C")]
	private void Update()
	{
	}

	[Token(Token = "0x60028C0")]
	[Address(RVA = "0x1559B18", Offset = "0x1559B18", VA = "0x1559B18")]
	public void Close()
	{
	}

	[Token(Token = "0x60028C1")]
	[Address(RVA = "0x1559B2C", Offset = "0x1559B2C", VA = "0x1559B2C")]
	public void ShowAnyPercentLeaderboards()
	{
	}

	[Token(Token = "0x60028C2")]
	[Address(RVA = "0x1559C2C", Offset = "0x1559C2C", VA = "0x1559C2C")]
	public void Show50PercentLeaderboards()
	{
	}

	[Token(Token = "0x60028C3")]
	[Address(RVA = "0x1559CB0", Offset = "0x1559CB0", VA = "0x1559CB0")]
	public void Show75PercentLeaderboards()
	{
	}

	[Token(Token = "0x60028C4")]
	[Address(RVA = "0x1559D34", Offset = "0x1559D34", VA = "0x1559D34")]
	public void Show100PercentLeaderboards()
	{
	}

	[Token(Token = "0x60028C5")]
	[Address(RVA = "0x1559BB0", Offset = "0x1559BB0", VA = "0x1559BB0")]
	private IEnumerator ChangeLeaderboard(LeaderboardBoard newBoard)
	{
		return null;
	}

	[Token(Token = "0x60028C6")]
	[Address(RVA = "0x1559DB8", Offset = "0x1559DB8", VA = "0x1559DB8")]
	public void Hide()
	{
	}

	[Token(Token = "0x60028C7")]
	[Address(RVA = "0x1559E34", Offset = "0x1559E34", VA = "0x1559E34")]
	public IEnumerator HideRoutine()
	{
		return null;
	}

	[Token(Token = "0x60028C8")]
	[Address(RVA = "0x1559EA8", Offset = "0x1559EA8", VA = "0x1559EA8")]
	public MainMenuLeaderboards()
	{
	}

	[Token(Token = "0x60028C9")]
	[Address(RVA = "0x1559EB0", Offset = "0x1559EB0", VA = "0x1559EB0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67398", Offset = "0x67398")]
	private void _003CShow_003Eb__9_0(float t)
	{
	}

	[Token(Token = "0x60028CA")]
	[Address(RVA = "0x1559F40", Offset = "0x1559F40", VA = "0x1559F40")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x673A8", Offset = "0x673A8")]
	private void _003CHideRoutine_003Eb__18_0(float t)
	{
	}
}
