using System.Collections.Generic;
using Chronos;
using UnityEngine;

public class Grenade : MonoBehaviour
{
	public float Timer;

	public bool Armed;

	public float Force;

	public float UpwardsForce;

	public float Radius;

	public ParticleSystem Particles;

	public ParticleSystem ArmedParticles;

	private Timeline timeline;

	private List<Rigidbody> affectedObjects;

	private void Start()
	{
		affectedObjects = new List<Rigidbody>();
		timeline = GetComponent<Timeline>();
	}

	private void Update()
	{
		if (!Armed)
		{
			return;
		}
		if (affectedObjects.Count != 0)
		{
			foreach (Rigidbody affectedObject in affectedObjects)
			{
				affectedObject.velocity = Vector3.zero;
				affectedObject.angularVelocity = Vector3.zero;
				affectedObject.AddExplosionForce(Force, base.transform.position, Radius, UpwardsForce, ForceMode.Impulse);
			}
			Object.Destroy(base.gameObject);
			return;
		}
		Timer -= timeline.deltaTime;
		if (!(Timer <= 0f))
		{
			return;
		}
		if (Particles != null)
		{
			Particles.transform.SetParent(null);
			Particles.Play(withChildren: true);
		}
		Collider[] array = Physics.OverlapSphere(base.transform.position, Radius);
		for (int i = 0; i < array.Length; i++)
		{
			Collider collider = array[i];
			if (!collider.CompareTag("Player"))
			{
				collider.gameObject.SendMessageUpwards("Kill", SendMessageOptions.DontRequireReceiver);
			}
			if (collider.attachedRigidbody != null)
			{
				affectedObjects.Add(collider.attachedRigidbody);
			}
		}
	}

	private void OnDrawGizmosSelected()
	{
		Gizmos.DrawWireSphere(base.transform.position, Radius);
	}

	public void WeaponShot()
	{
		ArmedParticles.Play();
		Armed = true;
	}
}
