using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000BC8")]
public class CameraShakeOnShoot : MonoBehaviour
{
	[Token(Token = "0x40041A1")]
	[FieldOffset(Offset = "0x18")]
	public float Duration;

	[Token(Token = "0x40041A2")]
	[FieldOffset(Offset = "0x1C")]
	public float Speed;

	[Token(Token = "0x40041A3")]
	[FieldOffset(Offset = "0x20")]
	public float MaxMagnitude;

	[Token(Token = "0x40041A4")]
	[FieldOffset(Offset = "0x28")]
	private GolfBallController controller;

	[Token(Token = "0x60038BB")]
	[Address(RVA = "0x18846A8", Offset = "0x18846A8", VA = "0x18846A8")]
	private void Awake()
	{
	}

	[Token(Token = "0x60038BC")]
	[Address(RVA = "0x188477C", Offset = "0x188477C", VA = "0x188477C")]
	private void Controller_OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x60038BD")]
	[Address(RVA = "0x18847F8", Offset = "0x18847F8", VA = "0x18847F8")]
	public CameraShakeOnShoot()
	{
	}
}
