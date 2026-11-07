using Core;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

[Token(Token = "0x2000C42")]
public class SetTextIfShooting : MonoBehaviour
{
	[Token(Token = "0x4004357")]
	[FieldOffset(Offset = "0x18")]
	public string TextIfAiming;

	[Token(Token = "0x4004358")]
	[FieldOffset(Offset = "0x20")]
	public string TextIfNotAiming;

	[Token(Token = "0x4004359")]
	[FieldOffset(Offset = "0x28")]
	public TextMeshPro Text;

	[Token(Token = "0x400435A")]
	[FieldOffset(Offset = "0x30")]
	public GolfBallController Ball;

	[Token(Token = "0x6003A64")]
	[Address(RVA = "0x169003C", Offset = "0x169003C", VA = "0x169003C")]
	private void Update()
	{
	}

	[Token(Token = "0x6003A65")]
	[Address(RVA = "0x1690078", Offset = "0x1690078", VA = "0x1690078")]
	public SetTextIfShooting()
	{
	}
}
