using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000DA6")]
public class LivingTent : MonoBehaviour
{
	[Token(Token = "0x4004A67")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float _interval;

	[Token(Token = "0x4004A68")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private float _force;

	[Token(Token = "0x4004A69")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Transform _target;

	[Token(Token = "0x4004A6A")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Transform _spawnPosition;

	[Token(Token = "0x4004A6B")]
	[FieldOffset(Offset = "0x30")]
	private bool _spawning;

	[Token(Token = "0x4004A6C")]
	[FieldOffset(Offset = "0x34")]
	private int index;

	[Token(Token = "0x4004A6D")]
	[FieldOffset(Offset = "0x38")]
	private Transform _controller;

	[Token(Token = "0x4004A6E")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private List<Rigidbody> _prefabs;

	[Token(Token = "0x4004A6F")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Animator _animator;

	[Token(Token = "0x4004A70")]
	[FieldOffset(Offset = "0x50")]
	private double time;

	[Token(Token = "0x4004A71")]
	[FieldOffset(Offset = "0x0")]
	private static readonly int Spawn;

	[Token(Token = "0x6004030")]
	[Address(RVA = "0x1537AD8", Offset = "0x1537AD8", VA = "0x1537AD8")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6004031")]
	[Address(RVA = "0x1537BB8", Offset = "0x1537BB8", VA = "0x1537BB8")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x6004032")]
	[Address(RVA = "0x1537BBC", Offset = "0x1537BBC", VA = "0x1537BBC")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6004033")]
	[Address(RVA = "0x1537C90", Offset = "0x1537C90", VA = "0x1537C90")]
	public void AnimationEventSpawn()
	{
	}

	[Token(Token = "0x6004034")]
	[Address(RVA = "0x1537ED8", Offset = "0x1537ED8", VA = "0x1537ED8")]
	public LivingTent()
	{
	}
}
