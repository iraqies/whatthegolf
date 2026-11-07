using UnityEngine;

public class HorseShoeSpinOnCollision : MonoBehaviour
{
	public LayerMask HitLayers;

	private Rigidbody rigid;

	private bool hasHit;

	private Collider[] colliders;

	private void Awake()
	{
	}

	private void OnCollisionEnter(Collision other)
	{
	}
}
