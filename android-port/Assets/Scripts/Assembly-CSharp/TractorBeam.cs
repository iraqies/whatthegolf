using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200088E")]
public class TractorBeam : MonoBehaviour
{
	[Token(Token = "0x4002EF5")]
	[FieldOffset(Offset = "0x18")]
	public LayerMask AffectedObjectLayers;

	[Token(Token = "0x4002EF6")]
	[FieldOffset(Offset = "0x20")]
	public List<string> AffectedObjectTags;

	[Token(Token = "0x4002EF7")]
	[FieldOffset(Offset = "0x28")]
	public float Force;

	[Token(Token = "0x4002EF8")]
	[FieldOffset(Offset = "0x2C")]
	public ForceMode ForceMode;

	[Token(Token = "0x4002EF9")]
	[FieldOffset(Offset = "0x30")]
	public Transform TractionPoint;

	[Token(Token = "0x4002EFA")]
	[FieldOffset(Offset = "0x38")]
	private List<Rigidbody> objectsInBeam;

	[Token(Token = "0x6002782")]
	[Address(RVA = "0x1720C20", Offset = "0x1720C20", VA = "0x1720C20")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002783")]
	[Address(RVA = "0x1720C98", Offset = "0x1720C98", VA = "0x1720C98")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6002784")]
	[Address(RVA = "0x1720E70", Offset = "0x1720E70", VA = "0x1720E70")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x6002785")]
	[Address(RVA = "0x1720C9C", Offset = "0x1720C9C", VA = "0x1720C9C")]
	private void CheckObject(Collider other)
	{
	}

	[Token(Token = "0x6002786")]
	[Address(RVA = "0x1720E74", Offset = "0x1720E74", VA = "0x1720E74")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6002787")]
	[Address(RVA = "0x1721054", Offset = "0x1721054", VA = "0x1721054")]
	public TractorBeam()
	{
	}
}
