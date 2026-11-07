using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000BEB")]
public class FlyingAppearingPlatform : MonoBehaviour
{
	[Token(Token = "0x4004204")]
	[FieldOffset(Offset = "0x18")]
	private Vector3 origPosition;

	[Token(Token = "0x4004205")]
	[FieldOffset(Offset = "0x24")]
	private Quaternion origRotation;

	[Token(Token = "0x4004206")]
	[FieldOffset(Offset = "0x34")]
	private Vector3 awayPosition;

	[Token(Token = "0x4004207")]
	[FieldOffset(Offset = "0x40")]
	private Quaternion awayRotation;

	[Token(Token = "0x4004208")]
	[FieldOffset(Offset = "0x50")]
	private Vector3 targetPos;

	[Token(Token = "0x4004209")]
	[FieldOffset(Offset = "0x5C")]
	private Quaternion targetRot;

	[Token(Token = "0x400420A")]
	[FieldOffset(Offset = "0x70")]
	private Rigidbody rigid;

	[Token(Token = "0x400420B")]
	[FieldOffset(Offset = "0x78")]
	private Collider col;

	[Token(Token = "0x400420C")]
	[FieldOffset(Offset = "0x80")]
	private bool isAway;

	[Token(Token = "0x6003922")]
	[Address(RVA = "0x146D088", Offset = "0x146D088", VA = "0x146D088")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003923")]
	[Address(RVA = "0x146D244", Offset = "0x146D244", VA = "0x146D244")]
	private void Update()
	{
	}

	[Token(Token = "0x6003924")]
	[Address(RVA = "0x146D304", Offset = "0x146D304", VA = "0x146D304")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6003925")]
	[Address(RVA = "0x146D590", Offset = "0x146D590", VA = "0x146D590")]
	public FlyingAppearingPlatform()
	{
	}
}
