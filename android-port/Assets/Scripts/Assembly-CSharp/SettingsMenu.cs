using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Audio;
using Core;
using Il2CppDummyDll;
using Menu;
using TMPro;
using Triband.Core;
using Unity.Notifications.iOS;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[Token(Token = "0x2000906")]
public class SettingsMenu : AddressableSingleton<SettingsMenu>
{
	[Token(Token = "0x2000907")]
	[Flags]
	public enum Location
	{
		[Token(Token = "0x4003161")]
		Hub = 1,
		[Token(Token = "0x4003162")]
		Overworld = 2,
		[Token(Token = "0x4003163")]
		Level = 4
	}

	[Token(Token = "0x2000908")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41EF8", Offset = "0x41EF8")]
	private sealed class _003C_003Ec__DisplayClass64_0
	{
		[Token(Token = "0x4003164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SettingsMenu _003C_003E4__this;

		[Token(Token = "0x4003165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float originalPos;

		[Token(Token = "0x4003166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float targetPos;

		[Token(Token = "0x60029EB")]
		[Address(RVA = "0x1843AB8", Offset = "0x1843AB8", VA = "0x1843AB8")]
		public _003C_003Ec__DisplayClass64_0()
		{
		}

		[Token(Token = "0x60029EC")]
		[Address(RVA = "0x1843AC0", Offset = "0x1843AC0", VA = "0x1843AC0")]
		internal void _003CSnapToVertical_003Eb__0(float t)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000909")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41F08", Offset = "0x41F08")]
	private struct _003CSnapToVertical_003Ed__64 : IAsyncStateMachine
	{
		[Token(Token = "0x4003167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x4003168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x4003169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public SettingsMenu _003C_003E4__this;

		[Token(Token = "0x400316A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public RectTransform target;

		[Token(Token = "0x400316B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool immediate;

		[Token(Token = "0x60029ED")]
		[Address(RVA = "0x1847F74", Offset = "0x1847F74", VA = "0x1847F74", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x60029EE")]
		[Address(RVA = "0x18483D4", Offset = "0x18483D4", VA = "0x18483D4", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x200090A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41F18", Offset = "0x41F18")]
	private sealed class _003C_003Ec__DisplayClass65_0
	{
		[Token(Token = "0x400316C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SettingsMenu _003C_003E4__this;

		[Token(Token = "0x400316D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public WTGNotification invalidNotif;

		[Token(Token = "0x400316E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public MainMenuData menu;

		[Token(Token = "0x60029EF")]
		[Address(RVA = "0x1843B30", Offset = "0x1843B30", VA = "0x1843B30")]
		public _003C_003Ec__DisplayClass65_0()
		{
		}

		[Token(Token = "0x60029F0")]
		[Address(RVA = "0x1843B38", Offset = "0x1843B38", VA = "0x1843B38")]
		internal float _003CInitAll_003Eb__0()
		{
			return default;
		}

		[Token(Token = "0x60029F1")]
		[Address(RVA = "0x1843BDC", Offset = "0x1843BDC", VA = "0x1843BDC")]
		internal float _003CInitAll_003Eb__1()
		{
			return default;
		}

		[Token(Token = "0x60029F2")]
		[Address(RVA = "0x1843C80", Offset = "0x1843C80", VA = "0x1843C80")]
		internal void _003CInitAll_003Eb__10()
		{
		}

		[Token(Token = "0x60029F3")]
		[Address(RVA = "0x1843CF0", Offset = "0x1843CF0", VA = "0x1843CF0")]
		internal void _003CInitAll_003Eb__11()
		{
		}

		[Token(Token = "0x60029F4")]
		[Address(RVA = "0x1843D60", Offset = "0x1843D60", VA = "0x1843D60")]
		internal void _003CInitAll_003Eb__12()
		{
		}

		[Token(Token = "0x60029F5")]
		[Address(RVA = "0x1843DD0", Offset = "0x1843DD0", VA = "0x1843DD0")]
		internal void _003CInitAll_003Eb__14(int value)
		{
		}

		[Token(Token = "0x60029F6")]
		[Address(RVA = "0x1843E54", Offset = "0x1843E54", VA = "0x1843E54")]
		internal void _003CInitAll_003Eb__17(int value)
		{
		}

		[Token(Token = "0x60029F7")]
		[Address(RVA = "0x1843ED8", Offset = "0x1843ED8", VA = "0x1843ED8")]
		internal void _003CInitAll_003Eb__20(int value)
		{
		}

		[Token(Token = "0x60029F8")]
		[Address(RVA = "0x1843F5C", Offset = "0x1843F5C", VA = "0x1843F5C")]
		internal void _003CInitAll_003Eb__27()
		{
		}

		[Token(Token = "0x60029F9")]
		[Address(RVA = "0x1843FFC", Offset = "0x1843FFC", VA = "0x1843FFC")]
		internal void _003CInitAll_003Eb__30()
		{
		}

		[Token(Token = "0x60029FA")]
		[Address(RVA = "0x184406C", Offset = "0x184406C", VA = "0x184406C")]
		internal int _003CInitAll_003Eb__31()
		{
			return default;
		}

		[Token(Token = "0x60029FB")]
		[Address(RVA = "0x18440F0", Offset = "0x18440F0", VA = "0x18440F0")]
		internal int _003CInitAll_003Eb__32()
		{
			return default;
		}

		[Token(Token = "0x60029FC")]
		[Address(RVA = "0x1844174", Offset = "0x1844174", VA = "0x1844174")]
		internal void _003CInitAll_003Eb__35()
		{
		}

		[Token(Token = "0x60029FD")]
		[Address(RVA = "0x18441A8", Offset = "0x18441A8", VA = "0x18441A8")]
		internal void _003CInitAll_003Eb__34(string newLanguage)
		{
		}
	}

	[Token(Token = "0x200090B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41F28", Offset = "0x41F28")]
	private sealed class _003C_003Ec__DisplayClass65_1
	{
		[Token(Token = "0x400316F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public WTGNotification notification;

		[Token(Token = "0x4003170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public _003C_003Ec__DisplayClass65_0 CS_0024_003C_003E8__locals1;

		[Token(Token = "0x60029FE")]
		[Address(RVA = "0x18443C8", Offset = "0x18443C8", VA = "0x18443C8")]
		public _003C_003Ec__DisplayClass65_1()
		{
		}

		[Token(Token = "0x60029FF")]
		[Address(RVA = "0x18443D0", Offset = "0x18443D0", VA = "0x18443D0")]
		internal void _003CInitAll_003Eb__33()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200090C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41F38", Offset = "0x41F38")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4003171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4003172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<float> _003C_003E9__65_2;

		[Token(Token = "0x4003173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Func<int> _003C_003E9__65_3;

		[Token(Token = "0x4003174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Func<List<string>> _003C_003E9__65_4;

		[Token(Token = "0x4003175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static Func<int> _003C_003E9__65_5;

		[Token(Token = "0x4003176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static Func<int> _003C_003E9__65_6;

		[Token(Token = "0x4003177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static Func<bool> _003C_003E9__65_7;

		[Token(Token = "0x4003178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static Func<bool> _003C_003E9__65_8;

		[Token(Token = "0x4003179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static Func<bool> _003C_003E9__65_9;

		[Token(Token = "0x400317A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static UnityAction _003C_003E9__65_13;

		[Token(Token = "0x400317B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static Func<int> _003C_003E9__65_15;

		[Token(Token = "0x400317C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static Func<int> _003C_003E9__65_16;

		[Token(Token = "0x400317D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static Func<int> _003C_003E9__65_18;

		[Token(Token = "0x400317E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static Func<int> _003C_003E9__65_19;

		[Token(Token = "0x400317F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static Func<int> _003C_003E9__65_21;

		[Token(Token = "0x4003180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static Func<int> _003C_003E9__65_22;

		[Token(Token = "0x4003181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static Func<int> _003C_003E9__65_23;

		[Token(Token = "0x4003182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static Func<int> _003C_003E9__65_24;

		[Token(Token = "0x4003183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public static Func<int> _003C_003E9__65_25;

		[Token(Token = "0x4003184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public static Func<int> _003C_003E9__65_26;

		[Token(Token = "0x4003185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public static Func<bool> _003C_003E9__65_28;

		[Token(Token = "0x4003186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public static Func<bool> _003C_003E9__65_29;

		[Token(Token = "0x4003187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public static Func<int> _003C_003E9__65_36;

		[Token(Token = "0x4003188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public static Action<AnimateRectTransform> _003C_003E9__79_0;

		[Token(Token = "0x4003189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public static Func<SettingsMenuCommon, float> _003C_003E9__79_1;

		[Token(Token = "0x400318A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public static Func<SettingsMenuCommon, bool> _003C_003E9__79_2;

		[Token(Token = "0x400318B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public static Action<SettingsMenuCommon> _003C_003E9__118_1;

		[Token(Token = "0x6002A01")]
		[Address(RVA = "0x1843248", Offset = "0x1843248", VA = "0x1843248")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6002A02")]
		[Address(RVA = "0x1843250", Offset = "0x1843250", VA = "0x1843250")]
		internal float _003CInitAll_003Eb__65_2()
		{
			return default;
		}

		[Token(Token = "0x6002A03")]
		[Address(RVA = "0x18432AC", Offset = "0x18432AC", VA = "0x18432AC")]
		internal int _003CInitAll_003Eb__65_3()
		{
			return default;
		}

		[Token(Token = "0x6002A04")]
		[Address(RVA = "0x18432F8", Offset = "0x18432F8", VA = "0x18432F8")]
		internal List<string> _003CInitAll_003Eb__65_4()
		{
			return null;
		}

		[Token(Token = "0x6002A05")]
		[Address(RVA = "0x1843358", Offset = "0x1843358", VA = "0x1843358")]
		internal int _003CInitAll_003Eb__65_5()
		{
			return default;
		}

		[Token(Token = "0x6002A06")]
		[Address(RVA = "0x184341C", Offset = "0x184341C", VA = "0x184341C")]
		internal int _003CInitAll_003Eb__65_6()
		{
			return default;
		}

		[Token(Token = "0x6002A07")]
		[Address(RVA = "0x1843594", Offset = "0x1843594", VA = "0x1843594")]
		internal bool _003CInitAll_003Eb__65_7()
		{
			return default;
		}

		[Token(Token = "0x6002A08")]
		[Address(RVA = "0x1843630", Offset = "0x1843630", VA = "0x1843630")]
		internal bool _003CInitAll_003Eb__65_8()
		{
			return default;
		}

		[Token(Token = "0x6002A09")]
		[Address(RVA = "0x184368C", Offset = "0x184368C", VA = "0x184368C")]
		internal bool _003CInitAll_003Eb__65_9()
		{
			return default;
		}

		[Token(Token = "0x6002A0A")]
		[Address(RVA = "0x18436D8", Offset = "0x18436D8", VA = "0x18436D8")]
		internal void _003CInitAll_003Eb__65_13()
		{
		}

		[Token(Token = "0x6002A0B")]
		[Address(RVA = "0x1843740", Offset = "0x1843740", VA = "0x1843740")]
		internal int _003CInitAll_003Eb__65_15()
		{
			return default;
		}

		[Token(Token = "0x6002A0C")]
		[Address(RVA = "0x1843748", Offset = "0x1843748", VA = "0x1843748")]
		internal int _003CInitAll_003Eb__65_16()
		{
			return default;
		}

		[Token(Token = "0x6002A0D")]
		[Address(RVA = "0x1843750", Offset = "0x1843750", VA = "0x1843750")]
		internal int _003CInitAll_003Eb__65_18()
		{
			return default;
		}

		[Token(Token = "0x6002A0E")]
		[Address(RVA = "0x1843758", Offset = "0x1843758", VA = "0x1843758")]
		internal int _003CInitAll_003Eb__65_19()
		{
			return default;
		}

		[Token(Token = "0x6002A0F")]
		[Address(RVA = "0x1843760", Offset = "0x1843760", VA = "0x1843760")]
		internal int _003CInitAll_003Eb__65_21()
		{
			return default;
		}

		[Token(Token = "0x6002A10")]
		[Address(RVA = "0x1843768", Offset = "0x1843768", VA = "0x1843768")]
		internal int _003CInitAll_003Eb__65_22()
		{
			return default;
		}

		[Token(Token = "0x6002A11")]
		[Address(RVA = "0x1843770", Offset = "0x1843770", VA = "0x1843770")]
		internal int _003CInitAll_003Eb__65_23()
		{
			return default;
		}

		[Token(Token = "0x6002A12")]
		[Address(RVA = "0x1843778", Offset = "0x1843778", VA = "0x1843778")]
		internal int _003CInitAll_003Eb__65_24()
		{
			return default;
		}

		[Token(Token = "0x6002A13")]
		[Address(RVA = "0x1843780", Offset = "0x1843780", VA = "0x1843780")]
		internal int _003CInitAll_003Eb__65_25()
		{
			return default;
		}

		[Token(Token = "0x6002A14")]
		[Address(RVA = "0x1843788", Offset = "0x1843788", VA = "0x1843788")]
		internal int _003CInitAll_003Eb__65_26()
		{
			return default;
		}

		[Token(Token = "0x6002A15")]
		[Address(RVA = "0x1843790", Offset = "0x1843790", VA = "0x1843790")]
		internal bool _003CInitAll_003Eb__65_28()
		{
			return default;
		}

		[Token(Token = "0x6002A16")]
		[Address(RVA = "0x18437EC", Offset = "0x18437EC", VA = "0x18437EC")]
		internal bool _003CInitAll_003Eb__65_29()
		{
			return default;
		}

		[Token(Token = "0x6002A17")]
		[Address(RVA = "0x1843848", Offset = "0x1843848", VA = "0x1843848")]
		internal int _003CInitAll_003Eb__65_36()
		{
			return default;
		}

		[Token(Token = "0x6002A18")]
		[Address(RVA = "0x18439C0", Offset = "0x18439C0", VA = "0x18439C0")]
		internal void _003CShow_003Eb__79_0(AnimateRectTransform a)
		{
		}

		[Token(Token = "0x6002A19")]
		[Address(RVA = "0x18439DC", Offset = "0x18439DC", VA = "0x18439DC")]
		internal float _003CShow_003Eb__79_1(SettingsMenuCommon a)
		{
			return default;
		}

		[Token(Token = "0x6002A1A")]
		[Address(RVA = "0x18439F8", Offset = "0x18439F8", VA = "0x18439F8")]
		internal bool _003CShow_003Eb__79_2(SettingsMenuCommon ui)
		{
			return default;
		}

		[Token(Token = "0x6002A1B")]
		[Address(RVA = "0x1843A10", Offset = "0x1843A10", VA = "0x1843A10")]
		internal void _003COnSelectedLineChanged_003Eb__118_1(SettingsMenuCommon ui)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x200090D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41F48", Offset = "0x41F48")]
	private struct _003CReloadHub_003Ed__70 : IAsyncStateMachine
	{
		[Token(Token = "0x400318C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x400318D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x400318E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public SettingsMenu _003C_003E4__this;

		[Token(Token = "0x400318F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TaskAwaiter _003C_003Eu__1;

		[Token(Token = "0x6002A1C")]
		[Address(RVA = "0x1846748", Offset = "0x1846748", VA = "0x1846748", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6002A1D")]
		[Address(RVA = "0x184692C", Offset = "0x184692C", VA = "0x184692C", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x200090E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41F58", Offset = "0x41F58")]
	private struct _003CPlaySecondOnboardingLevels_003Ed__71 : IAsyncStateMachine
	{
		[Token(Token = "0x4003190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x4003191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x4003192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public SettingsMenu _003C_003E4__this;

		[Token(Token = "0x4003193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TaskAwaiter<bool> _003C_003Eu__1;

		[Token(Token = "0x4003194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TaskAwaiter _003C_003Eu__2;

		[Token(Token = "0x6002A1E")]
		[Address(RVA = "0x18462F8", Offset = "0x18462F8", VA = "0x18462F8", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6002A1F")]
		[Address(RVA = "0x184673C", Offset = "0x184673C", VA = "0x184673C", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x200090F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41F68", Offset = "0x41F68")]
	private struct _003CSetInputDelay_003Ed__75 : IAsyncStateMachine
	{
		[Token(Token = "0x4003195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x4003196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x4003197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public SettingsMenu _003C_003E4__this;

		[Token(Token = "0x4003198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float delay;

		[Token(Token = "0x4003199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TaskAwaiter _003C_003Eu__1;

		[Token(Token = "0x6002A20")]
		[Address(RVA = "0x1846E54", Offset = "0x1846E54", VA = "0x1846E54", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6002A21")]
		[Address(RVA = "0x1847090", Offset = "0x1847090", VA = "0x1847090", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000910")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41F78", Offset = "0x41F78")]
	private struct _003CClose_003Ed__76 : IAsyncStateMachine
	{
		[Token(Token = "0x400319A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x400319B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x400319C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public SettingsMenu _003C_003E4__this;

		[Token(Token = "0x400319D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool showMenu;

		[Token(Token = "0x400319E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TaskAwaiter _003C_003Eu__1;

		[Token(Token = "0x6002A22")]
		[Address(RVA = "0x18444FC", Offset = "0x18444FC", VA = "0x18444FC", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6002A23")]
		[Address(RVA = "0x1844694", Offset = "0x1844694", VA = "0x1844694", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x2000911")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41F88", Offset = "0x41F88")]
	private sealed class _003C_003Ec__DisplayClass77_0
	{
		[Token(Token = "0x400319F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float animationDuration;

		[Token(Token = "0x6002A24")]
		[Address(RVA = "0x184446C", Offset = "0x184446C", VA = "0x184446C")]
		public _003C_003Ec__DisplayClass77_0()
		{
		}

		[Token(Token = "0x6002A25")]
		[Address(RVA = "0x1844474", Offset = "0x1844474", VA = "0x1844474")]
		internal void _003CCloseAsync_003Eb__0(AnimateRectTransform a)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000912")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41F98", Offset = "0x41F98")]
	private struct _003CCloseAsync_003Ed__77 : IAsyncStateMachine
	{
		[Token(Token = "0x40031A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x40031A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x40031A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SettingsMenu _003C_003E4__this;

		[Token(Token = "0x40031A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool showMenu;

		[Token(Token = "0x40031A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TaskAwaiter _003C_003Eu__1;

		[Token(Token = "0x6002A26")]
		[Address(RVA = "0x18446A0", Offset = "0x18446A0", VA = "0x18446A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6002A27")]
		[Address(RVA = "0x1844B84", Offset = "0x1844B84", VA = "0x1844B84", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x2000913")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41FA8", Offset = "0x41FA8")]
	private sealed class _003C_003Ec__DisplayClass79_0
	{
		[Token(Token = "0x40031A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float animationDuration;

		[Token(Token = "0x6002A28")]
		[Address(RVA = "0x18444B4", Offset = "0x18444B4", VA = "0x18444B4")]
		public _003C_003Ec__DisplayClass79_0()
		{
		}

		[Token(Token = "0x6002A29")]
		[Address(RVA = "0x18444BC", Offset = "0x18444BC", VA = "0x18444BC")]
		internal void _003CShow_003Eb__3(AnimateRectTransform a)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000914")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41FB8", Offset = "0x41FB8")]
	private struct _003CShow_003Ed__79 : IAsyncStateMachine
	{
		[Token(Token = "0x40031A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x40031A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x40031A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool snapToTop;

		[Token(Token = "0x40031A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public SettingsMenu _003C_003E4__this;

		[Token(Token = "0x40031AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private _003C_003Ec__DisplayClass79_0 _003C_003E8__1;

		[Token(Token = "0x40031AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private object _003C_003Eu__1;

		[Token(Token = "0x6002A2A")]
		[Address(RVA = "0x18474D4", Offset = "0x18474D4", VA = "0x18474D4", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6002A2B")]
		[Address(RVA = "0x1847F68", Offset = "0x1847F68", VA = "0x1847F68", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x2000915")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41FC8", Offset = "0x41FC8")]
	private sealed class _003CSetResolution_003Ed__84 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40031AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40031AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x1700045E")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002A2F")]
			[Address(RVA = "0x1847484", Offset = "0x1847484", VA = "0x1847484", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700045F")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002A31")]
			[Address(RVA = "0x18474CC", Offset = "0x18474CC", VA = "0x18474CC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002A2C")]
		[Address(RVA = "0x1847344", Offset = "0x1847344", VA = "0x1847344")]
		[DebuggerHidden]
		public _003CSetResolution_003Ed__84(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002A2D")]
		[Address(RVA = "0x1847370", Offset = "0x1847370", VA = "0x1847370", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002A2E")]
		[Address(RVA = "0x1847374", Offset = "0x1847374", VA = "0x1847374", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6002A2F")]
		[Address(RVA = "0x1847484", Offset = "0x1847484", VA = "0x1847484", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002A30")]
		[Address(RVA = "0x184748C", Offset = "0x184748C", VA = "0x184748C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6002A31")]
		[Address(RVA = "0x18474CC", Offset = "0x18474CC", VA = "0x18474CC", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000916")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41FD8", Offset = "0x41FD8")]
	private struct _003COnChangeSaveSlot_003Ed__86 : IAsyncStateMachine
	{
		[Token(Token = "0x40031AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x40031AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x40031B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int selected;

		[Token(Token = "0x40031B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public SettingsMenu _003C_003E4__this;

		[Token(Token = "0x40031B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool _003CisCurrentSaveSlot_003E5__2;

		[Token(Token = "0x40031B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TaskAwaiter<bool> _003C_003Eu__1;

		[Token(Token = "0x6002A32")]
		[Address(RVA = "0x1844E40", Offset = "0x1844E40", VA = "0x1844E40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6002A33")]
		[Address(RVA = "0x1845314", Offset = "0x1845314", VA = "0x1845314", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000917")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41FE8", Offset = "0x41FE8")]
	private struct _003CResetSaveSlot_003Ed__90 : IAsyncStateMachine
	{
		[Token(Token = "0x40031B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x40031B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x40031B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public SettingsMenu _003C_003E4__this;

		[Token(Token = "0x40031B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int selected;

		[Token(Token = "0x40031B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TaskAwaiter _003C_003Eu__1;

		[Token(Token = "0x40031B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TaskAwaiter<bool> _003C_003Eu__2;

		[Token(Token = "0x6002A34")]
		[Address(RVA = "0x1846938", Offset = "0x1846938", VA = "0x1846938", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6002A35")]
		[Address(RVA = "0x1846E48", Offset = "0x1846E48", VA = "0x1846E48", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000918")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41FF8", Offset = "0x41FF8")]
	private struct _003COnTutorialPressed_003Ed__95 : IAsyncStateMachine
	{
		[Token(Token = "0x40031BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x40031BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x40031BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public SettingsMenu _003C_003E4__this;

		[Token(Token = "0x40031BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TaskAwaiter<bool> _003C_003Eu__1;

		[Token(Token = "0x40031BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TaskAwaiter _003C_003Eu__2;

		[Token(Token = "0x6002A36")]
		[Address(RVA = "0x1845EC8", Offset = "0x1845EC8", VA = "0x1845EC8", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6002A37")]
		[Address(RVA = "0x18462EC", Offset = "0x18462EC", VA = "0x18462EC", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000919")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42008", Offset = "0x42008")]
	private struct _003COnHelpPressed_003Ed__96 : IAsyncStateMachine
	{
		[Token(Token = "0x40031BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x40031C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x40031C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public SettingsMenu _003C_003E4__this;

		[Token(Token = "0x40031C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TaskAwaiter _003C_003Eu__1;

		[Token(Token = "0x6002A38")]
		[Address(RVA = "0x1845320", Offset = "0x1845320", VA = "0x1845320", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6002A39")]
		[Address(RVA = "0x1845520", Offset = "0x1845520", VA = "0x1845520", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x200091A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42018", Offset = "0x42018")]
	private struct _003COnTermsOfUsePressed_003Ed__97 : IAsyncStateMachine
	{
		[Token(Token = "0x40031C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x40031C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x40031C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public SettingsMenu _003C_003E4__this;

		[Token(Token = "0x40031C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TaskAwaiter _003C_003Eu__1;

		[Token(Token = "0x6002A3A")]
		[Address(RVA = "0x1845CBC", Offset = "0x1845CBC", VA = "0x1845CBC", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6002A3B")]
		[Address(RVA = "0x1845EBC", Offset = "0x1845EBC", VA = "0x1845EBC", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x200091B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42028", Offset = "0x42028")]
	private struct _003COnSeeMoreButtonPressed_003Ed__98 : IAsyncStateMachine
	{
		[Token(Token = "0x40031C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x40031C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x40031C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public SettingsMenu _003C_003E4__this;

		[Token(Token = "0x40031CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TaskAwaiter _003C_003Eu__1;

		[Token(Token = "0x40031CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TaskAwaiter<bool> _003C_003Eu__2;

		[Token(Token = "0x40031CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private object _003C_003Eu__3;

		[Token(Token = "0x6002A3C")]
		[Address(RVA = "0x184552C", Offset = "0x184552C", VA = "0x184552C", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6002A3D")]
		[Address(RVA = "0x1845CB0", Offset = "0x1845CB0", VA = "0x1845CB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x200091C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42038", Offset = "0x42038")]
	private struct _003COnChangeAnalytics_003Ed__107 : IAsyncStateMachine
	{
		[Token(Token = "0x40031CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x40031CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x40031CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public SettingsMenu _003C_003E4__this;

		[Token(Token = "0x40031D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TaskAwaiter _003C_003Eu__1;

		[Token(Token = "0x6002A3E")]
		[Address(RVA = "0x1844B90", Offset = "0x1844B90", VA = "0x1844B90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6002A3F")]
		[Address(RVA = "0x1844E34", Offset = "0x1844E34", VA = "0x1844E34", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x200091D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42048", Offset = "0x42048")]
	private struct _003CSetPermission_003Ed__111 : IAsyncStateMachine
	{
		[Token(Token = "0x40031D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x40031D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x40031D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public SettingsMenu _003C_003E4__this;

		[Token(Token = "0x40031D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TaskAwaiter _003C_003Eu__1;

		[Token(Token = "0x6002A40")]
		[Address(RVA = "0x184709C", Offset = "0x184709C", VA = "0x184709C", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6002A41")]
		[Address(RVA = "0x1847338", Offset = "0x1847338", VA = "0x1847338", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x200091E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42058", Offset = "0x42058")]
	private sealed class _003C_003Ec__DisplayClass118_0
	{
		[Token(Token = "0x40031D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SettingsMenuCommon currentSelectionGO;

		[Token(Token = "0x6002A42")]
		[Address(RVA = "0x1843A34", Offset = "0x1843A34", VA = "0x1843A34")]
		public _003C_003Ec__DisplayClass118_0()
		{
		}

		[Token(Token = "0x6002A43")]
		[Address(RVA = "0x1843A3C", Offset = "0x1843A3C", VA = "0x1843A3C")]
		internal bool _003COnSelectedLineChanged_003Eb__0(SettingsMenuCommon ui)
		{
			return default;
		}
	}

	[Token(Token = "0x400311F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private List<AnimateRectTransform> animators;

	[Token(Token = "0x4003120")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Animator CloseButtonAnimator;

	[Token(Token = "0x4003121")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject SettingsBlocker;

	[Token(Token = "0x4003122")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public CanvasGroup SettingsCanvasGroup;

	[Token(Token = "0x4003123")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public List<SaveSlotElement> SaveSlots;

	[Token(Token = "0x4003124")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public ClipSettingsCollection volumeSliderSFX;

	[Token(Token = "0x4003125")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ClipSettingsCollection hoverButtonSFX;

	[Token(Token = "0x4003126")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public List<AudioClip> HoverOnButtonClips;

	[Token(Token = "0x4003127")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public float Volume;

	[Token(Token = "0x4003128")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public SettingsMenuCommon language;

	[Token(Token = "0x4003129")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public SettingsMenuCommon music;

	[Token(Token = "0x400312A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public SettingsMenuCommon sfx;

	[Token(Token = "0x400312B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public SettingsMenuCommon quality;

	[Token(Token = "0x400312C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public SettingsMenuCommon analytics;

	[Token(Token = "0x400312D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public SettingsMenuCommon savefile;

	[Token(Token = "0x400312E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public SettingsMenuCommon fullscreen;

	[Token(Token = "0x400312F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public SettingsMenuCommon resolution;

	[Token(Token = "0x4003130")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public SettingsMenuCommon notifications;

	[Token(Token = "0x4003131")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public SettingsMenuCommon saveslot;

	[Token(Token = "0x4003132")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public SettingsMenuCommon credits;

	[Token(Token = "0x4003133")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public SettingsMenuCommon tutorial;

	[Token(Token = "0x4003134")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public SettingsMenuCommon help;

	[Token(Token = "0x4003135")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public SettingsMenuCommon termsOfUse;

	[Token(Token = "0x4003136")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public SettingsMenuCommon switchGyroOn;

	[Token(Token = "0x4003137")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public SettingsMenuCommon ReconfigureController;

	[Token(Token = "0x4003138")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public SettingsMenuCommon useGyroShake;

	[Token(Token = "0x4003139")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public SettingsMenuCommon useDebugNotifications;

	[Token(Token = "0x400313A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public TextMeshProUGUI debugDate;

	[Token(Token = "0x400313B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public SettingsMenuCommon debugAddDays;

	[Token(Token = "0x400313C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public SettingsMenuCommon debugSetWeek;

	[Token(Token = "0x400313D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public SettingsMenuCommon debugSetWeek5;

	[Token(Token = "0x400313E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public SettingsMenuCommon debugReceptionistIndex;

	[Token(Token = "0x400313F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public SettingsMenuCommon debugBoothTurtleIndex;

	[Token(Token = "0x4003140")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public SettingsMenuCommon reloadHubButton;

	[Token(Token = "0x4003141")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	public MenuDialogueConfig receptionistConfig;

	[Token(Token = "0x4003142")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	public MenuDialogueConfig boothTurtleConfig;

	[Token(Token = "0x4003143")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	public SettingsMenuCommon incrementSessionCountButton;

	[Token(Token = "0x4003144")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	public GameObject debugStart;

	[Token(Token = "0x4003145")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	public SettingsMenuCommon seeMore;

	[Token(Token = "0x4003146")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	public TextMeshProUGUI versionText;

	[Token(Token = "0x4003147")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x4F92C", Offset = "0x4F92C")]
	public SettingsMenuCommon debugNotifications;

	[Token(Token = "0x4003148")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	public SettingsMenuCommon resetAchivements;

	[Token(Token = "0x4003149")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	public SettingsMenuCommon addAchivement;

	[Token(Token = "0x400314A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	public SettingsMenuCommon thanksgiving;

	[Token(Token = "0x400314B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	public SettingsMenuCommon secondOnboarding;

	[Token(Token = "0x400314C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	public SettingsMenuCommon leaderBoardDebug;

	[Token(Token = "0x400314D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	public NewsletterPopup helpPopup;

	[Token(Token = "0x400314E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	public NewsletterPopup termsOfUsePopup;

	[Token(Token = "0x400314F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	public CampaignStarter CampaignStarter;

	[Token(Token = "0x4003150")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	public List<SettingsMenuCommon> orderUI;

	[Token(Token = "0x4003151")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	public List<SettingsMenuCommon> allOrderUI;

	[Token(Token = "0x4003152")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	public MenuSettingsCrossPromotionAppleArcade CrossPromotion;

	[Token(Token = "0x4003153")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	private int selectedLine;

	[Token(Token = "0x4003154")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
	private bool selectedLineLockedIn;

	[Token(Token = "0x4003155")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	private float selectedSwitchDelay;

	[Token(Token = "0x4003156")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
	private float escapeDelay;

	[Token(Token = "0x4003157")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	private float playSoundDelay;

	[Token(Token = "0x4003158")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	public DebugMenu debugMenu;

	[Token(Token = "0x4003159")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	[SerializeField]
	private ScrollRect _scrollRect;

	[Token(Token = "0x400315A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	[SerializeField]
	private AnimationCurveScriptableObj _animCurve;

	[Token(Token = "0x400315B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
	private Coroutine _animateToPositionCR;

	[Token(Token = "0x400315C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
	private bool _isInputDisabled;

	[Token(Token = "0x400315D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F1")]
	private bool isInited;

	[Token(Token = "0x400315E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F2")]
	private bool bla;

	[Token(Token = "0x400315F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
	public ScrollRect scrollRect;

	[Token(Token = "0x1700045B")]
	public bool IsOpen
	{
		[Token(Token = "0x60029A8")]
		[Address(RVA = "0x1693BF0", Offset = "0x1693BF0", VA = "0x1693BF0")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x1700045C")]
	private AuthorizationStatus NotificationPermissionStatus
	{
		[Token(Token = "0x60029D5")]
		[Address(RVA = "0x169A814", Offset = "0x169A814", VA = "0x169A814")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x1700045D")]
	private bool AreNotificationsEnabled
	{
		[Token(Token = "0x60029D6")]
		[Address(RVA = "0x1697D90", Offset = "0x1697D90", VA = "0x1697D90")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x60029A9")]
	[Address(RVA = "0x1693C14", Offset = "0x1693C14", VA = "0x1693C14")]
	private void SnapToVertical(RectTransform target, bool immediate)
	{
	}

	[Token(Token = "0x60029AA")]
	[Address(RVA = "0x1693CC0", Offset = "0x1693CC0", VA = "0x1693CC0")]
	private void InitAll()
	{
	}

	[Token(Token = "0x60029AB")]
	[Address(RVA = "0x1697D70", Offset = "0x1697D70", VA = "0x1697D70")]
	private bool NotificationToggleState()
	{
		return default;
	}

	[Token(Token = "0x60029AC")]
	[Address(RVA = "0x1697DB0", Offset = "0x1697DB0", VA = "0x1697DB0")]
	private void SetReceptionistIndex(int arg0)
	{
	}

	[Token(Token = "0x60029AD")]
	[Address(RVA = "0x1697EF8", Offset = "0x1697EF8", VA = "0x1697EF8")]
	private void SetBoothTurtleIndex(int arg0)
	{
	}

	[Token(Token = "0x60029AE")]
	[Address(RVA = "0x1697DB8", Offset = "0x1697DB8", VA = "0x1697DB8")]
	private void SetMenuDialogueIndex(int arg0, MenuDialogueConfig conf)
	{
	}

	[Token(Token = "0x60029AF")]
	[Address(RVA = "0x1697F00", Offset = "0x1697F00", VA = "0x1697F00")]
	private void ReloadHub()
	{
	}

	[Token(Token = "0x60029B0")]
	[Address(RVA = "0x1697F98", Offset = "0x1697F98", VA = "0x1697F98")]
	private void PlaySecondOnboardingLevels()
	{
	}

	[Token(Token = "0x60029B1")]
	[Address(RVA = "0x1698030", Offset = "0x1698030", VA = "0x1698030")]
	private void Update()
	{
	}

	[Token(Token = "0x60029B2")]
	[Address(RVA = "0x1698798", Offset = "0x1698798", VA = "0x1698798")]
	private void UpdateCurrentlySelectedSettingsItem()
	{
	}

	[Token(Token = "0x60029B3")]
	[Address(RVA = "0x1698898", Offset = "0x1698898", VA = "0x1698898")]
	private void SetInputDelay(float delay)
	{
	}

	[Token(Token = "0x60029B4")]
	[Address(RVA = "0x16981D8", Offset = "0x16981D8", VA = "0x16981D8")]
	public void Close(bool showMenu)
	{
	}

	[Token(Token = "0x60029B5")]
	[Address(RVA = "0x1698940", Offset = "0x1698940", VA = "0x1698940")]
	public Task CloseAsync(bool showMenu)
	{
		return null;
	}

	[Token(Token = "0x60029B6")]
	[Address(RVA = "0x1698A28", Offset = "0x1698A28", VA = "0x1698A28")]
	public void Show(bool snapToTop = true)
	{
	}

	[Token(Token = "0x60029B7")]
	[Address(RVA = "0x1698ACC", Offset = "0x1698ACC", VA = "0x1698ACC")]
	private Location GetLocation()
	{
		return default;
	}

	[Token(Token = "0x60029B8")]
	[Address(RVA = "0x1698B9C", Offset = "0x1698B9C", VA = "0x1698B9C")]
	private void EnableContentByLocation(Location location)
	{
	}

	[Token(Token = "0x60029B9")]
	[Address(RVA = "0x1698DF4", Offset = "0x1698DF4", VA = "0x1698DF4")]
	public void PlaySoundOnUpdateValue()
	{
	}

	[Token(Token = "0x60029BA")]
	[Address(RVA = "0x1698E80", Offset = "0x1698E80", VA = "0x1698E80")]
	private void OnChangeFullscreen(int selected)
	{
	}

	[Token(Token = "0x60029BB")]
	[Address(RVA = "0x1699050", Offset = "0x1699050", VA = "0x1699050")]
	private IEnumerator SetResolution()
	{
		return null;
	}

	[Token(Token = "0x60029BC")]
	[Address(RVA = "0x16990AC", Offset = "0x16990AC", VA = "0x16990AC")]
	private int ClampSaveSlot(int s)
	{
		return default;
	}

	[Token(Token = "0x60029BD")]
	[Address(RVA = "0x1699128", Offset = "0x1699128", VA = "0x1699128")]
	public void OnChangeSaveSlot(int selected)
	{
	}

	[Token(Token = "0x60029BE")]
	[Address(RVA = "0x16991CC", Offset = "0x16991CC", VA = "0x16991CC")]
	private void ChangeSaveSlot(int selected)
	{
	}

	[Token(Token = "0x60029BF")]
	[Address(RVA = "0x16992BC", Offset = "0x16992BC", VA = "0x16992BC")]
	private void ResetAll()
	{
	}

	[Token(Token = "0x60029C0")]
	[Address(RVA = "0x1699494", Offset = "0x1699494", VA = "0x1699494")]
	private void OnResetSaveSlotPressed()
	{
	}

	[Token(Token = "0x60029C1")]
	[Address(RVA = "0x16995E0", Offset = "0x16995E0", VA = "0x16995E0")]
	private void ResetSaveSlot(int selected)
	{
	}

	[Token(Token = "0x60029C2")]
	[Address(RVA = "0x1699684", Offset = "0x1699684", VA = "0x1699684")]
	private void SaveSlotWindowClosed()
	{
	}

	[Token(Token = "0x60029C3")]
	[Address(RVA = "0x1699728", Offset = "0x1699728", VA = "0x1699728")]
	public void OnGyroShakeChanged()
	{
	}

	[Token(Token = "0x60029C4")]
	[Address(RVA = "0x1699890", Offset = "0x1699890", VA = "0x1699890")]
	private void OnReconfigureController()
	{
	}

	[Token(Token = "0x60029C5")]
	[Address(RVA = "0x169999C", Offset = "0x169999C", VA = "0x169999C")]
	public void OnSwitchGyroChanged()
	{
	}

	[Token(Token = "0x60029C6")]
	[Address(RVA = "0x1699B04", Offset = "0x1699B04", VA = "0x1699B04")]
	private void OnTutorialPressed()
	{
	}

	[Token(Token = "0x60029C7")]
	[Address(RVA = "0x1699B9C", Offset = "0x1699B9C", VA = "0x1699B9C")]
	private void OnHelpPressed()
	{
	}

	[Token(Token = "0x60029C8")]
	[Address(RVA = "0x1699C34", Offset = "0x1699C34", VA = "0x1699C34")]
	private void OnTermsOfUsePressed()
	{
	}

	[Token(Token = "0x60029C9")]
	[Address(RVA = "0x1699CCC", Offset = "0x1699CCC", VA = "0x1699CCC")]
	private void OnSeeMoreButtonPressed()
	{
	}

	[Token(Token = "0x60029CA")]
	[Address(RVA = "0x1699D68", Offset = "0x1699D68", VA = "0x1699D68")]
	private void OnChangeLanguage(int selected)
	{
	}

	[Token(Token = "0x60029CB")]
	[Address(RVA = "0x1699FA8", Offset = "0x1699FA8", VA = "0x1699FA8")]
	private void OnChangeResolution(int selected)
	{
	}

	[Token(Token = "0x60029CC")]
	[Address(RVA = "0x169A06C", Offset = "0x169A06C", VA = "0x169A06C")]
	private void OnChangeQuality(float val)
	{
	}

	[Token(Token = "0x60029CD")]
	[Address(RVA = "0x169A0F0", Offset = "0x169A0F0", VA = "0x169A0F0")]
	public void OnCreditsButtonPressed()
	{
	}

	[Token(Token = "0x60029CE")]
	[Address(RVA = "0x169A24C", Offset = "0x169A24C", VA = "0x169A24C")]
	private void OnChangeMusic(float val)
	{
	}

	[Token(Token = "0x60029CF")]
	[Address(RVA = "0x169A338", Offset = "0x169A338", VA = "0x169A338")]
	private void OnChangeSFX(float val)
	{
	}

	[Token(Token = "0x60029D0")]
	[Address(RVA = "0x169A424", Offset = "0x169A424", VA = "0x169A424")]
	private void OnChangeAnalytics()
	{
	}

	[Token(Token = "0x60029D1")]
	[Address(RVA = "0x169A4BC", Offset = "0x169A4BC", VA = "0x169A4BC")]
	internal void OnUseDebugNotifications()
	{
	}

	[Token(Token = "0x60029D2")]
	[Address(RVA = "0x169A5EC", Offset = "0x169A5EC", VA = "0x169A5EC")]
	private void OnChangeNotifications()
	{
	}

	[Token(Token = "0x60029D3")]
	[Address(RVA = "0x169A930", Offset = "0x169A930", VA = "0x169A930")]
	private void OnApplicationFocus(bool focus)
	{
	}

	[Token(Token = "0x60029D4")]
	[Address(RVA = "0x169AA5C", Offset = "0x169AA5C", VA = "0x169AA5C")]
	private void SetPermission()
	{
	}

	[Token(Token = "0x60029D7")]
	[Address(RVA = "0x169A884", Offset = "0x169A884", VA = "0x169A884")]
	public void OpenSettings()
	{
	}

	[Token(Token = "0x60029D8")]
	[Address(RVA = "0x1698278", Offset = "0x1698278", VA = "0x1698278")]
	private int GetNewSelectedLine()
	{
		return default;
	}

	[Token(Token = "0x60029D9")]
	[Address(RVA = "0x1698344", Offset = "0x1698344", VA = "0x1698344")]
	private void OnSelectedLineChanged(int newActive, bool immediate)
	{
	}

	[Token(Token = "0x60029DA")]
	[Address(RVA = "0x1699274", Offset = "0x1699274", VA = "0x1699274")]
	private void SetInteractable(bool interactable)
	{
	}

	[Token(Token = "0x60029DB")]
	[Address(RVA = "0x169AAF4", Offset = "0x169AAF4", VA = "0x169AAF4")]
	public void OnDropdownSelected(bool lockedIn)
	{
	}

	[Token(Token = "0x60029DC")]
	[Address(RVA = "0x169AB0C", Offset = "0x169AB0C", VA = "0x169AB0C")]
	private static List<string> GetFullscreenOptions()
	{
		return null;
	}

	[Token(Token = "0x60029DD")]
	[Address(RVA = "0x1697AD0", Offset = "0x1697AD0", VA = "0x1697AD0")]
	private void RefreshSaveSlot()
	{
	}

	[Token(Token = "0x60029DE")]
	[Address(RVA = "0x16971B4", Offset = "0x16971B4", VA = "0x16971B4")]
	private SettingsMenuSlider getAsSlider(ref SettingsMenuCommon s)
	{
		return null;
	}

	[Token(Token = "0x60029DF")]
	[Address(RVA = "0x16972AC", Offset = "0x16972AC", VA = "0x16972AC")]
	private SettingsMenuDropdown getAsDropdown(ref SettingsMenuCommon s)
	{
		return null;
	}

	[Token(Token = "0x60029E0")]
	[Address(RVA = "0x16973AC", Offset = "0x16973AC", VA = "0x16973AC")]
	private SettingsMenuToggle getAsToggle(ref SettingsMenuCommon s)
	{
		return null;
	}

	[Token(Token = "0x60029E1")]
	[Address(RVA = "0x169753C", Offset = "0x169753C", VA = "0x169753C")]
	private SettingsMenuButton getAsButton(ref SettingsMenuCommon s)
	{
		return null;
	}

	[Token(Token = "0x60029E2")]
	[Address(RVA = "0x1697718", Offset = "0x1697718", VA = "0x1697718")]
	private SettingsMenuButtonRow getAsButtonRow(ref SettingsMenuCommon s)
	{
		return null;
	}

	[Token(Token = "0x60029E3")]
	[Address(RVA = "0x169ACD8", Offset = "0x169ACD8", VA = "0x169ACD8")]
	public void Register(SettingsMenuCommon settingsMenuCommon)
	{
	}

	[Token(Token = "0x60029E4")]
	[Address(RVA = "0x169AD3C", Offset = "0x169AD3C", VA = "0x169AD3C")]
	public SettingsMenu()
	{
	}

	[Token(Token = "0x60029E5")]
	[Address(RVA = "0x169AD9C", Offset = "0x169AD9C", VA = "0x169AD9C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67630", Offset = "0x67630")]
	private void _003COnResetSaveSlotPressed_003Eb__89_0()
	{
	}

	[Token(Token = "0x60029E6")]
	[Address(RVA = "0x169AE88", Offset = "0x169AE88", VA = "0x169AE88")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67640", Offset = "0x67640")]
	private void _003COnCreditsButtonPressed_003Eb__102_0()
	{
	}

	[Token(Token = "0x60029E7")]
	[Address(RVA = "0x169AF28", Offset = "0x169AF28", VA = "0x169AF28")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67650", Offset = "0x67650")]
	private void _003COnChangeAnalytics_003Eb__107_0(bool _)
	{
	}

	[Token(Token = "0x60029E8")]
	[Address(RVA = "0x169B114", Offset = "0x169B114", VA = "0x169B114")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67660", Offset = "0x67660")]
	private void _003COnChangeAnalytics_003Eb__107_1()
	{
	}

	[Token(Token = "0x60029E9")]
	[Address(RVA = "0x169B1B4", Offset = "0x169B1B4", VA = "0x169B1B4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67670", Offset = "0x67670")]
	private void _003COnChangeNotifications_003Eb__109_0()
	{
	}

	[Token(Token = "0x60029EA")]
	[Address(RVA = "0x169B250", Offset = "0x169B250", VA = "0x169B250")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67680", Offset = "0x67680")]
	private void _003COnChangeNotifications_003Eg__Done_007C109_1(bool _)
	{
	}
}
