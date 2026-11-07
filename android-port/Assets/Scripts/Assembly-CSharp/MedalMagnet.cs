using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000258")]
public class MedalMagnet : MonoBehaviour
{
	[Token(Token = "0x4000BFB")]
	[FieldOffset(Offset = "0x18")]
	public List<Transform> MagnetPoints;

	[Token(Token = "0x4000BFC")]
	[FieldOffset(Offset = "0x20")]
	public SphereCollider EffectTrigger;

	[Token(Token = "0x4000BFD")]
	[FieldOffset(Offset = "0x28")]
	public float maxForce;

	[Token(Token = "0x4000BFE")]
	[FieldOffset(Offset = "0x2C")]
	public float minForceMultiplier;

	[Token(Token = "0x4000BFF")]
	[FieldOffset(Offset = "0x30")]
	public List<Rigidbody> affectedObjects;

	[Token(Token = "0x4000C00")]
	[FieldOffset(Offset = "0x38")]
	private Rigidbody rbody;

	[Token(Token = "0x6000A83")]
	[Address(RVA = "0x155FB80", Offset = "0x155FB80", VA = "0x155FB80")]
	private void Start()
	{
	}

	[Token(Token = "0x6000A84")]
	[Address(RVA = "0x155FC24", Offset = "0x155FC24", VA = "0x155FC24")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000A85")]
	[Address(RVA = "0x1560140", Offset = "0x1560140", VA = "0x1560140")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6000A86")]
	[Address(RVA = "0x1560284", Offset = "0x1560284", VA = "0x1560284")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000A87")]
	[Address(RVA = "0x15603FC", Offset = "0x15603FC", VA = "0x15603FC")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x6000A88")]
	[Address(RVA = "0x1560538", Offset = "0x1560538", VA = "0x1560538")]
	public MedalMagnet()
	{
	}
}
