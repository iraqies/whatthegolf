using Core;
using UnityEngine;

public class SimpleSpiderShooter : ShooterBase
{
	[SerializeField]
	private Rigidbody hook;

	[SerializeField]
	private Rigidbody arm;

	[SerializeField]
	private LayerMask HitLayer;

	[SerializeField]
	private float HookSpeed;

	[SerializeField]
	private float boostY;

	[SerializeField]
	private float HookForwardMovement;

	private bool HasHit;

	private bool HasShot;

	[SerializeField]
	private float HitDotResult;

	[SerializeField]
	private float ExtraUpwardsPullForce;

	[SerializeField]
	private float realInSpeed;

	[SerializeField]
	private float minDistance;

	public override void OnAimStart()
	{
		HasHit = false;
		HasShot = false;
		if (hook != null)
		{
			hook.gameObject.SetActive(true);
			SpringJoint component = hook.GetComponent<SpringJoint>();
			if (component != null)
			{
				component.connectedBody = null;
			}
		}
	}

	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
		Vector3 vector = new Vector3(boost.x, boostY, boost.z);
		if (arm != null && hook != null)
		{
			hook.position = arm.position;
			hook.transform.position = arm.position;
			if (vector.sqrMagnitude > 0.0001f)
			{
				hook.transform.rotation = Quaternion.LookRotation(vector.normalized);
			}
		}
	}

	public override void OnShoot(Vector3 boost)
	{
		HasShot = true;
	}

	protected void FixedUpdate()
	{
		if (!HasHit && HasShot && hook != null)
		{
			if (Physics.CheckSphere(hook.position, 1f, HitLayer))
			{
				HasHit = true;
			}
			hook.MovePosition(hook.position + hook.transform.forward * HookSpeed * Time.fixedDeltaTime);
		}
		if (!HasHit || arm == null || hook == null)
		{
			return;
		}
		if (Vector3.Distance(arm.position, hook.position) < minDistance)
		{
			Vector3 position = Vector3.Lerp(arm.position, hook.position, Mathf.Clamp01(HookForwardMovement));
			arm.transform.position = position;
			arm.position = position;
			return;
		}
		SpringJoint component = hook.GetComponent<SpringJoint>();
		if (component != null)
		{
			component.connectedBody = arm;
		}
		HasHit = false;
		HasShot = false;
	}
}
