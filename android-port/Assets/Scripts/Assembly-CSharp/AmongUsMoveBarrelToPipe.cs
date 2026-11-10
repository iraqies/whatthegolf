using UnityEngine;

public class AmongUsMoveBarrelToPipe : MonoBehaviour
{
	private GameObject barrel;

	private Rigidbody barrelRigidbody;

	public Transform positionToMoveTo;

	public float speed;

	private void OnTriggerEnter(Collider other)
	{
		if (other != null && other.gameObject != null && other.gameObject.tag == "Enemy")
		{
			barrel = other.gameObject;
			barrelRigidbody = barrel.GetComponentInChildren<Rigidbody>();
			if (barrelRigidbody != null)
			{
				barrelRigidbody.isKinematic = true;
			}
		}
	}

	private void Update()
	{
		if (barrel != null && positionToMoveTo != null)
		{
			barrel.transform.position = Vector3.MoveTowards(barrel.transform.position, positionToMoveTo.position, speed * Time.deltaTime);
			if (Vector3.Distance(barrel.transform.position, positionToMoveTo.position) < 0.001f)
			{
				if (barrel.transform.parent != null)
				{
					Object.Destroy(barrel.transform.parent.gameObject);
				}
				else
				{
					Object.Destroy(barrel);
				}
				barrel = null;
			}
		}
	}
}
