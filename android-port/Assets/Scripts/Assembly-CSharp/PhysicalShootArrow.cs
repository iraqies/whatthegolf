using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000121")]
public class PhysicalShootArrow : MonoBehaviour
{
	[Token(Token = "0x4000509")]
	[FieldOffset(Offset = "0x18")]
	public GolfBallController Controller;

	[Token(Token = "0x400050A")]
	[FieldOffset(Offset = "0x20")]
	public Transform ColliderObject;

	[Token(Token = "0x400050B")]
	[FieldOffset(Offset = "0x28")]
	public AudioMaterial ArrowAudioMaterial;

	[Token(Token = "0x400050C")]
	[FieldOffset(Offset = "0x30")]
	public string ArrowLayer;

	[Token(Token = "0x400050D")]
	[FieldOffset(Offset = "0x38")]
	private bool hasAddedCollider;

	[Token(Token = "0x400050E")]
	[FieldOffset(Offset = "0x40")]
	private BoxCollider boxCollider;

	[Token(Token = "0x400050F")]
	[FieldOffset(Offset = "0x48")]
	private float startSize;

	[Token(Token = "0x60004FB")]
	[Address(RVA = "0x15E1350", Offset = "0x15E1350", VA = "0x15E1350")]
	private void Awake()
	{
	}

	[Token(Token = "0x60004FC")]
	[Address(RVA = "0x15E13BC", Offset = "0x15E13BC", VA = "0x15E13BC")]
	private void Start()
	{
	}

	[Token(Token = "0x60004FD")]
	[Address(RVA = "0x15E146C", Offset = "0x15E146C", VA = "0x15E146C")]
	private void OnAimUpdate(Vector3 dir, bool blocked)
	{
	}

	[Token(Token = "0x60004FE")]
	[Address(RVA = "0x15E1630", Offset = "0x15E1630", VA = "0x15E1630")]
	private void Update()
	{
	}

	[Token(Token = "0x60004FF")]
	[Address(RVA = "0x15E1808", Offset = "0x15E1808", VA = "0x15E1808")]
	public PhysicalShootArrow()
	{
	}
}
