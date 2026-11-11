using UnityEngine;

public class KinematicOnCollision : MonoBehaviour
{
	public LayerMask CollisionMask;

	public float Delay;

	public bool KinematicState = true;

	public float ForceOnUnkinematic;

	private Rigidbody rigidbody;

	private float timer;

	private Collider col;

	private void Awake()
	{
		rigidbody = GetComponent<Rigidbody>();
		col = GetComponent<Collider>();
		if (Delay > 0f && col != null)
		{
			col.isTrigger = true;
		}
	}

	private void Update()
	{
		if (timer > 0f && rigidbody != null && !rigidbody.isKinematic)
		{
			timer -= Time.deltaTime;
			if (timer <= 0f)
			{
				if (col != null)
					col.isTrigger = false;
				rigidbody.isKinematic = KinematicState;
			}
		}
	}

	private void OnCollisionEnter(Collision other)
	{
		if (other == null || other.gameObject == null || rigidbody == null) return;
		int mask = CollisionMask;
		if (mask == (mask | (1 << other.gameObject.layer)))
		{
			if (Delay > 0f)
			{
				timer = Delay;
			}
			else
			{
				rigidbody.isKinematic = KinematicState;
				if (!rigidbody.isKinematic && ForceOnUnkinematic > 0f)
				{
					rigidbody.AddForce(-other.impulse * ForceOnUnkinematic, ForceMode.Impulse);
				}
			}
		}
	}
}
