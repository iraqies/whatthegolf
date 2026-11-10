using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Core;
using UnityEngine;

public class HoleInOnePeggleBall : MonoBehaviour
{
	public Action OnReset;

	public Transform resetToPosition;

	private List<PeggleBob> bobs;

	private void Start()
	{
		if (transform.parent != null)
			bobs = transform.parent.GetComponentsInChildren<PeggleBob>().ToList();
		else
			bobs = FindObjectsOfType<PeggleBob>().ToList();
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision != null && collision.transform != null && collision.transform.GetComponent<HoleInOneBallReset>() != null)
		{
			OnReset?.Invoke();
			StartCoroutine(UpdateBobs());
		}
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision != null && collision.transform != null && collision.transform.GetComponent<HoleInOneBallReset>() != null)
		{
			OnReset?.Invoke();
			StartCoroutine(UpdateBobs());
		}
	}

	private void Reset()
	{
		StartCoroutine(UpdateBobs());
	}

	private IEnumerator UpdateBobs()
	{
		SpriteRenderer[] renderers = gameObject.GetComponentsInChildren<SpriteRenderer>();
		if (renderers != null)
		{
			for (int i = 0; i < renderers.Length; i++)
			{
				if (renderers[i] != null)
					renderers[i].enabled = false;
			}
		}
		TrailRenderer trail = GetComponentInChildren<TrailRenderer>();
		Rigidbody2D rb = GetComponent<Rigidbody2D>();
		if (rb != null)
		{
			rb.isKinematic = true;
			rb.velocity = Vector2.zero;
			rb.angularVelocity = 0f;
		}

		yield return new WaitForSeconds(0.25f);

		if (trail != null)
			trail.enabled = false;
		if (resetToPosition != null)
			transform.position = resetToPosition.position;

		GravityAfterShoot grav = GetComponent<GravityAfterShoot>();
		if (grav != null)
			grav.Reset();

		if (bobs != null)
		{
			var hitBobs = bobs.OrderBy(b => b != null ? b.hitTime : 0f).ToList();
			int hitCount = hitBobs.Count(b => b != null && b.HasBeenHit);
			float delay = hitCount > 0 ? Mathf.Min(0.15f, 1.5f / hitCount) : 0.15f;
			foreach (PeggleBob bob in hitBobs)
			{
				if (bob != null && bob.HasBeenHit)
				{
					bob.Remove();
					bobs.Remove(bob);
					yield return new WaitForSeconds(delay);
				}
			}
		}

		yield return new WaitForSeconds(0.4f);

		BallShooter shooter = GetComponent<BallShooter>();
		if (shooter != null)
			shooter.didShoot = false;
		if (trail != null)
			trail.enabled = true;
		if (renderers != null)
		{
			for (int i = 0; i < renderers.Length; i++)
			{
				if (renderers[i] != null)
					renderers[i].enabled = true;
			}
		}
		if (rb != null)
			rb.isKinematic = false;
		GolfBallController ctrl = GetComponent<GolfBallController>();
		if (ctrl != null)
			ctrl.enabled = true;
	}
}
