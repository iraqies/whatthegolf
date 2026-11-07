using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20003F9")]
public class ParallaxFromGyro : MonoBehaviour
{
	[Token(Token = "0x40015A9")]
	[FieldOffset(Offset = "0x18")]
	public Vector2 magnitude;

	[Token(Token = "0x40015AA")]
	[FieldOffset(Offset = "0x20")]
	public bool useMax;

	[Token(Token = "0x40015AB")]
	[FieldOffset(Offset = "0x24")]
	public Vector2 maxMagnitude;

	[Token(Token = "0x40015AC")]
	[FieldOffset(Offset = "0x2C")]
	private Vector3 basePosition;

	[Token(Token = "0x40015AD")]
	[FieldOffset(Offset = "0x38")]
	private float tweenTime;

	[Token(Token = "0x60012A4")]
	[Address(RVA = "0x15DA9CC", Offset = "0x15DA9CC", VA = "0x15DA9CC")]
	private void OnApplicationPause(bool pause)
	{
	}

	[Token(Token = "0x60012A5")]
	[Address(RVA = "0x15DA9D8", Offset = "0x15DA9D8", VA = "0x15DA9D8")]
	private void Start()
	{
	}

	[Token(Token = "0x60012A6")]
	[Address(RVA = "0x15DAA14", Offset = "0x15DAA14", VA = "0x15DAA14")]
	private void Update()
	{
	}

	[Token(Token = "0x60012A7")]
	[Address(RVA = "0x15DAC7C", Offset = "0x15DAC7C", VA = "0x15DAC7C")]
	public ParallaxFromGyro()
	{
	}
}
