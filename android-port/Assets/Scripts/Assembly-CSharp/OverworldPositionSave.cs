using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000B47")]
public class OverworldPositionSave : MonoBehaviour
{
	[Token(Token = "0x4003EBE")]
	[FieldOffset(Offset = "0x18")]
	public float SaveVelocityThreshold;

	[Token(Token = "0x4003EBF")]
	[FieldOffset(Offset = "0x1C")]
	private bool startSaving;

	[Token(Token = "0x4003EC0")]
	[FieldOffset(Offset = "0x20")]
	private Rigidbody2D rigid;

	[Token(Token = "0x4003EC1")]
	[FieldOffset(Offset = "0x28")]
	private OverworldID id;

	[Token(Token = "0x4003EC2")]
	[FieldOffset(Offset = "0x30")]
	private readonly string saveKey;

	[Token(Token = "0x600359D")]
	[Address(RVA = "0x15C9A08", Offset = "0x15C9A08", VA = "0x15C9A08")]
	private void Awake()
	{
	}

	[Token(Token = "0x600359E")]
	[Address(RVA = "0x15C9A88", Offset = "0x15C9A88", VA = "0x15C9A88")]
	private void Start()
	{
	}

	[Token(Token = "0x600359F")]
	[Address(RVA = "0x15C9C28", Offset = "0x15C9C28", VA = "0x15C9C28")]
	private void OnCollisionEnter2D(Collision2D other)
	{
	}

	[Token(Token = "0x60035A0")]
	[Address(RVA = "0x15C9C34", Offset = "0x15C9C34", VA = "0x15C9C34")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60035A1")]
	[Address(RVA = "0x15C9DF0", Offset = "0x15C9DF0", VA = "0x15C9DF0")]
	public OverworldPositionSave()
	{
	}
}
