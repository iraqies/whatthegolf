using UnityEngine;

public class BlocMagnet : MonoBehaviour
{
	public Rigidbody magnetRigidbody;

	public Transform arrowPos;

	public int spaceBetweenBlocs = 4;

	private void OnCollisionEnter(Collision collision)
	{
		if (collision.transform.CompareTag("Player"))
		{
			Assimilate(collision.gameObject, collision.contacts[0].thisCollider.transform.localPosition);
		}
	}

	private void Assimilate(GameObject blocToAssimilate, Vector3 colliderBlocPos)
	{
		Object.Destroy(blocToAssimilate.GetComponentInChildren<Rigidbody>());
		blocToAssimilate.transform.parent = base.transform;
		Vector3 vector = new Vector3(RoundFloat(blocToAssimilate.transform.localPosition.x), RoundFloat(blocToAssimilate.transform.localPosition.y), RoundFloat(blocToAssimilate.transform.localPosition.z));
		if (vector == colliderBlocPos)
		{
			blocToAssimilate.transform.localPosition += (blocToAssimilate.transform.localPosition - colliderBlocPos).normalized * spaceBetweenBlocs;
			vector = new Vector3(RoundFloat(blocToAssimilate.transform.localPosition.x), RoundFloat(blocToAssimilate.transform.localPosition.y), RoundFloat(blocToAssimilate.transform.localPosition.z));
		}
		blocToAssimilate.transform.localRotation = Quaternion.identity;
		blocToAssimilate.transform.localPosition = vector;
		magnetRigidbody.ResetCenterOfMass();
		arrowPos.localPosition = magnetRigidbody.centerOfMass;
	}

	private int RoundFloat(float value)
	{
		return (int)(value / (float)spaceBetweenBlocs) * spaceBetweenBlocs;
	}
}
