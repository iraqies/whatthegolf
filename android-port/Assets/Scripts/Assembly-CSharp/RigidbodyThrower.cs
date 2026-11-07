using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20005F0")]
public class RigidbodyThrower : MonoBehaviour
{
	[Token(Token = "0x20005F1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40910", Offset = "0x40910")]
	private sealed class _003CStart_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001E64")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001E65")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001E66")]
		[FieldOffset(Offset = "0x20")]
		public RigidbodyThrower _003C_003E4__this;

		[Token(Token = "0x170002F4")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001B0C")]
			[Address(RVA = "0x18354D4", Offset = "0x18354D4", VA = "0x18354D4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170002F5")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001B0E")]
			[Address(RVA = "0x183551C", Offset = "0x183551C", VA = "0x183551C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001B09")]
		[Address(RVA = "0x18351E0", Offset = "0x18351E0", VA = "0x18351E0")]
		[DebuggerHidden]
		public _003CStart_003Ed__9(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001B0A")]
		[Address(RVA = "0x183520C", Offset = "0x183520C", VA = "0x183520C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001B0B")]
		[Address(RVA = "0x1835210", Offset = "0x1835210", VA = "0x1835210", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001B0C")]
		[Address(RVA = "0x18354D4", Offset = "0x18354D4", VA = "0x18354D4", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001B0D")]
		[Address(RVA = "0x18354DC", Offset = "0x18354DC", VA = "0x18354DC", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001B0E")]
		[Address(RVA = "0x183551C", Offset = "0x183551C", VA = "0x183551C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4001E5C")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Rigidbody rigidbody;

	[Token(Token = "0x4001E5D")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float throwVelocity;

	[Token(Token = "0x4001E5E")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private Vector3 throwAngularVelocity;

	[Token(Token = "0x4001E5F")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float debugGravity;

	[Token(Token = "0x4001E60")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private float intervalOffset;

	[Token(Token = "0x4001E61")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private float interval;

	[Token(Token = "0x4001E62")]
	[FieldOffset(Offset = "0x3C")]
	private float y;

	[Token(Token = "0x4001E63")]
	[FieldOffset(Offset = "0x40")]
	private float nextThrowTime;

	[Token(Token = "0x6001B05")]
	[Address(RVA = "0x1657E2C", Offset = "0x1657E2C", VA = "0x1657E2C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001B06")]
	[Address(RVA = "0x1657E6C", Offset = "0x1657E6C", VA = "0x1657E6C")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x6001B07")]
	[Address(RVA = "0x1657EE0", Offset = "0x1657EE0", VA = "0x1657EE0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6001B08")]
	[Address(RVA = "0x165806C", Offset = "0x165806C", VA = "0x165806C")]
	public RigidbodyThrower()
	{
	}
}
