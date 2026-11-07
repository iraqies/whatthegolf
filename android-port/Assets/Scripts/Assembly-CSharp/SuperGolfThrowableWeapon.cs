using System;
using System.Collections;
using System.Collections.Generic;
using Audio;
using UnityEngine;

public class SuperGolfThrowableWeapon : SuperGolfGun
{
	public ClipSettingsCollection sfxOnHit;

	public float ThrowForce;

	public float ThrowUpForce;

	public float KillForce;

	public List<string> KillTags;

	public bool CanBePickedUpAfterThrown;

	public ParticleSystem DeadlyParticles;

	private Collider shooterCollider;

	private Vector3 throwDirection;

	private int bouncesLeft;

	private Vector3 lastVel;

	private bool ignoreCollision;

	private bool canBeDeadly;

	protected override IEnumerator StartShooting(Collider shooterCollider, Vector3 direction, Action onFinishedShooting = null)
	{
		return null;
	}

	private void FixedUpdate()
	{
	}

	public override bool IsEquipped()
	{
		return false;
	}

	public bool IsBeingHeld()
	{
		return false;
	}

	public override void DestroyGun(Collider shooterCollider = null)
	{
	}

	public override void ThrowGun(Collider shooterCollider)
	{
	}

	protected override void OnCollisionEnter(Collision other)
	{
	}

	private bool IsDeadly()
	{
		return false;
	}

	public void IgnoreFirstCollision()
	{
	}
}
