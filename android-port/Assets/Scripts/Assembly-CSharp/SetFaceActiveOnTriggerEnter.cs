using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000DD8")]
public class SetFaceActiveOnTriggerEnter : MonoBehaviour
{
	[Token(Token = "0x2000DD9")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44D30", Offset = "0x44D30")]
	private sealed class _003CStartCR_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4004B66")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4004B67")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4004B68")]
		[FieldOffset(Offset = "0x20")]
		public SetFaceActiveOnTriggerEnter _003C_003E4__this;

		[Token(Token = "0x170006B8")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600413B")]
			[Address(RVA = "0x1842D00", Offset = "0x1842D00", VA = "0x1842D00", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170006B9")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600413D")]
			[Address(RVA = "0x1842D48", Offset = "0x1842D48", VA = "0x1842D48", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6004138")]
		[Address(RVA = "0x1842C18", Offset = "0x1842C18", VA = "0x1842C18")]
		[DebuggerHidden]
		public _003CStartCR_003Ed__5(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6004139")]
		[Address(RVA = "0x1842C44", Offset = "0x1842C44", VA = "0x1842C44", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600413A")]
		[Address(RVA = "0x1842C48", Offset = "0x1842C48", VA = "0x1842C48", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600413B")]
		[Address(RVA = "0x1842D00", Offset = "0x1842D00", VA = "0x1842D00", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600413C")]
		[Address(RVA = "0x1842D08", Offset = "0x1842D08", VA = "0x1842D08", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600413D")]
		[Address(RVA = "0x1842D48", Offset = "0x1842D48", VA = "0x1842D48", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4004B62")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject _face;

	[Token(Token = "0x4004B63")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private bool _playAudio;

	[Token(Token = "0x4004B64")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private ClipSettingsCollection _sfx;

	[Token(Token = "0x4004B65")]
	[FieldOffset(Offset = "0x30")]
	private bool _playSfx;

	[Token(Token = "0x6004133")]
	[Address(RVA = "0x168CA9C", Offset = "0x168CA9C", VA = "0x168CA9C")]
	private void Start()
	{
	}

	[Token(Token = "0x6004134")]
	[Address(RVA = "0x168CB18", Offset = "0x168CB18", VA = "0x168CB18")]
	private IEnumerator StartCR()
	{
		return null;
	}

	[Token(Token = "0x6004135")]
	[Address(RVA = "0x168CB8C", Offset = "0x168CB8C", VA = "0x168CB8C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6004136")]
	[Address(RVA = "0x168CC08", Offset = "0x168CC08", VA = "0x168CC08")]
	private void OnTriggerEnter2D(Collider2D other)
	{
	}

	[Token(Token = "0x6004137")]
	[Address(RVA = "0x168CCEC", Offset = "0x168CCEC", VA = "0x168CCEC")]
	public SetFaceActiveOnTriggerEnter()
	{
	}
}
