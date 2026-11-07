using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20008D0")]
public class LeaderboardServer : MonoBehaviour
{
	[Token(Token = "0x20008D1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41CC0", Offset = "0x41CC0")]
	private sealed class _003CStart_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400304A")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400304B")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400304C")]
		[FieldOffset(Offset = "0x20")]
		public LeaderboardServer _003C_003E4__this;

		[Token(Token = "0x1700044D")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60028B3")]
			[Address(RVA = "0x17D0090", Offset = "0x17D0090", VA = "0x17D0090", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700044E")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60028B5")]
			[Address(RVA = "0x17D00D8", Offset = "0x17D00D8", VA = "0x17D00D8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60028B0")]
		[Address(RVA = "0x17CFF20", Offset = "0x17CFF20", VA = "0x17CFF20")]
		[DebuggerHidden]
		public _003CStart_003Ed__5(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60028B1")]
		[Address(RVA = "0x17CFF4C", Offset = "0x17CFF4C", VA = "0x17CFF4C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60028B2")]
		[Address(RVA = "0x17CFF50", Offset = "0x17CFF50", VA = "0x17CFF50", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60028B3")]
		[Address(RVA = "0x17D0090", Offset = "0x17D0090", VA = "0x17D0090", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60028B4")]
		[Address(RVA = "0x17D0098", Offset = "0x17D0098", VA = "0x17D0098", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60028B5")]
		[Address(RVA = "0x17D00D8", Offset = "0x17D00D8", VA = "0x17D00D8", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x20008D2")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41CD0", Offset = "0x41CD0")]
	private sealed class _003C_003Ec__DisplayClass8_0
	{
		[Token(Token = "0x400304D")]
		[FieldOffset(Offset = "0x10")]
		public bool gotAnswer;

		[Token(Token = "0x400304E")]
		[FieldOffset(Offset = "0x11")]
		public bool gotTime;

		[Token(Token = "0x400304F")]
		[FieldOffset(Offset = "0x18")]
		public LeaderboardServer _003C_003E4__this;

		[Token(Token = "0x60028B6")]
		[Address(RVA = "0x17CFEEC", Offset = "0x17CFEEC", VA = "0x17CFEEC")]
		public _003C_003Ec__DisplayClass8_0()
		{
		}

		[Token(Token = "0x60028B7")]
		[Address(RVA = "0x17CFEF4", Offset = "0x17CFEF4", VA = "0x17CFEF4")]
		internal void _003CUpdateServerTime_003Eb__0(bool success, DateTime time)
		{
		}
	}

	[Token(Token = "0x20008D3")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41CE0", Offset = "0x41CE0")]
	private sealed class _003CUpdateServerTime_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4003050")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4003051")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4003052")]
		[FieldOffset(Offset = "0x20")]
		public LeaderboardServer _003C_003E4__this;

		[Token(Token = "0x4003053")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass8_0 _003C_003E8__1;

		[Token(Token = "0x1700044F")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60028BB")]
			[Address(RVA = "0x17D0368", Offset = "0x17D0368", VA = "0x17D0368", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000450")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60028BD")]
			[Address(RVA = "0x17D03B0", Offset = "0x17D03B0", VA = "0x17D03B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60028B8")]
		[Address(RVA = "0x17D00E0", Offset = "0x17D00E0", VA = "0x17D00E0")]
		[DebuggerHidden]
		public _003CUpdateServerTime_003Ed__8(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60028B9")]
		[Address(RVA = "0x17D010C", Offset = "0x17D010C", VA = "0x17D010C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60028BA")]
		[Address(RVA = "0x17D0110", Offset = "0x17D0110", VA = "0x17D0110", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60028BB")]
		[Address(RVA = "0x17D0368", Offset = "0x17D0368", VA = "0x17D0368", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60028BC")]
		[Address(RVA = "0x17D0370", Offset = "0x17D0370", VA = "0x17D0370", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60028BD")]
		[Address(RVA = "0x17D03B0", Offset = "0x17D03B0", VA = "0x17D03B0", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4003046")]
	[FieldOffset(Offset = "0x0")]
	private static LeaderboardServer _instance;

	[Token(Token = "0x4003047")]
	[FieldOffset(Offset = "0x18")]
	private DateTime serverTime;

	[Token(Token = "0x4003048")]
	[FieldOffset(Offset = "0x20")]
	private float waitShort;

	[Token(Token = "0x4003049")]
	[FieldOffset(Offset = "0x24")]
	private float waitLong;

	[Token(Token = "0x1700044C")]
	public static LeaderboardServer Instance
	{
		[Token(Token = "0x60028AA")]
		[Address(RVA = "0x152221C", Offset = "0x152221C", VA = "0x152221C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60028AB")]
	[Address(RVA = "0x152235C", Offset = "0x152235C", VA = "0x152235C")]
	public DateTime GetDateTime()
	{
		return default;
	}

	[Token(Token = "0x60028AC")]
	[Address(RVA = "0x15223E4", Offset = "0x15223E4", VA = "0x15223E4")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x60028AD")]
	[Address(RVA = "0x1522458", Offset = "0x1522458", VA = "0x1522458")]
	private IEnumerator UpdateServerTime()
	{
		return null;
	}

	[Token(Token = "0x60028AE")]
	[Address(RVA = "0x15224CC", Offset = "0x15224CC", VA = "0x15224CC")]
	private void Update()
	{
	}

	[Token(Token = "0x60028AF")]
	[Address(RVA = "0x1522504", Offset = "0x1522504", VA = "0x1522504")]
	public LeaderboardServer()
	{
	}
}
