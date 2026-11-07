using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C11")]
public class OtherCollisionEvents : MonoBehaviour
{
	[Token(Token = "0x40042B0")]
	[FieldOffset(Offset = "0x18")]
	public InspectorColliderEvent TriggerEnter;

	[Token(Token = "0x40042B1")]
	[FieldOffset(Offset = "0x20")]
	public InspectorColliderEvent TriggerStay;

	[Token(Token = "0x40042B2")]
	[FieldOffset(Offset = "0x28")]
	public InspectorColliderEvent TriggerExit;

	[Token(Token = "0x40042B3")]
	[FieldOffset(Offset = "0x30")]
	public InspectorCollisionEvent CollisionEnter;

	[Token(Token = "0x40042B4")]
	[FieldOffset(Offset = "0x38")]
	public InspectorCollisionEvent CollisionStay;

	[Token(Token = "0x40042B5")]
	[FieldOffset(Offset = "0x40")]
	public InspectorCollisionEvent CollisionExit;

	[Token(Token = "0x60039D7")]
	[Address(RVA = "0x159E040", Offset = "0x159E040", VA = "0x159E040")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x60039D8")]
	[Address(RVA = "0x159E0B0", Offset = "0x159E0B0", VA = "0x159E0B0")]
	private void OnCollisionStay(Collision collision)
	{
	}

	[Token(Token = "0x60039D9")]
	[Address(RVA = "0x159E120", Offset = "0x159E120", VA = "0x159E120")]
	private void OnCollisionExit(Collision collision)
	{
	}

	[Token(Token = "0x60039DA")]
	[Address(RVA = "0x159E190", Offset = "0x159E190", VA = "0x159E190")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60039DB")]
	[Address(RVA = "0x159E200", Offset = "0x159E200", VA = "0x159E200")]
	private void OnTriggerStay(Collider other)
	{
	}

	[Token(Token = "0x60039DC")]
	[Address(RVA = "0x159E270", Offset = "0x159E270", VA = "0x159E270")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x60039DD")]
	[Address(RVA = "0x159E2E0", Offset = "0x159E2E0", VA = "0x159E2E0")]
	public OtherCollisionEvents()
	{
	}
}
