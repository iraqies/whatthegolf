using Cinemachine;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000042")]
public class DollyCartController : MonoBehaviour
{
	[Token(Token = "0x4000119")]
	[FieldOffset(Offset = "0x18")]
	public CinemachineDollyCart Cart;

	[Token(Token = "0x400011A")]
	[FieldOffset(Offset = "0x20")]
	public Vector2 WaitTimeBeforeChangeDirection;

	[Token(Token = "0x400011B")]
	[FieldOffset(Offset = "0x28")]
	private float waitTimer;

	[Token(Token = "0x600010D")]
	[Address(RVA = "0x14304F4", Offset = "0x14304F4", VA = "0x14304F4")]
	private void Update()
	{
	}

	[Token(Token = "0x600010E")]
	[Address(RVA = "0x1430570", Offset = "0x1430570", VA = "0x1430570")]
	public DollyCartController()
	{
	}
}
