using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000B1D")]
public class PeriodicallyToggleFan : MonoBehaviour
{
	[Token(Token = "0x4003E24")]
	[FieldOffset(Offset = "0x18")]
	public float StartDelay;

	[Token(Token = "0x4003E25")]
	[FieldOffset(Offset = "0x1C")]
	public float Interval;

	[Token(Token = "0x4003E26")]
	[FieldOffset(Offset = "0x20")]
	public float ToggleDuration;

	[Token(Token = "0x4003E27")]
	[FieldOffset(Offset = "0x28")]
	private Fan fan;

	[Token(Token = "0x4003E28")]
	[FieldOffset(Offset = "0x30")]
	private float timer;

	[Token(Token = "0x4003E29")]
	[FieldOffset(Offset = "0x34")]
	private float toggleTimer;

	[Token(Token = "0x6003508")]
	[Address(RVA = "0x15DE12C", Offset = "0x15DE12C", VA = "0x15DE12C")]
	private void Start()
	{
	}

	[Token(Token = "0x6003509")]
	[Address(RVA = "0x15DE194", Offset = "0x15DE194", VA = "0x15DE194")]
	private void Update()
	{
	}

	[Token(Token = "0x600350A")]
	[Address(RVA = "0x15DE210", Offset = "0x15DE210", VA = "0x15DE210")]
	public PeriodicallyToggleFan()
	{
	}
}
