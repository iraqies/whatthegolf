using System.Collections.Generic;
using UnityEngine;

public class TractorBeam : MonoBehaviour
{
	public LayerMask AffectedObjectLayers;

	public List<string> AffectedObjectTags;

	public float Force;

	public ForceMode ForceMode;

	public Transform TractionPoint;

	private List<Rigidbody> objectsInBeam;

	private void Awake()
	{
		objectsInBeam = new List<Rigidbody>();
	}

	private void OnTriggerEnter(Collider other)
	{
		CheckObject(other);
	}

	private void OnTriggerExit(Collider other)
	{
		CheckObject(other);
	}

	private void CheckObject(Collider other)
	{
		if (other == null || other.gameObject == null)
		{
			return;
		}
		int num = AffectedObjectLayers;
		bool flag = num == (num | (1 << other.gameObject.layer));
		if (!flag && AffectedObjectTags != null)
		{
			flag = AffectedObjectTags.Contains(other.tag);
		}
		if (!flag || other.attachedRigidbody == null || objectsInBeam == null)
		{
			return;
		}
		Rigidbody attachedRigidbody = other.attachedRigidbody;
		if (objectsInBeam.Contains(attachedRigidbody))
		{
			objectsInBeam.Remove(attachedRigidbody);
		}
		else
		{
			objectsInBeam.Add(attachedRigidbody);
		}
	}

	private void FixedUpdate()
	{
		if (objectsInBeam == null || TractionPoint == null)
		{
			return;
		}
		foreach (Rigidbody item in objectsInBeam)
		{
			if (item != null)
			{
				Vector3 normalized = (TractionPoint.position - item.position).normalized;
				item.AddForce(normalized * Force, ForceMode);
			}
		}
	}
}
