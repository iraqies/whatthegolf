using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using Utility;

[Token(Token = "0x20005DF")]
public class SpawnFromVolumeTowardsTarget : MonoBehaviour, IObjectPooler
{
	[Token(Token = "0x4001DE1")]
	[FieldOffset(Offset = "0x18")]
	public Rigidbody2D ObjectToSpawn;

	[Token(Token = "0x4001DE2")]
	[FieldOffset(Offset = "0x20")]
	public BoxCollider2D SpawnVolume;

	[Token(Token = "0x4001DE3")]
	[FieldOffset(Offset = "0x28")]
	public Transform Target;

	[Token(Token = "0x4001DE4")]
	[FieldOffset(Offset = "0x30")]
	public float SpawnInterval;

	[Token(Token = "0x4001DE5")]
	[FieldOffset(Offset = "0x34")]
	public float firstSpawnDelay;

	[Token(Token = "0x4001DE6")]
	[FieldOffset(Offset = "0x38")]
	public float offset;

	[Token(Token = "0x4001DE7")]
	[FieldOffset(Offset = "0x3C")]
	private float timer;

	[Token(Token = "0x4001DE8")]
	[FieldOffset(Offset = "0x40")]
	private ObjectPool<GameObject> objectPool;

	[Token(Token = "0x4001DE9")]
	[FieldOffset(Offset = "0x48")]
	private List<GameObject> activeObject;

	[Token(Token = "0x170002EE")]
	public ObjectPool<GameObject> GetPool
	{
		[Token(Token = "0x6001ABF")]
		[Address(RVA = "0x16C6530", Offset = "0x16C6530", VA = "0x16C6530", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001AC0")]
	[Address(RVA = "0x16C6538", Offset = "0x16C6538", VA = "0x16C6538")]
	private void Start()
	{
	}

	[Token(Token = "0x6001AC1")]
	[Address(RVA = "0x16C6628", Offset = "0x16C6628", VA = "0x16C6628")]
	private void Update()
	{
	}

	[Token(Token = "0x6001AC2")]
	[Address(RVA = "0x16C6B44", Offset = "0x16C6B44", VA = "0x16C6B44")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6001AC3")]
	[Address(RVA = "0x16C69CC", Offset = "0x16C69CC", VA = "0x16C69CC")]
	public Vector3 CalculateVelocityForTarget(Vector3 startPosition, Vector3 target, float initialAngle)
	{
		return default;
	}

	[Token(Token = "0x6001AC4")]
	[Address(RVA = "0x16C6CF4", Offset = "0x16C6CF4", VA = "0x16C6CF4")]
	public SpawnFromVolumeTowardsTarget()
	{
	}
}
