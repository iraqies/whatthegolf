using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000130")]
public class MoveCollidersOnMovableSurface : MonoBehaviour
{
	[Token(Token = "0x4000542")]
	[FieldOffset(Offset = "0x18")]
	private Transform _dummyTransform;

	[Token(Token = "0x4000543")]
	[FieldOffset(Offset = "0x20")]
	private Dictionary<Collider, Transform> _colliderParentDict;

	[Token(Token = "0x6000531")]
	[Address(RVA = "0x1570BE4", Offset = "0x1570BE4", VA = "0x1570BE4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000532")]
	[Address(RVA = "0x1570CA4", Offset = "0x1570CA4", VA = "0x1570CA4")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000533")]
	[Address(RVA = "0x1570D44", Offset = "0x1570D44", VA = "0x1570D44")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6000534")]
	[Address(RVA = "0x1570E44", Offset = "0x1570E44", VA = "0x1570E44")]
	private void OnCollisionExit(Collision collision)
	{
	}

	[Token(Token = "0x6000535")]
	[Address(RVA = "0x1570F18", Offset = "0x1570F18", VA = "0x1570F18")]
	public MoveCollidersOnMovableSurface()
	{
	}
}
