using UnityEngine;

public class BlocMagnet : MonoBehaviour
{
	public Rigidbody magnetRigidbody;

	public Transform arrowPos;

	public int spaceBetweenBlocs;

	private void OnCollisionEnter(Collision collision)
	{
	}

	private void Assimilate(GameObject blocToAssimilate, Vector3 colliderBlocPos)
	{
	}

	private int RoundFloat(float value)
	{
		return 0;
	}
}
