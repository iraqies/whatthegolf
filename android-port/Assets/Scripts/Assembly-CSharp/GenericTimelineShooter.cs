using System.Collections.Generic;
using Chronos;
using Core;
using UnityEngine;

public class GenericTimelineShooter : GolfBallShooterBase
{
	[SerializeField]
	private Timeline timeline;

	[SerializeField]
	private List<Clock> clocks;

	[SerializeField]
	private float aimTimeScale = 0.1f;

	[SerializeField]
	private float upSpeed = 100f;

	[SerializeField]
	private float downSpeed = 10f;

	[SerializeField]
	public float minShootVelocity = 5f;

	[SerializeField]
	public float fullShootVelocity = 25f;

	[SerializeField]
	public float pitch;

	[SerializeField]
	public AnimationCurve powerToPitchWeightCurve = AnimationCurve.Linear(0f, 1f, 1f, 1f);

	[SerializeField]
	public float spin;

	[SerializeField]
	protected bool lookInShotDirection;

	public bool lookInAimDirection;

	public float LookInAimDirectionSpeed = float.PositiveInfinity;

	[SerializeField]
	protected bool dontLookInAimDirectionWhenBlocked;

	[SerializeField]
	protected bool useLocalUp;

	[SerializeField]
	public bool zeroPitchIfNotGrouneded = true;

	public override void OnActivate()
	{
		base.OnActivate();
		if (rigidbodyC == null)
			rigidbodyC = GetComponent<Rigidbody>() ?? GetComponentInChildren<Rigidbody>();
		if (rigidbodyC != null)
			rigidbodyC.isKinematic = false;
		if (timeline != null && timeline.rigidbody != null)
			timeline.rigidbody.isKinematic = false;
	}

	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		if (clocks != null)
		{
			bool aiming = GolfBallController != null && GolfBallController.IsAiming;
			float targetScale = aiming ? aimTimeScale : 1f;
			foreach (var clock in clocks)
			{
				if (clock == null) continue;
				float cur = clock.localTimeScale;
				float spd = targetScale > cur ? upSpeed : downSpeed;
				clock.localTimeScale = Mathf.Lerp(cur, targetScale, cur * spd);
			}
		}
	}

	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
		base.OnAimUpdate(boost, onlyAimArrow);
		if (!lookInAimDirection) return;
		if (dontLookInAimDirectionWhenBlocked && IsBlocking()) return;
		if (boost.sqrMagnitude <= 1e-6f || rigidbodyC == null) return;

		Vector3 upVec = useLocalUp ? transform.up : Vector3.up;
		Quaternion targetRot = Quaternion.LookRotation(boost, upVec);
		if (!float.IsInfinity(LookInAimDirectionSpeed))
		{
			float dt = (timeline != null && timeline.deltaTime > 0f) ? timeline.deltaTime : Time.deltaTime;
			targetRot = Quaternion.RotateTowards(rigidbodyC.rotation, targetRot, LookInAimDirectionSpeed * dt);
		}
		rigidbodyC.MoveRotation(targetRot);
	}

	public override void OnShoot(Vector3 boost)
	{
		base.OnShoot(boost);
		Vector3 upVec = useLocalUp ? transform.up : Vector3.up;
		if (lookInShotDirection && rigidbodyC != null && boost.sqrMagnitude > 1e-6f)
		{
			rigidbodyC.MoveRotation(Quaternion.LookRotation(boost, upVec));
		}

		float eval = powerToPitchWeightCurve != null ? powerToPitchWeightCurve.Evaluate(boost.magnitude) : 1f;
		Vector3 planeNormal = GolfBallController != null ? GolfBallController.GetPlane(GolfBallController.AimPlane).normal : Vector3.up;
		float weightedPitch = pitch * eval;
		Vector3 axis = Vector3.Cross(boost, planeNormal);
		if (!zeroPitchIfNotGrouneded || GolfBallController == null || GolfBallController.IsGrounded)
		{
			if (axis.sqrMagnitude > 1e-6f)
				boost = Quaternion.AngleAxis(weightedPitch, axis) * boost;
		}

		StandardShoot(boost, weightedPitch, minShootVelocity, fullShootVelocity, spin);
	}

	protected override void StandardShoot(Vector3 boost, float pitch, float minShootVelocity, float fullShootVelocity, float spin)
	{
		if (timeline != null && timeline.rigidbody != null && timeline.rigidbody.component != null)
		{
			Vector3 planeNormal = GolfBallController != null ? GolfBallController.GetPlane(GolfBallController.AimPlane).normal : Vector3.up;
			Vector3 axis = Vector3.Cross(boost, planeNormal);
			timeline.rigidbody.isKinematic = false;
			timeline.rigidbody.angularVelocity = Vector3.zero;
			timeline.rigidbody.velocity = Vector3.zero;
			Vector3 dir = boost.normalized;
			float mag = boost.magnitude;
			Vector3 minVel = dir * minShootVelocity;
			Vector3 maxVel = dir * fullShootVelocity;
			timeline.rigidbody.velocity = minVel + (maxVel - minVel) * mag;
			timeline.rigidbody.AddTorque(-axis * spin, ForceMode.VelocityChange);
		}
		base.StandardShoot(boost, pitch, minShootVelocity, fullShootVelocity, spin);
	}
}
