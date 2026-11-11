using System.Collections;
using Core;
using UnityEngine;

public class GolferAndBallShooter : GolfBallShooterBase
{
	[SerializeField]
	private Rigidbody ball;

	[SerializeField]
	private Rigidbody golfer;

	[SerializeField]
	private float fullVelocity = 25f;

	[SerializeField]
	private float fullPitch = 15f;

	[SerializeField]
	private float fullSpin = 5f;

	[SerializeField]
	private float golferRunSpeed = 10f;

	private bool hasBall = true;

	private Animator golfAnimator;

	private bool isShooting;

	private Vector3 ballOffset;

	private NearestVertGravity ballGravity;

	protected override void Awake()
	{
		base.Awake();
		golfAnimator = GetComponentInChildren<Animator>();
		if (ball != null && golfer != null)
		{
			ballOffset = ball.transform.position - golfer.transform.position;
		}
		if (ball != null)
		{
			ballGravity = ball.GetComponent<NearestVertGravity>();
		}
	}

	public override void OnShoot(Vector3 boost)
	{
		if (isShooting)
		{
			return;
		}
		base.OnShoot(boost);
		if (hasBall)
		{
			isShooting = true;
			StartCoroutine(PlayShootSequence(boost));
			hasBall = false;
			if (ballGravity != null)
			{
				ballGravity.enabled = true;
			}
			if (ball != null)
			{
				ball.isKinematic = false;
			}
		}
		else if (golfer != null)
		{
			golfer.velocity = boost * golferRunSpeed;
			if (boost != Vector3.zero)
			{
				transform.rotation = Quaternion.LookRotation(boost, transform.up);
			}
		}
	}

	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
		if (boost != Vector3.zero)
		{
			transform.rotation = Quaternion.LookRotation(boost, transform.up);
		}
		if (hasBall)
		{
			if (golfAnimator != null)
			{
				golfAnimator.SetFloat("GolfSwingBlend", Mathf.Min(0.5f, boost.magnitude));
			}
			if (ball != null && golfer != null)
			{
				ball.transform.position = golfer.transform.TransformPoint(ballOffset);
			}
		}
	}

	private IEnumerator PlayShootSequence(Vector3 boost)
	{
		float startBlend = Mathf.Min(0.5f, boost.magnitude);
		yield return StartCoroutine(pTween.To(0.15f, t =>
		{
			if (golfAnimator != null)
			{
				golfAnimator.SetFloat("GolfSwingBlend", Mathf.Lerp(startBlend, 1f, TweenFunctions.EaseIn(t)));
			}
		}));
		if (ball != null)
		{
			Vector3 pitched = PitchBoost(boost);
			Vector3 spinAxis = Vector3.Cross(boost, transform.up);
			ball.AddForce(pitched * fullVelocity, ForceMode.VelocityChange);
			ball.AddTorque(spinAxis * fullSpin, ForceMode.VelocityChange);
		}
		isShooting = false;
		if (golfAnimator != null)
		{
			golfAnimator.SetBool("IsGolfSwinging", false);
		}
	}

	private Vector3 PitchBoost(Vector3 boost)
	{
		Vector3 axis = Vector3.Cross(boost, transform.up);
		return Quaternion.AngleAxis(fullPitch * boost.magnitude, axis) * boost;
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other == null || !other.CompareTag("GolfBall"))
		{
			return;
		}
		if (rigidbodyC != null)
		{
			rigidbodyC.velocity = Vector3.zero;
			rigidbodyC.angularVelocity = Vector3.zero;
		}
		if (ball != null)
		{
			ball.velocity = Vector3.zero;
			ball.angularVelocity = Vector3.zero;
		}
		if (golfAnimator != null)
		{
			golfAnimator.SetBool("IsGolfSwinging", true);
		}
		if (ball != null && golfer != null)
		{
			ball.transform.position = golfer.transform.TransformPoint(ballOffset);
		}
		hasBall = true;
		if (ballGravity != null)
		{
			ballGravity.enabled = false;
		}
		if (ball != null)
		{
			ball.isKinematic = true;
		}
	}
}
