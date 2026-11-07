using Audio;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000A8B")]
public class BoatOar : MonoBehaviour
{
	[Token(Token = "0x4003A86")]
	[FieldOffset(Offset = "0x18")]
	public Rigidbody2D Rigid;

	[Token(Token = "0x4003A87")]
	[FieldOffset(Offset = "0x20")]
	public float MoveSpeed;

	[Token(Token = "0x4003A88")]
	[FieldOffset(Offset = "0x24")]
	public Vector2 Range;

	[Token(Token = "0x4003A89")]
	[FieldOffset(Offset = "0x2C")]
	public float RingSpawnInterval;

	[Token(Token = "0x4003A8A")]
	[FieldOffset(Offset = "0x30")]
	public ParticleSystem RingParticles;

	[Token(Token = "0x4003A8B")]
	[FieldOffset(Offset = "0x38")]
	public ParticleSystem RingParticles2;

	[Token(Token = "0x4003A8C")]
	[FieldOffset(Offset = "0x40")]
	public ClipSettingsCollection clips;

	[Token(Token = "0x4003A8D")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private GolfBallController boatController;

	[Token(Token = "0x4003A8E")]
	[FieldOffset(Offset = "0x50")]
	private float timer;

	[Token(Token = "0x4003A8F")]
	[FieldOffset(Offset = "0x54")]
	private float ringTimer;

	[Token(Token = "0x6003257")]
	[Address(RVA = "0x161639C", Offset = "0x161639C", VA = "0x161639C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003258")]
	[Address(RVA = "0x16163F8", Offset = "0x16163F8", VA = "0x16163F8")]
	private void Update()
	{
	}

	[Token(Token = "0x6003259")]
	[Address(RVA = "0x16165F4", Offset = "0x16165F4", VA = "0x16165F4")]
	public BoatOar()
	{
	}
}
