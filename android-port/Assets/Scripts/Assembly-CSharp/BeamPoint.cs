using System;
using UnityEngine;

public class BeamPoint : MonoBehaviour
{
	public Action<BeamableObject> OnEnterBeamPoint;

	private void OnTriggerEnter(Collider other)
	{
	}
}
