using System.Collections.Generic;
using UnityEngine;

public class ScreenShakeOnCollision : MonoBehaviour
{
	public LayerMask CollisionMask;

	public bool OnlyOnce;

	public float Duration;

	public float Speed;

	public float Magnitude;

	public List<AudioClip> AudioClip;

	public float clipVolumeMax;

	public bool UseCollisionForce;

	private bool hasShaken;

	private void OnCollisionEnter(Collision other)
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void CheckCollision(GameObject other, Vector3 impactForce)
	{
	}
}
