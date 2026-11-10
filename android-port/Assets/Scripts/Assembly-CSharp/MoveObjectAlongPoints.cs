using UnityEngine;

public class MoveObjectAlongPoints : MonoBehaviour
{
	public enum MovementTypeEnum
	{
		PingPong = 0,
		Loop = 1
	}

	public AnimationCurve MovementCurve = new AnimationCurve(new Keyframe(0f, 1f), new Keyframe(1f, 1f));

	public Transform WaypointContainer;

	public float TimePerRound = 1f;

	public bool MoveWithBezier;

	public bool FollowWaypointRotations;

	public MovementTypeEnum MovementType;

	public float SpeedMod = 1f;

	private float movementTimer;

	private int currentDirection = 1;

	private int currentMovementTargetIndex;

	private float movementDist;

	private Rigidbody rigid;

	private Rigidbody2D rigid2D;

	private float movementTimerTarget;

	private float movedSoFar;

	private Vector3 lastPos;

	private void Awake()
	{
		rigid = GetComponent<Rigidbody>();
		rigid2D = GetComponent<Rigidbody2D>();
	}

	private void Start()
	{
		movementDist = 0f;
		lastPos = base.transform.position;
		if (WaypointContainer == null)
			return;

		int i = 0;
		while (i < WaypointContainer.childCount - 1)
		{
			movementDist += GetDistance(i);
			i += (MoveWithBezier ? 2 : 1);
		}
		SetMovementTarget();
	}

	private void FixedUpdate()
	{
		if (WaypointContainer == null || WaypointContainer.childCount < 2)
			return;

		Vector3 targetPos = GetTargetPosition();
		if (rigid != null)
		{
			rigid.MovePosition(targetPos);
			if (FollowWaypointRotations)
			{
				rigid.MoveRotation(GetTargetRotation());
			}
		}
		else if (rigid2D != null)
		{
			rigid2D.MovePosition(new Vector2(targetPos.x, targetPos.y));
			if (FollowWaypointRotations)
			{
				rigid2D.MoveRotation(GetTargetRotation());
			}
		}
	}

	private void Update()
	{
		movedSoFar += Vector3.Distance(base.transform.position, lastPos);
		float curveVal = (MovementCurve != null && movementDist > 0f) ? MovementCurve.Evaluate(movedSoFar / movementDist) : 1f;
		movementTimer += Time.deltaTime * curveVal * SpeedMod;

		if (movementTimer < 0f || movementTimer > movementTimerTarget)
		{
			int step = currentDirection << (MoveWithBezier ? 1 : 0);
			currentMovementTargetIndex += step;
			if (WaypointContainer != null)
			{
				currentMovementTargetIndex = Mathf.Clamp(currentMovementTargetIndex, 0, WaypointContainer.childCount - 1);
				if (currentMovementTargetIndex == WaypointContainer.childCount - 1 || currentMovementTargetIndex == 0)
				{
					if (MovementType == MovementTypeEnum.Loop)
					{
						currentMovementTargetIndex = 0;
					}
					else if (MovementType == MovementTypeEnum.PingPong)
					{
						currentDirection = -currentDirection;
					}
					movedSoFar = 0f;
				}
				else if (movementTimer < 0f)
				{
					if (MovementType == MovementTypeEnum.Loop)
					{
						currentMovementTargetIndex = 0;
					}
					else if (MovementType == MovementTypeEnum.PingPong)
					{
						currentDirection = -currentDirection;
					}
				}
			}
			float prevTimer = movementTimer;
			SetMovementTarget();
			if (prevTimer < 0f)
			{
				movementTimer = movementTimerTarget;
			}
		}
		lastPos = base.transform.position;
	}

	public void ChangeDirection()
	{
		if (MovementType == MovementTypeEnum.Loop)
		{
			currentMovementTargetIndex = 0;
		}
		else if (MovementType == MovementTypeEnum.PingPong)
		{
			currentDirection = -currentDirection;
		}
	}

