using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000DE7")]
public class TreeCounter : MonoBehaviour
{
	[Token(Token = "0x4004BC0")]
	[FieldOffset(Offset = "0x18")]
	public TotalTreeCounter totalCounter;

	[Token(Token = "0x4004BC1")]
	[FieldOffset(Offset = "0x20")]
	private bool popped;

	[Token(Token = "0x6004179")]
	[Address(RVA = "0x172CEE8", Offset = "0x172CEE8", VA = "0x172CEE8")]
	public void AddOneCount()
	{
	}

	[Token(Token = "0x600417A")]
	[Address(RVA = "0x172CF1C", Offset = "0x172CF1C", VA = "0x172CF1C")]
	public TreeCounter()
	{
	}
}
