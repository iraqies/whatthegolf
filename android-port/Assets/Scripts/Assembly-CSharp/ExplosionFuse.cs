using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20006E5")]
public class ExplosionFuse : MonoBehaviour
{
	[Token(Token = "0x400241A")]
	[FieldOffset(Offset = "0x18")]
	public Transform Fuse;

	[Token(Token = "0x400241B")]
	[FieldOffset(Offset = "0x20")]
	public List<Transform> FusePoints;

	[Token(Token = "0x400241C")]
	[FieldOffset(Offset = "0x28")]
	public float FuseMoveSpeed;

	[Token(Token = "0x400241D")]
	[FieldOffset(Offset = "0x30")]
	public ExplosionBarrelHelper Barrel;

	[Token(Token = "0x400241E")]
	[FieldOffset(Offset = "0x38")]
	public float NewPointDistance;

	[Token(Token = "0x400241F")]
	[FieldOffset(Offset = "0x3C")]
	private int nextPointIndex;

	[Token(Token = "0x4002420")]
	[FieldOffset(Offset = "0x40")]
	private float speedRampUp;

	[Token(Token = "0x6001FCF")]
	[Address(RVA = "0x1453978", Offset = "0x1453978", VA = "0x1453978")]
	private void Start()
	{
	}

	[Token(Token = "0x6001FD0")]
	[Address(RVA = "0x1453A38", Offset = "0x1453A38", VA = "0x1453A38")]
	private void Update()
	{
	}

	[Token(Token = "0x6001FD1")]
	[Address(RVA = "0x1453F4C", Offset = "0x1453F4C", VA = "0x1453F4C")]
	public ExplosionFuse()
	{
	}
}
