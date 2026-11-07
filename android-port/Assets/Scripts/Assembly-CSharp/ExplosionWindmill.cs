using System.Collections;
using Audio;
using Core;
using UnityEngine;

public class ExplosionWindmill : MonoBehaviour
{
	public ExplosionBarrel barrel;

	public Rigidbody wings;

	public Rigidbody main;

	public Collider mainCollider;

	public RotateAxis rotator;

	public ClipSettingsCollection explosionSweetenerSFX;

	public bool failLevelOnExplode;

	private float delayTimer;

	private GolfBallController controller;

	private void Start()
	{
	}

	private void Barrel_OnExplode(Collider arg1, ExplosionBarrel arg2)
	{
	}

	private IEnumerator Boom()
	{
		return null;
	}
}
