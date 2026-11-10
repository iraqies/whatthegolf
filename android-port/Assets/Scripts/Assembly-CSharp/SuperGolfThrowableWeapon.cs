using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Audio;
using UnityEngine;

public class SuperGolfThrowableWeapon : SuperGolfGun
{
	public ClipSettingsCollection sfxOnHit;

	public float ThrowForce = 50f;

	public float ThrowUpForce = 50f;

	public float KillForce = 50f;

	public List<string> KillTags;

	public bool CanBePickedUpAfterThrown = true;

	public ParticleSystem DeadlyParticles;

	private Collider shooterCollider;

	private Vector3 throwDirection;

	private int bouncesLeft;

	private Vector3 lastVel;

	private bool ignoreCollision;

	private bool canBeDeadly;

	protected override IEnumerator StartShooting(Collider shooterCollider, Vector3 direction, Action onFinishedShooting = null)
	{
		if (BulletSpawnPoint != null)
		{
			int layerMask = 1 << LayerMask.NameToLayer("Ground");
			if (!Physics.Linecast(base.transform.position, BulletSpawnPoint.position + direction * 3f, layerMask))
			{
				ShotsLeft--;
				CanBePickedUp = CanBePickedUpAfterThrown;
				throwDirection = direction;
				if (collider != null)
				{
					collider.enabled = true;
				}
				Equip(null, false, shooterCollider);
				onFinishedShooting?.Invoke();
				canBeDeadly = true;
			}
		}
		yield break;
	}

	private void FixedUpdate()
	{
		if (shooterCollider != null)
		{
			Collider[] array = Physics.OverlapSphere(base.transform.position, 1f);
			if (array != null && (array.Length == 0 || !array.Contains(shooterCollider) || (array.Length == 1 && array[0] == collider)))
			{
				if (collider != null)
				{
					Physics.IgnoreCollision(collider, shooterCollider, false);
				}
				shooterCollider = null;
			}
		}
		if (timeline != null && timeline.rigidbody != null)
		{
			lastVel = timeline.rigidbody.velocity;
		}
		if (DeadlyParticles != null && collider != null)
		{
			if (collider.enabled && IsDeadly() && !DeadlyParticles.isPlaying)
			{
				DeadlyParticles.Play();
			}
			else if ((!collider.enabled || !IsDeadly()) && DeadlyParticles.isPlaying)
			{
				DeadlyParticles.Stop();
			}
		}
		if (canBeDeadly && lastVel.magnitude < KillForce)
		{
			canBeDeadly = false;
		}
	}

	public override bool IsEquipped()
	{
		return IsDeadly();
	}

	public bool IsBeingHeld()
	{
		if (collider != null)
		{
			return !collider.enabled;
		}
		return false;
	}

	public override void DestroyGun(Collider shooterCollider = null)
	{
	}

	public override void ThrowGun(Collider shooterCollider)
	{
		if (shooterCollider != null && collider != null)
		{
			Physics.IgnoreCollision(collider, shooterCollider, true);
		}
		SetOwner(null);
		ToggleLaser(false);
		if (rigidbody != null)
		{
			rigidbody.constraints = RigidbodyConstraints.None;
		}
		if (timeline != null && timeline.rigidbody != null)
		{
			timeline.rigidbody.isKinematic = false;
			timeline.rigidbody.velocity = throwDirection * ThrowForce + Vector3.up * ThrowUpForce;
			timeline.rigidbody.angularVelocity = new Vector3(throwDirection.x * 5f, throwDirection.y * 5f, throwDirection.z * 5f);
		}
		this.shooterCollider = shooterCollider;
		bouncesLeft = 1;
		SendMessage("WeaponShot", SendMessageOptions.DontRequireReceiver);
	}

	protected override void OnCollisionEnter(Collision other)
	{
		if (ignoreCollision)
		{
			ignoreCollision = false;
			return;
		}
		if (other == null || other.gameObject == null)
		{
			return;
		}
		if (KillTags != null && KillTags.Contains(other.gameObject.tag))
		{
			if (IsDeadly())
			{
				if (sfxOnHit != null)
				{
					sfxOnHit.Play(null, base.transform.position, 1f, 1f);
				}
				other.gameObject.SendMessage("Kill", SendMessageOptions.DontRequireReceiver);
				canBeDeadly = false;
			}
		}
		else if (other.gameObject.layer == LayerMask.NameToLayer("Ground"))
		{
			bouncesLeft--;
		}
	}

	private bool IsDeadly()
	{
		if (canBeDeadly)
		{
			return lastVel.magnitude >= KillForce;
		}
		return false;
	}

	public void IgnoreFirstCollision()
	{
		ignoreCollision = true;
	}
}
