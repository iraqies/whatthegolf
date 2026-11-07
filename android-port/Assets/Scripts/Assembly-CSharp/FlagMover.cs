using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000740")]
public abstract class FlagMover : MonoBehaviour
{
	[Token(Token = "0x4002671")]
	[FieldOffset(Offset = "0x18")]
	protected IFlagMovable movable;

	[Token(Token = "0x6002171")]
	[Address(RVA = "0x146A81C", Offset = "0x146A81C", VA = "0x146A81C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002172")]
	[Address(RVA = "0x146A884", Offset = "0x146A884", VA = "0x146A884", Slot = "4")]
	protected virtual void Init()
	{
	}

	[Token(Token = "0x6002173")]
	[Address(RVA = "0x146A888", Offset = "0x146A888", VA = "0x146A888")]
	protected FlagMover()
	{
	}
}
