using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000704")]
public class SpinningChair : MonoBehaviour
{
	[Token(Token = "0x40024E1")]
	[FieldOffset(Offset = "0x18")]
	public float RotateSpeed;

	[Token(Token = "0x40024E2")]
	[FieldOffset(Offset = "0x1C")]
	public bool isSpinning;

	[Token(Token = "0x6002063")]
	[Address(RVA = "0x16D6874", Offset = "0x16D6874", VA = "0x16D6874")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6002064")]
	[Address(RVA = "0x16D6910", Offset = "0x16D6910", VA = "0x16D6910")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6002065")]
	[Address(RVA = "0x16D6998", Offset = "0x16D6998", VA = "0x16D6998")]
	public SpinningChair()
	{
	}
}
