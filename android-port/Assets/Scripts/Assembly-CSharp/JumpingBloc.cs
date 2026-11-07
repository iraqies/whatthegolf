using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000DF5")]
public class JumpingBloc : MonoBehaviour
{
	[Token(Token = "0x2000DF6")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44E08", Offset = "0x44E08")]
	private sealed class _003CRemoveConstraints_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4004C07")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4004C08")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4004C09")]
		[FieldOffset(Offset = "0x20")]
		public JumpingBloc _003C_003E4__this;

		[Token(Token = "0x170006C4")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60041C1")]
			[Address(RVA = "0x17CBF58", Offset = "0x17CBF58", VA = "0x17CBF58", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170006C5")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60041C3")]
			[Address(RVA = "0x17CBFA0", Offset = "0x17CBFA0", VA = "0x17CBFA0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60041BE")]
		[Address(RVA = "0x17CBE78", Offset = "0x17CBE78", VA = "0x17CBE78")]
		[DebuggerHidden]
		public _003CRemoveConstraints_003Ed__6(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60041BF")]
		[Address(RVA = "0x17CBEA4", Offset = "0x17CBEA4", VA = "0x17CBEA4", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60041C0")]
		[Address(RVA = "0x17CBEA8", Offset = "0x17CBEA8", VA = "0x17CBEA8", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60041C1")]
		[Address(RVA = "0x17CBF58", Offset = "0x17CBF58", VA = "0x17CBF58", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60041C2")]
		[Address(RVA = "0x17CBF60", Offset = "0x17CBF60", VA = "0x17CBF60", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60041C3")]
		[Address(RVA = "0x17CBFA0", Offset = "0x17CBFA0", VA = "0x17CBFA0", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4004C03")]
	[FieldOffset(Offset = "0x18")]
	public List<Rigidbody> objectsToDragInJump;

	[Token(Token = "0x4004C04")]
	[FieldOffset(Offset = "0x20")]
	public Vector3 jumpForce;

	[Token(Token = "0x4004C05")]
	[FieldOffset(Offset = "0x30")]
	private Rigidbody rb;

	[Token(Token = "0x4004C06")]
	[FieldOffset(Offset = "0x38")]
	private bool jumped;

	[Token(Token = "0x60041B9")]
	[Address(RVA = "0x14F8D34", Offset = "0x14F8D34", VA = "0x14F8D34")]
	private void Start()
	{
	}

	[Token(Token = "0x60041BA")]
	[Address(RVA = "0x14F8D90", Offset = "0x14F8D90", VA = "0x14F8D90")]
	public void Jump()
	{
	}

	[Token(Token = "0x60041BB")]
	[Address(RVA = "0x14F8ED4", Offset = "0x14F8ED4", VA = "0x14F8ED4")]
	private IEnumerator RemoveConstraints()
	{
		return null;
	}

	[Token(Token = "0x60041BC")]
	[Address(RVA = "0x14F8F48", Offset = "0x14F8F48", VA = "0x14F8F48")]
	private void Update()
	{
	}

	[Token(Token = "0x60041BD")]
	[Address(RVA = "0x14F907C", Offset = "0x14F907C", VA = "0x14F907C")]
	public JumpingBloc()
	{
	}
}
