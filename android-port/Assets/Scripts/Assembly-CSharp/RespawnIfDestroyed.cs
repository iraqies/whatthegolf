using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20005DE")]
public class RespawnIfDestroyed : MonoBehaviour
{
	[Token(Token = "0x4001DDD")]
	[FieldOffset(Offset = "0x18")]
	public GameObject ItemToRespawn;

	[Token(Token = "0x4001DDE")]
	[FieldOffset(Offset = "0x20")]
	private Vector3 spawnPosition;

	[Token(Token = "0x4001DDF")]
	[FieldOffset(Offset = "0x2C")]
	private Quaternion spawnRotation;

	[Token(Token = "0x4001DE0")]
	[FieldOffset(Offset = "0x40")]
	private GameObject itemTemplate;

	[Token(Token = "0x6001ABC")]
	[Address(RVA = "0x164CDB8", Offset = "0x164CDB8", VA = "0x164CDB8")]
	private void Start()
	{
	}

	[Token(Token = "0x6001ABD")]
	[Address(RVA = "0x164CEA4", Offset = "0x164CEA4", VA = "0x164CEA4")]
	private void Update()
	{
	}

	[Token(Token = "0x6001ABE")]
	[Address(RVA = "0x164CFF4", Offset = "0x164CFF4", VA = "0x164CFF4")]
	public RespawnIfDestroyed()
	{
	}
}
