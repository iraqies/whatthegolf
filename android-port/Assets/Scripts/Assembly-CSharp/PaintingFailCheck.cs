using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001FC")]
public class PaintingFailCheck : MonoBehaviour
{
	[Token(Token = "0x40009B8")]
	[FieldOffset(Offset = "0x18")]
	public string FailTags;

	[Token(Token = "0x40009B9")]
	[FieldOffset(Offset = "0x20")]
	public GiraffePainterController Painter;

	[Token(Token = "0x60008EA")]
	[Address(RVA = "0x15D7F2C", Offset = "0x15D7F2C", VA = "0x15D7F2C")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60008EB")]
	[Address(RVA = "0x15D7FCC", Offset = "0x15D7FCC", VA = "0x15D7FCC")]
	public PaintingFailCheck()
	{
	}
}
