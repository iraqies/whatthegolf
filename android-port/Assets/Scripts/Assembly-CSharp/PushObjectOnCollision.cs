using UnityEngine;

public class PushObjectOnCollision : MonoBehaviour
{
	public Vector3 PushDirection;

	public float RandomSpread;

	public float PushStrength;

	public float AngularForce;

	public LayerMask AffectedLayers;

	private Rigidbody rigidbody;

	private Collider[] cols;

	private void Start()
	{
	}

	private void OnCollisionEnter(Collision other)
	{
	}

	private void ToggleIgnoreCollision(Collider c, bool ignore)
	{
	}
}
