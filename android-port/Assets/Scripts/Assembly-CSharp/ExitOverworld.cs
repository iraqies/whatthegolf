using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000E51")]
public class ExitOverworld : MonoBehaviour
{
	[Token(Token = "0x2000E52")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44FB8", Offset = "0x44FB8")]
	private sealed class _003CExitOverworldRoutine_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4004DB0")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4004DB1")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4004DB2")]
		[FieldOffset(Offset = "0x20")]
		public ExitOverworld _003C_003E4__this;

		[Token(Token = "0x170006E1")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6004305")]
			[Address(RVA = "0x17A1628", Offset = "0x17A1628", VA = "0x17A1628", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170006E2")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6004307")]
			[Address(RVA = "0x17A1670", Offset = "0x17A1670", VA = "0x17A1670", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6004302")]
		[Address(RVA = "0x17A1444", Offset = "0x17A1444", VA = "0x17A1444")]
		[DebuggerHidden]
		public _003CExitOverworldRoutine_003Ed__4(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6004303")]
		[Address(RVA = "0x17A1470", Offset = "0x17A1470", VA = "0x17A1470", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6004304")]
		[Address(RVA = "0x17A1474", Offset = "0x17A1474", VA = "0x17A1474", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6004305")]
		[Address(RVA = "0x17A1628", Offset = "0x17A1628", VA = "0x17A1628", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6004306")]
		[Address(RVA = "0x17A1630", Offset = "0x17A1630", VA = "0x17A1630", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6004307")]
		[Address(RVA = "0x17A1670", Offset = "0x17A1670", VA = "0x17A1670", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4004DAD")]
	[FieldOffset(Offset = "0x18")]
	public float delay;

	[Token(Token = "0x4004DAE")]
	[FieldOffset(Offset = "0x1C")]
	private bool _exiting;

	[Token(Token = "0x4004DAF")]
	[FieldOffset(Offset = "0x20")]
	public Transition.TransitionEffect TransitionEffectType;

	[Token(Token = "0x60042FF")]
	[Address(RVA = "0x144EE38", Offset = "0x144EE38", VA = "0x144EE38")]
	public void ExitToMenu()
	{
	}

	[Token(Token = "0x6004300")]
	[Address(RVA = "0x144EED0", Offset = "0x144EED0", VA = "0x144EED0")]
	private IEnumerator ExitOverworldRoutine()
	{
		return null;
	}

	[Token(Token = "0x6004301")]
	[Address(RVA = "0x144EF44", Offset = "0x144EF44", VA = "0x144EF44")]
	public ExitOverworld()
	{
	}
}
