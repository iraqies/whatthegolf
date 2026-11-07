using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000363")]
public class SaveNotificationController : MonoBehaviour
{
	[Token(Token = "0x2000364")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F2EC", Offset = "0x3F2EC")]
	private sealed class _003CStart_003Ed__1 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40012A9")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40012AA")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40012AB")]
		[FieldOffset(Offset = "0x20")]
		public SaveNotificationController _003C_003E4__this;

		[Token(Token = "0x40012AC")]
		[FieldOffset(Offset = "0x28")]
		private AsyncOperation _003Chandle_003E5__2;

		[Token(Token = "0x170001D5")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000FB8")]
			[Address(RVA = "0x183DC54", Offset = "0x183DC54", VA = "0x183DC54", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170001D6")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000FBA")]
			[Address(RVA = "0x183DC9C", Offset = "0x183DC9C", VA = "0x183DC9C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000FB5")]
		[Address(RVA = "0x183DA8C", Offset = "0x183DA8C", VA = "0x183DA8C")]
		[DebuggerHidden]
		public _003CStart_003Ed__1(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000FB6")]
		[Address(RVA = "0x183DAB8", Offset = "0x183DAB8", VA = "0x183DAB8", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000FB7")]
		[Address(RVA = "0x183DABC", Offset = "0x183DABC", VA = "0x183DABC", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000FB8")]
		[Address(RVA = "0x183DC54", Offset = "0x183DC54", VA = "0x183DC54", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000FB9")]
		[Address(RVA = "0x183DC5C", Offset = "0x183DC5C", VA = "0x183DC5C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000FBA")]
		[Address(RVA = "0x183DC9C", Offset = "0x183DC9C", VA = "0x183DC9C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x40012A8")]
	[FieldOffset(Offset = "0x18")]
	public float MessageDuration;

	[Token(Token = "0x6000FB3")]
	[Address(RVA = "0x1676A34", Offset = "0x1676A34", VA = "0x1676A34")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x6000FB4")]
	[Address(RVA = "0x1676AA8", Offset = "0x1676AA8", VA = "0x1676AA8")]
	public SaveNotificationController()
	{
	}
}
