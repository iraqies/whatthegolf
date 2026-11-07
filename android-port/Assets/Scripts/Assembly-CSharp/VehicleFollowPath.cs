using Cinemachine;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001E1")]
public class VehicleFollowPath : MonoBehaviour
{
	[Token(Token = "0x40008E8")]
	[FieldOffset(Offset = "0x18")]
	public Vehicle Vehicle;

	[Token(Token = "0x40008E9")]
	[FieldOffset(Offset = "0x20")]
	public CinemachineDollyCart Dolly;

	[Token(Token = "0x40008EA")]
	[FieldOffset(Offset = "0x28")]
	public float SteerThreshold;

	[Token(Token = "0x6000868")]
	[Address(RVA = "0x174955C", Offset = "0x174955C", VA = "0x174955C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000869")]
	[Address(RVA = "0x17496E8", Offset = "0x17496E8", VA = "0x17496E8")]
	public VehicleFollowPath()
	{
	}
}
