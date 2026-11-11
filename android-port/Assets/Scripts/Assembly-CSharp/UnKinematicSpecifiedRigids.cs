using System.Collections.Generic;
using UnityEngine;

public class UnKinematicSpecifiedRigids : MonoBehaviour
{
	public bool setAllKinematicAtStart;

	public float massCoefficient = 1f;

	public List<Rigidbody> rigidbodies;

	private void Start()
	{
		if (rigidbodies == null) return;
		for (int i = 0; i < rigidbodies.Count; i++)
		{
			if (rigidbodies[i] != null)
			{
				rigidbodies[i].mass *= massCoefficient;
				if (setAllKinematicAtStart)
					rigidbodies[i].isKinematic = true;
			}
		}
	}

	public void MakeUnkinematic()
	{
		if (rigidbodies == null) return;
		for (int i = 0; i < rigidbodies.Count; i++)
		{
			if (rigidbodies[i] != null)
				rigidbodies[i].isKinematic = false;
		}
	}
}
