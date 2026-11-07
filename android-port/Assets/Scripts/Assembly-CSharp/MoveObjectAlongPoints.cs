using UnityEngine;

public class MoveObjectAlongPoints : MonoBehaviour
{
	public enum MovementTypeEnum
	{
		PingPong = 0,
		Loop = 1
	}

	public AnimationCurve MovementCurve;

	public Transform WaypointContainer;

	public float TimePerRound;

	public bool MoveWithBezier;

	public bool FollowWaypointRotations;

	public MovementTypeEnum MovementType;

	public float SpeedMod;

	private float movementTimer;

	private int currentDirection;

	private int currentMovementTargetIndex;

	private float movementDist;

	private Rigidbody rigid;

	private Rigidbody2D rigid2D;

	private float movementTimerTarget;

	private float movedSoFar;

	private Vector3 lastPos;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void FixedUpdate()
	{
	}

	private void Update()
	{
	}

	public void ChangeDirection()
	{
	}

	private Vector3 GetTargetPosition()
	{
		return default;
	}

	public int GetDirection()
	{
		return 0;
	}

	public void SetDirection(float direction)
	{
	}

	private Quaternion GetTargetRotation()
	{
		return default;
	}

	private void SetMovementTarget()
	{
	}

	private float GetDistance(int index)
	{
		return 0f;
	}

	private void OnDrawGizmos()
	{
	}
}
