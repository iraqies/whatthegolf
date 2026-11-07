using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200078E")]
public class ToggleControllerBasedOnAnotherController : MonoBehaviour
{
	[Token(Token = "0x40027F1")]
	[FieldOffset(Offset = "0x18")]
	public GolfBallController ThisController;

	[Token(Token = "0x40027F2")]
	[FieldOffset(Offset = "0x20")]
	public GolfBallController OtherController;

	[Token(Token = "0x60022AD")]
	[Address(RVA = "0x171A290", Offset = "0x171A290", VA = "0x171A290")]
	private void Update()
	{
	}

	[Token(Token = "0x60022AE")]
	[Address(RVA = "0x171A3E0", Offset = "0x171A3E0", VA = "0x171A3E0")]
	public ToggleControllerBasedOnAnotherController()
	{
	}
}
