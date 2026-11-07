using System.Collections.Generic;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20007E5")]
public class MoonLanderPad : MonoBehaviour
{
	[Token(Token = "0x4002A41")]
	[FieldOffset(Offset = "0x18")]
	public int RequiredHitsForCompletion;

	[Token(Token = "0x4002A42")]
	[FieldOffset(Offset = "0x20")]
	private GolfGoal golfGoal;

	[Token(Token = "0x4002A43")]
	[FieldOffset(Offset = "0x28")]
	private List<GolfBallController> hits;

	[Token(Token = "0x6002449")]
	[Address(RVA = "0x156D034", Offset = "0x156D034", VA = "0x156D034")]
	private void Awake()
	{
	}

	[Token(Token = "0x600244A")]
	[Address(RVA = "0x156D090", Offset = "0x156D090", VA = "0x156D090")]
	public void Landed(GolfBallController controller)
	{
	}

	[Token(Token = "0x600244B")]
	[Address(RVA = "0x156D188", Offset = "0x156D188", VA = "0x156D188")]
	public MoonLanderPad()
	{
	}
}
