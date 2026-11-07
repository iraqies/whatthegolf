using Chronos;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200014C")]
public class SleepVelocityTimeline : MonoBehaviour
{
	[Token(Token = "0x40005D2")]
	[FieldOffset(Offset = "0x18")]
	public Vector3 up;

	[Token(Token = "0x40005D3")]
	[FieldOffset(Offset = "0x24")]
	public float threshold;

	[Token(Token = "0x40005D4")]
	[FieldOffset(Offset = "0x28")]
	public float breakAmount;

	[Token(Token = "0x40005D5")]
	[FieldOffset(Offset = "0x2C")]
	private float currentVelocity;

	[Token(Token = "0x40005D6")]
	[FieldOffset(Offset = "0x30")]
	private float timer;

	[Token(Token = "0x40005D7")]
	[FieldOffset(Offset = "0x34")]
	public float timerThreshold;

	[Token(Token = "0x40005D8")]
	[FieldOffset(Offset = "0x38")]
	public float yThreshold;

	[Token(Token = "0x40005D9")]
	[FieldOffset(Offset = "0x40")]
	private Timeline timeline;

	[Token(Token = "0x6000592")]
	[Address(RVA = "0x16B64F0", Offset = "0x16B64F0", VA = "0x16B64F0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000593")]
	[Address(RVA = "0x16B654C", Offset = "0x16B654C", VA = "0x16B654C")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000594")]
	[Address(RVA = "0x16B670C", Offset = "0x16B670C", VA = "0x16B670C")]
	public SleepVelocityTimeline()
	{
	}
}
