using UnityEngine;

public class CatIn2D : MonoBehaviour
{
	[SerializeField]
	private ToggleGenericRagdoll toggleRagdoll;

	[SerializeField]
	private float correctDirForcePush;

	private bool didHit;

	private Rigidbody rigid;

	private void Awake()
	{
	}

	private void OnCollisionEnter(Collision collision)
	{
	}
}
