using System;
using UnityEngine;

public class RigidbodyCollisionInfo : MonoBehaviour
{
	private HitInfo hitInfo;
	private TriggerInfo triggerInfo;

	public Action<HitInfo> onCollision;
	public Action<TriggerInfo> onTrigger;
	public Action<Collider> OnTrigger3D;
	public Action<Collider> OnTriggerEnterEvent
	{
		get => OnTrigger3D;
		set => OnTrigger3D = value;
	}
	public Action<Collider2D> OnTrigger2D;
	public Action<Collision> CollisionEnter3D;
	public Action<Collision2D> CollisionEnter2D;
	public Action<Collision> CollisionExit3D;
	public Action<Collision2D> CollisionExit2D;

	public bool CanSendActualObjectHit { get; set; }

	public static RigidbodyCollisionInfo GetOrAdd(GameObject go)
	{
		if (go == null) return null;
		var info = go.GetComponent<RigidbodyCollisionInfo>();
		if (info == null) info = go.AddComponent<RigidbodyCollisionInfo>();
		return info;
	}

	private void OnCollisionEnter(Collision collision)
	{
		CollisionEnter3D?.Invoke(collision);
		if (onCollision != null && collision != null)
		{
			hitInfo = Audio.AudioUtility.GetHitInfo(collision);
			onCollision(hitInfo);
		}
	}

	private void OnCollisionExit(Collision collision)
	{
		CollisionExit3D?.Invoke(collision);
	}

	private void OnCollisionExit2D(Collision2D collision)
	{
		CollisionExit2D?.Invoke(collision);
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		OnTrigger2D?.Invoke(other);
		if (onTrigger != null && other != null)
		{
			triggerInfo = new TriggerInfo { thisHit = gameObject, otherHit = other.gameObject, point = other.transform.position };
			onTrigger(triggerInfo);
		}
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		CollisionEnter2D?.Invoke(collision);
		if (onCollision != null && collision != null)
		{
			hitInfo = Audio.AudioUtility.GetHitInfo(collision);
			onCollision(hitInfo);
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		OnTrigger3D?.Invoke(other);
		if (onTrigger != null && other != null)
		{
			triggerInfo = new TriggerInfo { thisHit = gameObject, otherHit = other.gameObject, point = other.transform.position };
			onTrigger(triggerInfo);
		}
	}
}
