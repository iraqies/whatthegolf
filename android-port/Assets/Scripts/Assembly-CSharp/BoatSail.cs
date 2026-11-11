using UnityEngine;

public class BoatSail : MonoBehaviour
{
	[SerializeField]
	private Rigidbody rigid;

	[SerializeField]
	private Transform frontVector;

	[SerializeField]
	private float turnTowardsMovementSpeed = 5f;

	[SerializeField]
	private float stopDistance = 1f;

	private float moveForce = 10f;

	private Vector3 target;

	private bool moving;

	private void Awake()
	{
		if (rigid == null)
		{
			rigid = GetComponent<Rigidbody>();
		}
	}

	private void FixedUpdate()
	{
		if (!moving || rigid == null)
		{
			return;
		}
		Vector3 curPos = rigid.position;
		curPos.y = 0f;
		Vector3 dstPos = target;
		dstPos.y = 0f;
		if (Vector3.Distance(curPos, dstPos) < stopDistance)
		{
			moving = false;
			return;
		}
		Vector3 dir = (target - rigid.position).normalized;
		dir.y = 0f;
		rigid.AddForce(dir * moveForce, ForceMode.Acceleration);
		if (rigid.velocity.sqrMagnitude > 0.01f && frontVector != null)
		{
			Vector3 velDir = rigid.velocity.normalized;
			velDir.y = 0f;
			Vector3 curForward = frontVector.forward;
			curForward.y = 0f;
			if (velDir.sqrMagnitude > 0.001f && curForward.sqrMagnitude > 0.001f)
			{
				Quaternion deltaRot = Quaternion.FromToRotation(curForward.normalized, velDir.normalized);
				Quaternion targetRot = deltaRot * rigid.rotation;
				rigid.MoveRotation(Quaternion.Lerp(rigid.rotation, targetRot, turnTowardsMovementSpeed * Time.fixedDeltaTime));
			}
		}
	}

	public void SailToTarget(Vector3 target, float force)
	{
		this.target = target;
		moveForce = force;
		moving = true;
	}
}
