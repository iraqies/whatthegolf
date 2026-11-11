using System.Collections;
using UnityEngine;

public class BossBehaviourSineMovement : BossBehaviour
{
	public float curveWidth = 4f;

	public float speed = 15f;

	public float distance;

	public float sineMovementSpeed = 1f;

	public float IntroLength = 1f;

	public float CurveIntroLength = 2f;

	public float RotateSpeed = 10f;

	public float UpAndDownBobSpeed = 3f;

	public float UpAndDownBobAmount = 0.25f;

	public float BaseCarHeight;

	public float SpeedDecline = 10f;

	private Vector3 busPosition;

	private float currentSpeed;

	private bool isDriving;

	private float xMovementMultiplier;

	private float moveDistanceForSineMovement;

	public float introBoost;

	private float curveIntro;

	private Vector3 startPos;

	private Quaternion startRot;

	private float currentCarBaseHeight;

	private float upAndDownBobVal;

	public override Vector3 Position
	{
		get
		{
			if (!isDriving)
			{
				return busPosition;
			}
			distance += Time.fixedDeltaTime * currentSpeed;
			busPosition = GetBusPositionForOffsetZ(0f, true);
			return busPosition;
		}
	}

	public override Quaternion Rotation
	{
		get
		{
			if (!isDriving)
			{
				return BossRigidbody != null ? BossRigidbody.rotation : transform.rotation;
			}
			Vector3 ahead = GetBusPositionForOffsetZ(2.5f, true);
			Vector3 dir = ahead - busPosition;
			if (dir.sqrMagnitude < 0.0001f)
			{
				return BossRigidbody != null ? BossRigidbody.rotation : transform.rotation;
			}
			Quaternion targetRot = Quaternion.LookRotation(dir.normalized, Vector3.up);
			Quaternion curRot = BossRigidbody != null ? BossRigidbody.rotation : transform.rotation;
			return Quaternion.Slerp(curRot, targetRot, Time.fixedDeltaTime * RotateSpeed);
		}
	}

	private void Start()
	{
		if (BossRigidbody != null)
		{
			startPos = BossRigidbody.position;
			startRot = BossRigidbody.rotation;
			busPosition = startPos;
		}
		else
		{
			startPos = transform.position;
			startRot = transform.rotation;
			busPosition = startPos;
		}
		if (BossStage != null)
		{
			BossStage.OnChallengeBegin += () =>
			{
				isDriving = true;
				currentSpeed = speed;
				currentCarBaseHeight = BaseCarHeight;
				StartCoroutine(pTween.To(Mathf.Max(0.01f, IntroLength), 0f, 1f, t => introBoost = t));
				StartCoroutine(pTween.To(Mathf.Max(0.01f, CurveIntroLength), 0f, 1f, t =>
				{
					curveIntro = t;
					xMovementMultiplier = t;
				}));
			};
		}
	}

	private float GetXMovementFromZ(float z, bool useXmovementMultiplier = true)
	{
		float mult = useXmovementMultiplier ? xMovementMultiplier : 1f;
		return Mathf.Sin(GetMoveDistanceFromForward(z) * sineMovementSpeed) * curveWidth * mult;
	}

	public Vector3 GetBusPositionForOffsetZ(float zOffset, bool useXmovementMultiplier = true)
	{
		float forwardDist = distance + zOffset;
		float xOffset = GetXMovementFromZ(forwardDist, useXmovementMultiplier);
		upAndDownBobVal = Mathf.Sin((Time.time + zOffset * 0.1f) * UpAndDownBobSpeed) * UpAndDownBobAmount;
		Vector3 pos = startPos + startRot * new Vector3(xOffset, 0f, forwardDist);
		pos.y = startPos.y + currentCarBaseHeight + upAndDownBobVal;
		return pos;
	}

	private float GetMoveDistanceFromForward(float forward)
	{
		return moveDistanceForSineMovement + forward;
	}

	public override float GetSpeed()
	{
		return currentSpeed;
	}

	public override IEnumerator EndRoutine()
	{
		while (currentSpeed > 0.01f)
		{
			currentSpeed = Mathf.MoveTowards(currentSpeed, 0f, Time.deltaTime * SpeedDecline);
			currentCarBaseHeight = Mathf.Lerp(0f, BaseCarHeight, currentSpeed / Mathf.Max(0.01f, speed));
			xMovementMultiplier = Mathf.MoveTowards(xMovementMultiplier, 0f, Time.deltaTime * SpeedDecline);
			yield return null;
		}
		currentSpeed = 0f;
		isDriving = false;
	}
}
