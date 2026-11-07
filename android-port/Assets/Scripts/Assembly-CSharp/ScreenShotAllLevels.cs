using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000DD3")]
public class ScreenShotAllLevels : MonoBehaviour
{
	[Token(Token = "0x2000DD4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44D20", Offset = "0x44D20")]
	private sealed class _003CPlayAllLevels_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4004B58")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4004B59")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4004B5A")]
		[FieldOffset(Offset = "0x20")]
		public ScreenShotAllLevels _003C_003E4__this;

		[Token(Token = "0x4004B5B")]
		[FieldOffset(Offset = "0x28")]
		private List<LevelData>.Enumerator _003C_003E7__wrap1;

		[Token(Token = "0x4004B5C")]
		[FieldOffset(Offset = "0x40")]
		private LevelData _003ClevelData_003E5__3;

		[Token(Token = "0x170006B6")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6004128")]
			[Address(RVA = "0x183F3E4", Offset = "0x183F3E4", VA = "0x183F3E4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170006B7")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600412A")]
			[Address(RVA = "0x183F42C", Offset = "0x183F42C", VA = "0x183F42C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6004124")]
		[Address(RVA = "0x183EE80", Offset = "0x183EE80", VA = "0x183EE80")]
		[DebuggerHidden]
		public _003CPlayAllLevels_003Ed__3(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6004125")]
		[Address(RVA = "0x183EEAC", Offset = "0x183EEAC", VA = "0x183EEAC", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6004126")]
		[Address(RVA = "0x183EF8C", Offset = "0x183EF8C", VA = "0x183EF8C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6004127")]
		[Address(RVA = "0x183EF30", Offset = "0x183EF30", VA = "0x183EF30")]
		private void _003C_003Em__Finally1()
		{
		}

		[Token(Token = "0x6004128")]
		[Address(RVA = "0x183F3E4", Offset = "0x183F3E4", VA = "0x183F3E4", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6004129")]
		[Address(RVA = "0x183F3EC", Offset = "0x183F3EC", VA = "0x183F3EC", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600412A")]
		[Address(RVA = "0x183F42C", Offset = "0x183F42C", VA = "0x183F42C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4004B56")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private LevelDataContainer container;

	[Token(Token = "0x4004B57")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private string _folderPath;

	[Token(Token = "0x6004121")]
	[Address(RVA = "0x167D570", Offset = "0x167D570", VA = "0x167D570")]
	private void Start()
	{
	}

	[Token(Token = "0x6004122")]
	[Address(RVA = "0x167D64C", Offset = "0x167D64C", VA = "0x167D64C")]
	private IEnumerator PlayAllLevels()
	{
		return null;
	}

	[Token(Token = "0x6004123")]
	[Address(RVA = "0x167D6C0", Offset = "0x167D6C0", VA = "0x167D6C0")]
	public ScreenShotAllLevels()
	{
	}
}
