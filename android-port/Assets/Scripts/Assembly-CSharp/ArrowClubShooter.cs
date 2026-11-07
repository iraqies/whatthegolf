using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20005EA")]
public class ArrowClubShooter : MonoBehaviour
{
	[Token(Token = "0x4001E3D")]
	[FieldOffset(Offset = "0x18")]
	public GolfBallController Controller;

	[Token(Token = "0x4001E3E")]
	[FieldOffset(Offset = "0x20")]
	public Transform ColliderObject;

	[Token(Token = "0x4001E3F")]
	[FieldOffset(Offset = "0x28")]
	public Transform Hole;

	[Token(Token = "0x4001E40")]
	[FieldOffset(Offset = "0x30")]
	public float HoleAppearSpeed;

	[Token(Token = "0x4001E41")]
	[FieldOffset(Offset = "0x38")]
	public ParticleSystem Particles;

	[Token(Token = "0x4001E42")]
	[FieldOffset(Offset = "0x40")]
	public AudioMaterial ArrowAudioMaterial;

	[Token(Token = "0x4001E43")]
	[FieldOffset(Offset = "0x48")]
	public GameObject Crosshair;

	[Token(Token = "0x4001E44")]
	[FieldOffset(Offset = "0x50")]
	public float CrosshairSpeed;

	[Token(Token = "0x4001E45")]
	[FieldOffset(Offset = "0x54")]
	private bool hasAddedCollider;

	[Token(Token = "0x4001E46")]
	[FieldOffset(Offset = "0x58")]
	private Vector3 holeOriginalScale;

	[Token(Token = "0x4001E47")]
	[FieldOffset(Offset = "0x64")]
	private float holeScaletimer;

	[Token(Token = "0x4001E48")]
	[FieldOffset(Offset = "0x68")]
	private BoxCollider2D boxCollider;

	[Token(Token = "0x4001E49")]
	[FieldOffset(Offset = "0x70")]
	private float startSize;

	[Token(Token = "0x6001AEE")]
	[Address(RVA = "0x142779C", Offset = "0x142779C", VA = "0x142779C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001AEF")]
	[Address(RVA = "0x142784C", Offset = "0x142784C", VA = "0x142784C")]
	private void Start()
	{
	}

	[Token(Token = "0x6001AF0")]
	[Address(RVA = "0x14278FC", Offset = "0x14278FC", VA = "0x14278FC")]
	private void OnAimUpdate(Vector3 dir, bool blocked)
	{
	}

	[Token(Token = "0x6001AF1")]
	[Address(RVA = "0x1427A94", Offset = "0x1427A94", VA = "0x1427A94")]
	private void Update()
	{
	}

	[Token(Token = "0x6001AF2")]
	[Address(RVA = "0x1427F50", Offset = "0x1427F50", VA = "0x1427F50")]
	private void TryAim(Vector3 point)
	{
	}

	[Token(Token = "0x6001AF3")]
	[Address(RVA = "0x1427FD4", Offset = "0x1427FD4", VA = "0x1427FD4")]
	public ArrowClubShooter()
	{
	}
}
