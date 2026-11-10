using System.Collections.Generic;
using Core;
using UnityEngine;
using Utility;

public class HitscanShooter2D : GolfBall2DShooterBase
{
	public Transform shootTransform;

	public float shootDist = 100f;

	public LayerMask targetMask;

	public GameObject projectilePrefab;

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
		CheckHitscan(boost);
	}

	private void ShootProjectile(Vector3 boost)
	{
		if (shootTransform == null || projectiles == null)
			return;

		GameObject go = projectiles.Get(shootTransform.position, Quaternion.LookRotation(boost), null, true);
		if (go != null)
		{
			SuperGolfBullet bullet = go.GetComponent<SuperGolfBullet>();
			if (bullet != null)
			{
				bullet.BulletPool = projectiles;
				bullet.previousOwnerColliders = colliders;
			}
		}
	}

	private void CheckHitscan(Vector3 boost)
	{
		if (shootTransform == null)
			return;

		Vector2 origin = shootTransform.position;
		Vector2 dir = boost.normalized;
		RaycastHit2D hit = Physics2D.Raycast(origin, dir, shootDist, targetMask);
		if (hit.collider != null && hit.collider.TryGetComponent<BottleTarget>(out BottleTarget target))
		{
			target.OnHit(hit.point);
		}
		Debug.DrawRay(shootTransform.position, boost.normalized * shootDist, Color.red, 1f);
	}
}
