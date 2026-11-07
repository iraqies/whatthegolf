using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000834")]
public class SuperGolfCannonMuzzle : MonoBehaviour
{
	[Token(Token = "0x2000835")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x418C8", Offset = "0x418C8")]
	private sealed class _003C_003Ec__DisplayClass4_0
	{
		[Token(Token = "0x4002C43")]
		[FieldOffset(Offset = "0x10")]
		public SuperGolfCannonMuzzle _003C_003E4__this;

		[Token(Token = "0x4002C44")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 p;

		[Token(Token = "0x60025BD")]
		[Address(RVA = "0x185C810", Offset = "0x185C810", VA = "0x185C810")]
		public _003C_003Ec__DisplayClass4_0()
		{
		}

		[Token(Token = "0x60025BE")]
		[Address(RVA = "0x185C818", Offset = "0x185C818", VA = "0x185C818")]
		internal void _003CPreFireAnimation_003Eb__0(float t)
		{
		}

		[Token(Token = "0x60025BF")]
		[Address(RVA = "0x185C8D0", Offset = "0x185C8D0", VA = "0x185C8D0")]
		internal void _003CPreFireAnimation_003Eb__1(float t)
		{
		}
	}

	[Token(Token = "0x2000836")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x418D8", Offset = "0x418D8")]
	private sealed class _003CPreFireAnimation_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002C45")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002C46")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002C47")]
		[FieldOffset(Offset = "0x20")]
		public SuperGolfCannonMuzzle _003C_003E4__this;

		[Token(Token = "0x4002C48")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass4_0 _003C_003E8__1;

		[Token(Token = "0x17000414")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60025C3")]
			[Address(RVA = "0x185CBA0", Offset = "0x185CBA0", VA = "0x185CBA0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000415")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60025C5")]
			[Address(RVA = "0x185CBE8", Offset = "0x185CBE8", VA = "0x185CBE8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60025C0")]
		[Address(RVA = "0x185C988", Offset = "0x185C988", VA = "0x185C988")]
		[DebuggerHidden]
		public _003CPreFireAnimation_003Ed__4(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60025C1")]
		[Address(RVA = "0x185C9B4", Offset = "0x185C9B4", VA = "0x185C9B4", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60025C2")]
		[Address(RVA = "0x185C9B8", Offset = "0x185C9B8", VA = "0x185C9B8", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60025C3")]
		[Address(RVA = "0x185CBA0", Offset = "0x185CBA0", VA = "0x185CBA0", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60025C4")]
		[Address(RVA = "0x185CBA8", Offset = "0x185CBA8", VA = "0x185CBA8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60025C5")]
		[Address(RVA = "0x185CBE8", Offset = "0x185CBE8", VA = "0x185CBE8", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4002C3F")]
	[FieldOffset(Offset = "0x18")]
	public Transform BulletOrigin;

	[Token(Token = "0x4002C40")]
	[FieldOffset(Offset = "0x20")]
	public Transform MuzzleObject;

	[Token(Token = "0x4002C41")]
	[FieldOffset(Offset = "0x28")]
	public ParticleSystem Particles;

	[Token(Token = "0x4002C42")]
	[FieldOffset(Offset = "0x30")]
	public bool MoveCannonOnShot;

	[Token(Token = "0x60025BB")]
	[Address(RVA = "0x16E9894", Offset = "0x16E9894", VA = "0x16E9894")]
	public IEnumerator PreFireAnimation()
	{
		return null;
	}

	[Token(Token = "0x60025BC")]
	[Address(RVA = "0x16E9908", Offset = "0x16E9908", VA = "0x16E9908")]
	public SuperGolfCannonMuzzle()
	{
	}
}
