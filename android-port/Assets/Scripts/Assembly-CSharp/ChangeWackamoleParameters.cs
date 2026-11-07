using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000E75")]
public class ChangeWackamoleParameters : MonoBehaviour
{
	[Token(Token = "0x4004E38")]
	[FieldOffset(Offset = "0x18")]
	private WackAMoleBehaviour wackamole;

	[Token(Token = "0x4004E39")]
	[FieldOffset(Offset = "0x20")]
	public float newTimeOnEachHole;

	[Token(Token = "0x4004E3A")]
	[FieldOffset(Offset = "0x24")]
	public float newMovementSpeed;

	[Token(Token = "0x6004391")]
	[Address(RVA = "0x1898A8C", Offset = "0x1898A8C", VA = "0x1898A8C")]
	private void Start()
	{
	}

	[Token(Token = "0x6004392")]
	[Address(RVA = "0x1898AE8", Offset = "0x1898AE8", VA = "0x1898AE8")]
	public void Change()
	{
	}

	[Token(Token = "0x6004393")]
	[Address(RVA = "0x1898B08", Offset = "0x1898B08", VA = "0x1898B08")]
	public ChangeWackamoleParameters()
	{
	}
}
