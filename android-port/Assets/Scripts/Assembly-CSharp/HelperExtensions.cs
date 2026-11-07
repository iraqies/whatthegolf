using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20004AE")]
public static class HelperExtensions
{
	[Token(Token = "0x20004AF")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3FDA4", Offset = "0x3FDA4")]
	private sealed class _003C_003Ec__DisplayClass7_0
	{
		[Token(Token = "0x40018C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Func<bool> predicate;

		[Token(Token = "0x40018C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TaskCompletionSource<bool> tcs;

		[Token(Token = "0x60015AC")]
		[Address(RVA = "0x17BA1F8", Offset = "0x17BA1F8", VA = "0x17BA1F8")]
		public _003C_003Ec__DisplayClass7_0()
		{
		}

		[Token(Token = "0x60015AD")]
		[Address(RVA = "0x17BA200", Offset = "0x17BA200", VA = "0x17BA200")]
		internal bool _003CWaitUntilAsync_003Eb__0()
		{
			return default;
		}
	}

	[Token(Token = "0x20004B0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3FDB4", Offset = "0x3FDB4")]
	private sealed class _003CYieldTask_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40018C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40018C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40018C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Task t;

		[Token(Token = "0x1700025F")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60015B1")]
			[Address(RVA = "0x17BA610", Offset = "0x17BA610", VA = "0x17BA610", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000260")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60015B3")]
			[Address(RVA = "0x17BA658", Offset = "0x17BA658", VA = "0x17BA658", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60015AE")]
		[Address(RVA = "0x17BA584", Offset = "0x17BA584", VA = "0x17BA584")]
		[DebuggerHidden]
		public _003CYieldTask_003Ed__9(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60015AF")]
		[Address(RVA = "0x17BA5B0", Offset = "0x17BA5B0", VA = "0x17BA5B0", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60015B0")]
		[Address(RVA = "0x17BA5B4", Offset = "0x17BA5B4", VA = "0x17BA5B4", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60015B1")]
		[Address(RVA = "0x17BA610", Offset = "0x17BA610", VA = "0x17BA610", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60015B2")]
		[Address(RVA = "0x17BA618", Offset = "0x17BA618", VA = "0x17BA618", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60015B3")]
		[Address(RVA = "0x17BA658", Offset = "0x17BA658", VA = "0x17BA658", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x20004B1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3FDC4", Offset = "0x3FDC4")]
	private sealed class _003CWaitForCoroutine_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40018CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40018CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40018CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IEnumerator cr;

		[Token(Token = "0x40018CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TaskCompletionSource<bool> tcs;

		[Token(Token = "0x17000261")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60015B7")]
			[Address(RVA = "0x17BA3C4", Offset = "0x17BA3C4", VA = "0x17BA3C4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000262")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60015B9")]
			[Address(RVA = "0x17BA40C", Offset = "0x17BA40C", VA = "0x17BA40C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60015B4")]
		[Address(RVA = "0x17BA304", Offset = "0x17BA304", VA = "0x17BA304")]
		[DebuggerHidden]
		public _003CWaitForCoroutine_003Ed__10(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60015B5")]
		[Address(RVA = "0x17BA330", Offset = "0x17BA330", VA = "0x17BA330", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60015B6")]
		[Address(RVA = "0x17BA334", Offset = "0x17BA334", VA = "0x17BA334", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60015B7")]
		[Address(RVA = "0x17BA3C4", Offset = "0x17BA3C4", VA = "0x17BA3C4", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60015B8")]
		[Address(RVA = "0x17BA3CC", Offset = "0x17BA3CC", VA = "0x17BA3CC", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60015B9")]
		[Address(RVA = "0x17BA40C", Offset = "0x17BA40C", VA = "0x17BA40C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x20004B2")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3FDD4", Offset = "0x3FDD4")]
	private sealed class _003CWaitUntil_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40018CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40018CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40018D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Func<bool> predicate;

		[Token(Token = "0x40018D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TaskCompletionSource<bool> tcs;

		[Token(Token = "0x17000263")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60015BD")]
			[Address(RVA = "0x17BA534", Offset = "0x17BA534", VA = "0x17BA534", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000264")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60015BF")]
			[Address(RVA = "0x17BA57C", Offset = "0x17BA57C", VA = "0x17BA57C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60015BA")]
		[Address(RVA = "0x17BA414", Offset = "0x17BA414", VA = "0x17BA414")]
		[DebuggerHidden]
		public _003CWaitUntil_003Ed__13(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60015BB")]
		[Address(RVA = "0x17BA440", Offset = "0x17BA440", VA = "0x17BA440", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60015BC")]
		[Address(RVA = "0x17BA444", Offset = "0x17BA444", VA = "0x17BA444", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60015BD")]
		[Address(RVA = "0x17BA534", Offset = "0x17BA534", VA = "0x17BA534", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60015BE")]
		[Address(RVA = "0x17BA53C", Offset = "0x17BA53C", VA = "0x17BA53C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60015BF")]
		[Address(RVA = "0x17BA57C", Offset = "0x17BA57C", VA = "0x17BA57C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x60015A3")]
	public static T Ref<T>(this T obj) where T : UnityEngine.Object
	{
		return null;
	}

	[Token(Token = "0x60015A4")]
	[Address(RVA = "0x14C6500", Offset = "0x14C6500", VA = "0x14C6500")]
	public static void SafeDestroy(this UnityEngine.Object obj)
	{
	}

	[Token(Token = "0x60015A5")]
	[Address(RVA = "0x14C65A8", Offset = "0x14C65A8", VA = "0x14C65A8")]
	public static void SafeDestroyGameObject(this Component obj)
	{
	}

	[Token(Token = "0x60015A6")]
	public static T GetArg<T>(this object[] array, int index, [Optional] T defaultValue)
	{
		return (T)null;
	}

	[Token(Token = "0x60015A7")]
	[Address(RVA = "0x14C666C", Offset = "0x14C666C", VA = "0x14C666C")]
	public static Task<bool> WaitUntilAsync(this MonoBehaviour obj, Func<bool> predicate)
	{
		return null;
	}

	[Token(Token = "0x60015A8")]
	[Address(RVA = "0x14C6870", Offset = "0x14C6870", VA = "0x14C6870")]
	public static Task<bool> WaitAsync(this MonoBehaviour obj, IEnumerator coroutine)
	{
		return null;
	}

	[Token(Token = "0x60015A9")]
	[Address(RVA = "0x14C69DC", Offset = "0x14C69DC", VA = "0x14C69DC")]
	public static IEnumerator YieldTask(this Task t)
	{
		return null;
	}

	[Token(Token = "0x60015AA")]
	[Address(RVA = "0x14C6964", Offset = "0x14C6964", VA = "0x14C6964")]
	private static IEnumerator WaitForCoroutine(TaskCompletionSource<bool> tcs, IEnumerator cr)
	{
		return null;
	}

	[Token(Token = "0x60015AB")]
	[Address(RVA = "0x14C67F8", Offset = "0x14C67F8", VA = "0x14C67F8")]
	private static IEnumerator WaitUntil(TaskCompletionSource<bool> tcs, Func<bool> predicate)
	{
		return null;
	}
}