	private Vector3 GetTargetPosition()
	{
		if (WaypointContainer == null)
			return base.transform.position;

		float t = (movementTimerTarget > 0f) ? (movementTimer / movementTimerTarget) : 0f;
		if (MoveWithBezier)
		{
			Vector3 p0 = WaypointContainer.GetChild(currentMovementTargetIndex).position;
			Vector3 p1 = WaypointContainer.GetChild(currentMovementTargetIndex + currentDirection).position;
			Vector3 p2 = WaypointContainer.GetChild(currentMovementTargetIndex + (currentDirection << 1)).position;
			return TweenFunctions.Bezier(p0, p1, p2, t);
		}

		Vector3 a = WaypointContainer.GetChild(currentMovementTargetIndex).position;
		Vector3 b = WaypointContainer.GetChild(currentMovementTargetIndex + currentDirection).position;
		return Vector3.Lerp(a, b, Mathf.Clamp01(t));
	}

	public int GetDirection()
	{
		return currentDirection;
	}

	public void SetDirection(float direction)
	{
		float s = Mathf.Sign(direction);
		currentDirection = (float.IsPositiveInfinity(s) ? 0 : (int)s);
	}

	private Quaternion GetTargetRotation()
	{
		if (WaypointContainer == null)
			return base.transform.rotation;

		float t = (movementTimerTarget > 0f) ? (movementTimer / movementTimerTarget) : 0f;
		Quaternion r0 = WaypointContainer.GetChild(currentMovementTargetIndex).rotation;
		int nextIdx = MoveWithBezier
			? (currentMovementTargetIndex + (currentDirection << 1))
			: (currentMovementTargetIndex + currentDirection);
		Quaternion r1 = WaypointContainer.GetChild(nextIdx).rotation;
		return Quaternion.Lerp(r0, r1, t);
	}

	private void SetMovementTarget()
	{
		movementTimer = 0f;
		if (WaypointContainer != null && WaypointContainer.childCount >= 2 && movementDist > 0f)
		{
			movementTimerTarget = (GetDistance(currentMovementTargetIndex) / movementDist) * TimePerRound;
		}
	}

	private float GetDistance(int index)
	{
		if (WaypointContainer == null)
			return 0f;

		if (MoveWithBezier)
		{
			Vector3 p0 = WaypointContainer.GetChild(index).position;
			Vector3 p1 = WaypointContainer.GetChild(index + currentDirection).position;
			Vector3 p2 = WaypointContainer.GetChild(index + (currentDirection << 1)).position;
			float dist = 0f;
			Vector3 prev = p0;
			for (int i = 0; i < 100; i++)
			{
				Vector3 cur = TweenFunctions.Bezier(p0, p1, p2, i / 100f);
				dist += Vector3.Distance(prev, cur);
				prev = cur;
			}
			return dist;
		}

		Vector3 a = WaypointContainer.GetChild(index).position;
		Vector3 b = WaypointContainer.GetChild(index + currentDirection).position;
		return Vector3.Distance(a, b);
	}

	private void OnDrawGizmos()
	{
		if (WaypointContainer == null)
			return;

		if (MoveWithBezier)
		{
			int i = 0;
			while (i < WaypointContainer.childCount - 1)
			{
				Vector3 p0 = WaypointContainer.GetChild(i).position;
				Vector3 p1 = WaypointContainer.GetChild(i | 1).position;
				i += 2;
				if (i >= WaypointContainer.childCount)
					break;
				Vector3 p2 = WaypointContainer.GetChild(i).position;
				Vector3 prev = p0;
				for (int j = 0; j < 10; j++)
				{
					Vector3 cur = TweenFunctions.Bezier(p0, p1, p2, j / 10f);
					Gizmos.DrawLine(prev, cur);
					prev = cur;
				}
				Gizmos.DrawLine(prev, p2);
			}
		}
		else
		{
			for (int i = 0; i < WaypointContainer.childCount - 1; i++)
			{
				Gizmos.DrawLine(WaypointContainer.GetChild(i).position, WaypointContainer.GetChild(i + 1).position);
			}
		}
	}
}
