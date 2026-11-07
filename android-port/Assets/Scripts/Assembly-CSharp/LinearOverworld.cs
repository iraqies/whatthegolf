using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20009D2")]
public class LinearOverworld : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20009D3")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42750", Offset = "0x42750")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4003601")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4003602")]
		[FieldOffset(Offset = "0x8")]
		public static Action _003C_003E9__9_0;

		[Token(Token = "0x4003603")]
		[FieldOffset(Offset = "0x10")]
		public static Action<Level.CompletedState> _003C_003E9__10_0;

		[Token(Token = "0x4003604")]
		[FieldOffset(Offset = "0x18")]
		public static Action<bool> _003C_003E9__10_2;

		[Token(Token = "0x6002E3B")]
		[Address(RVA = "0x17E92D0", Offset = "0x17E92D0", VA = "0x17E92D0")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6002E3C")]
		[Address(RVA = "0x17E92D8", Offset = "0x17E92D8", VA = "0x17E92D8")]
		internal void _003CdelayedStartMusic_003Eb__9_0()
		{
		}

		[Token(Token = "0x6002E3D")]
		[Address(RVA = "0x17E9304", Offset = "0x17E9304", VA = "0x17E9304")]
		internal void _003CPlayOnboardingLevels_003Eb__10_0(Level.CompletedState s)
		{
		}

		[Token(Token = "0x6002E3E")]
		[Address(RVA = "0x17E9308", Offset = "0x17E9308", VA = "0x17E9308")]
		internal void _003CPlayOnboardingLevels_003Eb__10_2(bool isCompleted)
		{
		}
	}

	[Token(Token = "0x20009D4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42760", Offset = "0x42760")]
	private sealed class _003CdelayedStartMusic_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4003605")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4003606")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x170004C5")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002E42")]
			[Address(RVA = "0x17E9C08", Offset = "0x17E9C08", VA = "0x17E9C08", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170004C6")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002E44")]
			[Address(RVA = "0x17E9C50", Offset = "0x17E9C50", VA = "0x17E9C50", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002E3F")]
		[Address(RVA = "0x17E9A4C", Offset = "0x17E9A4C", VA = "0x17E9A4C")]
		[DebuggerHidden]
		public _003CdelayedStartMusic_003Ed__9(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002E40")]
		[Address(RVA = "0x17E9A78", Offset = "0x17E9A78", VA = "0x17E9A78", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002E41")]
		[Address(RVA = "0x17E9A7C", Offset = "0x17E9A7C", VA = "0x17E9A7C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6002E42")]
		[Address(RVA = "0x17E9C08", Offset = "0x17E9C08", VA = "0x17E9C08", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002E43")]
		[Address(RVA = "0x17E9C10", Offset = "0x17E9C10", VA = "0x17E9C10", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6002E44")]
		[Address(RVA = "0x17E9C50", Offset = "0x17E9C50", VA = "0x17E9C50", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x20009D5")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42770", Offset = "0x42770")]
	private sealed class _003C_003Ec__DisplayClass10_0
	{
		[Token(Token = "0x4003607")]
		[FieldOffset(Offset = "0x10")]
		public int i;

		[Token(Token = "0x6002E45")]
		[Address(RVA = "0x17E930C", Offset = "0x17E930C", VA = "0x17E930C")]
		public _003C_003Ec__DisplayClass10_0()
		{
		}

		[Token(Token = "0x6002E46")]
		[Address(RVA = "0x17E9314", Offset = "0x17E9314", VA = "0x17E9314")]
		internal void _003CPlayOnboardingLevels_003Eb__1()
		{
		}
	}

	[Token(Token = "0x20009D6")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42780", Offset = "0x42780")]
	private sealed class _003CPlayOnboardingLevels_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4003608")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4003609")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400360A")]
		[FieldOffset(Offset = "0x20")]
		public LinearOverworld _003C_003E4__this;

		[Token(Token = "0x400360B")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass10_0 _003C_003E8__1;

		[Token(Token = "0x170004C7")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002E4A")]
			[Address(RVA = "0x17E99FC", Offset = "0x17E99FC", VA = "0x17E99FC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170004C8")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002E4C")]
			[Address(RVA = "0x17E9A44", Offset = "0x17E9A44", VA = "0x17E9A44", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002E47")]
		[Address(RVA = "0x17E9320", Offset = "0x17E9320", VA = "0x17E9320")]
		[DebuggerHidden]
		public _003CPlayOnboardingLevels_003Ed__10(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002E48")]
		[Address(RVA = "0x17E934C", Offset = "0x17E934C", VA = "0x17E934C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002E49")]
		[Address(RVA = "0x17E9350", Offset = "0x17E9350", VA = "0x17E9350", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6002E4A")]
		[Address(RVA = "0x17E99FC", Offset = "0x17E99FC", VA = "0x17E99FC", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002E4B")]
		[Address(RVA = "0x17E9A04", Offset = "0x17E9A04", VA = "0x17E9A04", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6002E4C")]
		[Address(RVA = "0x17E9A44", Offset = "0x17E9A44", VA = "0x17E9A44", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x40035F9")]
	[FieldOffset(Offset = "0x18")]
	public bool HideRestart;

	[Token(Token = "0x40035FA")]
	[FieldOffset(Offset = "0x19")]
	public bool HideExit;

	[Token(Token = "0x40035FB")]
	[FieldOffset(Offset = "0x1A")]
	public bool HideStats;

	[Token(Token = "0x40035FC")]
	[FieldOffset(Offset = "0x1C")]
	public int startIndex;

	[Token(Token = "0x40035FD")]
	[FieldOffset(Offset = "0x20")]
	public List<GameObject> disableWhilePlaying;

	[Token(Token = "0x40035FE")]
	[FieldOffset(Offset = "0x28")]
	public LevelDataContainer onboardingLevels;

	[Token(Token = "0x40035FF")]
	[FieldOffset(Offset = "0x30")]
	public MusicData menuMusic;

	[Token(Token = "0x4003600")]
	[FieldOffset(Offset = "0x38")]
	public float MusicVolume;

	[Token(Token = "0x6002E36")]
	[Address(RVA = "0x1533FC4", Offset = "0x1533FC4", VA = "0x1533FC4")]
	private void Start()
	{
	}

	[Token(Token = "0x6002E37")]
	[Address(RVA = "0x15340B4", Offset = "0x15340B4", VA = "0x15340B4")]
	private IEnumerator delayedStartMusic()
	{
		return null;
	}

	[Token(Token = "0x6002E38")]
	[Address(RVA = "0x1534040", Offset = "0x1534040", VA = "0x1534040")]
	private IEnumerator PlayOnboardingLevels()
	{
		return null;
	}

	[Token(Token = "0x6002E39")]
	[Address(RVA = "0x1534110", Offset = "0x1534110", VA = "0x1534110")]
	public LinearOverworld()
	{
	}
}
