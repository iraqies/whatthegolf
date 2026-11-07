using UnityEngine;

public class KinematicOnCollision : MonoBehaviour
{
	public LayerMask CollisionMask;

	public float Delay;

	public bool KinematicState;

	public float ForceOnUnkinematic;

	private Rigidbody rigidbody;

	private float timer;

	private Collider col;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void OnCollisionEnter(Collision other)
	{
	}
}
