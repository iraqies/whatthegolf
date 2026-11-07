using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000795")]
public class HorsePlayer : MonoBehaviour
{
	[Token(Token = "0x4002804")]
	[FieldOffset(Offset = "0x18")]
	public HorseLaps Waypoints;

	[Token(Token = "0x4002805")]
	[FieldOffset(Offset = "0x20")]
	private int currentWaypoint;

	[Token(Token = "0x60022C6")]
	[Address(RVA = "0x14D81EC", Offset = "0x14D81EC", VA = "0x14D81EC")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60022C7")]
	[Address(RVA = "0x14D836C", Offset = "0x14D836C", VA = "0x14D836C")]
	public HorsePlayer()
	{
	}
}
