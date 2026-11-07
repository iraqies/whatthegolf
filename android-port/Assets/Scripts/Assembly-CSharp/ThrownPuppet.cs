using Core;
using Il2CppDummyDll;
using RootMotion.Dynamics;
using UnityEngine;

[Token(Token = "0x2000217")]
public class ThrownPuppet : MonoBehaviour
{
	[Token(Token = "0x4000A69")]
	[FieldOffset(Offset = "0x18")]
	public PuppetMasterProp Prop;

	[Token(Token = "0x4000A6A")]
	[FieldOffset(Offset = "0x20")]
	public SpinningBowlerPuppet Spinner;

	[Token(Token = "0x4000A6B")]
	[FieldOffset(Offset = "0x28")]
	public DropPropOnShoot PropDropper;

	[Token(Token = "0x4000A6C")]
	[FieldOffset(Offset = "0x30")]
	public GolfBallController Controller;

	[Token(Token = "0x4000A6D")]
	[FieldOffset(Offset = "0x38")]
	public GameObject FakeProp;

	[Token(Token = "0x6000957")]
	[Address(RVA = "0x1713880", Offset = "0x1713880", VA = "0x1713880")]
	public void Activate()
	{
	}

	[Token(Token = "0x6000958")]
	[Address(RVA = "0x1713924", Offset = "0x1713924", VA = "0x1713924")]
	public ThrownPuppet()
	{
	}
}
