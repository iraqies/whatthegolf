using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20006FF")]
public class FishLocation : MonoBehaviour
{
	[Token(Token = "0x40024B3")]
	[FieldOffset(Offset = "0x0")]
	public static int fishCaught;

	[Token(Token = "0x40024B4")]
	[FieldOffset(Offset = "0x18")]
	public float maxTime;

	[Token(Token = "0x40024B5")]
	[FieldOffset(Offset = "0x1C")]
	public float minTime;

	[Token(Token = "0x40024B6")]
	[FieldOffset(Offset = "0x20")]
	private float randomTime;

	[Token(Token = "0x40024B7")]
	[FieldOffset(Offset = "0x24")]
	private float timer;

	[Token(Token = "0x40024B8")]
	[FieldOffset(Offset = "0x28")]
	public GameObject flagFish;

	[Token(Token = "0x40024B9")]
	[FieldOffset(Offset = "0x30")]
	private GameObject flagFishClone;

	[Token(Token = "0x40024BA")]
	[FieldOffset(Offset = "0x38")]
	private Transform golfTransform;

	[Token(Token = "0x40024BB")]
	[FieldOffset(Offset = "0x40")]
	private bool caught;

	[Token(Token = "0x40024BC")]
	[FieldOffset(Offset = "0x48")]
	private ParticleSystem waves;

	[Token(Token = "0x40024BD")]
	[FieldOffset(Offset = "0x50")]
	private Vector3 waveScale;

	[Token(Token = "0x40024BE")]
	[FieldOffset(Offset = "0x5C")]
	private bool shark;

	[Token(Token = "0x40024BF")]
	[FieldOffset(Offset = "0x60")]
	private Vector3 accelInput;

	[Token(Token = "0x40024C0")]
	[FieldOffset(Offset = "0x70")]
	private Transform fisherTransform;

	[Token(Token = "0x40024C1")]
	[FieldOffset(Offset = "0x78")]
	public GameObject somethingElse;

	[Token(Token = "0x40024C2")]
	[FieldOffset(Offset = "0x80")]
	private GameObject something;

	[Token(Token = "0x6002049")]
	[Address(RVA = "0x1467990", Offset = "0x1467990", VA = "0x1467990")]
	[Attribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x6590C", Offset = "0x6590C")]
	private static void Init()
	{
	}

	[Token(Token = "0x600204A")]
	[Address(RVA = "0x14679F4", Offset = "0x14679F4", VA = "0x14679F4")]
	private void Start()
	{
	}

	[Token(Token = "0x600204B")]
	[Address(RVA = "0x1467B20", Offset = "0x1467B20", VA = "0x1467B20")]
	private void OnTriggerStay(Collider other)
	{
	}

	[Token(Token = "0x600204C")]
	[Address(RVA = "0x14684D0", Offset = "0x14684D0", VA = "0x14684D0")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x600204D")]
	[Address(RVA = "0x1468604", Offset = "0x1468604", VA = "0x1468604")]
	private void Update()
	{
	}

	[Token(Token = "0x600204E")]
	[Address(RVA = "0x146878C", Offset = "0x146878C", VA = "0x146878C")]
	public FishLocation()
	{
	}
}
