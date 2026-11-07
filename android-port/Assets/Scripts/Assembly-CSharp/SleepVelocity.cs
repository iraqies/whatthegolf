using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000B2E")]
public class SleepVelocity : MonoBehaviour
{
	[Token(Token = "0x4003E64")]
	[FieldOffset(Offset = "0x18")]
	public Vector3 up;

	[Token(Token = "0x4003E65")]
	[FieldOffset(Offset = "0x24")]
	public float threshold;

	[Token(Token = "0x4003E66")]
	[FieldOffset(Offset = "0x28")]
	public float breakAmount;

	[Token(Token = "0x4003E67")]
	[FieldOffset(Offset = "0x30")]
	private Rigidbody rigid;

	[Token(Token = "0x4003E68")]
	[FieldOffset(Offset = "0x38")]
	private float currentVelocity;

	[Token(Token = "0x4003E69")]
	[FieldOffset(Offset = "0x3C")]
	private float timer;

	[Token(Token = "0x4003E6A")]
	[FieldOffset(Offset = "0x40")]
	public float timerThreshold;

	[Token(Token = "0x4003E6B")]
	[FieldOffset(Offset = "0x44")]
	public float yThreshold;

	[Token(Token = "0x600353B")]
	[Address(RVA = "0x16B6234", Offset = "0x16B6234", VA = "0x16B6234")]
	private void Start()
	{
	}

	[Token(Token = "0x600353C")]
	[Address(RVA = "0x16B6290", Offset = "0x16B6290", VA = "0x16B6290")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600353D")]
	[Address(RVA = "0x16B6498", Offset = "0x16B6498", VA = "0x16B6498")]
	public SleepVelocity()
	{
	}
}
