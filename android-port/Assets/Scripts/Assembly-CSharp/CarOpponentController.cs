using UnityEngine;

public class CarOpponentController : MonoBehaviour
{
	public float speed;

	public float rotationDamping = 40f;

	[SerializeField]
	private Transform wayPointParent;

	public int curTargetIndex;

	public float waypointDistanceThreshold;

	private Transform[] wayPointTransforms;

	private Vector3 targetPosition;

	private Vector2 startPos;

	private Quaternion startRot;

	[SerializeField]
	private Rigidbody2D rigid;

	private void Awake()
	{
		startPos = base.transform.position;
		startRot = base.transform.rotation;
		if (wayPointParent != null)
		{
			wayPointTransforms = new Transform[wayPointParent.childCount];
			for (int i = 0; i < wayPointParent.childCount; i++)
			{
				wayPointTransforms[i] = wayPointParent.GetChild(i);
			}
			if (curTargetIndex >= 0 && curTargetIndex < wayPointTransforms.Length && wayPointTransforms[curTargetIndex] != null)
			{
				targetPosition = wayPointTransforms[curTargetIndex].position;
			}
		}
	}

	private void OnEnable()
	{
		if (wayPointTransforms != null && wayPointTransforms.Length > 0 && wayPointTransforms[0] != null)
		{
			targetPosition = wayPointTransforms[0].position;
		}
		curTargetIndex = 0;
		base.transform.position = startPos;
		base.transform.rotation = startRot;
	}

	private void FixedUpdate()
	{
		if (wayPointTransforms == null || wayPointTransforms.Length == 0 || rigid == null)
		{
			return;
		}
		if (Vector3.Distance(base.transform.position, targetPosition) < waypointDistanceThreshold)
		{
			curTargetIndex = (curTargetIndex + 1) % wayPointTransforms.Length;
			if (wayPointTransforms[curTargetIndex] != null)
			{
				targetPosition = wayPointTransforms[curTargetIndex].position;
			}
		}
		Vector2 normalized = (targetPosition - base.transform.position).normalized;
		rigid.AddForce(normalized * speed * Time.fixedDeltaTime, ForceMode2D.Force);
		float angle = Mathf.Atan2(normalized.y, normalized.x) * 57.29578f - 90f;
		Quaternion b = Quaternion.AngleAxis(angle, Vector3.forward);
		Quaternion rotation = Quaternion.Slerp(base.transform.rotation, b, Time.fixedDeltaTime * rotationDamping);
		rigid.MoveRotation(rotation.eulerAngles.z);
	}
}
