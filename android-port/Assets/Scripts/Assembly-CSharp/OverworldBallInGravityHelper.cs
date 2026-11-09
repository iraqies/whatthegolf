using System.Collections.Generic;
using System.Linq;
using Audio;
using Core;
using UnityEngine;

public class OverworldBallInGravityHelper : MonoBehaviour
{
	public LayerMask wallLayerMask;

	public float raycastDistance = 0.378f;

	public bool useCustomStopThreshold;

	public float customStopThreshold;

	public AudioClipSettings sfxOnUp;

	public AudioClipSettings sfxOnRight;

	public AudioClipSettings sfxOnDown;

	public AudioClipSettings sfxOnLeft;

	private float baseStopThreshold;

	private OverworldBall2D ball;

	private GolfBallController controller;

	private int shotsSinceGrounded;

	private int maxInAirShots;

	private Vector2 currentWindDirection;

	private List<WindArea2D> zones;

	private float stillTime;

	private Vector3 lastPosition;

	private float stillThreshold = 0.05f;

	private void Awake()
	{
		zones = new List<WindArea2D>();
		ball = GetComponent<OverworldBall2D>();
		controller = GetComponent<GolfBallController>();
		if (controller != null)
		{
			controller.OnPreShoot -= Controller_OnPreShoot;
			controller.OnPreShoot += Controller_OnPreShoot;
		}
		if (ball != null)
			baseStopThreshold = ball.stopThreshold;
	}

	private void Controller_OnPreShoot(Vector3 obj)
	{
		if (isInGravityZone() && !IsGrounded())
		{
			shotsSinceGrounded++;
		}
	}

	private void FixedUpdate()
	{
		if (!isInGravityZone())
			return;
		if (IsGrounded())
		{
			shotsSinceGrounded = 0;
		}
		if (Vector3.Distance(transform.position, lastPosition) < stillThreshold)
		{
			stillTime += Time.fixedDeltaTime;
			if (stillTime > 1f)
				shotsSinceGrounded = 0;
		}
		else
		{
			stillTime = 0f;
		}
		lastPosition = transform.position;
		if (controller != null)
		{
			controller.BlockShooting = shotsSinceGrounded >= maxInAirShots && maxInAirShots != -1;
		}
	}

	private bool IsGrounded()
	{
		if (!isInGravityZone() || zones == null || zones.Count == 0)
			return true;
		var lastZone = zones[zones.Count - 1];
		if (lastZone == null)
			return true;
		Vector2 dir = lastZone.WindForce.normalized;
		RaycastHit2D hit = Physics2D.Raycast(transform.position, dir, raycastDistance, wallLayerMask);
		return hit.collider != null;
	}

	private void OnEnable()
	{
		if (zones == null)
			zones = new List<WindArea2D>();
		shotsSinceGrounded = 0;
		var rb = GetComponent<Rigidbody2D>();
		if (rb != null)
			rb.WakeUp();
	}

	public void EnterGravityZone(WindArea2D zone, int zoneMaxInAirShots)
	{
		if (zone == null) return;
		if ((currentWindDirection.normalized - zone.WindForce.normalized).sqrMagnitude >= 0.0001f)
		{
			currentWindDirection = zone.WindForce;
			if (zone.playGravitySwitchSfxOnBall)
			{
				if (currentWindDirection.x < 0f && sfxOnLeft != null)
					sfxOnLeft.Play(Vector3.zero);
				if (currentWindDirection.x > 0f && sfxOnRight != null)
					sfxOnRight.Play(Vector3.zero);
				if (currentWindDirection.y > 0f && sfxOnUp != null)
					sfxOnUp.Play(Vector3.zero);
				if (currentWindDirection.y < 0f && sfxOnDown != null)
					sfxOnDown.Play(Vector3.zero);
			}
		}
		shotsSinceGrounded = 0;
		maxInAirShots = zoneMaxInAirShots;
		if (zones == null)
			zones = new List<WindArea2D>();
		if (!zones.Contains(zone))
			zones.Add(zone);
		if (useCustomStopThreshold && ball != null)
			ball.stopThreshold = customStopThreshold;
	}

	public void ExitGravityZone(WindArea2D zone)
	{
		if (zones != null && zones.Contains(zone))
			zones.Remove(zone);
		shotsSinceGrounded = 0;
		if (!isInGravityZone())
		{
			if (controller != null)
				controller.BlockShooting = false;
			if (useCustomStopThreshold && ball != null)
				ball.stopThreshold = baseStopThreshold;
		}
	}

	private bool isInGravityZone()
	{
		return zones != null && zones.Count >= 1 && zones.Exists(z => z != null && z.gameObject.activeInHierarchy);
	}
}
