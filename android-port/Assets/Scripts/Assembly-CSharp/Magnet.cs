using System.Collections.Generic;
using UnityEngine;

public class Magnet : MonoBehaviour
{
	public List<Transform> MagnetPoints;

	public BoxCollider EffectTrigger;

	public float MaxForce;

	public List<Rigidbody> affectedObjects;

	private void Start()
	{
		affectedObjects = new List<Rigidbody>();
	}

	private void FixedUpdate()
	{
		if (affectedObjects == null || MagnetPoints == null || EffectTrigger == null)
		{
			return;
		}
		float sizeZ = Mathf.Max(0.001f, EffectTrigger.size.z);
		foreach (Rigidbody rb in affectedObjects)
		{
			if (rb == null || rb.transform == transform)
			{
				continue;
			}
			Transform bestPoint = null;
			float bestRatio = float.MinValue;
			foreach (Transform pt in MagnetPoints)
			{
				if (pt == null)
				{
					continue;
				}
				float dist = (rb.transform.position - pt.position).magnitude;
				float ratio = Mathf.Max(0f, dist / sizeZ);
				if (ratio > bestRatio)
				{
					bestRatio = ratio;
					bestPoint = pt;
				}
			}
			if (bestRatio > float.MinValue && bestPoint != null)
			{
				Vector3 dir = (bestPoint.position - rb.position).normalized;
				rb.AddForce(dir * bestRatio * MaxForce, ForceMode.Force);
			}
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other != null && other.attachedRigidbody != null && !other.attachedRigidbody.isKinematic && affectedObjects != null)
		{
			if (!affectedObjects.Contains(other.attachedRigidbody))
			{
				affectedObjects.Add(other.attachedRigidbody);
			}
		}
	}

	private void OnTriggerExit(Collider other)
	{
		if (other != null && other.attachedRigidbody != null && affectedObjects != null)
		{
			affectedObjects.Remove(other.attachedRigidbody);
		}
	}
}
