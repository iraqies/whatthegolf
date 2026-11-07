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
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}

	private void CheckObject(Collider other)
	{
	}

	private void FixedUpdate()
	{
	}
}
