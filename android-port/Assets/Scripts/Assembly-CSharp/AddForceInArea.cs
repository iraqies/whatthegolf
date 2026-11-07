using UnityEngine;

public class AddForceInArea : MonoBehaviour
{
	[SerializeField]
	private bool executeOnStart;

	[SerializeField]
	private float radius;

	[SerializeField]
	private float force;

	[SerializeField]
	private Vector3 forceDirection;

	[SerializeField]
	private ForceMode forceMode;

	[SerializeField]
	private int maxOthersAffected;

	[SerializeField]
	private LayerMask acceptedLayers;

	private Collider[] colliders;

	private void Start()
	{
	}

	public void Execute()
	{
	}

	private void OnDrawGizmosSelected()
	{
	}
}
