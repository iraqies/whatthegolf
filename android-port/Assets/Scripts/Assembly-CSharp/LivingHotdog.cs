using Core;
using UnityEngine;

public class LivingHotdog : MonoBehaviour
{
	[SerializeField]
	private GameObject _living;

	private bool alive;

	[SerializeField]
	private bool _activateOnStart = true;

	[SerializeField]
	private Rigidbody _livingHotDogRigid;

	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.GetComponentInParent<GolfBallController>() != null)
		{
			_living.SetActive(value: true);
			_living.transform.SetParent(base.transform.parent);
			Object.Destroy(GetComponent<Rigidbody>());
			GetComponent<MeshRenderer>().enabled = false;
			GetComponent<Collider>().enabled = false;
			alive = true;
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Player"))
		{
			_livingHotDogRigid.isKinematic = false;
		}
	}

	private void Start()
	{
		if (_activateOnStart)
		{
			_living.SetActive(value: true);
			_living.transform.SetParent(base.transform.parent);
			Object.Destroy(GetComponent<Rigidbody>());
			GetComponent<MeshRenderer>().enabled = false;
			GetComponent<Collider>().enabled = false;
			alive = true;
		}
	}

	private void LateUpdate()
	{
	}
}
