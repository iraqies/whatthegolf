using UnityEngine;

public class ParentOnCollision : MonoBehaviour
{
	public LayerMask CollisionMask;

	private bool hasCollided;

	private void OnCollisionEnter(Collision other)
	{
	}
}
