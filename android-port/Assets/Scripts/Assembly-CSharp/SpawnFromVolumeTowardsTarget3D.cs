using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using Utility;

[Token(Token = "0x20005E0")]
public class SpawnFromVolumeTowardsTarget3D : MonoBehaviour, IObjectPooler
{
	[Token(Token = "0x4001DEA")]
	[FieldOffset(Offset = "0x18")]
	public Rigidbody ObjectToSpawn;

	[Token(Token = "0x4001DEB")]
	[FieldOffset(Offset = "0x20")]
	public BoxCollider SpawnVolume;

	[Token(Token = "0x4001DEC")]
	[FieldOffset(Offset = "0x28")]
	public Transform Target;

	[Token(Token = "0x4001DED")]
	[FieldOffset(Offset = "0x30")]
	public float SpawnInterval;

	[Token(Token = "0x4001DEE")]
	[FieldOffset(Offset = "0x34")]
	public float firstSpawnDelay;

	[Token(Token = "0x4001DEF")]
	[FieldOffset(Offset = "0x38")]
	public float offset;

	[Token(Token = "0x4001DF0")]
	[FieldOffset(Offset = "0x3C")]
	private float timer;

	[Token(Token = "0x4001DF1")]
	[FieldOffset(Offset = "0x40")]
	private ObjectPool<GameObject> objectPool;

	[Token(Token = "0x4001DF2")]
	[FieldOffset(Offset = "0x48")]
	private List<GameObject> activeObject;

	[Token(Token = "0x170002EF")]
	public ObjectPool<GameObject> GetPool
	{
		[Token(Token = "0x6001AC5")]
		[Address(RVA = "0x16C6CFC", Offset = "0x16C6CFC", VA = "0x16C6CFC", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001AC6")]
	[Address(RVA = "0x16C6D04", Offset = "0x16C6D04", VA = "0x16C6D04")]
	private void Start()
	{
	}

	[Token(Token = "0x6001AC7")]
	[Address(RVA = "0x16C6DF4", Offset = "0x16C6DF4", VA = "0x16C6DF4")]
	private void Update()
	{
	}

	[Token(Token = "0x6001AC8")]
	[Address(RVA = "0x16C725C", Offset = "0x16C725C", VA = "0x16C725C")]
	public Vector3 CalculateVelocityForTarget(Vector3 startPosition, Vector3 target, float initialAngle)
	{
		return default;
	}

	[Token(Token = "0x6001AC9")]
	[Address(RVA = "0x16C73D4", Offset = "0x16C73D4", VA = "0x16C73D4")]
	public SpawnFromVolumeTowardsTarget3D()
	{
	}
}
