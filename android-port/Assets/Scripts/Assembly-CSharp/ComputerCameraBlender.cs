using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000993")]
public class ComputerCameraBlender : GolfBehaviour
{
	[Token(Token = "0x40034C9")]
	[FieldOffset(Offset = "0x20")]
	public List<OverworldMainDoorRobot> robots;

	[Token(Token = "0x40034CA")]
	[FieldOffset(Offset = "0x28")]
	public OverworldCameraSettings robotSettings;

	[Token(Token = "0x40034CB")]
	[FieldOffset(Offset = "0x30")]
	private Coroutine current;

	[Token(Token = "0x6002CE0")]
	[Address(RVA = "0x18AA99C", Offset = "0x18AA99C", VA = "0x18AA99C", Slot = "4")]
	public override void OnPrePlayOrPreCompile()
	{
	}

	[Token(Token = "0x6002CE1")]
	[Address(RVA = "0x18AA9FC", Offset = "0x18AA9FC", VA = "0x18AA9FC")]
	private void Start()
	{
	}

	[Token(Token = "0x6002CE2")]
	[Address(RVA = "0x18AABBC", Offset = "0x18AABBC", VA = "0x18AABBC")]
	private void Robot_OnBallExitedAndIsExploding(OverworldMainDoorRobot obj)
	{
	}

	[Token(Token = "0x6002CE3")]
	[Address(RVA = "0x18AACA8", Offset = "0x18AACA8", VA = "0x18AACA8")]
	public ComputerCameraBlender()
	{
	}

	[Token(Token = "0x6002CE4")]
	[Address(RVA = "0x18AACB0", Offset = "0x18AACB0", VA = "0x18AACB0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x68284", Offset = "0x68284")]
	private void _003CRobot_OnBallExitedAndIsExploding_003Eb__5_0(float t)
	{
	}
}
