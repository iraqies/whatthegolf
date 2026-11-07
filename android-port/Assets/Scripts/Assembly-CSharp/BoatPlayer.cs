using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000A8C")]
public class BoatPlayer : MonoBehaviour
{
	[Token(Token = "0x4003A90")]
	[FieldOffset(Offset = "0x18")]
	public GameObject BallSprite;

	[Token(Token = "0x4003A91")]
	[FieldOffset(Offset = "0x20")]
	public GolfBallController Controller;

	[Token(Token = "0x4003A92")]
	[FieldOffset(Offset = "0x28")]
	public Rigidbody2D Rigid;

	[Token(Token = "0x4003A93")]
	[FieldOffset(Offset = "0x30")]
	public Collider2D Collider;

	[Token(Token = "0x4003A94")]
	[FieldOffset(Offset = "0x38")]
	public float NoiseScale;

	[Token(Token = "0x4003A95")]
	[FieldOffset(Offset = "0x3C")]
	public float WaveForce;

	[Token(Token = "0x4003A96")]
	[FieldOffset(Offset = "0x40")]
	public float WaveTorque;

	[Token(Token = "0x4003A97")]
	[FieldOffset(Offset = "0x44")]
	public float ScrollSpeed;

	[Token(Token = "0x4003A98")]
	[FieldOffset(Offset = "0x48")]
	private Vector3 startPos;

	[Token(Token = "0x4003A99")]
	[FieldOffset(Offset = "0x54")]
	private Vector2 waveScroll;

	[Token(Token = "0x600325A")]
	[Address(RVA = "0x161660C", Offset = "0x161660C", VA = "0x161660C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600325B")]
	[Address(RVA = "0x1616650", Offset = "0x1616650", VA = "0x1616650")]
	public void Reset()
	{
	}

	[Token(Token = "0x600325C")]
	[Address(RVA = "0x1616690", Offset = "0x1616690", VA = "0x1616690")]
	public Vector3 GetBoatPlayerPosition()
	{
		return default;
	}

	[Token(Token = "0x600325D")]
	[Address(RVA = "0x16166C8", Offset = "0x16166C8", VA = "0x16166C8")]
	public void Dock()
	{
	}

	[Token(Token = "0x600325E")]
	[Address(RVA = "0x1616754", Offset = "0x1616754", VA = "0x1616754")]
	public void Undock()
	{
	}

	[Token(Token = "0x600325F")]
	[Address(RVA = "0x1616798", Offset = "0x1616798", VA = "0x1616798")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6003260")]
	[Address(RVA = "0x16169E0", Offset = "0x16169E0", VA = "0x16169E0")]
	public BoatPlayer()
	{
	}
}
