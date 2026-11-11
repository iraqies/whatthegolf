using UnityEngine;

public class JoustingElephant : MonoBehaviour
{
	public Rigidbody elephantRigidbody;

	public Transform rider;

	public Rigidbody lance;

	public LayerMask opponentLayer;

	public float opponentDetectionRadius = 10f;

	private Rigidbody[] ragdoll;

	private Collider[] nearbyOpponents;

	private void Start()
	{
		ragdoll = rider.GetComponentsInChildren<Rigidbody>();
		for (int i = 0; i < ragdoll.Length; i++)
		{
			ragdoll[i].isKinematic = true;
		}
		nearbyOpponents = new Collider[5];
	}

	private void FixedUpdate()
	{
		int num = Physics.OverlapSphereNonAlloc(base.transform.position, opponentDetectionRadius, nearbyOpponents, opponentLayer, QueryTriggerInteraction.Ignore);
		if (num >= 1)
		{
			int num2 = 0;
			float num3 = float.MaxValue;
			for (int i = 0; i < num; i++)
			{
				float num4 = Vector3.Distance(nearbyOpponents[i].attachedRigidbody.position, base.transform.position);
				if (num4 < num3)
				{
					num2 = i;
					num3 = num4;
				}
			}
			Vector3 position = nearbyOpponents[num2].attachedRigidbody.position;
			Vector3 position2 = lance.position;
			lance.MoveRotation(Quaternion.LookRotation(new Vector3(position.x - position2.x, 0f, position.z - position2.z), Vector3.up));
		}
	}

	public void EnableRagdoll()
	{
		rider.GetComponent<Animator>().enabled = false;
		rider.parent = null;
		for (int i = 0; i < ragdoll.Length; i++)
		{
			ragdoll[i].isKinematic = false;
		}
	}

	private void OnDrawGizmos()
	{
		Gizmos.color = Color.green;
		Gizmos.DrawWireSphere(base.transform.position, opponentDetectionRadius);
	}
}
