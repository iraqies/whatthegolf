using Il2CppDummyDll;
using RootMotion.Dynamics;
using UnityEngine;

[Token(Token = "0x2000026")]
public class Skeleton : MonoBehaviour
{
	[Token(Token = "0x4000057")]
	[FieldOffset(Offset = "0x18")]
	public Animator animator;

	[Token(Token = "0x4000058")]
	[FieldOffset(Offset = "0x20")]
	public PuppetMaster puppetMaster;

	[Token(Token = "0x4000059")]
	[FieldOffset(Offset = "0x28")]
	public ConfigurableJoint[] leftLeg;

	[Token(Token = "0x400005A")]
	[FieldOffset(Offset = "0x30")]
	public ConfigurableJoint[] rightLeg;

	[Token(Token = "0x400005B")]
	[FieldOffset(Offset = "0x38")]
	private bool leftLegRemoved;

	[Token(Token = "0x400005C")]
	[FieldOffset(Offset = "0x39")]
	private bool rightLegRemoved;

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x13FB10C", Offset = "0x13FB10C", VA = "0x13FB10C")]
	private void Start()
	{
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x13FB230", Offset = "0x13FB230", VA = "0x13FB230")]
	public void OnRebuild()
	{
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x13FB2C4", Offset = "0x13FB2C4", VA = "0x13FB2C4")]
	private void OnMuscleDisconnected(Muscle m)
	{
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x13FB3A4", Offset = "0x13FB3A4", VA = "0x13FB3A4")]
	private bool IsLegMuscle(Muscle m, out bool isLeft)
	{
		return default;
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x13FB538", Offset = "0x13FB538", VA = "0x13FB538")]
	public Skeleton()
	{
	}
}
