using UnityEngine;

public class StopRotationWhenLanding : MonoBehaviour
{
	[SerializeField]
	private Rigidbody r;

	[SerializeField]
	private float adjustForce;

	[SerializeField]
	private float threshold;

	private void FixedUpdate()
	{
	}
}
