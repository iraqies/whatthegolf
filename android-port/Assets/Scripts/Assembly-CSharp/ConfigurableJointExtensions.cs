using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200027E")]
public static class ConfigurableJointExtensions
{
	[Token(Token = "0x6000B4D")]
	[Address(RVA = "0x18AC578", Offset = "0x18AC578", VA = "0x18AC578")]
	public static void SetTargetRotationLocal(this ConfigurableJoint joint, Quaternion targetLocalRotation, Quaternion startLocalRotation)
	{
	}

	[Token(Token = "0x6000B4E")]
	[Address(RVA = "0x18AC864", Offset = "0x18AC864", VA = "0x18AC864")]
	public static void SetTargetRotation(this ConfigurableJoint joint, Quaternion targetWorldRotation, Quaternion startWorldRotation)
	{
	}

	[Token(Token = "0x6000B4F")]
	[Address(RVA = "0x18AC678", Offset = "0x18AC678", VA = "0x18AC678")]
	private static void SetTargetRotationInternal(ConfigurableJoint joint, Quaternion targetRotation, Quaternion startRotation, Space space)
	{
	}
}
