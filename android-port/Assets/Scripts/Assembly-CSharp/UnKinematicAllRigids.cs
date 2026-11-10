using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class UnKinematicAllRigids : MonoBehaviour
{
	public bool setAllKinematicAtStart;

	public float massCoefficient;

	private List<Rigidbody> rigidbodies;

	private void Start()
	{
		rigidbodies = base.gameObject.GetComponentsInChildren<Rigidbody>().ToList();
		if (rigidbodies == null)
		{
			return;
		}
		foreach (Rigidbody rigidbody in rigidbodies)
		{
			if (rigidbody != null)
			{
				rigidbody.mass *= massCoefficient;
				if (setAllKinematicAtStart)
				{
					rigidbody.isKinematic = true;
				}
			}
		}
	}

	public void MakeUnkinematic()
	{
		if (rigidbodies == null)
		{
			return;
		}
		foreach (Rigidbody rigidbody in rigidbodies)
		{
			if (rigidbody != null)
			{
				rigidbody.isKinematic = false;
			}
		}
	}

	public UnKinematicAllRigids()
	{
		massCoefficient = 1f;
	}
}
