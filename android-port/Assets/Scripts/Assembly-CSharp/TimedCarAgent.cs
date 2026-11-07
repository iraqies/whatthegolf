using Chronos;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000B8F")]
public class TimedCarAgent : CarAgent
{
	[Token(Token = "0x4004066")]
	[FieldOffset(Offset = "0xB8")]
	public Vector3 timedGravity;

	[Token(Token = "0x4004067")]
	[FieldOffset(Offset = "0xC8")]
	private Timeline timeline;

	[Token(Token = "0x60037C8")]
	[Address(RVA = "0x1717AEC", Offset = "0x1717AEC", VA = "0x1717AEC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60037C9")]
	[Address(RVA = "0x1717B48", Offset = "0x1717B48", VA = "0x1717B48", Slot = "4")]
	protected override void Unlock()
	{
	}

	[Token(Token = "0x60037CA")]
	[Address(RVA = "0x1717BBC", Offset = "0x1717BBC", VA = "0x1717BBC", Slot = "5")]
	protected override void FixedUpdate()
	{
	}

	[Token(Token = "0x60037CB")]
	[Address(RVA = "0x171807C", Offset = "0x171807C", VA = "0x171807C")]
	public TimedCarAgent()
	{
	}
}
