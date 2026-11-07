using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C6D")]
public class UnparentOnStart : MonoBehaviour
{
	[Token(Token = "0x400440F")]
	[FieldOffset(Offset = "0x18")]
	private Quaternion originalRotation;

	[Token(Token = "0x4004410")]
	[FieldOffset(Offset = "0x28")]
	private Vector3 originalPosition;

	[Token(Token = "0x4004411")]
	[FieldOffset(Offset = "0x38")]
	private Transform originalParent;

	[Token(Token = "0x4004412")]
	[FieldOffset(Offset = "0x40")]
	private Rigidbody thisRigidbody;

	[Token(Token = "0x4004413")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private bool DontUnparentOnStart;

	[Token(Token = "0x6003AF6")]
	[Address(RVA = "0x173D238", Offset = "0x173D238", VA = "0x173D238")]
	private void Start()
	{
	}

	[Token(Token = "0x6003AF7")]
	[Address(RVA = "0x173D2B0", Offset = "0x173D2B0", VA = "0x173D2B0")]
	public void Unparent()
	{
	}

	[Token(Token = "0x6003AF8")]
	[Address(RVA = "0x173D340", Offset = "0x173D340", VA = "0x173D340")]
	public void Reparent(bool alsoReturnToPosition)
	{
	}

	[Token(Token = "0x6003AF9")]
	[Address(RVA = "0x173D390", Offset = "0x173D390", VA = "0x173D390")]
	public void ResetPosition()
	{
	}

	[Token(Token = "0x6003AFA")]
	[Address(RVA = "0x173D408", Offset = "0x173D408", VA = "0x173D408")]
	public void DestroyObject()
	{
	}

	[Token(Token = "0x6003AFB")]
	[Address(RVA = "0x173D48C", Offset = "0x173D48C", VA = "0x173D48C")]
	public UnparentOnStart()
	{
	}
}
