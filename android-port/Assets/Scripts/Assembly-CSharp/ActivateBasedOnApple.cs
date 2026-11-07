using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200054E")]
public class ActivateBasedOnApple : MonoBehaviour
{
	[Token(Token = "0x4001B69")]
	[FieldOffset(Offset = "0x18")]
	public bool showOnApple;

	[Token(Token = "0x4001B6A")]
	[FieldOffset(Offset = "0x19")]
	public bool showOnEpic;

	[Token(Token = "0x4001B6B")]
	[FieldOffset(Offset = "0x1A")]
	public bool showOnSwitch;

	[Token(Token = "0x6001834")]
	[Address(RVA = "0x1404B88", Offset = "0x1404B88", VA = "0x1404B88")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001835")]
	[Address(RVA = "0x1404BF0", Offset = "0x1404BF0", VA = "0x1404BF0")]
	public ActivateBasedOnApple()
	{
	}
}
