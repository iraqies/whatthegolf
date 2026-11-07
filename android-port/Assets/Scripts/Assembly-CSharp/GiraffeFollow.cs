using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20007AC")]
public class GiraffeFollow : MonoBehaviour
{
	[Token(Token = "0x4002883")]
	[FieldOffset(Offset = "0x18")]
	public Transform target;

	[Token(Token = "0x4002884")]
	[FieldOffset(Offset = "0x20")]
	public bool crash;

	[Token(Token = "0x4002885")]
	[FieldOffset(Offset = "0x21")]
	public bool ontrain;

	[Token(Token = "0x6002325")]
	[Address(RVA = "0x148A2C0", Offset = "0x148A2C0", VA = "0x148A2C0")]
	private void Start()
	{
	}

	[Token(Token = "0x6002326")]
	[Address(RVA = "0x148A2C8", Offset = "0x148A2C8", VA = "0x148A2C8")]
	private void OnCollisionEnter2D(Collision2D collision)
	{
	}

	[Token(Token = "0x6002327")]
	[Address(RVA = "0x148A3F8", Offset = "0x148A3F8", VA = "0x148A3F8")]
	public GiraffeFollow()
	{
	}
}
