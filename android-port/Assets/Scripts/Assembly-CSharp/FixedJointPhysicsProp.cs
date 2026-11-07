using Il2CppDummyDll;
using RootMotion.Dynamics;
using UnityEngine;

[Token(Token = "0x2000210")]
public class FixedJointPhysicsProp : MonoBehaviour
{
	[Token(Token = "0x4000A3A")]
	[FieldOffset(Offset = "0x18")]
	public PuppetMasterProp Prop;

	[Token(Token = "0x4000A3B")]
	[FieldOffset(Offset = "0x20")]
	public FixedJoint Joint;

	[Token(Token = "0x600093A")]
	[Address(RVA = "0x14695A8", Offset = "0x14695A8", VA = "0x14695A8")]
	private void Update()
	{
	}

	[Token(Token = "0x600093B")]
	[Address(RVA = "0x1469664", Offset = "0x1469664", VA = "0x1469664")]
	public FixedJointPhysicsProp()
	{
	}
}
