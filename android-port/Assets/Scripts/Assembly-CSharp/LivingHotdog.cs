using UnityEngine;

public class LivingHotdog : MonoBehaviour
{
	[SerializeField]
	private GameObject _living;

	private bool alive;

	[SerializeField]
	private bool _activateOnStart;

	[SerializeField]
	private Rigidbody _livingHotDogRigid;

	private void OnCollisionEnter(Collision collision)
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void Start()
	{
	}

	private void LateUpdate()
	{
	}
}
