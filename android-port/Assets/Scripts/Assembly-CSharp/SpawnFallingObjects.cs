using System.Collections.Generic;
using Chronos;
using Il2CppDummyDll;
using UnityEngine;
using Utility;

[Token(Token = "0x2000886")]
public class SpawnFallingObjects : MonoBehaviour
{
	[Token(Token = "0x2000887")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x41B30", Offset = "0x41B30")]
	private sealed class _003C_003Ec__DisplayClass20_0
	{
		[Token(Token = "0x4002EC3")]
		[FieldOffset(Offset = "0x10")]
		public Rigidbody activeObject;

		[Token(Token = "0x600275C")]
		[Address(RVA = "0x1853178", Offset = "0x1853178", VA = "0x1853178")]
		public _003C_003Ec__DisplayClass20_0()
		{
		}

		[Token(Token = "0x600275D")]
		[Address(RVA = "0x1853180", Offset = "0x1853180", VA = "0x1853180")]
		internal bool _003CUpdate_003Eb__0(ObjectPool<Rigidbody> p)
		{
			return default;
		}
	}

	[Token(Token = "0x4002EB1")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public List<Rigidbody> spawnObjects;

	[Token(Token = "0x4002EB2")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public float spawnInterval;

	[Token(Token = "0x4002EB3")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	public int spawnAmount;

	[Token(Token = "0x4002EB4")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	public Vector2 spawnTorqueForceRange;

	[Token(Token = "0x4002EB5")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	public Vector3 spawnForce;

	[Token(Token = "0x4002EB6")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	public BoxCollider spawnArea;

	[Token(Token = "0x4002EB7")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	public BoxCollider levelBounds;

	[Token(Token = "0x4002EB8")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	public float radiusCheck;

	[Token(Token = "0x4002EB9")]
	[FieldOffset(Offset = "0x54")]
	[SerializeField]
	public float timeChangeSpeed;

	[Token(Token = "0x4002EBA")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	public float timeChangeBackSpeed;

	[Token(Token = "0x4002EBB")]
	[FieldOffset(Offset = "0x5C")]
	[SerializeField]
	public float startDelay;

	[Token(Token = "0x4002EBC")]
	[FieldOffset(Offset = "0x60")]
	private float spawnTimer;

	[Token(Token = "0x4002EBD")]
	[FieldOffset(Offset = "0x68")]
	private List<ObjectPool<Rigidbody>> pools;

	[Token(Token = "0x4002EBE")]
	[FieldOffset(Offset = "0x70")]
	private List<Rigidbody> activeObjects;

	[Token(Token = "0x4002EBF")]
	[FieldOffset(Offset = "0x78")]
	private Timeline timeline;

	[Token(Token = "0x4002EC0")]
	[FieldOffset(Offset = "0x80")]
	private float timeScaleTarget;

	[Token(Token = "0x4002EC1")]
	[FieldOffset(Offset = "0x84")]
	private float origTimeScale;

	[Token(Token = "0x4002EC2")]
	[FieldOffset(Offset = "0x88")]
	private float heightOffsetToBall;

	[Token(Token = "0x6002758")]
	[Address(RVA = "0x16C4B44", Offset = "0x16C4B44", VA = "0x16C4B44")]
	private void Start()
	{
	}

	[Token(Token = "0x6002759")]
	[Address(RVA = "0x16C4F6C", Offset = "0x16C4F6C", VA = "0x16C4F6C")]
	private void Ball_OnShoot(Vector3 obj)
	{
	}

	[Token(Token = "0x600275A")]
	[Address(RVA = "0x16C4F88", Offset = "0x16C4F88", VA = "0x16C4F88")]
	private void Update()
	{
	}

	[Token(Token = "0x600275B")]
	[Address(RVA = "0x16C56D0", Offset = "0x16C56D0", VA = "0x16C56D0")]
	public SpawnFallingObjects()
	{
	}
}
