using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000A96")]
public class OverworldIslandDockTrigger : MonoBehaviour
{
	[Token(Token = "0x4003ADD")]
	[FieldOffset(Offset = "0x18")]
	public OverworldIsland Island;

	[Token(Token = "0x6003293")]
	[Address(RVA = "0x15BA32C", Offset = "0x15BA32C", VA = "0x15BA32C")]
	private void OnTriggerEnter2D(Collider2D other)
	{
	}

	[Token(Token = "0x6003294")]
	[Address(RVA = "0x15BA344", Offset = "0x15BA344", VA = "0x15BA344")]
	private void OnTriggerExit2D(Collider2D other)
	{
	}

	[Token(Token = "0x6003295")]
	[Address(RVA = "0x15BA348", Offset = "0x15BA348", VA = "0x15BA348")]
	public OverworldIslandDockTrigger()
	{
	}
}
