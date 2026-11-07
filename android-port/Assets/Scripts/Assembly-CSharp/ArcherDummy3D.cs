using System.Collections.Generic;
using UnityEngine;

public class ArcherDummy3D : MonoBehaviour
{
	private Rigidbody rb;

	private string arrowLayerName;

	[SerializeField]
	private int hitsToBreak;

	[SerializeField]
	private float maxAngle;

	[SerializeField]
	private float rotationSpeed;

	private int hits;

	private Quaternion targetRotation;

	private bool broken;

	private List<GameObject> arrowsAlreadyCounted;

	private void Start()
	{
	}

	private void OnCollisionEnter(Collision collision)
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void FixedUpdate()
	{
	}
}
