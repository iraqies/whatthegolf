using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000BCF")]
public class CloudSpawner : MonoBehaviour
{
	[Token(Token = "0x40041B5")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Transform RotateAroundPoint;

	[Token(Token = "0x40041B6")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public float height;

	[Token(Token = "0x40041B7")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	public float width;

	[Token(Token = "0x40041B8")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	public float depth;

	[Token(Token = "0x40041B9")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private int startClouds;

	[Token(Token = "0x40041BA")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Transform CloudTemplates;

	[Token(Token = "0x40041BB")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Transform CloudContainer;

	[Token(Token = "0x40041BC")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private bool cloudsLookAtPlayer;

	[Token(Token = "0x40041BD")]
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	[Attribute(Name = "RangeAttribute", RVA = "0x50DB8", Offset = "0x50DB8")]
	private float parallaxCoefficient;

	[Token(Token = "0x40041BE")]
	[FieldOffset(Offset = "0x48")]
	private GameObject cloudRotator;

	[Token(Token = "0x40041BF")]
	[FieldOffset(Offset = "0x50")]
	private Vector3 lastCameraPos;

	[Token(Token = "0x60038CF")]
	[Address(RVA = "0x18A51E4", Offset = "0x18A51E4", VA = "0x18A51E4")]
	private void Start()
	{
	}

	[Token(Token = "0x60038D0")]
	[Address(RVA = "0x18A57E0", Offset = "0x18A57E0", VA = "0x18A57E0")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60038D1")]
	[Address(RVA = "0x18A53B0", Offset = "0x18A53B0", VA = "0x18A53B0")]
	public void SpawnClouds()
	{
	}

	[Token(Token = "0x60038D2")]
	[Address(RVA = "0x18A525C", Offset = "0x18A525C", VA = "0x18A525C")]
	public void CleanUp()
	{
	}

	[Token(Token = "0x60038D3")]
	[Address(RVA = "0x18A5954", Offset = "0x18A5954", VA = "0x18A5954")]
	public CloudSpawner()
	{
	}
}
