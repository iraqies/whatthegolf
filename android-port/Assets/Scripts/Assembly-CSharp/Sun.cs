using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20008E7")]
public class Sun : MonoBehaviour
{
	[Token(Token = "0x40030C0")]
	[FieldOffset(Offset = "0x18")]
	public Transform SunBody;

	[Token(Token = "0x40030C1")]
	[FieldOffset(Offset = "0x20")]
	public Transform SunShine;

	[Token(Token = "0x6002935")]
	[Address(RVA = "0x16E7A30", Offset = "0x16E7A30", VA = "0x16E7A30")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6002936")]
	[Address(RVA = "0x16E7A70", Offset = "0x16E7A70", VA = "0x16E7A70")]
	public Sun()
	{
	}
}
