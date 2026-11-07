using System.Collections.Generic;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C63")]
public class ToggleObjectOnOutOfBounds : MonoBehaviour
{
	[Token(Token = "0x40043F2")]
	[FieldOffset(Offset = "0x18")]
	public List<GameObject> ObjectToToggle;

	[Token(Token = "0x6003AD4")]
	[Address(RVA = "0x171BFE4", Offset = "0x171BFE4", VA = "0x171BFE4")]
	private void Start()
	{
	}

	[Token(Token = "0x6003AD5")]
	[Address(RVA = "0x171C10C", Offset = "0x171C10C", VA = "0x171C10C")]
	private void Ball_OnReset()
	{
	}

	[Token(Token = "0x6003AD6")]
	[Address(RVA = "0x171C260", Offset = "0x171C260", VA = "0x171C260")]
	private void OnOutOfBounds(GolfBallController c, string msg, Level.State state)
	{
	}

	[Token(Token = "0x6003AD7")]
	[Address(RVA = "0x171C3B4", Offset = "0x171C3B4", VA = "0x171C3B4")]
	public ToggleObjectOnOutOfBounds()
	{
	}
}
