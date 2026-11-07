using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using CameraStack;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Tilemaps;

[Token(Token = "0x2000A2C")]
public class OverworldSecretWall : MonoBehaviour
{
	[Token(Token = "0x2000A2D")]
	public enum ButtonType
	{
		[Token(Token = "0x4003844")]
		fromAbove = 0
	}

	[Token(Token = "0x2000A2E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42AE8", Offset = "0x42AE8")]
	private sealed class _003COpenRoutine_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4003845")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4003846")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4003847")]
		[FieldOffset(Offset = "0x20")]
		public bool instant;

		[Token(Token = "0x4003848")]
		[FieldOffset(Offset = "0x28")]
		public OverworldSecretWall _003C_003E4__this;

		[Token(Token = "0x4003849")]
		[FieldOffset(Offset = "0x30")]
		private Vector3Int _003Cpos_003E5__2;

		[Token(Token = "0x400384A")]
		[FieldOffset(Offset = "0x3C")]
		private bool _003CdidChangeGround_003E5__3;

		[Token(Token = "0x400384B")]
		[FieldOffset(Offset = "0x40")]
		private int _003Cy_003E5__4;

		[Token(Token = "0x17000504")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600307D")]
			[Address(RVA = "0x181D8F4", Offset = "0x181D8F4", VA = "0x181D8F4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000505")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600307F")]
			[Address(RVA = "0x181D93C", Offset = "0x181D93C", VA = "0x181D93C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600307A")]
		[Address(RVA = "0x181D438", Offset = "0x181D438", VA = "0x181D438")]
		[DebuggerHidden]
		public _003COpenRoutine_003Ed__11(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600307B")]
		[Address(RVA = "0x181D464", Offset = "0x181D464", VA = "0x181D464", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600307C")]
		[Address(RVA = "0x181D468", Offset = "0x181D468", VA = "0x181D468", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600307D")]
		[Address(RVA = "0x181D8F4", Offset = "0x181D8F4", VA = "0x181D8F4", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600307E")]
		[Address(RVA = "0x181D8FC", Offset = "0x181D8FC", VA = "0x181D8FC", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600307F")]
		[Address(RVA = "0x181D93C", Offset = "0x181D93C", VA = "0x181D93C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x400383B")]
	[FieldOffset(Offset = "0x18")]
	public Transform bounds;

	[Token(Token = "0x400383C")]
	[FieldOffset(Offset = "0x20")]
	public Tile groundTile;

	[Token(Token = "0x400383D")]
	[FieldOffset(Offset = "0x28")]
	public ButtonType orientation;

	[Token(Token = "0x400383E")]
	[FieldOffset(Offset = "0x30")]
	public GameObject fromTop;

	[Token(Token = "0x400383F")]
	[FieldOffset(Offset = "0x38")]
	private bool isOpen;

	[Token(Token = "0x4003840")]
	[FieldOffset(Offset = "0x40")]
	private GridFiller filler;

	[Token(Token = "0x4003841")]
	[FieldOffset(Offset = "0x48")]
	private readonly string saveFormat;

	[Token(Token = "0x4003842")]
	[FieldOffset(Offset = "0x50")]
	private OverworldCamera camera;

	[Token(Token = "0x6003074")]
	[Address(RVA = "0x15CB868", Offset = "0x15CB868", VA = "0x15CB868")]
	public void Init(GridFiller gridFiller)
	{
	}

	[Token(Token = "0x6003075")]
	[Address(RVA = "0x15CBC1C", Offset = "0x15CBC1C", VA = "0x15CBC1C")]
	private void Open(bool instant)
	{
	}

	[Token(Token = "0x6003076")]
	[Address(RVA = "0x15CBCBC", Offset = "0x15CBCBC", VA = "0x15CBCBC")]
	private IEnumerator OpenRoutine(bool instant)
	{
		return null;
	}

	[Token(Token = "0x6003077")]
	[Address(RVA = "0x15CBD38", Offset = "0x15CBD38", VA = "0x15CBD38")]
	private void OnCollisionEnter2D(Collision2D collision)
	{
	}

	[Token(Token = "0x6003078")]
	[Address(RVA = "0x15CC010", Offset = "0x15CC010", VA = "0x15CC010")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6003079")]
	[Address(RVA = "0x15CC130", Offset = "0x15CC130", VA = "0x15CC130")]
	public OverworldSecretWall()
	{
	}
}
