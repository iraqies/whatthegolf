using UnityEngine;

public class AddExplosionForce : MonoBehaviour
{
	public Transform ExplosionPoint;

	public float radius;

	public float force;

	public ForceMode mode;

	public bool executeOnEnable;

	public bool disableKinematic;

	public Rigidbody[] m_rigidbodies;

	private void OnEnable()
	{
	}

	public void Execute()
	{
	}
}
