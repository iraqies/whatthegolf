using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20005BD")]
public class SpinWhenAiming : MonoBehaviour
{
	[Token(Token = "0x4001D56")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GolfBallController controller;

	[Token(Token = "0x4001D57")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Rigidbody rigid;

	[Token(Token = "0x4001D58")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float spinSpeed;

	[Token(Token = "0x4001D59")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private Vector3 spinAxis;

	[Token(Token = "0x4001D5A")]
	[FieldOffset(Offset = "0x38")]
	private bool isSpinning;

	[Token(Token = "0x6001A10")]
	[Address(RVA = "0x16D6030", Offset = "0x16D6030", VA = "0x16D6030")]
	private void Start()
	{
	}

	[Token(Token = "0x6001A11")]
	[Address(RVA = "0x16D61AC", Offset = "0x16D61AC", VA = "0x16D61AC")]
	private void OnShoot(Vector3 obj)
	{
	}

	[Token(Token = "0x6001A12")]
	[Address(RVA = "0x16D61B4", Offset = "0x16D61B4", VA = "0x16D61B4")]
	private void OnCancel()
	{
	}

	[Token(Token = "0x6001A13")]
	[Address(RVA = "0x16D61BC", Offset = "0x16D61BC", VA = "0x16D61BC")]
	private void OnAimUpdate(Vector3 arg1, bool arg2)
	{
	}

	[Token(Token = "0x6001A14")]
	[Address(RVA = "0x16D61C8", Offset = "0x16D61C8", VA = "0x16D61C8")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6001A15")]
	[Address(RVA = "0x16D620C", Offset = "0x16D620C", VA = "0x16D620C")]
	public SpinWhenAiming()
	{
	}
}
