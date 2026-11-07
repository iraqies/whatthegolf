using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000DE4")]
public class SpawnParticlesOnHitPosition : MonoBehaviour
{
	[Token(Token = "0x4004BB6")]
	[FieldOffset(Offset = "0x18")]
	public string acceptedTag;

	[Token(Token = "0x4004BB7")]
	[FieldOffset(Offset = "0x20")]
	public GameObject particlePrefab;

	[Token(Token = "0x4004BB8")]
	[FieldOffset(Offset = "0x28")]
	public Transform staticSpawnPos;

	[Token(Token = "0x4004BB9")]
	[FieldOffset(Offset = "0x30")]
	private Vector3 particleDir;

	[Token(Token = "0x600416F")]
	[Address(RVA = "0x16C8D34", Offset = "0x16C8D34", VA = "0x16C8D34")]
	private void OnCollisionEnter2D(Collision2D collision)
	{
	}

	[Token(Token = "0x6004170")]
	[Address(RVA = "0x16C8DC0", Offset = "0x16C8DC0", VA = "0x16C8DC0")]
	private void SpawnParticles(Vector3 spawnPos)
	{
	}

	[Token(Token = "0x6004171")]
	[Address(RVA = "0x16C8F00", Offset = "0x16C8F00", VA = "0x16C8F00")]
	public SpawnParticlesOnHitPosition()
	{
	}
}
