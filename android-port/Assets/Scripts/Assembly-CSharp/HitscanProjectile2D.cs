using System.Collections;
using Audio;
using UnityEngine;

public class HitscanProjectile2D : SuperGolfBullet
{
	public float Force;

	public float TrailOffset;

	public float distance;

	public LayerMask hitMask;

	public bool CanShootFlag;

	public ClipSettingsCollection _ricochetSounds;

	public ClipSettingsCollection shootSounds;

	private float lifetimeTimer;

	private ParticleSystem particles;

	private int bouncesLeft;

	private int bouncesDone;

	private TrailRenderer projectileTrail;

	protected override void Awake()
	{
	}

	protected override void OnEnable()
	{
	}

	private IEnumerator LaunchProjectile()
	{
		return null;
	}

	private void CheckProjectilePath(Vector3 origin, Vector3 direction)
	{
	}

	protected override void Update()
	{
	}

	protected override void KillBullet(Vector3 point)
	{
	}

	public override void SetSpeed(float speedMod)
	{
	}
}
