using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200099E")]
public class CompetitionOverworld : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x200099F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42610", Offset = "0x42610")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x40034FF")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4003500")]
		[FieldOffset(Offset = "0x8")]
		public static Action _003C_003E9__6_0;

		[Token(Token = "0x4003501")]
		[FieldOffset(Offset = "0x10")]
		public static Action<bool> _003C_003E9__7_1;

		[Token(Token = "0x6002D36")]
		[Address(RVA = "0x178E3A4", Offset = "0x178E3A4", VA = "0x178E3A4")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6002D37")]
		[Address(RVA = "0x178E3AC", Offset = "0x178E3AC", VA = "0x178E3AC")]
		internal void _003CdelayedStartMusic_003Eb__6_0()
		{
		}

		[Token(Token = "0x6002D38")]
		[Address(RVA = "0x178E3D8", Offset = "0x178E3D8", VA = "0x178E3D8")]
		internal void _003CPlayOnboardingLevels_003Eb__7_1(bool isCompleted)
		{
		}
	}

	[Token(Token = "0x20009A0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42620", Offset = "0x42620")]
	private sealed class _003CdelayedStartMusic_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4003502")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4003503")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x170004AE")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002D3C")]
			[Address(RVA = "0x178EAE4", Offset = "0x178EAE4", VA = "0x178EAE4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170004AF")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002D3E")]
			[Address(RVA = "0x178EB2C", Offset = "0x178EB2C", VA = "0x178EB2C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002D39")]
		[Address(RVA = "0x178E928", Offset = "0x178E928", VA = "0x178E928")]
		[DebuggerHidden]
		public _003CdelayedStartMusic_003Ed__6(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002D3A")]
		[Address(RVA = "0x178E954", Offset = "0x178E954", VA = "0x178E954", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002D3B")]
		[Address(RVA = "0x178E958", Offset = "0x178E958", VA = "0x178E958", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6002D3C")]
		[Address(RVA = "0x178EAE4", Offset = "0x178EAE4", VA = "0x178EAE4", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002D3D")]
		[Address(RVA = "0x178EAEC", Offset = "0x178EAEC", VA = "0x178EAEC", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6002D3E")]
		[Address(RVA = "0x178EB2C", Offset = "0x178EB2C", VA = "0x178EB2C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x20009A1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42630", Offset = "0x42630")]
	private sealed class _003CPlayOnboardingLevels_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4003504")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4003505")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4003506")]
		[FieldOffset(Offset = "0x20")]
		public CompetitionOverworld _003C_003E4__this;

		[Token(Token = "0x4003507")]
		[FieldOffset(Offset = "0x28")]
		private int _003Ci_003E5__2;

		[Token(Token = "0x170004B0")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002D42")]
			[Address(RVA = "0x178E8D8", Offset = "0x178E8D8", VA = "0x178E8D8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170004B1")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002D44")]
			[Address(RVA = "0x178E920", Offset = "0x178E920", VA = "0x178E920", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002D3F")]
		[Address(RVA = "0x178E3DC", Offset = "0x178E3DC", VA = "0x178E3DC")]
		[DebuggerHidden]
		public _003CPlayOnboardingLevels_003Ed__7(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002D40")]
		[Address(RVA = "0x178E408", Offset = "0x178E408", VA = "0x178E408", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002D41")]
		[Address(RVA = "0x178E40C", Offset = "0x178E40C", VA = "0x178E40C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6002D42")]
		[Address(RVA = "0x178E8D8", Offset = "0x178E8D8", VA = "0x178E8D8", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002D43")]
		[Address(RVA = "0x178E8E0", Offset = "0x178E8E0", VA = "0x178E8E0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6002D44")]
		[Address(RVA = "0x178E920", Offset = "0x178E920", VA = "0x178E920", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x40034FA")]
	[FieldOffset(Offset = "0x18")]
	public int startIndex;

	[Token(Token = "0x40034FB")]
	[FieldOffset(Offset = "0x20")]
	public List<GameObject> disableWhilePlaying;

	[Token(Token = "0x40034FC")]
	[FieldOffset(Offset = "0x28")]
	public LevelDataContainer onboardingLevels;

	[Token(Token = "0x40034FD")]
	[FieldOffset(Offset = "0x30")]
	public MusicData music;

	[Token(Token = "0x40034FE")]
	[FieldOffset(Offset = "0x38")]
	public GameObject saveText;

	[Token(Token = "0x6002D30")]
	[Address(RVA = "0x18A9CEC", Offset = "0x18A9CEC", VA = "0x18A9CEC")]
	private void Start()
	{
	}

	[Token(Token = "0x6002D31")]
	[Address(RVA = "0x18A9DDC", Offset = "0x18A9DDC", VA = "0x18A9DDC")]
	private IEnumerator delayedStartMusic()
	{
		return null;
	}

	[Token(Token = "0x6002D32")]
	[Address(RVA = "0x18A9D68", Offset = "0x18A9D68", VA = "0x18A9D68")]
	private IEnumerator PlayOnboardingLevels()
	{
		return null;
	}

	[Token(Token = "0x6002D33")]
	[Address(RVA = "0x18A9E38", Offset = "0x18A9E38", VA = "0x18A9E38")]
	public CompetitionOverworld()
	{
	}

	[Token(Token = "0x6002D34")]
	[Address(RVA = "0x18A9E40", Offset = "0x18A9E40", VA = "0x18A9E40")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68484", Offset = "0x68484")]
	private void _003CPlayOnboardingLevels_003Eb__7_0(Level.CompletedState s)
	{
	}
}
