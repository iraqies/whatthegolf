using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D70")]
public class EvilFlagOther2D : MonoBehaviour
{
	[Token(Token = "0x2000D71")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x449C0", Offset = "0x449C0")]
	private sealed class _003CLerpPositions_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4004915")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4004916")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4004917")]
		[FieldOffset(Offset = "0x20")]
		public EvilFlagOther2D _003C_003E4__this;

		[Token(Token = "0x4004918")]
		[FieldOffset(Offset = "0x28")]
		public Vector2 targetPosition;

		[Token(Token = "0x4004919")]
		[FieldOffset(Offset = "0x30")]
		public float duration;

		[Token(Token = "0x400491A")]
		[FieldOffset(Offset = "0x34")]
		private float _003Ctime_003E5__2;

		[Token(Token = "0x400491B")]
		[FieldOffset(Offset = "0x38")]
		private Vector2 _003CstartPosition_003E5__3;

		[Token(Token = "0x1700066E")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003F39")]
			[Address(RVA = "0x17A1294", Offset = "0x17A1294", VA = "0x17A1294", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700066F")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003F3B")]
			[Address(RVA = "0x17A12DC", Offset = "0x17A12DC", VA = "0x17A12DC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003F36")]
		[Address(RVA = "0x17A112C", Offset = "0x17A112C", VA = "0x17A112C")]
		[DebuggerHidden]
		public _003CLerpPositions_003Ed__6(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003F37")]
		[Address(RVA = "0x17A1158", Offset = "0x17A1158", VA = "0x17A1158", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003F38")]
		[Address(RVA = "0x17A115C", Offset = "0x17A115C", VA = "0x17A115C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6003F39")]
		[Address(RVA = "0x17A1294", Offset = "0x17A1294", VA = "0x17A1294", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003F3A")]
		[Address(RVA = "0x17A129C", Offset = "0x17A129C", VA = "0x17A129C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6003F3B")]
		[Address(RVA = "0x17A12DC", Offset = "0x17A12DC", VA = "0x17A12DC", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4004910")]
	[FieldOffset(Offset = "0x18")]
	public Transform[] positionsToMoveTo;

	[Token(Token = "0x4004911")]
	[FieldOffset(Offset = "0x20")]
	public float velocity;

	[Token(Token = "0x4004912")]
	[FieldOffset(Offset = "0x28")]
	public AnimationCurve animationCurve;

	[Token(Token = "0x4004913")]
	[FieldOffset(Offset = "0x30")]
	private bool isMoving;

	[Token(Token = "0x4004914")]
	[FieldOffset(Offset = "0x34")]
	private int currentTarget;

	[Token(Token = "0x6003F33")]
	[Address(RVA = "0x144CAB8", Offset = "0x144CAB8", VA = "0x144CAB8")]
	private void OnTriggerEnter2D(Collider2D collision)
	{
	}

	[Token(Token = "0x6003F34")]
	[Address(RVA = "0x144CC94", Offset = "0x144CC94", VA = "0x144CC94")]
	private IEnumerator LerpPositions(Vector2 targetPosition, float duration)
	{
		return null;
	}

	[Token(Token = "0x6003F35")]
	[Address(RVA = "0x144CD2C", Offset = "0x144CD2C", VA = "0x144CD2C")]
	public EvilFlagOther2D()
	{
	}
}
