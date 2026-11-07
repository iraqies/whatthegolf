using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000067")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x3D4D0", Offset = "0x3D4D0")]
public class EvilFlagHidingOnTrigger : MonoBehaviour
{
	[Token(Token = "0x2000068")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D538", Offset = "0x3D538")]
	private sealed class _003CMove_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001A7")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40001A8")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40001A9")]
		[FieldOffset(Offset = "0x20")]
		public EvilFlagHidingOnTrigger _003C_003E4__this;

		[Token(Token = "0x40001AA")]
		[FieldOffset(Offset = "0x28")]
		private Vector3 _003Ctarget_003E5__2;

		[Token(Token = "0x17000047")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60001BC")]
			[Address(RVA = "0x17A10DC", Offset = "0x17A10DC", VA = "0x17A10DC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000048")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60001BE")]
			[Address(RVA = "0x17A1124", Offset = "0x17A1124", VA = "0x17A1124", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x17A0BF0", Offset = "0x17A0BF0", VA = "0x17A0BF0")]
		[DebuggerHidden]
		public _003CMove_003Ed__15(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x17A0C1C", Offset = "0x17A0C1C", VA = "0x17A0C1C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x17A0C20", Offset = "0x17A0C20", VA = "0x17A0C20", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x17A10DC", Offset = "0x17A10DC", VA = "0x17A10DC", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x17A10E4", Offset = "0x17A10E4", VA = "0x17A10E4", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x17A1124", Offset = "0x17A1124", VA = "0x17A1124", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x400019B")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Transform endTarget;

	[Token(Token = "0x400019C")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private bool useTrigger;

	[Token(Token = "0x400019D")]
	[FieldOffset(Offset = "0x21")]
	[SerializeField]
	private bool useCollision;

	[Token(Token = "0x400019E")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private List<string> AcceptedTags;

	[Token(Token = "0x400019F")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private List<Collider> Blacklist;

	[Token(Token = "0x40001A0")]
	[FieldOffset(Offset = "0x38")]
	private bool hasMoved;

	[Token(Token = "0x40001A1")]
	[FieldOffset(Offset = "0x3C")]
	private Vector3 startPosition;

	[Token(Token = "0x40001A2")]
	[FieldOffset(Offset = "0x48")]
	private Vector3 endPosition;

	[Token(Token = "0x40001A3")]
	[FieldOffset(Offset = "0x54")]
	public float velocity;

	[Token(Token = "0x40001A4")]
	[FieldOffset(Offset = "0x58")]
	public float hideYOffset;

	[Token(Token = "0x40001A5")]
	[FieldOffset(Offset = "0x60")]
	private Rigidbody rigidbody;

	[Token(Token = "0x40001A6")]
	[FieldOffset(Offset = "0x68")]
	public RandomAudioClips audioClip;

	[Token(Token = "0x60001B4")]
	[Address(RVA = "0x144BA34", Offset = "0x144BA34", VA = "0x144BA34")]
	private void Start()
	{
	}

	[Token(Token = "0x60001B5")]
	[Address(RVA = "0x144BAC4", Offset = "0x144BAC4", VA = "0x144BAC4")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60001B6")]
	[Address(RVA = "0x144BC94", Offset = "0x144BC94", VA = "0x144BC94")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x60001B7")]
	[Address(RVA = "0x144BC20", Offset = "0x144BC20", VA = "0x144BC20")]
	private IEnumerator Move()
	{
		return null;
	}

	[Token(Token = "0x60001B8")]
	[Address(RVA = "0x144BE04", Offset = "0x144BE04", VA = "0x144BE04")]
	public EvilFlagHidingOnTrigger()
	{
	}
}
