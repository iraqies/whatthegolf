using UnityEngine;

public class ObstacleInHole : MonoBehaviour
{
	[SerializeField]
	private Rigidbody rigid;

	[SerializeField]
	private ConfigurableJoint joint;

	[SerializeField]
	private float force;

	private void OnTriggerEnter(Collider other)
	{
	}

	private void Start()
	{
	}
}
