using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20007F4")]
public class PeggleBob : MonoBehaviour
{
	[Token(Token = "0x20007F5")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x416F0", Offset = "0x416F0")]
	private sealed class _003C_003Ec__DisplayClass13_0
	{
		[Token(Token = "0x4002AA6")]
		[FieldOffset(Offset = "0x10")]
		public PeggleBob _003C_003E4__this;

		[Token(Token = "0x4002AA7")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 startScale;

		[Token(Token = "0x600248A")]
		[Address(RVA = "0x1822EE4", Offset = "0x1822EE4", VA = "0x1822EE4")]
		public _003C_003Ec__DisplayClass13_0()
		{
		}

		[Token(Token = "0x600248B")]
		[Address(RVA = "0x1822EEC", Offset = "0x1822EEC", VA = "0x1822EEC")]
		internal void _003CRemoveRoutine_003Eb__0(float t)
		{
		}
	}

	[Token(Token = "0x20007F6")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41700", Offset = "0x41700")]
	private sealed class _003CRemoveRoutine_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002AA8")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002AA9")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002AAA")]
		[FieldOffset(Offset = "0x20")]
		public PeggleBob _003C_003E4__this;

		[Token(Token = "0x170003FC")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600248F")]
			[Address(RVA = "0x1823178", Offset = "0x1823178", VA = "0x1823178", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170003FD")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002491")]
			[Address(RVA = "0x18231C0", Offset = "0x18231C0", VA = "0x18231C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600248C")]
		[Address(RVA = "0x1822FAC", Offset = "0x1822FAC", VA = "0x1822FAC")]
		[DebuggerHidden]
		public _003CRemoveRoutine_003Ed__13(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600248D")]
		[Address(RVA = "0x1822FD8", Offset = "0x1822FD8", VA = "0x1822FD8", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600248E")]
		[Address(RVA = "0x1822FDC", Offset = "0x1822FDC", VA = "0x1822FDC", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600248F")]
		[Address(RVA = "0x1823178", Offset = "0x1823178", VA = "0x1823178", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002490")]
		[Address(RVA = "0x1823180", Offset = "0x1823180", VA = "0x1823180", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6002491")]
		[Address(RVA = "0x18231C0", Offset = "0x18231C0", VA = "0x18231C0", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4002A9E")]
	[FieldOffset(Offset = "0x18")]
	public Color OffColor;

	[Token(Token = "0x4002A9F")]
	[FieldOffset(Offset = "0x28")]
	public float BounceForce;

	[Token(Token = "0x4002AA0")]
	[FieldOffset(Offset = "0x30")]
	public SpriteRenderer InnerSprite;

	[Token(Token = "0x4002AA1")]
	[FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4F02C", Offset = "0x4F02C")]
	private bool HasBeenHit__BackingField;

	[Token(Token = "0x4002AA2")]
	[FieldOffset(Offset = "0x40")]
	public AudioSource HitSource;

	[Token(Token = "0x4002AA3")]
	[FieldOffset(Offset = "0x48")]
	public float PitchMod;

	[Token(Token = "0x4002AA4")]
	[FieldOffset(Offset = "0x50")]
	public List<AudioClip> RemoveClips;

	[Token(Token = "0x4002AA5")]
	[FieldOffset(Offset = "0x58")]
	public float hitTime;

	[Token(Token = "0x170003FB")]
	public bool HasBeenHit
	{
		[Token(Token = "0x6002483")]
		[Address(RVA = "0x15DD98C", Offset = "0x15DD98C", VA = "0x15DD98C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x665A0", Offset = "0x665A0")]
		get
		{
			return default;
		}
		[Token(Token = "0x6002484")]
		[Address(RVA = "0x15DD994", Offset = "0x15DD994", VA = "0x15DD994")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x665B0", Offset = "0x665B0")]
		private set
		{
		}
	}

	[Token(Token = "0x6002485")]
	[Address(RVA = "0x15DD99C", Offset = "0x15DD99C", VA = "0x15DD99C")]
	private void OnCollisionEnter2D(Collision2D col)
	{
	}

	[Token(Token = "0x6002486")]
	[Address(RVA = "0x15DDAC0", Offset = "0x15DDAC0", VA = "0x15DDAC0")]
	public void Remove()
	{
	}

	[Token(Token = "0x6002487")]
	[Address(RVA = "0x15DDB3C", Offset = "0x15DDB3C", VA = "0x15DDB3C")]
	private IEnumerator RemoveRoutine()
	{
		return null;
	}

	[Token(Token = "0x6002488")]
	[Address(RVA = "0x15DDBB0", Offset = "0x15DDBB0", VA = "0x15DDBB0")]
	private void Update()
	{
	}

	[Token(Token = "0x6002489")]
	[Address(RVA = "0x15DDC60", Offset = "0x15DDC60", VA = "0x15DDC60")]
	public PeggleBob()
	{
	}
}
