using System.Collections.Generic;
using UnityEngine;

public class BallConveyorBelt : MonoBehaviour
{
	public Transform BeltStart;

	public Transform BeltEnd;

	public GameObject BeltTransporter;

	public float Spacing = 5f;

	public float MoveSpeed = 1f;

	private List<Rigidbody> transporters;

	private void Start()
	{
		if (BeltStart == null || BeltEnd == null)
			return;
		int count = Mathf.FloorToInt((BeltStart.position - BeltEnd.position).magnitude / Mathf.Max(0.01f, Spacing));
		transporters = new List<Rigidbody>();
		for (int i = 0; i < count; i++)
		{
			if (BeltTransporter == null)
				break;
			GameObject obj = Instantiate(BeltTransporter);
			Vector3 dir = (BeltEnd.position - BeltStart.position).normalized;
			obj.transform.position = BeltStart.position + dir * (i * Spacing);
			Rigidbody rb = obj.GetComponent<Rigidbody>();
			if (rb != null)
				transporters.Add(rb);
		}
	}

	private void FixedUpdate()
	{
		if (transporters == null || BeltStart == null || BeltEnd == null)
			return;
		foreach (Rigidbody rb in transporters)
		{
			if (rb == null)
				continue;
			Vector3 dir = (BeltStart.position - BeltEnd.position).normalized;
			rb.MovePosition(rb.position + dir * MoveSpeed * Time.deltaTime);
			if (Vector3.Distance(rb.position, BeltEnd.position) < 1f)
			{
				rb.MovePosition(BeltStart.position);
			}
		}
	}
}
