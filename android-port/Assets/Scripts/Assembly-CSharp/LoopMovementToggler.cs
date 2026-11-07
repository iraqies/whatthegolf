using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000E88")]
public class LoopMovementToggler : MonoBehaviour
{
	[Token(Token = "0x4004E82")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private LoopMovement[] loopMovements;

	[Token(Token = "0x60043DF")]
	[Address(RVA = "0x154BEB0", Offset = "0x154BEB0", VA = "0x154BEB0")]
	public void EnableLooping()
	{
	}

	[Token(Token = "0x60043E0")]
	[Address(RVA = "0x154BFD8", Offset = "0x154BFD8", VA = "0x154BFD8")]
	public void DisableLooping()
	{
	}

	[Token(Token = "0x60043E1")]
	[Address(RVA = "0x154C048", Offset = "0x154C048", VA = "0x154C048")]
	public LoopMovementToggler()
	{
	}
}
