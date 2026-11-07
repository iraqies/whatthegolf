using System;
using UnityEngine;

public class RigidbodyCollisionInfo : MonoBehaviour
{
	private HitInfo hitInfo;

	private TriggerInfo triggerInfo;

	public Action<HitInfo> onCollision;

	public Action<TriggerInfo> onTrigger;

	public Action<Collider> OnTrigger3D;

	public Action<Collider2D> OnTrigger2D;

	public Action<Collision> CollisionEnter3D;

	public Action<Collision2D> CollisionEnter2D;

	public Action<Collision> CollisionExit3D;

	public Action<Collision2D> CollisionExit2D;

	public bool CanSendActualObjectHit { get; set; }

	public static RigidbodyCollisionInfo GetOrAdd(GameObject go)
	{
		return null;
	}

	private void OnCollisionEnter(Collision collision)
	{
	}

	private void OnCollisionExit(Collision collision)
	{
	}

	private void OnCollisionExit2D(Collision2D collision)
	{
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}
}
