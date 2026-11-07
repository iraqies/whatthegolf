using System.Collections.Generic;
using Core;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x20003EE")]
public class iOSHapticsContainer : MonoBehaviour
{
	[Token(Token = "0x4001573")]
	[FieldOffset(Offset = "0x18")]
	public List<GolfBallController> _golfBallControllers;

	[Token(Token = "0x4001574")]
	[FieldOffset(Offset = "0x20")]
	public List<OverworldGoal> _overworldGoals;

	[Token(Token = "0x4001575")]
	[FieldOffset(Offset = "0x28")]
	public List<OverworldButton2D> overworldButton2Ds;

	[Token(Token = "0x4001576")]
	[FieldOffset(Offset = "0x30")]
	public List<Button> _buttons;

	[Token(Token = "0x4001577")]
	[FieldOffset(Offset = "0x38")]
	public GolfGoal _golfGoal;

	[Token(Token = "0x6001277")]
	[Address(RVA = "0x176400C", Offset = "0x176400C", VA = "0x176400C")]
	public iOSHapticsContainer()
	{
	}
}
