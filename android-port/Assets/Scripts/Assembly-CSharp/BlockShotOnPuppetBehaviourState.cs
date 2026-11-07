using Core;
using Il2CppDummyDll;
using RootMotion.Dynamics;
using UnityEngine;

[Token(Token = "0x2000BC2")]
public class BlockShotOnPuppetBehaviourState : MonoBehaviour
{
	[Token(Token = "0x4004187")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private BehaviourPuppet puppet;

	[Token(Token = "0x4004188")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private BehaviourPuppet.State[] blockOnStates;

	[Token(Token = "0x4004189")]
	[FieldOffset(Offset = "0x28")]
	private GolfBallController controller;

	[Token(Token = "0x60038AA")]
	[Address(RVA = "0x1614C4C", Offset = "0x1614C4C", VA = "0x1614C4C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60038AB")]
	[Address(RVA = "0x1614D7C", Offset = "0x1614D7C", VA = "0x1614D7C")]
	public bool IsBlocking()
	{
		return default;
	}

	[Token(Token = "0x60038AC")]
	[Address(RVA = "0x1614E68", Offset = "0x1614E68", VA = "0x1614E68")]
	public BlockShotOnPuppetBehaviourState()
	{
	}
}
