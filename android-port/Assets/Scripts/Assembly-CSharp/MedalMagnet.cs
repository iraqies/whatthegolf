using System.Collections.Generic;
using UnityEngine;

public class MedalMagnet : MonoBehaviour
{
	public List<Transform> MagnetPoints;

	public SphereCollider EffectTrigger;

	public float maxForce = 1f;

	public float minForceMultiplier = 0.01f;

	public List<Rigidbody> affectedObjects = new List<Rigidbody>();

	private Rigidbody rbody;

	private void Start()
	{
		if (affectedObjects == null)
		{
			affectedObjects = new List<Rigidbody>();
		}
		rbody = GetComponent<Rigidbody>();
	}

	private void FixedUpdate()
	{
		if (affectedObjects == null || MagnetPoints == null || EffectTrigger == null)
		{
			return;
		}
		for (int i = 0; i < affectedObjects.Count; i++)
		{
			Rigidbody rigidbody = affectedObjects[i];
			if (rigidbody == null)
			{
				continue;
			}
			Transform transform = null;
			float num = float.PositiveInfinity;
			for (int j = 0; j < MagnetPoints.Count; j++)
			{
				Transform transform2 = MagnetPoints[j];
				if (transform2 != null)
				{
					float num2 = Vector3.Distance(rigidbody.transform.position, transform2.position);
					if (num2 < num)
					{
						num = num2;
						transform = transform2;
					}
				}
			}
			if (transform != null)
			{
				Vector3 vector = transform.position - rigidbody.transform.position;
				float t = Mathf.Clamp01(vector.magnitude / EffectTrigger.radius);
				float d = Mathf.Lerp(maxForce, maxForce * minForceMultiplier, t);
				rigidbody.AddForce(vector.normalized * d, ForceMode.Acceleration);
			}
		}
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (collision == null || collision.gameObject == null || !collision.gameObject.CompareTag("AffectedByMagnet"))
		{
			return;
		}
		Rigidbody component = collision.gameObject.GetComponent<Rigidbody>();
		if (component != null && affectedObjects != null && affectedObjects.Contains(component))
		{
			FixedJoint fixedJoint = collision.gameObject.AddComponent<FixedJoint>();
			if (fixedJoint != null)
			{
				fixedJoint.connectedBody = rbody;
			}
			affectedObjects.Remove(component);
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other == null || other.gameObject == null || !other.gameObject.CompareTag("AffectedByMagnet"))
		{
			return;
		}
		Rigidbody component = other.gameObject.GetComponent<Rigidbody>();
		if (component != null && affectedObjects != null && !affectedObjects.Contains(component) && other.gameObject.GetComponent<Joint>() == null)
		{
			affectedObjects.Add(component);
		}
	}

	private void OnTriggerExit(Collider other)
	{
		if (other == null || other.gameObject == null || !other.gameObject.CompareTag("AffectedByMagnet"))
		{
			return;
		}
		Rigidbody component = other.gameObject.GetComponent<Rigidbody>();
		if (component != null && affectedObjects != null && affectedObjects.Contains(component))
		{
			affectedObjects.Remove(component);
		}
	}
}
