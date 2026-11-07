using Il2CppDummyDll;
using RootMotion.Demos;
using UnityEngine;

[Token(Token = "0x2000231")]
public class PuppetControllerStandInSpot : UserControlThirdPerson
{
	[Token(Token = "0x4000B32")]
	[FieldOffset(Offset = "0x48")]
	public CharacterPuppet Puppet;

	[Token(Token = "0x4000B33")]
	[FieldOffset(Offset = "0x50")]
	public float movementDeadzone;

	[Token(Token = "0x4000B34")]
	[FieldOffset(Offset = "0x54")]
	private Vector3 originPos;

	[Token(Token = "0x60009DD")]
	[Address(RVA = "0x162A478", Offset = "0x162A478", VA = "0x162A478")]
	private void Awake()
	{
	}

	[Token(Token = "0x60009DE")]
	[Address(RVA = "0x162A4B4", Offset = "0x162A4B4", VA = "0x162A4B4", Slot = "5")]
	protected override void Update()
	{
	}

	[Token(Token = "0x60009DF")]
	[Address(RVA = "0x162A680", Offset = "0x162A680", VA = "0x162A680")]
	public PuppetControllerStandInSpot()
	{
	}
}
