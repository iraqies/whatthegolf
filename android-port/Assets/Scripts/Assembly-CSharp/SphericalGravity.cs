using UnityEngine;

public class SphericalGravity : MonoBehaviour
{
	[SerializeField]
	private Transform ball;

	[SerializeField]
	private Collider Sphere;

	[SerializeField]
	private float gravityForce;

	private RaycastHit hit;

	private void FixedUpdate()
	{
	}
}
