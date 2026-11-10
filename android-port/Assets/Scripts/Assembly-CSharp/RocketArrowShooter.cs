using System;
using CameraStack;
using Core;
using UnityEngine;

public class RocketArrowShooter : GolfBallShooterBase
{
	private Rigidbody rb;

	public float minShootVelocity;

	public float fullShootVelocity;

	public ParticleSystem particle;

	private GolfBallController controller;

	private bool isAiming;

	private Arrow3D arrow;

	private bool hasAimedOnce;

	[SerializeField]
	private AudioSource rocketAudio;

	private void Start()
	{
		controller = GetComponent<GolfBallController>();
		rb = GetComponent<Rigidbody>();
		arrow = GetComponent<Arrow3D>();
		if (arrow != null)
		{
			arrow.OnCollisionEnterExtraActions = (Action<Collision>)Delegate.Combine(arrow.OnCollisionEnterExtraActions, new Action<Collision>(HandleCollision));
		}
		if (CameraManager.Instance != null)
		{
			CBFollow follow = CameraManager.Instance.GetComponentInChildren<CBFollow>();
			if (follow != null)
				follow.FollowTarget = transform;
		}
		if (particle != null)
			particle.Play();
		if (rocketAudio != null)
			rocketAudio.Play();
	}

	public override void OnAimStart()
	{
		isAiming = true;
	}

	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
		hasAimedOnce = true;
		if (rb == null)
			return;
		float roundedPct = Mathf.Round(boost.magnitude * 100f);
		if (GolfBallController == null || onlyAimArrow || GolfBallController.BlockShooting)
			return;
		boost.Normalize();
		transform.forward = boost.normalized;
		float speed = Mathf.Lerp(minShootVelocity, fullShootVelocity, roundedPct / 100f);
		rb.velocity = boost * speed;
	}

	public override void OnShoot(Vector3 boost)
	{
		isAiming = false;
	}

	public override void OnCancel()
	{
		isAiming = false;
	}

	private void HandleCollision(Collision collision)
	{
		if (arrow != null)
		{
			arrow.OnCollisionEnterExtraActions = (Action<Collision>)Delegate.Remove(arrow.OnCollisionEnterExtraActions, new Action<Collision>(HandleCollision));
		}
		if (rocketAudio != null)
			rocketAudio.Stop();
		if (collision != null && collision.collider != null && collision.collider.gameObject != null && arrow != null && collision.collider.gameObject.tag == arrow.golfGoalLayerTag)
		{
			if (GolfBallController != null)
			{
				GolfBallController.StopAiming();
				GolfBallController.enabled = false;
			}
			enabled = false;
		}
		else if (Level.Instance != null)
		{
			Level.Instance.Fail(true, true, null, 0f, true, "");
		}
	}

	private void OnDisable()
	{
		if (particle != null)
			particle.Stop();
	}

	protected override void FixedUpdate()
	{
		if (!hasAimedOnce && rb != null)
		{
			rb.velocity = transform.forward * fullShootVelocity;
		}
		if (rb != null && !isAiming && rb.velocity.magnitude > 0f)
		{
			transform.forward = rb.velocity;
		}
	}

	private void Update()
	{
		if (IsPointOutsideCamera(transform.position) && Level.Instance != null)
		{
			Level.Instance.Fail(true, true, null, 0f, true, "");
		}
	}

	protected bool IsPointOutsideCamera(Vector3 p)
	{
		if (CameraManager.Instance == null || CameraManager.Instance.Cameras == null || CameraManager.Instance.Cameras.Length == 0 || CameraManager.Instance.Cameras[0] == null)
			return false;
		Camera cam = CameraManager.Instance.Cameras[0];
		Vector3 sp = cam.WorldToScreenPoint(p);
		if (sp.x < 0f || sp.x > cam.pixelWidth || sp.y < 0f || sp.y > cam.pixelHeight)
			return true;
		return false;
	}
}
