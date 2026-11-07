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
	}

	private void Update()
	{
	}

	private void OnDrawGizmosSelected()
	{
	}

	public void WeaponShot()
	{
	}
}
