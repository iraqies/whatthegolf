using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x20003CA")]
public class RigidbodyThresholdEvent : MonoBehaviour
{
	[Token(Token = "0x40014D3")]
	[FieldOffset(Offset = "0x18")]
	public float threshold;

	[Token(Token = "0x40014D4")]
	[FieldOffset(Offset = "0x20")]
	public Rigidbody _rigidbody3D;

	[Token(Token = "0x40014D5")]
	[FieldOffset(Offset = "0x28")]
	public Rigidbody2D _rigidbody2D;

	[Token(Token = "0x40014D6")]
	[FieldOffset(Offset = "0x30")]
	private bool overThreshold;

	[Token(Token = "0x40014D7")]
	[FieldOffset(Offset = "0x34")]
	private float velocity;

	[Token(Token = "0x40014D8")]
	[FieldOffset(Offset = "0x38")]
	public UnityEvent onAboveThreshold;

	[Token(Token = "0x40014D9")]
	[FieldOffset(Offset = "0x40")]
	public UnityEvent onBelowThreshold;

	[Token(Token = "0x60011E2")]
	[Address(RVA = "0x1657CB0", Offset = "0x1657CB0", VA = "0x1657CB0")]
	private void Update()
	{
	}

	[Token(Token = "0x60011E3")]
	[Address(RVA = "0x1657E24", Offset = "0x1657E24", VA = "0x1657E24")]
	public RigidbodyThresholdEvent()
	{
	}
}
