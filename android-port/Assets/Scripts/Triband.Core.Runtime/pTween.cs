using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

[Token(Token = "0x2000005")]
public static class pTween
{
	[Token(Token = "0x2000006")]
	public enum TimeMode
	{
		[Token(Token = "0x4000003")]
		Normal = 0,
		[Token(Token = "0x4000004")]
		Unscaled = 1,
		[Token(Token = "0x4000005")]
		Realtime = 2
	}

	[Token(Token = "0x2000007")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AF694", Offset = "0x1AF694")]
	private sealed class _003CTo_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x20")]
		public TimeMode timeMode;

		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x24")]
		public float duration;

		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x28")]
		public Action<float> callback;

		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x30")]
		public float startValue;

		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x34")]
		public float endValue;

		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x38")]
		public bool useFixedUpdate;

		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x3C")]
		private float _003Cend_003E5__2;

		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x40")]
		private float _003CdurationInv_003E5__3;

		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x44")]
		private float _003CstartMulDurationInv_003E5__4;

		[Token(Token = "0x17000002")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000016")]
			[Address(RVA = "0x29FA368", Offset = "0x29FA368", VA = "0x29FA368", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000003")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000018")]
			[Address(RVA = "0x29FA3B0", Offset = "0x29FA3B0", VA = "0x29FA3B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x29F95C0", Offset = "0x29F95C0", VA = "0x29F95C0")]
		[DebuggerHidden]
		public _003CTo_003Ed__2(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x29FA1C8", Offset = "0x29FA1C8", VA = "0x29FA1C8", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x29FA1CC", Offset = "0x29FA1CC", VA = "0x29FA1CC", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x29FA368", Offset = "0x29FA368", VA = "0x29FA368", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x29FA370", Offset = "0x29FA370", VA = "0x29FA370", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x29FA3B0", Offset = "0x29FA3B0", VA = "0x29FA3B0", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000008")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AF6A4", Offset = "0x1AF6A4")]
	private sealed class _003CThen_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x20")]
		public IEnumerator coroutine;

		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x28")]
		public IEnumerator after;

		[Token(Token = "0x17000004")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600001C")]
			[Address(RVA = "0x29F9D84", Offset = "0x29F9D84", VA = "0x29F9D84", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000005")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600001E")]
			[Address(RVA = "0x29F9DCC", Offset = "0x29F9DCC", VA = "0x29F9DCC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x29F978C", Offset = "0x29F978C", VA = "0x29F978C")]
		[DebuggerHidden]
		public _003CThen_003Ed__7(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x29F9B0C", Offset = "0x29F9B0C", VA = "0x29F9B0C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x29F9B10", Offset = "0x29F9B10", VA = "0x29F9B10", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x29F9D84", Offset = "0x29F9D84", VA = "0x29F9D84", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x29F9D8C", Offset = "0x29F9D8C", VA = "0x29F9D8C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x29F9DCC", Offset = "0x29F9DCC", VA = "0x29F9DCC", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000009")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AF6B4", Offset = "0x1AF6B4")]
	private sealed class _003CThen_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x20")]
		public IEnumerator coroutine;

		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x28")]
		public Action after;

		[Token(Token = "0x17000006")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000022")]
			[Address(RVA = "0x29F9F48", Offset = "0x29F9F48", VA = "0x29F9F48", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000007")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000024")]
			[Address(RVA = "0x29F9F90", Offset = "0x29F9F90", VA = "0x29F9F90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x29F9830", Offset = "0x29F9830", VA = "0x29F9830")]
		[DebuggerHidden]
		public _003CThen_003Ed__8(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x29F9DD4", Offset = "0x29F9DD4", VA = "0x29F9DD4", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x29F9DD8", Offset = "0x29F9DD8", VA = "0x29F9DD8", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x29F9F48", Offset = "0x29F9F48", VA = "0x29F9F48", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x29F9F50", Offset = "0x29F9F50", VA = "0x29F9F50", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x29F9F90", Offset = "0x29F9F90", VA = "0x29F9F90", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x200000A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AF6C4", Offset = "0x1AF6C4")]
	private sealed class _003CThen_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x20")]
		public IEnumerator coroutine;

		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x28")]
		public float delay;

		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x30")]
		public Action after;

		[Token(Token = "0x17000008")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000028")]
			[Address(RVA = "0x29FA178", Offset = "0x29FA178", VA = "0x29FA178", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000009")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600002A")]
			[Address(RVA = "0x29FA1C0", Offset = "0x29FA1C0", VA = "0x29FA1C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x29F98E8", Offset = "0x29F98E8", VA = "0x29F98E8")]
		[DebuggerHidden]
		public _003CThen_003Ed__9(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x29F9F98", Offset = "0x29F9F98", VA = "0x29F9F98", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x29F9F9C", Offset = "0x29F9F9C", VA = "0x29F9F9C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x29FA178", Offset = "0x29FA178", VA = "0x29FA178", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x29FA180", Offset = "0x29FA180", VA = "0x29FA180", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x29FA1C0", Offset = "0x29FA1C0", VA = "0x29FA1C0", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x29F94E8", Offset = "0x29F94E8", VA = "0x29F94E8")]
	private static float GetCurrentTime(TimeMode mode)
	{
		return default;
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x29F9510", Offset = "0x29F9510", VA = "0x29F9510")]
	public static IEnumerator To(float duration, float startValue, float endValue, Action<float> callback, TimeMode timeMode = TimeMode.Normal, bool useFixedUpdate = false)
	{
		return null;
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x29F95EC", Offset = "0x29F95EC", VA = "0x29F95EC")]
	public static IEnumerator To(float duration, Action<float> callback, bool useFixedUpdate = false)
	{
		return null;
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x29F9680", Offset = "0x29F9680", VA = "0x29F9680")]
	public static IEnumerator ToRealTime(float duration, Action<float> callback)
	{
		return null;
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x29F9714", Offset = "0x29F9714", VA = "0x29F9714")]
	public static IEnumerator Then(this IEnumerator coroutine, IEnumerator after)
	{
		return null;
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x29F97B8", Offset = "0x29F97B8", VA = "0x29F97B8")]
	public static IEnumerator Then(this IEnumerator coroutine, Action after)
	{
		return null;
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x29F985C", Offset = "0x29F985C", VA = "0x29F985C")]
	public static IEnumerator Then(this IEnumerator coroutine, float delay, Action after)
	{
		return null;
	}
}
