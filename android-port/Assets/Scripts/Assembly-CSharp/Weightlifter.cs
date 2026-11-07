using UnityEngine;

public class Weightlifter : MonoBehaviour
{
	public float startDelay;

	public float explosionForce;

	public float explosionRadius;

	public Transform explosionForceOrigin;

	public Rigidbody weight;

	public Rigidbody[] props;

	public Rigidbody weightLifterRigid;

	private float timeAtStart;

	private bool didCollapse;

	private void Awake()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	public void Collapse()
	{
	}
}
