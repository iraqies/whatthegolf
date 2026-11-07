using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000E1E")]
public class MarlenesMover : MonoBehaviour
{
	[Token(Token = "0x4004CA4")]
	[FieldOffset(Offset = "0x18")]
	public Transform mover;

	[Token(Token = "0x4004CA5")]
	[FieldOffset(Offset = "0x20")]
	public Transform pointA;

	[Token(Token = "0x4004CA6")]
	[FieldOffset(Offset = "0x28")]
	public Transform pointB;

	[Token(Token = "0x4004CA7")]
	[FieldOffset(Offset = "0x30")]
	public Transform startTransform;

	[Token(Token = "0x4004CA8")]
	[FieldOffset(Offset = "0x38")]
	private Vector3 currPos;

	[Token(Token = "0x4004CA9")]
	[FieldOffset(Offset = "0x44")]
	private Vector3 currTarget;

	[Token(Token = "0x4004CAA")]
	[FieldOffset(Offset = "0x50")]
	private Vector3 currVelocity;

	[Token(Token = "0x4004CAB")]
	[FieldOffset(Offset = "0x5C")]
	public float smoothTime;

	[Token(Token = "0x4004CAC")]
	[FieldOffset(Offset = "0x60")]
	public float maxSpeed;

	[Token(Token = "0x6004243")]
	[Address(RVA = "0x155EBA8", Offset = "0x155EBA8", VA = "0x155EBA8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6004244")]
	[Address(RVA = "0x155EBE4", Offset = "0x155EBE4", VA = "0x155EBE4")]
	public void GoToPointA()
	{
	}

	[Token(Token = "0x6004245")]
	[Address(RVA = "0x155EC84", Offset = "0x155EC84", VA = "0x155EC84")]
	public void GoToPointB()
	{
	}

	[Token(Token = "0x6004246")]
	[Address(RVA = "0x155ED24", Offset = "0x155ED24", VA = "0x155ED24")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6004247")]
	[Address(RVA = "0x155EE54", Offset = "0x155EE54", VA = "0x155EE54")]
	public MarlenesMover()
	{
	}
}
