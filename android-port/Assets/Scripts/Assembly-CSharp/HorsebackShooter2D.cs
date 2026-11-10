using System.Collections.Generic;
using Core;
using UnityEngine;
using Utility;

public class HorsebackShooter2D : GolfBall2DShooterBase
{
	public Transform shootTransform;

	public GameObject projectilePrefab;

	public MinMax forceLimits;

	private ObjectPool<GameObject> projectiles;

	private List<Collider> colliders;

	protected override void Awake()
	{
		base.Awake();
		colliders = new List<Collider>();
		GetComponentsInChildren(colliders);
		if (projectilePrefab != null)
		{
			projectiles = new ObjectPool<GameObject>(projectilePrefab, 0, null);
		}
	}

	public override void OnShoot(Vector3 boost)
	{
		base.OnShoot(boost);
		ShootProjectile(boost);
	}

	private void ShootProjectile(Vector3 boost)
	{
		if (shootTransform == null || projectiles == null || forceLimits == null)
			return;

		GameObject go = projectiles.Get(shootTransform.position, Quaternion.LookRotation(boost), null, true);
		if (go != null)
		{
			SuperGolfBullet bullet = go.GetComponent<SuperGolfBullet>();
			if (bullet != null)
			{
				bullet.BulletPool = projectiles;
				bullet.SetSpeed(Mathf.Lerp(forceLimits.min, forceLimits.max, boost.magnitude));
				bullet.previousOwnerColliders = colliders;
			}
		}
	}
}
