using System.Collections;
using UnityEngine;

public class RobotArmHitter : MonoBehaviour
{
	public Transform Target;

	public Rigidbody RotatePivot;

	public Rigidbody ArmTwister;

	public Transform HandTwister;

	public Transform HitPoint;

	public float SwingHeight = 90f;

	public float SwingSpeed = 0.2f;

	public float SwingRange = 3f;

	public float FacingOffset;

	public float MaxReach = 5f;

	public bool CanRotate = true;

	public float offset;

	public bool test;

	private Quaternion restingRotation;

	private Quaternion restingHandRotation;

	private WaitForSeconds wait = new WaitForSeconds(0.5f);

	private bool isSwinging;

	private Quaternion targetSwingRotation;

	private float rotTarget;

	private float rotCurrent;

	private bool canSwing;

	private float swingDelay;

	private void Start()
	{
		if (ArmTwister != null)
		{
			restingRotation = ArmTwister.rotation;
		}
		if (HandTwister != null)
		{
			restingHandRotation = HandTwister.rotation;
		}
		Collider[] cols = GetComponentsInChildren<Collider>();
		if (cols != null)
		{
			for (int i = 0; i < cols.Length; i++)
			{
				for (int j = i + 1; j < cols.Length; j++)
				{
					if (cols[i] != null && cols[j] != null && cols[i].gameObject != cols[j].gameObject)
					{
						Physics.IgnoreCollision(cols[i], cols[j]);
					}
				}
			}
		}
	}

	private void Update()
	{
		if (Target == null)
		{
			return;
		}
		if (swingDelay > 0f)
		{
			swingDelay -= Time.deltaTime;
			return;
		}
		if (Input.GetKeyUp(KeyCode.Space) || (!isSwinging && canSwing && HitPoint != null && Vector3.Distance(HitPoint.position, Target.position) <= SwingRange))
		{
			StartCoroutine(SwingAtTarget());
		}
	}

	private void FixedUpdate()
	{
		if (isSwinging)
		{
			if (ArmTwister != null)
			{
				ArmTwister.MoveRotation(targetSwingRotation);
			}
			return;
		}
		if (Target == null)
		{
			return;
		}
		if (CanRotate && RotatePivot != null)
		{
			Vector3 toTarget = Target.position - RotatePivot.position;
			toTarget.y = 0f;
			if (toTarget.sqrMagnitude > 0.001f)
			{
				Quaternion lookRot = Quaternion.LookRotation(toTarget.normalized, Vector3.up) * Quaternion.Euler(0f, FacingOffset, 0f);
				RotatePivot.MoveRotation(lookRot);
			}
		}
		if (HitPoint != null)
		{
			Vector3 localTarget = HitPoint.InverseTransformPoint(Target.position);
			rotTarget = Mathf.Clamp(localTarget.y * 10f + offset, -MaxReach, MaxReach);
			rotCurrent = Mathf.MoveTowards(rotCurrent, rotTarget, Time.deltaTime * 90f);
			canSwing = Mathf.Abs(rotCurrent - rotTarget) < 15f;
			if (ArmTwister != null)
			{
				ArmTwister.MoveRotation(Quaternion.AngleAxis(rotCurrent, ArmTwister.transform.right) * restingRotation);
			}
			if (HandTwister != null)
			{
				HandTwister.rotation = Quaternion.AngleAxis(rotCurrent, HandTwister.transform.forward) * restingHandRotation;
			}
		}
	}

	private IEnumerator SwingAtTarget()
	{
		if (ArmTwister == null)
		{
			yield break;
		}
		isSwinging = true;
		Quaternion initialRot = ArmTwister.rotation;
		Quaternion windupRot = Quaternion.AngleAxis(-SwingHeight, ArmTwister.transform.up) * initialRot;
		yield return StartCoroutine(pTween.To(SwingSpeed, t =>
		{
			targetSwingRotation = Quaternion.Lerp(initialRot, windupRot, Mathf.SmoothStep(0f, 1f, t));
		}));
		Quaternion swingEndRot = Quaternion.AngleAxis(SwingHeight, ArmTwister.transform.up) * initialRot;
		yield return StartCoroutine(pTween.To(SwingSpeed * 0.5f, t =>
		{
			targetSwingRotation = Quaternion.Lerp(windupRot, swingEndRot, t);
		}));
		yield return wait;
		Quaternion curRot = ArmTwister.rotation;
		yield return StartCoroutine(pTween.To(SwingSpeed, t =>
		{
			targetSwingRotation = Quaternion.Lerp(curRot, initialRot, Mathf.SmoothStep(0f, 1f, t));
		}));
		yield return wait;
		isSwinging = false;
		swingDelay = 0.5f;
	}

	private void OnDrawGizmosSelected()
	{
		if (HitPoint != null)
		{
			Gizmos.DrawWireSphere(HitPoint.position, SwingRange);
		}
	}
}
