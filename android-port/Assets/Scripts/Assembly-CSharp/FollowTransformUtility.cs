using UnityEngine;

public class FollowTransformUtility : MonoBehaviour
{
	[SerializeField]
	public Transform Target;

	[SerializeField]
	private bool ignoreY;

	[SerializeField]
	private bool moveRigidWithVelocity = true;

	[SerializeField]
	private float FollowSpeed = 10f;

	[SerializeField]
	private float FollowDistance;

	private Rigidbody rigid;

	public void SetFollowDistance(int d)
	{
		FollowDistance = d;
	}

	public void SetFollowTransform(Transform t)
	{
		Target = t;
	}

	private void Awake()
	{
		rigid = GetComponent<Rigidbody>();
	}

	private void FixedUpdate()
	{
		if (Target == null || rigid == null)
		{
			return;
		}
		Vector3 targetPos = GetPosition();
		if (moveRigidWithVelocity)
		{
			Vector3 diff = targetPos - rigid.position;
			if (ignoreY)
			{
				diff.y = 0f;
			}
			Vector3 desiredVel = diff / Mathf.Max(0.001f, Time.fixedDeltaTime);
			if (ignoreY)
			{
				desiredVel.y = rigid.velocity.y;
			}
			rigid.velocity = Vector3.Lerp(rigid.velocity, desiredVel, Mathf.Clamp01(Time.deltaTime * FollowSpeed));
		}
		else
		{
			if (ignoreY)
			{
				targetPos.y = rigid.position.y;
			}
			rigid.MovePosition(targetPos);
		}
	}

	private Vector3 GetPosition()
	{
		if (Target == null)
		{
			return transform.position;
		}
		Vector3 curPos = rigid != null ? rigid.position : transform.position;
		Vector3 dir = (curPos - Target.position).normalized;
		Vector3 desired = Target.position + dir * FollowDistance;
		return Vector3.MoveTowards(transform.position, desired, FollowSpeed * Time.deltaTime);
	}
}
