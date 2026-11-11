using Core;
using UnityEngine;

public class FakeController : GolfBallController
{
	public Transform Target;

	public Vector2 DelayBetweenShots = new Vector2(0.5f, 1.5f);

	public Vector2 HoldArrowDuration = new Vector2(0.5f, 1.2f);

	public float TargetFollowSpeed = 5f;

	public Vector2 PowerRange = new Vector2(0.4f, 1f);

	private float delay;

	private float holdArrow;

	private float holdArrowStartDuration;

	private Transform targetFollower;

	private Vector3 randomTargetPosition;

	private float randomPower = 0.8f;

	protected override void Start()
	{
		base.Start();
		delay = Random.Range(DelayBetweenShots.x, DelayBetweenShots.y);
	}

	protected override Vector2 GetInputPosition()
	{
		Vector3 targetPos = Target != null ? Target.position : transform.position + randomTargetPosition;
		if (targetFollower == null)
		{
			GameObject go = new GameObject("FakeControllerTargetFollower");
			targetFollower = go.transform;
			targetFollower.position = targetPos;
		}
		Vector3 jitter = new Vector3(Mathf.Sin(Time.time * 2f), 0f, Mathf.Cos(Time.time * 2f)) * 0.5f;
		targetFollower.position = Vector3.MoveTowards(targetFollower.position, targetPos + jitter, Time.deltaTime * TargetFollowSpeed);
		Camera cam = GetCam();
		if (cam == null)
		{
			return Vector2.zero;
		}
		Vector3 spTarget = cam.WorldToScreenPoint(targetFollower.position);
		Vector3 spBall = cam.WorldToScreenPoint(transform.position);
		Vector3 dir = (spBall - spTarget).normalized;
		float mag = Mathf.Lerp(0f, randomPower * 200f, 1f - Mathf.Clamp01(holdArrow / Mathf.Max(0.01f, holdArrowStartDuration)));
		return (Vector2)spBall + new Vector2(dir.x, dir.y) * mag;
	}

	public override bool GetShootButton(bool onlyController = false, string shootButtonName = "Shoot")
	{
		return isAiming;
	}

	public override bool GetShootButtonDown(bool onlyController = false, string shootButtonName = "Shoot")
	{
		if (delay <= 0f && !isAiming)
		{
			holdArrowStartDuration = Random.Range(HoldArrowDuration.x, HoldArrowDuration.y);
			holdArrow = holdArrowStartDuration;
			delay = Random.Range(DelayBetweenShots.x, DelayBetweenShots.y);
			Vector3 rnd = Random.onUnitSphere;
			randomTargetPosition = new Vector3(rnd.x, 0f, rnd.z) * 5f;
			randomPower = Random.Range(PowerRange.x, PowerRange.y);
			return true;
		}
		return false;
	}

	public override bool GetShootButtonUp(bool onlyController = false, string shootButtonName = "Shoot")
	{
		return isAiming && holdArrow <= 0f && !BlockShooting;
	}

	protected override void CheckOutOfBounds(string tag)
	{
		if (tag == "OutOfBounds" || tag == "OutOfBoundsReset" || tag == "KillZone")
		{
			if (shootArrow != null)
			{
				shootArrow.Hide();
			}
			Reset(0f);
		}
	}

	private void LateUpdate()
	{
		if (isAiming)
		{
			holdArrow -= Time.deltaTime;
		}
		else
		{
			delay -= Time.deltaTime;
		}
	}
}
