using Core;
using UnityEngine;

public class CageShooter : GolfBallShooterBase
{
	public GameObject FreePlayerObject;

	public Animator Animator;

	public HingeJoint CageJoint;

	public Vector2 JointMotorForceRange;

	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	public void BreakCage(Vector3 position)
	{
	}
}
