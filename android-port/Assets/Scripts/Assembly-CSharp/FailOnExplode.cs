using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20007A9")]
public class FailOnExplode : MonoBehaviour
{
	[Token(Token = "0x20007AA")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41570", Offset = "0x41570")]
	private sealed class _003CBoom_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400287E")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400287F")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x170003D5")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600231F")]
			[Address(RVA = "0x17A2D7C", Offset = "0x17A2D7C", VA = "0x17A2D7C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170003D6")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002321")]
			[Address(RVA = "0x17A2DC4", Offset = "0x17A2DC4", VA = "0x17A2DC4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600231C")]
		[Address(RVA = "0x17A2C64", Offset = "0x17A2C64", VA = "0x17A2C64")]
		[DebuggerHidden]
		public _003CBoom_003Ed__3(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600231D")]
		[Address(RVA = "0x17A2C90", Offset = "0x17A2C90", VA = "0x17A2C90", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600231E")]
		[Address(RVA = "0x17A2C94", Offset = "0x17A2C94", VA = "0x17A2C94", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600231F")]
		[Address(RVA = "0x17A2D7C", Offset = "0x17A2D7C", VA = "0x17A2D7C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002320")]
		[Address(RVA = "0x17A2D84", Offset = "0x17A2D84", VA = "0x17A2D84", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6002321")]
		[Address(RVA = "0x17A2DC4", Offset = "0x17A2DC4", VA = "0x17A2DC4", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x400287C")]
	[FieldOffset(Offset = "0x18")]
	public List<ExplosionBarrel2D> explosionBarrel2Ds;

	[Token(Token = "0x400287D")]
	[FieldOffset(Offset = "0x20")]
	public List<ExplosionBarrel> explosionBarrels;

	[Token(Token = "0x6002319")]
	[Address(RVA = "0x145B47C", Offset = "0x145B47C", VA = "0x145B47C")]
	private void Update()
	{
	}

	[Token(Token = "0x600231A")]
	[Address(RVA = "0x145B790", Offset = "0x145B790", VA = "0x145B790")]
	private IEnumerator Boom()
	{
		return null;
	}

	[Token(Token = "0x600231B")]
	[Address(RVA = "0x145B7EC", Offset = "0x145B7EC", VA = "0x145B7EC")]
	public FailOnExplode()
	{
	}
}
