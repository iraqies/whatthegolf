using System.Collections;
using UnityEngine;

public class BossBehaviourSineMovement : BossBehaviour
{
	public float curveWidth;

	public float speed;

	public float distance;

	public float sineMovementSpeed;

	public float IntroLength;

	public float CurveIntroLength;

	public float RotateSpeed;

	public float UpAndDownBobSpeed;

	public float UpAndDownBobAmount;

	public float BaseCarHeight;

	public float SpeedDecline;

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

	public override Vector3 Position => default;

	public override Quaternion Rotation => default;

	private void Start()
	{
	}

	private float GetXMovementFromZ(float z, bool useXmovementMultiplier = true)
	{
		return 0f;
	}

	public Vector3 GetBusPositionForOffsetZ(float zOffset, bool useXmovementMultiplier = true)
	{
		return default;
	}

	private float GetMoveDistanceFromForward(float forward)
	{
		return 0f;
	}

	public override float GetSpeed()
	{
		return 0f;
	}

	public override IEnumerator EndRoutine()
	{
		return null;
	}
}
