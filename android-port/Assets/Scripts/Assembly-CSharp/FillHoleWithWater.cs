using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20002F6")]
public class FillHoleWithWater : MonoBehaviour
{
	[Token(Token = "0x400105B")]
	[FieldOffset(Offset = "0x18")]
	public Transform endposition;

	[Token(Token = "0x400105C")]
	[FieldOffset(Offset = "0x20")]
	private Vector3 startPos;

	[Token(Token = "0x400105D")]
	[FieldOffset(Offset = "0x2C")]
	public float waterSpeed;

	[Token(Token = "0x400105E")]
	[FieldOffset(Offset = "0x30")]
	private float waterCount;

	[Token(Token = "0x400105F")]
	[FieldOffset(Offset = "0x38")]
	public GameObject boat;

	[Token(Token = "0x4001060")]
	[FieldOffset(Offset = "0x40")]
	public GameObject cannon;

	[Token(Token = "0x4001061")]
	[FieldOffset(Offset = "0x48")]
	private GolfBallController boatController;

	[Token(Token = "0x4001062")]
	[FieldOffset(Offset = "0x50")]
	private GolfBallController cannonController;

	[Token(Token = "0x4001063")]
	[FieldOffset(Offset = "0x58")]
	public Collider ColliderToDisable;

	[Token(Token = "0x4001064")]
	[FieldOffset(Offset = "0x60")]
	public GameObject flagToEnable;

	[Token(Token = "0x4001065")]
	[FieldOffset(Offset = "0x68")]
	public ParticleSystem waterParticles;

	[Token(Token = "0x4001066")]
	[FieldOffset(Offset = "0x70")]
	public ParticleSystem controllerSwitchParticle;

	[Token(Token = "0x4001067")]
	[FieldOffset(Offset = "0x78")]
	public AudioSource controllerSwitchAudio;

	[Token(Token = "0x4001068")]
	[FieldOffset(Offset = "0x80")]
	private bool hasSwapped;

	[Token(Token = "0x6000DA9")]
	[Address(RVA = "0x1463DD8", Offset = "0x1463DD8", VA = "0x1463DD8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000DAA")]
	[Address(RVA = "0x1463E68", Offset = "0x1463E68", VA = "0x1463E68")]
	public void OnParticleCollided()
	{
	}

	[Token(Token = "0x6000DAB")]
	[Address(RVA = "0x1463FAC", Offset = "0x1463FAC", VA = "0x1463FAC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000DAC")]
	[Address(RVA = "0x1463EA0", Offset = "0x1463EA0", VA = "0x1463EA0")]
	private void SwitchControllers()
	{
	}

	[Token(Token = "0x6000DAD")]
	[Address(RVA = "0x1464050", Offset = "0x1464050", VA = "0x1464050")]
	public FillHoleWithWater()
	{
	}
}
