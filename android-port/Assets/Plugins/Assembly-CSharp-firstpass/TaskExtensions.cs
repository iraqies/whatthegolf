using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Il2CppDummyDll;

[Token(Token = "0x2000019")]
public static class TaskExtensions
{
	[Token(Token = "0x200001A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x330FC", Offset = "0x330FC")]
	private sealed class _003CAsIEnumerator_003Ed__0 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400003B")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400003C")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400003D")]
		[FieldOffset(Offset = "0x20")]
		public Task task;

		[Token(Token = "0x17000011")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000066")]
			[Address(RVA = "0x1356A1C", Offset = "0x1356A1C", VA = "0x1356A1C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000012")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000068")]
			[Address(RVA = "0x1356A64", Offset = "0x1356A64", VA = "0x1356A64", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x1356958", Offset = "0x1356958", VA = "0x1356958")]
		[DebuggerHidden]
		public _003CAsIEnumerator_003Ed__0(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x1356984", Offset = "0x1356984", VA = "0x1356984", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x1356988", Offset = "0x1356988", VA = "0x1356988", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x1356A1C", Offset = "0x1356A1C", VA = "0x1356A1C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x1356A24", Offset = "0x1356A24", VA = "0x1356A24", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x1356A64", Offset = "0x1356A64", VA = "0x1356A64", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x200001B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3310C", Offset = "0x3310C")]
	private sealed class _003CAsIEnumerator_003Ed__1<T> : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400003E")]
		[FieldOffset(Offset = "0x0")]
		private int _003C_003E1__state;

		[Token(Token = "0x400003F")]
		[FieldOffset(Offset = "0x0")]
		private T _003C_003E2__current;

		[Token(Token = "0x4000040")]
		[FieldOffset(Offset = "0x0")]
		public Task<T> task;

		[Token(Token = "0x17000013")]
		private T System_002ECollections_002EGeneric_002EIEnumerator_003CT_003E_002ECurrent
		{
			[Token(Token = "0x600006C")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CT_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000014")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600006E")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000069")]
		[DebuggerHidden]
		public _003CAsIEnumerator_003Ed__1(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600006A")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600006B")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600006C")]
		[DebuggerHidden]
		private T System_002ECollections_002EGeneric_002EIEnumerator_003CT_003E_002Eget_Current()
		{
			return (T)null;
		}

		[Token(Token = "0x600006D")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600006E")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x1319988", Offset = "0x1319988", VA = "0x1319988")]
	public static IEnumerator AsIEnumerator(this Task task)
	{
		return null;
	}

	[Token(Token = "0x6000062")]
	public static IEnumerator<T> AsIEnumerator<T>(this Task<T> task)
	{
		return null;
	}
}
