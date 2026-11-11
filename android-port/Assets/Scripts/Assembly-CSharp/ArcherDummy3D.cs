using System.Collections.Generic;
using UnityEngine;

public class ArcherDummy3D : MonoBehaviour
{
	private Rigidbody rb;

	private string arrowLayerName = "ShootArrow";

	[SerializeField]
	private int hitsToBreak = 5;

	[SerializeField]
	private float maxAngle = 45f;

	[SerializeField]
	private float rotationSpeed = 300f;

	private int hits;

	private Quaternion targetRotation;

	private bool broken;

	private List<GameObject> arrowsAlreadyCounted = new List<GameObject>(10);

	private void Start()
	{
		rb = GetComponent<Rigidbody>();
		targetRotation = rb.rotation;
	}

	private void OnCollisionEnter(Collision collision)
	{
		OnTriggerEnter(collision.collider);
	}

	private void OnTriggerEnter(Collider other)
	{
		if (broken || ((other.attachedRigidbody == null || other.attachedRigidbody.gameObject.layer != LayerMask.NameToLayer(arrowLayerName)) && (other.attachedRigidbody != null || other.gameObject.layer != LayerMask.NameToLayer(arrowLayerName))))
		{
			return;
		}
		GameObject item = ((other.attachedRigidbody == null) ? other.gameObject : other.attachedRigidbody.gameObject);
		if (!arrowsAlreadyCounted.Contains(item))
		{
			arrowsAlreadyCounted.Add(item);
			hits++;
			if (hits < hitsToBreak)
			{
				float x = Mathf.Lerp(0f, maxAngle, (float)hits / (float)hitsToBreak);
				targetRotation = Quaternion.Euler(x, rb.rotation.eulerAngles.y, rb.rotation.eulerAngles.z);
			}
			else
			{
				broken = true;
				rb.isKinematic = false;
			}
		}
	}

	private void FixedUpdate()
	{
		if (!broken)
		{
			rb.MoveRotation(Quaternion.Lerp(rb.rotation, targetRotation, Time.deltaTime * rotationSpeed));
		}
	}
}
