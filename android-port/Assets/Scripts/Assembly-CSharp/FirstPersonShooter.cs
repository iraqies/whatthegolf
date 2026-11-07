using System;
using Audio;
using Core;
using Il2CppDummyDll;
using UnityEngine;
using Utility;

[Token(Token = "0x2000827")]
public class FirstPersonShooter : GolfBallShooterExperimental
{
	[Token(Token = "0x4002BE5")]
	[FieldOffset(Offset = "0x88")]
	public float SmashVelocity;

	[Token(Token = "0x4002BE6")]
	[FieldOffset(Offset = "0x8C")]
	public float SleepVelocity;

	[Token(Token = "0x4002BE7")]
	[FieldOffset(Offset = "0x90")]
	public float ShootInterval;

	[Token(Token = "0x4002BE8")]
	[FieldOffset(Offset = "0x98")]
	public GameObject Bullet;

	[Token(Token = "0x4002BE9")]
	[FieldOffset(Offset = "0xA0")]
	public bool CanShoot;

	[Token(Token = "0x4002BEA")]
	[FieldOffset(Offset = "0xA1")]
	public bool BulletIsParticles;

	[Token(Token = "0x4002BEB")]
	[FieldOffset(Offset = "0xA4")]
	public float ParticlesVelocity;

	[Token(Token = "0x4002BEC")]
	[FieldOffset(Offset = "0xA8")]
	public RandomAudioClips ShootSounds;

	[Token(Token = "0x4002BED")]
	[FieldOffset(Offset = "0xB0")]
	public bool BlockFromController;

	[Token(Token = "0x4002BEE")]
	[FieldOffset(Offset = "0xB1")]
	public bool SyncCooldowns;

	[Token(Token = "0x4002BEF")]
	[FieldOffset(Offset = "0xB8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4F264", Offset = "0x4F264")]
	private Action<Vector3> m_OnActualShoot;

	[Token(Token = "0x4002BF0")]
	[FieldOffset(Offset = "0xC0")]
	private ObjectPool<GameObject> bulletPool;

	[Token(Token = "0x4002BF1")]
	[FieldOffset(Offset = "0xC8")]
	private Collider collider;

	[Token(Token = "0x4002BF2")]
	[FieldOffset(Offset = "0xD0")]
	private float shootTimer;

	[Token(Token = "0x4002BF3")]
	[FieldOffset(Offset = "0xD8")]
	private ParticleSystem bulletParticles;

	[Token(Token = "0x4002BF4")]
	[FieldOffset(Offset = "0xE0")]
	private TimeControl _timeControll;

	[Token(Token = "0x14000035")]
	public event Action<Vector3> OnActualShoot
	{
		[Token(Token = "0x600257E")]
		[Address(RVA = "0x1466D20", Offset = "0x1466D20", VA = "0x1466D20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x669B0", Offset = "0x669B0")]
		add
		{
		}
		[Token(Token = "0x600257F")]
		[Address(RVA = "0x1466DC4", Offset = "0x1466DC4", VA = "0x1466DC4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x669C0", Offset = "0x669C0")]
		remove
		{
		}
	}

	[Token(Token = "0x6002580")]
	[Address(RVA = "0x1466E68", Offset = "0x1466E68", VA = "0x1466E68")]
	private void Start()
	{
	}

	[Token(Token = "0x6002581")]
	[Address(RVA = "0x1466FD0", Offset = "0x1466FD0", VA = "0x1466FD0")]
	private void Update()
	{
	}

	[Token(Token = "0x6002582")]
	[Address(RVA = "0x14672B4", Offset = "0x14672B4", VA = "0x14672B4")]
	private void Shoot(Vector3 boost)
	{
	}

	[Token(Token = "0x6002583")]
	[Address(RVA = "0x146721C", Offset = "0x146721C", VA = "0x146721C")]
	private void TryShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x6002584")]
	[Address(RVA = "0x14676A0", Offset = "0x14676A0", VA = "0x14676A0")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x6002585")]
	[Address(RVA = "0x14677AC", Offset = "0x14677AC", VA = "0x14677AC")]
	public FirstPersonShooter()
	{
	}
}
