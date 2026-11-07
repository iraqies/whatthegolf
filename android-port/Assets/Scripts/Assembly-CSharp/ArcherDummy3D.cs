using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001C9")]
[Attribute(Name = "RequireComponent", RVA = "0x3E188", Offset = "0x3E188")]
public class ArcherDummy3D : MonoBehaviour
{
	[Token(Token = "0x4000828")]
	[FieldOffset(Offset = "0x18")]
	private Rigidbody rb;

	[Token(Token = "0x4000829")]
	[FieldOffset(Offset = "0x20")]
	private string arrowLayerName;

	[Token(Token = "0x400082A")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private int hitsToBreak;

	[Token(Token = "0x400082B")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private float maxAngle;

	[Token(Token = "0x400082C")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float rotationSpeed;

	[Token(Token = "0x400082D")]
	[FieldOffset(Offset = "0x34")]
	private int hits;

	[Token(Token = "0x400082E")]
	[FieldOffset(Offset = "0x38")]
	private Quaternion targetRotation;

	[Token(Token = "0x400082F")]
	[FieldOffset(Offset = "0x48")]
	private bool broken;

	[Token(Token = "0x4000830")]
	[FieldOffset(Offset = "0x50")]
	private List<GameObject> arrowsAlreadyCounted;

	[Token(Token = "0x60007F4")]
	[Address(RVA = "0x141F348", Offset = "0x141F348", VA = "0x141F348")]
	private void Start()
	{
	}

	[Token(Token = "0x60007F5")]
	[Address(RVA = "0x141F3BC", Offset = "0x141F3BC", VA = "0x141F3BC")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x60007F6")]
	[Address(RVA = "0x141F3F4", Offset = "0x141F3F4", VA = "0x141F3F4")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60007F7")]
	[Address(RVA = "0x141F6DC", Offset = "0x141F6DC", VA = "0x141F6DC")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60007F8")]
	[Address(RVA = "0x141F7BC", Offset = "0x141F7BC", VA = "0x141F7BC")]
	public ArcherDummy3D()
	{
	}
}
