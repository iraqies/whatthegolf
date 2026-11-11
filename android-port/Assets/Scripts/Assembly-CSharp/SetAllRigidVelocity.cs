using System.Collections.Generic;
using UnityEngine;

public class SetAllRigidVelocity : MonoBehaviour
{
	[SerializeField]
	private List<Rigidbody> rigids;

	[SerializeField]
	private Vector3 velocity;

	[SerializeField]
	private Vector3 angularVelocity;

	private void Start()
	{
		Transform[] children = transform.GetComponentsInChildren<Transform>(true);
		if (children != null && rigids != null)
		{
			for (int i = 0; i < children.Length; i++)
			{
				if (children[i] != null)
				{
					Rigidbody rb = children[i].GetComponent<Rigidbody>();
					if (rb != null)
					{
						rigids.Add(rb);
					}
				}
			}
		}
	}

	public void SetAll()
	{
		SetAllVelocity();
		SetAllAngularVelocity();
	}

	public void SetAllVelocity()
	{
		if (rigids != null)
		{
			rigids.ForEach(r =>
			{
				if (r != null)
				{
					r.velocity = velocity;
				}
			});
		}
	}

	public void SetAllAngularVelocity()
	{
		if (rigids != null)
		{
			rigids.ForEach(r =>
			{
				if (r != null)
				{
					r.angularVelocity = angularVelocity;
				}
			});
		}
	}
}
