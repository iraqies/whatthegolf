using System.Collections;
using Core;
using UnityEngine;

public class ExplosionBarrelHelper : MonoBehaviour
{
	public bool stopWhileAiming;

	private ExplosionBarrel barrel;

	private GolfBallController controller;

	private GolfBallShooterExperimental shooter;

	private Rigidbody rigid;

	private float startDrag;

	private bool didExplode;

	private void Start()
	{
	}

	private void FixedUpdate()
	{
	}

	public void Explode()
	{
	}

	private void OnCollisionEnter(Collision collision)
	{
	}

	private IEnumerator Boom()
	{
		return null;
	}
}
