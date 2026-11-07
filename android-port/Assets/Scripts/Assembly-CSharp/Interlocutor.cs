using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000A4F")]
public class Interlocutor : MonoBehaviour
{
	[Token(Token = "0x40038F9")]
	[FieldOffset(Offset = "0x18")]
	public Transform BubblePosition;

	[Token(Token = "0x40038FA")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "RangeAttribute", RVA = "0x50434", Offset = "0x50434")]
	public float BubblePointPosition;

	[Token(Token = "0x6003121")]
	[Address(RVA = "0x14F17A8", Offset = "0x14F17A8", VA = "0x14F17A8")]
	public Interlocutor()
	{
	}
}
