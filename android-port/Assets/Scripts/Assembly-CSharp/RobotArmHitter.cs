using System.Collections;
using UnityEngine;

public class RobotArmHitter : MonoBehaviour
{
	public Transform Target;

	public Rigidbody RotatePivot;

	public Rigidbody ArmTwister;

	public Transform HandTwister;

	public Transform HitPoint;

	public float SwingHeight;

	public float SwingSpeed;

	public float SwingRange;

	public float FacingOffset;

	public float MaxReach;

	public bool CanRotate;

	public float offset;

	public bool test;

	private Quaternion restingRotation;

	private Quaternion restingHandRotation;

	private WaitForSeconds wait;

	private bool isSwinging;

	private Quaternion targetSwingRotation;

	private float rotTarget;

	private float rotCurrent;

	private bool canSwing;

	private float swingDelay;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	private IEnumerator SwingAtTarget()
	{
		return null;
	}

	private void OnDrawGizmosSelected()
	{
	}
}
