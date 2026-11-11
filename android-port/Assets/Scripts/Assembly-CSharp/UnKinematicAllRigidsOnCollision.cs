using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

public class UnKinematicAllRigidsOnCollision : MonoBehaviour
{
	public bool setAllKinematicAtStart;

	public float massCoefficient = 1f;

	public LayerMask collisionMask;

	public bool trigger = true;

	public UnityEvent unityEventOnCollision;

	private List<Rigidbody> rigidbodies;

	private void Start()
	{
		rigidbodies = base.gameObject.GetComponentsInChildren<Rigidbody>().ToList();
		foreach (Rigidbody rigidbody in rigidbodies)
		{
			rigidbody.mass *= massCoefficient;
			if (setAllKinematicAtStart)
			{
				rigidbody.isKinematic = true;
			}
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if (!trigger || (int)collisionMask != ((int)collisionMask | (1 << other.gameObject.layer)))
		{
			return;
		}
		unityEventOnCollision?.Invoke();
		foreach (Rigidbody rigidbody in rigidbodies)
		{
			rigidbody.isKinematic = false;
		}
	}

	private void OnCollisionEnter(Collision other)
	{
		if (trigger || (int)collisionMask != ((int)collisionMask | (1 << other.gameObject.layer)))
		{
			return;
		}
		unityEventOnCollision?.Invoke();
		foreach (Rigidbody rigidbody in rigidbodies)
		{
			rigidbody.isKinematic = false;
		}
	}
}
