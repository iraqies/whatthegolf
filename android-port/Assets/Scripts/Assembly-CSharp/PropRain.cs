using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20005AC")]
public class PropRain : MonoBehaviour
{
	[Token(Token = "0x4001CEB")]
	[FieldOffset(Offset = "0x18")]
	public GameObject Prop;

	[Token(Token = "0x4001CEC")]
	[FieldOffset(Offset = "0x20")]
	public bool Raining;

	[Token(Token = "0x4001CED")]
	[FieldOffset(Offset = "0x24")]
	public float MaximumRandomPositionOffset;

	[Token(Token = "0x4001CEE")]
	[FieldOffset(Offset = "0x28")]
	public float PropLifetime;

	[Token(Token = "0x4001CEF")]
	[FieldOffset(Offset = "0x2C")]
	public float rainCooldownMax;

	[Token(Token = "0x4001CF0")]
	[FieldOffset(Offset = "0x30")]
	private float rainCooldownTime;

	[Token(Token = "0x4001CF1")]
	[FieldOffset(Offset = "0x34")]
	private float rainCooldownTimer;

	[Token(Token = "0x60019C7")]
	[Address(RVA = "0x1628540", Offset = "0x1628540", VA = "0x1628540")]
	private void Update()
	{
	}

	[Token(Token = "0x60019C8")]
	[Address(RVA = "0x16285B8", Offset = "0x16285B8", VA = "0x16285B8")]
	private void NewProp()
	{
	}

	[Token(Token = "0x60019C9")]
	[Address(RVA = "0x16287E4", Offset = "0x16287E4", VA = "0x16287E4")]
	public PropRain()
	{
	}
}
