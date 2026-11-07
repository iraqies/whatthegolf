using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000B0F")]
public class Magnet : MonoBehaviour
{
	[Token(Token = "0x4003DCC")]
	[FieldOffset(Offset = "0x18")]
	public List<Transform> MagnetPoints;

	[Token(Token = "0x4003DCD")]
	[FieldOffset(Offset = "0x20")]
	public BoxCollider EffectTrigger;

	[Token(Token = "0x4003DCE")]
	[FieldOffset(Offset = "0x28")]
	public float MaxForce;

	[Token(Token = "0x4003DCF")]
	[FieldOffset(Offset = "0x30")]
	public List<Rigidbody> affectedObjects;

	[Token(Token = "0x60034CC")]
	[Address(RVA = "0x1552BE4", Offset = "0x1552BE4", VA = "0x1552BE4")]
	private void Start()
	{
	}

	[Token(Token = "0x60034CD")]
	[Address(RVA = "0x1552C5C", Offset = "0x1552C5C", VA = "0x1552C5C")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60034CE")]
	[Address(RVA = "0x1553114", Offset = "0x1553114", VA = "0x1553114")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60034CF")]
	[Address(RVA = "0x1553248", Offset = "0x1553248", VA = "0x1553248")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x60034D0")]
	[Address(RVA = "0x1553324", Offset = "0x1553324", VA = "0x1553324")]
	public Magnet()
	{
	}
}
