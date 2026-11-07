using System.Collections;
using UnityEngine;

public class CatBossKillCollider : MonoBehaviour
{
	public Transform Target;

	public float KillVelocityThreshold;

	public bool KillOnHit;

	public float HitForce;

	public float SquashDuration;

	public float ShootVelocityMod;

	private Rigidbody rigid;

	private void Start()
	{
	}

	private void FixedUpdate()
	{
	}

	private void OnCollisionEnter(Collision other)
	{
	}

	private IEnumerator Squash(Rigidbody player)
	{
		return null;
	}
}
