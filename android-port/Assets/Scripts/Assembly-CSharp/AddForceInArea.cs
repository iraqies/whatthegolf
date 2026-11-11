using UnityEngine;

public class AddForceInArea : MonoBehaviour
{
	[SerializeField]
	private bool executeOnStart;

	[SerializeField]
	private float radius = 5f;

	[SerializeField]
	private float force = 10f;

	[SerializeField]
	private Vector3 forceDirection = Vector3.up;

	[SerializeField]
	private ForceMode forceMode;

	[SerializeField]
	private int maxOthersAffected = 20;

	[SerializeField]
	private LayerMask acceptedLayers;

	private Collider[] colliders;

	private void Start()
	{
		colliders = new Collider[maxOthersAffected];
		if (executeOnStart)
		{
			Execute();
		}
	}

	public void Execute()
	{
		int num = Physics.OverlapSphereNonAlloc(base.transform.position, radius, colliders, acceptedLayers);
		for (int i = 0; i < num; i++)
		{
			Collider collider = colliders[i];
			if (collider.attachedRigidbody != null && !collider.attachedRigidbody.isKinematic)
			{
				collider.attachedRigidbody.AddForce(force * forceDirection, forceMode);
			}
		}
	}

	private void OnDrawGizmosSelected()
	{
		Gizmos.color = Color.green;
		Gizmos.DrawWireSphere(base.transform.position, radius);
	}
}
