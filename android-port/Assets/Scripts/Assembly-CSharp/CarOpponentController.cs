using Core;
using UnityEngine;

public class CarOpponentController : GolfBallController
{
	public Transform TargetContainer;

	public Vector2 DelayBetweenShots;

	public Vector2 HoldArrowDuration;

	public float EdgeCheckDistanceMod;

	public float EdgeCheckDownwardsDistance;

	private float holdArrow;

	private float holdArrowStartDuration;

	private Rigidbody rigid;

	private bool forceShot;

	private int target;

	private int targetChild;

	protected override void Start()
	{
	}

	private void FixedUpdate()
	{
	}

	protected override bool IsStartingToAim()
	{
		return false;
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

	internal override Vector3 GetFinalAimVector()
	{
		return default;
	}

	private void LateUpdate()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}
}
