using System.Collections;
using Audio;
using UnityEngine;

public class HitscanProjectile : SuperGolfBullet
{
	public float Force;

	public float TrailOffset;

	public RandomAudioClips ricochetSounds;

	private float lifetimeTimer;

	private ParticleSystem particles;

	protected override void Awake()
	{
		base.Awake();
	}

	protected override void OnEnable()
	{
	}

	private IEnumerator NextFrameMoveTrail(RaycastHit hit)
	{
		return null;
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
