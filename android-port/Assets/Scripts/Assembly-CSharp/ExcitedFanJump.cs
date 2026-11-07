using UnityEngine;

public class ExcitedFanJump : MonoBehaviour
{
	public GameObject mesh;

	public Vector3 boost;

	private Rigidbody[] rigidbodies;

	private bool jumped;

	private void Start()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}
}
