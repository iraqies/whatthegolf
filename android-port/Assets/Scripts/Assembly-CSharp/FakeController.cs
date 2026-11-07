using Core;
using UnityEngine;

public class FakeController : GolfBallController
{
	public Transform Target;

	public Vector2 DelayBetweenShots;

	public Vector2 HoldArrowDuration;

	public float TargetFollowSpeed;

	public Vector2 PowerRange;

	private float delay;

	private float holdArrow;

	private float holdArrowStartDuration;

	private Transform targetFollower;

	private Vector3 randomTargetPosition;

	private float randomPower;

	protected override void Start()
	{
	}

	protected override Vector2 GetInputPosition()
	{
		return default;
	}

	public override bool GetShootButton(bool onlyController = false, string shootButtonName = "Shoot")
	{
		return false;
	}

	public override bool GetShootButtonDown(bool onlyController = false, string shootButtonName = "Shoot")
	{
		return false;
	}

	public override bool GetShootButtonUp(bool onlyController = false, string shootButtonName = "Shoot")
	{
		return false;
	}

	protected override void CheckOutOfBounds(string tag)
	{
	}

	private void LateUpdate()
	{
	}
}
