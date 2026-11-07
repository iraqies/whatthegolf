using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x2000AFC")]
public class CollisionEvents : MonoBehaviour
{
	[Token(Token = "0x4003D21")]
	[FieldOffset(Offset = "0x18")]
	public UnityEvent OnCollisionEnterEvent;

	[Token(Token = "0x4003D22")]
	[FieldOffset(Offset = "0x20")]
	public UnityEvent OnCollisionExitEvent;

	[Token(Token = "0x4003D23")]
	[FieldOffset(Offset = "0x28")]
	public UnityEvent OnTriggerEnterEvent;

	[Token(Token = "0x4003D24")]
	[FieldOffset(Offset = "0x30")]
	public UnityEvent OnTriggerExitEvent;

	[Token(Token = "0x4003D25")]
	[FieldOffset(Offset = "0x38")]
	public Action<Rigidbody> OnCollisionEnterTrigger;

	[Token(Token = "0x4003D26")]
	[FieldOffset(Offset = "0x40")]
	public Action<Rigidbody> OnTriggerEnterTrigger;

	[Token(Token = "0x4003D27")]
	[FieldOffset(Offset = "0x48")]
	public Action<Rigidbody> OnTriggerExitTrigger;

	[Token(Token = "0x4003D28")]
	[FieldOffset(Offset = "0x50")]
	public List<Collider> Blacklist;

	[Token(Token = "0x4003D29")]
	[FieldOffset(Offset = "0x58")]
	public List<string> AcceptedTags;

	[Token(Token = "0x6003458")]
	[Address(RVA = "0x18A8BA4", Offset = "0x18A8BA4", VA = "0x18A8BA4")]
	private void OnCollisionEnter(Collision col)
	{
	}

	[Token(Token = "0x6003459")]
	[Address(RVA = "0x18A8CEC", Offset = "0x18A8CEC", VA = "0x18A8CEC")]
	private void OnCollisionExit(Collision col)
	{
	}

	[Token(Token = "0x600345A")]
	[Address(RVA = "0x18A8DFC", Offset = "0x18A8DFC", VA = "0x18A8DFC")]
	private void OnTriggerEnter(Collider col)
	{
	}

	[Token(Token = "0x600345B")]
	[Address(RVA = "0x18A8F48", Offset = "0x18A8F48", VA = "0x18A8F48")]
	private void OnTriggerExit(Collider col)
	{
	}

	[Token(Token = "0x600345C")]
	[Address(RVA = "0x18A9094", Offset = "0x18A9094", VA = "0x18A9094")]
	public CollisionEvents()
	{
	}
}
