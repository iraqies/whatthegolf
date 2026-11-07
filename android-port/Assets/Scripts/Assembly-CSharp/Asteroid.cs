using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20000B0")]
public class Asteroid : MonoBehaviour
{
	[Token(Token = "0x40002B2")]
	[FieldOffset(Offset = "0x18")]
	public int Health;

	[Token(Token = "0x40002B3")]
	[FieldOffset(Offset = "0x20")]
	public ParticleSystem BreakParticles;

	[Token(Token = "0x40002B4")]
	[FieldOffset(Offset = "0x28")]
	public Sprite[] PossibleSprites;

	[Token(Token = "0x40002B5")]
	[FieldOffset(Offset = "0x30")]
	public Transform[] SmallerAsteroidSpawnpoints;

	[Token(Token = "0x40002B6")]
	[FieldOffset(Offset = "0x38")]
	public GameObject AsteroidPrefab;

	[Token(Token = "0x40002B7")]
	[FieldOffset(Offset = "0x40")]
	public bool CarriesFlag;

	[Token(Token = "0x40002B8")]
	[FieldOffset(Offset = "0x44")]
	public float ExplosionForce;

	[Token(Token = "0x40002B9")]
	[FieldOffset(Offset = "0x48")]
	private int explosionTicks;

	[Token(Token = "0x40002BA")]
	[FieldOffset(Offset = "0x4C")]
	private int hitTicks;

	[Token(Token = "0x40002BB")]
	[FieldOffset(Offset = "0x50")]
	private bool exploding;

	[Token(Token = "0x40002BC")]
	[FieldOffset(Offset = "0x58")]
	private Rigidbody2D rigidbody;

	[Token(Token = "0x40002BD")]
	[FieldOffset(Offset = "0x60")]
	protected Vector3 parentAsteroidPosition;

	[Token(Token = "0x40002BE")]
	[FieldOffset(Offset = "0x6C")]
	public bool hit;

	[Token(Token = "0x40002BF")]
	[FieldOffset(Offset = "0x70")]
	public SpriteRenderer HitRenderer;

	[Token(Token = "0x40002C0")]
	[FieldOffset(Offset = "0x78")]
	private float hitScale;

	[Token(Token = "0x6000305")]
	[Address(RVA = "0x142AA04", Offset = "0x142AA04", VA = "0x142AA04")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000306")]
	[Address(RVA = "0x142AB78", Offset = "0x142AB78", VA = "0x142AB78")]
	public void Break()
	{
	}

	[Token(Token = "0x6000307")]
	[Address(RVA = "0x142AE80", Offset = "0x142AE80", VA = "0x142AE80")]
	private void Update()
	{
	}

	[Token(Token = "0x6000308")]
	[Address(RVA = "0x142AFF8", Offset = "0x142AFF8", VA = "0x142AFF8")]
	public Asteroid()
	{
	}
}
