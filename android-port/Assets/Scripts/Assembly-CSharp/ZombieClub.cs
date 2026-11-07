using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000748")]
public class ZombieClub : MonoBehaviour
{
	[Token(Token = "0x4002680")]
	[FieldOffset(Offset = "0x18")]
	public Transform[] seats;

	[Token(Token = "0x4002681")]
	[FieldOffset(Offset = "0x20")]
	private List<Transform> freeSeats;

	[Token(Token = "0x6002188")]
	[Address(RVA = "0x1763B7C", Offset = "0x1763B7C", VA = "0x1763B7C")]
	private void Start()
	{
	}

	[Token(Token = "0x6002189")]
	[Address(RVA = "0x1763BD4", Offset = "0x1763BD4", VA = "0x1763BD4")]
	public Transform TakeSeat()
	{
		return null;
	}

	[Token(Token = "0x600218A")]
	[Address(RVA = "0x1762EA0", Offset = "0x1762EA0", VA = "0x1762EA0")]
	public Transform TakeClosestSeat(Vector3 position)
	{
		return null;
	}

	[Token(Token = "0x600218B")]
	[Address(RVA = "0x1763C68", Offset = "0x1763C68", VA = "0x1763C68")]
	public void FreeSeat(Transform seat)
	{
	}

	[Token(Token = "0x600218C")]
	[Address(RVA = "0x1763CCC", Offset = "0x1763CCC", VA = "0x1763CCC")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x600218D")]
	[Address(RVA = "0x1763D4C", Offset = "0x1763D4C", VA = "0x1763D4C")]
	public ZombieClub()
	{
	}
}
