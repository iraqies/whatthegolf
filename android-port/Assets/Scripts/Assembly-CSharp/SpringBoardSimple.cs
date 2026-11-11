using System.Collections.Generic;
using Audio;
using UnityEngine;

public class SpringBoardSimple : MonoBehaviour
{
	public Vector3 ForceDirection;

	public float SpeedBoost;

	public ForceMode Mode;

	public ClipSettingsCollection sfxOnBounce;

	private List<Rigidbody> affectedRigidbodies;

	private float lastSfxTime;

	private void Start()
	{
		affectedRigidbodies = new List<Rigidbody>();
	}

	private void OnTriggerEnter(Collider other)
	{
		if (!enabled || other == null || other.attachedRigidbody == null)
		{
			return;
		}
		if (affectedRigidbodies != null && affectedRigidbodies.Contains(other.attachedRigidbody))
		{
			return;
		}
		if (Time.time >= lastSfxTime + 0.15f)
		{
			if (sfxOnBounce != null)
			{
				sfxOnBounce.Play(null, transform.position, 1f, 1f);
			}
			lastSfxTime = Time.time;
		}
		other.attachedRigidbody.velocity = transform.TransformDirection(ForceDirection.normalized) * SpeedBoost;
	}

	private void OnTriggerExit(Collider other)
	{
		if (enabled && other != null && affectedRigidbodies != null)
		{
			affectedRigidbodies.Remove(other.attachedRigidbody);
		}
	}

	private void OnDrawGizmosSelected()
	{
		Gizmos.DrawLine(transform.position, transform.position + transform.TransformDirection(ForceDirection.normalized) * SpeedBoost);
	}
}
