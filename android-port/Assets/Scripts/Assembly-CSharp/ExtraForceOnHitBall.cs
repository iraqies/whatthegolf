using UnityEngine;

public class ExtraForceOnHitBall : MonoBehaviour
{
	[SerializeField]
	private float force;

	private Rigidbody rigid;

	private void Start()
	{
	}

	private void OnCollisionEnter(Collision col)
	{
	}
}
