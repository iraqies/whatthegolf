using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000DF2")]
public class FlatToyBehaviour : MonoBehaviour
{
	[Token(Token = "0x2000DF3")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44DF8", Offset = "0x44DF8")]
	private sealed class _003CFlatLifetime_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4004BFB")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4004BFC")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4004BFD")]
		[FieldOffset(Offset = "0x20")]
		public FlatToyBehaviour _003C_003E4__this;

		[Token(Token = "0x170006C2")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60041B2")]
			[Address(RVA = "0x17A8F10", Offset = "0x17A8F10", VA = "0x17A8F10", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170006C3")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60041B4")]
			[Address(RVA = "0x17A8F58", Offset = "0x17A8F58", VA = "0x17A8F58", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60041AF")]
		[Address(RVA = "0x17A8BE0", Offset = "0x17A8BE0", VA = "0x17A8BE0")]
		[DebuggerHidden]
		public _003CFlatLifetime_003Ed__17(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60041B0")]
		[Address(RVA = "0x17A8C0C", Offset = "0x17A8C0C", VA = "0x17A8C0C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60041B1")]
		[Address(RVA = "0x17A8C10", Offset = "0x17A8C10", VA = "0x17A8C10", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60041B2")]
		[Address(RVA = "0x17A8F10", Offset = "0x17A8F10", VA = "0x17A8F10", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60041B3")]
		[Address(RVA = "0x17A8F18", Offset = "0x17A8F18", VA = "0x17A8F18", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60041B4")]
		[Address(RVA = "0x17A8F58", Offset = "0x17A8F58", VA = "0x17A8F58", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4004BEF")]
	[FieldOffset(Offset = "0x18")]
	public float lifeTime;

	[Token(Token = "0x4004BF0")]
	[FieldOffset(Offset = "0x20")]
	public GameObject objectTest;

	[Token(Token = "0x4004BF1")]
	[FieldOffset(Offset = "0x28")]
	private Rigidbody rigidbody;

	[Token(Token = "0x4004BF2")]
	[FieldOffset(Offset = "0x30")]
	private Animator animator;

	[Token(Token = "0x4004BF3")]
	[FieldOffset(Offset = "0x38")]
	private MeshRenderer meshRenderer;

	[Token(Token = "0x4004BF4")]
	[FieldOffset(Offset = "0x40")]
	private MeshFilter meshFilter;

	[Token(Token = "0x4004BF5")]
	[FieldOffset(Offset = "0x48")]
	private MeshRenderer rendererToCopy;

	[Token(Token = "0x4004BF6")]
	[FieldOffset(Offset = "0x50")]
	private MeshFilter meshToCopy;

	[Token(Token = "0x4004BF7")]
	[FieldOffset(Offset = "0x58")]
	private GameObject flattenedObject;

	[Token(Token = "0x4004BF8")]
	[FieldOffset(Offset = "0x60")]
	private bool startedShaking;

	[Token(Token = "0x4004BF9")]
	[FieldOffset(Offset = "0x68")]
	private Coroutine lifetimeCoroutine;

	[Token(Token = "0x4004BFA")]
	[FieldOffset(Offset = "0x70")]
	private BoxCollider flatCollider;

	[Token(Token = "0x60041A7")]
	[Address(RVA = "0x146BA5C", Offset = "0x146BA5C", VA = "0x146BA5C")]
	private void Start()
	{
	}

	[Token(Token = "0x60041A8")]
	[Address(RVA = "0x146BB54", Offset = "0x146BB54", VA = "0x146BB54")]
	public void Initialize(GameObject flattenedGO)
	{
	}

	[Token(Token = "0x60041A9")]
	[Address(RVA = "0x146BDE8", Offset = "0x146BDE8", VA = "0x146BDE8")]
	private void Update()
	{
	}

	[Token(Token = "0x60041AA")]
	[Address(RVA = "0x146BE44", Offset = "0x146BE44", VA = "0x146BE44")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60041AB")]
	[Address(RVA = "0x146C018", Offset = "0x146C018", VA = "0x146C018")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60041AC")]
	[Address(RVA = "0x146BAE0", Offset = "0x146BAE0", VA = "0x146BAE0")]
	private IEnumerator FlatLifetime()
	{
		return null;
	}

	[Token(Token = "0x60041AD")]
	[Address(RVA = "0x146C0AC", Offset = "0x146C0AC", VA = "0x146C0AC")]
	public void RevertBackToNormal()
	{
	}

	[Token(Token = "0x60041AE")]
	[Address(RVA = "0x146C1E4", Offset = "0x146C1E4", VA = "0x146C1E4")]
	public FlatToyBehaviour()
	{
	}
}
