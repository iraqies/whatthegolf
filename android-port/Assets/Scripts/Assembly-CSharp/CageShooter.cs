using Core;
using UnityEngine;

public class CageShooter : GolfBallShooterBase
{
	public GameObject FreePlayerObject;

	public Animator Animator;

	public HingeJoint CageJoint;

	public Vector2 JointMotorForceRange = new Vector2(8000f, 15000f);

	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
		if (!onlyAimArrow)
		{
			JointMotor motor = CageJoint.motor;
			CageJoint.axis = new Vector3(boost.z, 0f, 0f - boost.x);
			motor.force = Mathf.Lerp(JointMotorForceRange.x, JointMotorForceRange.y, boost.magnitude);
			CageJoint.motor = motor;
			Animator.SetFloat("X", boost.x);
			Animator.SetFloat("Y", 0f - boost.z);
		}
	}

	public void BreakCage(Vector3 position)
	{
		GolfBallController c = FreePlayerObject.GetComponentInChildren<GolfBallController>();
		c.PlayerIndex = GolfBallController.PlayerID;
		c.enabled = false;
		FreePlayerObject.transform.position = position;
		FreePlayerObject.gameObject.SetActive(true);
		Animator.gameObject.SetActive(false);
		StartCoroutine(pTween.To(1f, delegate
		{
			c.enabled = true;
		}));
	}
}
