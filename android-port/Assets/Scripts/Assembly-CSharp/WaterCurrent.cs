using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20005F2")]
public class WaterCurrent : MonoBehaviour
{
	[Token(Token = "0x20005F3")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40920", Offset = "0x40920")]
	private sealed class _003CStart_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001E6B")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001E6C")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001E6D")]
		[FieldOffset(Offset = "0x20")]
		public WaterCurrent _003C_003E4__this;

		[Token(Token = "0x4001E6E")]
		[FieldOffset(Offset = "0x28")]
		private float _003Cd_003E5__2;

		[Token(Token = "0x170002F6")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001B15")]
			[Address(RVA = "0x1876E38", Offset = "0x1876E38", VA = "0x1876E38", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170002F7")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001B17")]
			[Address(RVA = "0x1876E80", Offset = "0x1876E80", VA = "0x1876E80", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001B12")]
		[Address(RVA = "0x1876CF4", Offset = "0x1876CF4", VA = "0x1876CF4")]
		[DebuggerHidden]
		public _003CStart_003Ed__5(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001B13")]
		[Address(RVA = "0x1876D20", Offset = "0x1876D20", VA = "0x1876D20", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001B14")]
		[Address(RVA = "0x1876D24", Offset = "0x1876D24", VA = "0x1876D24", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001B15")]
		[Address(RVA = "0x1876E38", Offset = "0x1876E38", VA = "0x1876E38", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001B16")]
		[Address(RVA = "0x1876E40", Offset = "0x1876E40", VA = "0x1876E40", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001B17")]
		[Address(RVA = "0x1876E80", Offset = "0x1876E80", VA = "0x1876E80", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4001E67")]
	[FieldOffset(Offset = "0x18")]
	private Vector3 startPosition;

	[Token(Token = "0x4001E68")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private Vector3 velocity;

	[Token(Token = "0x4001E69")]
	[FieldOffset(Offset = "0x30")]
	private float maxDistance;

	[Token(Token = "0x4001E6A")]
	[FieldOffset(Offset = "0x38")]
	private Rigidbody rigidbody;

	[Token(Token = "0x6001B0F")]
	[Address(RVA = "0x17504C4", Offset = "0x17504C4", VA = "0x17504C4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001B10")]
	[Address(RVA = "0x1750544", Offset = "0x1750544", VA = "0x1750544")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x6001B11")]
	[Address(RVA = "0x17505B8", Offset = "0x17505B8", VA = "0x17505B8")]
	public WaterCurrent()
	{
	}
}
