using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20009C5")]
public class IntroComputer : MonoBehaviour
{
	[Token(Token = "0x20009C6")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x426C0", Offset = "0x426C0")]
	private sealed class _003CPlayHitAnimRoutine_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40035A8")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40035A9")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40035AA")]
		[FieldOffset(Offset = "0x20")]
		public IntroComputer _003C_003E4__this;

		[Token(Token = "0x170004BD")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002DF1")]
			[Address(RVA = "0x17C8DF4", Offset = "0x17C8DF4", VA = "0x17C8DF4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170004BE")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002DF3")]
			[Address(RVA = "0x17C8E3C", Offset = "0x17C8E3C", VA = "0x17C8E3C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002DEE")]
		[Address(RVA = "0x17C8C9C", Offset = "0x17C8C9C", VA = "0x17C8C9C")]
		[DebuggerHidden]
		public _003CPlayHitAnimRoutine_003Ed__4(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002DEF")]
		[Address(RVA = "0x17C8CC8", Offset = "0x17C8CC8", VA = "0x17C8CC8", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002DF0")]
		[Address(RVA = "0x17C8CCC", Offset = "0x17C8CCC", VA = "0x17C8CCC", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6002DF1")]
		[Address(RVA = "0x17C8DF4", Offset = "0x17C8DF4", VA = "0x17C8DF4", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002DF2")]
		[Address(RVA = "0x17C8DFC", Offset = "0x17C8DFC", VA = "0x17C8DFC", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6002DF3")]
		[Address(RVA = "0x17C8E3C", Offset = "0x17C8E3C", VA = "0x17C8E3C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x40035A5")]
	[FieldOffset(Offset = "0x18")]
	public SpriteRenderer darkScreen;

	[Token(Token = "0x40035A6")]
	[FieldOffset(Offset = "0x20")]
	public Animator anim;

	[Token(Token = "0x40035A7")]
	[FieldOffset(Offset = "0x28")]
	private float nextHitAnim;

	[Token(Token = "0x6002DEB")]
	[Address(RVA = "0x14F1E00", Offset = "0x14F1E00", VA = "0x14F1E00")]
	private void OnCollisionEnter2D(Collision2D collision)
	{
	}

	[Token(Token = "0x6002DEC")]
	[Address(RVA = "0x14F1EBC", Offset = "0x14F1EBC", VA = "0x14F1EBC")]
	private IEnumerator PlayHitAnimRoutine()
	{
		return null;
	}

	[Token(Token = "0x6002DED")]
	[Address(RVA = "0x14F1F30", Offset = "0x14F1F30", VA = "0x14F1F30")]
	public IntroComputer()
	{
	}
}
