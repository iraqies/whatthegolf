using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;

[Token(Token = "0x200050E")]
public class OverworldLoader : MonoBehaviour
{
	[Token(Token = "0x200050F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4011C", Offset = "0x4011C")]
	private sealed class _003CLogoSplashRoutine_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001A2D")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001A2E")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001A2F")]
		[FieldOffset(Offset = "0x20")]
		public OverworldLoader _003C_003E4__this;

		[Token(Token = "0x1700028B")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600172C")]
			[Address(RVA = "0x1812C24", Offset = "0x1812C24", VA = "0x1812C24", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700028C")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600172E")]
			[Address(RVA = "0x1812C6C", Offset = "0x1812C6C", VA = "0x1812C6C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001729")]
		[Address(RVA = "0x1812A94", Offset = "0x1812A94", VA = "0x1812A94")]
		[DebuggerHidden]
		public _003CLogoSplashRoutine_003Ed__8(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600172A")]
		[Address(RVA = "0x1812AC0", Offset = "0x1812AC0", VA = "0x1812AC0", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600172B")]
		[Address(RVA = "0x1812AC4", Offset = "0x1812AC4", VA = "0x1812AC4", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600172C")]
		[Address(RVA = "0x1812C24", Offset = "0x1812C24", VA = "0x1812C24", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600172D")]
		[Address(RVA = "0x1812C2C", Offset = "0x1812C2C", VA = "0x1812C2C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600172E")]
		[Address(RVA = "0x1812C6C", Offset = "0x1812C6C", VA = "0x1812C6C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000510")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4012C", Offset = "0x4012C")]
	private sealed class _003C_003Ec__DisplayClass10_0
	{
		[Token(Token = "0x4001A30")]
		[FieldOffset(Offset = "0x10")]
		public bool didPlayTunnelAnimation;

		[Token(Token = "0x4001A31")]
		[FieldOffset(Offset = "0x18")]
		public OverworldLoader _003C_003E4__this;

		[Token(Token = "0x4001A32")]
		[FieldOffset(Offset = "0x20")]
		public bool firstReachLogo;

		[Token(Token = "0x600172F")]
		[Address(RVA = "0x18127EC", Offset = "0x18127EC", VA = "0x18127EC")]
		public _003C_003Ec__DisplayClass10_0()
		{
		}

		[Token(Token = "0x6001730")]
		[Address(RVA = "0x18127F4", Offset = "0x18127F4", VA = "0x18127F4")]
		internal void _003CStart_003Eb__1()
		{
		}

		[Token(Token = "0x6001731")]
		[Address(RVA = "0x1812800", Offset = "0x1812800", VA = "0x1812800")]
		internal bool _003CStart_003Eb__2()
		{
			return default;
		}

		[Token(Token = "0x6001732")]
		[Address(RVA = "0x18128BC", Offset = "0x18128BC", VA = "0x18128BC")]
		internal bool _003CStart_003Eb__3()
		{
			return default;
		}
	}

	[Serializable]
	[Token(Token = "0x2000511")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4013C", Offset = "0x4013C")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4001A33")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4001A34")]
		[FieldOffset(Offset = "0x8")]
		public static Action _003C_003E9__10_0;

		[Token(Token = "0x4001A35")]
		[FieldOffset(Offset = "0x10")]
		public static Action _003C_003E9__10_4;

		[Token(Token = "0x6001734")]
		[Address(RVA = "0x1812754", Offset = "0x1812754", VA = "0x1812754")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6001735")]
		[Address(RVA = "0x181275C", Offset = "0x181275C", VA = "0x181275C")]
		internal void _003CStart_003Eb__10_0()
		{
		}

		[Token(Token = "0x6001736")]
		[Address(RVA = "0x18127E8", Offset = "0x18127E8", VA = "0x18127E8")]
		internal void _003CStart_003Eb__10_4()
		{
		}
	}

	[Token(Token = "0x2000512")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4014C", Offset = "0x4014C")]
	private sealed class _003CStart_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001A36")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001A37")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001A38")]
		[FieldOffset(Offset = "0x20")]
		public OverworldLoader _003C_003E4__this;

		[Token(Token = "0x4001A39")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass10_0 _003C_003E8__1;

		[Token(Token = "0x1700028D")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600173A")]
			[Address(RVA = "0x1813888", Offset = "0x1813888", VA = "0x1813888", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700028E")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600173C")]
			[Address(RVA = "0x18138D0", Offset = "0x18138D0", VA = "0x18138D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001737")]
		[Address(RVA = "0x1813220", Offset = "0x1813220", VA = "0x1813220")]
		[DebuggerHidden]
		public _003CStart_003Ed__10(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001738")]
		[Address(RVA = "0x181324C", Offset = "0x181324C", VA = "0x181324C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001739")]
		[Address(RVA = "0x1813250", Offset = "0x1813250", VA = "0x1813250", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600173A")]
		[Address(RVA = "0x1813888", Offset = "0x1813888", VA = "0x1813888", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600173B")]
		[Address(RVA = "0x1813890", Offset = "0x1813890", VA = "0x1813890", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600173C")]
		[Address(RVA = "0x18138D0", Offset = "0x18138D0", VA = "0x18138D0", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000513")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4015C", Offset = "0x4015C")]
	private sealed class _003CCleanup_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001A3A")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001A3B")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001A3C")]
		[FieldOffset(Offset = "0x20")]
		public bool blockingUnloadedAssets;

		[Token(Token = "0x4001A3D")]
		[FieldOffset(Offset = "0x21")]
		public bool useGC;

		[Token(Token = "0x1700028F")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001740")]
			[Address(RVA = "0x1812A44", Offset = "0x1812A44", VA = "0x1812A44", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000290")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001742")]
			[Address(RVA = "0x1812A8C", Offset = "0x1812A8C", VA = "0x1812A8C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600173D")]
		[Address(RVA = "0x1812948", Offset = "0x1812948", VA = "0x1812948")]
		[DebuggerHidden]
		public _003CCleanup_003Ed__11(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600173E")]
		[Address(RVA = "0x1812974", Offset = "0x1812974", VA = "0x1812974", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600173F")]
		[Address(RVA = "0x1812978", Offset = "0x1812978", VA = "0x1812978", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001740")]
		[Address(RVA = "0x1812A44", Offset = "0x1812A44", VA = "0x1812A44", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001741")]
		[Address(RVA = "0x1812A4C", Offset = "0x1812A4C", VA = "0x1812A4C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001742")]
		[Address(RVA = "0x1812A8C", Offset = "0x1812A8C", VA = "0x1812A8C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000514")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4016C", Offset = "0x4016C")]
	private sealed class _003COverworldStartLoadingAsync__003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001A3E")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001A3F")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001A40")]
		[FieldOffset(Offset = "0x20")]
		public OverworldLoader _003C_003E4__this;

		[Token(Token = "0x4001A41")]
		[FieldOffset(Offset = "0x28")]
		public bool skipTunnel;

		[Token(Token = "0x17000291")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001746")]
			[Address(RVA = "0x18131D0", Offset = "0x18131D0", VA = "0x18131D0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000292")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001748")]
			[Address(RVA = "0x1813218", Offset = "0x1813218", VA = "0x1813218", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001743")]
		[Address(RVA = "0x1812EC8", Offset = "0x1812EC8", VA = "0x1812EC8")]
		[DebuggerHidden]
		public _003COverworldStartLoadingAsync__003Ed__12(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001744")]
		[Address(RVA = "0x1812EF4", Offset = "0x1812EF4", VA = "0x1812EF4", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001745")]
		[Address(RVA = "0x1812EF8", Offset = "0x1812EF8", VA = "0x1812EF8", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001746")]
		[Address(RVA = "0x18131D0", Offset = "0x18131D0", VA = "0x18131D0", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001747")]
		[Address(RVA = "0x18131D8", Offset = "0x18131D8", VA = "0x18131D8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001748")]
		[Address(RVA = "0x1813218", Offset = "0x1813218", VA = "0x1813218", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000515")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4017C", Offset = "0x4017C")]
	private sealed class _003COverworldFinshLoadAndSwitch_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001A42")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001A43")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001A44")]
		[FieldOffset(Offset = "0x20")]
		public OverworldLoader _003C_003E4__this;

		[Token(Token = "0x4001A45")]
		[FieldOffset(Offset = "0x28")]
		private int _003Ci_003E5__2;

		[Token(Token = "0x4001A46")]
		[FieldOffset(Offset = "0x2C")]
		private int _003Cc_003E5__3;

		[Token(Token = "0x17000293")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600174C")]
			[Address(RVA = "0x1812E78", Offset = "0x1812E78", VA = "0x1812E78", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000294")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600174E")]
			[Address(RVA = "0x1812EC0", Offset = "0x1812EC0", VA = "0x1812EC0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001749")]
		[Address(RVA = "0x1812C74", Offset = "0x1812C74", VA = "0x1812C74")]
		[DebuggerHidden]
		public _003COverworldFinshLoadAndSwitch_003Ed__13(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600174A")]
		[Address(RVA = "0x1812CA0", Offset = "0x1812CA0", VA = "0x1812CA0", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600174B")]
		[Address(RVA = "0x1812CA4", Offset = "0x1812CA4", VA = "0x1812CA4", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600174C")]
		[Address(RVA = "0x1812E78", Offset = "0x1812E78", VA = "0x1812E78", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600174D")]
		[Address(RVA = "0x1812E80", Offset = "0x1812E80", VA = "0x1812E80", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600174E")]
		[Address(RVA = "0x1812EC0", Offset = "0x1812EC0", VA = "0x1812EC0", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4001A25")]
	[FieldOffset(Offset = "0x18")]
	public IntroTunnelInOverworld tunnel;

	[Token(Token = "0x4001A26")]
	[FieldOffset(Offset = "0x20")]
	public string OverWorldSceneName;

	[Token(Token = "0x4001A27")]
	[FieldOffset(Offset = "0x28")]
	private Coroutine ballRolling;

	[Token(Token = "0x4001A28")]
	[FieldOffset(Offset = "0x30")]
	private AsyncOperationHandle<SceneInstance> loadHandle;

	[Token(Token = "0x4001A29")]
	[FieldOffset(Offset = "0x50")]
	public Animator logoAnimator;

	[Token(Token = "0x4001A2A")]
	[FieldOffset(Offset = "0x58")]
	private bool didPlayAnimation;

	[Token(Token = "0x4001A2B")]
	[FieldOffset(Offset = "0x59")]
	private bool shouldContinueTunnel;

	[Token(Token = "0x4001A2C")]
	[FieldOffset(Offset = "0x5C")]
	private float startTunnelTime;

	[Token(Token = "0x6001722")]
	[Address(RVA = "0x15BC59C", Offset = "0x15BC59C", VA = "0x15BC59C")]
	private IEnumerator LogoSplashRoutine()
	{
		return null;
	}

	[Token(Token = "0x6001723")]
	[Address(RVA = "0x15BC610", Offset = "0x15BC610", VA = "0x15BC610")]
	private float GetTimeSinceStart()
	{
		return default;
	}

	[Token(Token = "0x6001724")]
	[Address(RVA = "0x15BC63C", Offset = "0x15BC63C", VA = "0x15BC63C")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x6001725")]
	[Address(RVA = "0x15BC6B0", Offset = "0x15BC6B0", VA = "0x15BC6B0")]
	private IEnumerator Cleanup(bool blockingUnloadedAssets, bool useGC = true)
	{
		return null;
	}

	[Token(Token = "0x6001726")]
	[Address(RVA = "0x15BC72C", Offset = "0x15BC72C", VA = "0x15BC72C")]
	private IEnumerator OverworldStartLoadingAsync_(bool skipTunnel)
	{
		return null;
	}

	[Token(Token = "0x6001727")]
	[Address(RVA = "0x15BC7A8", Offset = "0x15BC7A8", VA = "0x15BC7A8")]
	public IEnumerator OverworldFinshLoadAndSwitch()
	{
		return null;
	}

	[Token(Token = "0x6001728")]
	[Address(RVA = "0x15BC81C", Offset = "0x15BC81C", VA = "0x15BC81C")]
	public OverworldLoader()
	{
	}
}
