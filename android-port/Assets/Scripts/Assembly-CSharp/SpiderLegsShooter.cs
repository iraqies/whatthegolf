using Core;
using UnityEngine;

public class SpiderLegsShooter : GolfBallShooterBase
{
	[SerializeField]
	private float fullShootVelocity = 25f;

	[SerializeField]
	private SpiderLegs spiderLegs;

	[SerializeField]
	private Transform Body;

	[SerializeField]
	private Animator topAnimator;

	[SerializeField]
	private Animator bottomAnimator;

	public bool UseAddForce { get; set; }

	public override void OnShoot(Vector3 boost)
	{
		if (spiderLegs != null && spiderLegs.IsGrounded())
		{
			base.OnShoot(boost);
			if (UseAddForce)
			{
				if (rigidbodyC != null)
				{
					Vector3 dir = boost.normalized;
					float mag = boost.magnitude;
					Vector3 vel = Vector3.Lerp(dir * 5f, dir * fullShootVelocity, mag);
					rigidbodyC.AddForce(vel, ForceMode.VelocityChange);
				}
			}
			else
			{
				StandardShoot(boost, 0f, 0f, fullShootVelocity, 0f);
			}
			if (Body != null && boost.sqrMagnitude > 1e-6f)
				Body.transform.rotation = Quaternion.LookRotation(boost, transform.up);
		}
		if (topAnimator != null)
			topAnimator.SetTrigger("Jump");
		if (bottomAnimator != null)
			bottomAnimator.SetTrigger("Jump");
	}
}
