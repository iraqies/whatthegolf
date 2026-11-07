using System.Collections.Generic;
using UnityEngine;

public class HotdogHole : MonoBehaviour
{
	private const string IgnoreGround = "IgnoreGround";

	public string Default;

	public float upForceForRagdoll;

	public bool ShouldCheckForRagdoll;

	[SerializeField]
	private string TagToCheckForRoot;

	[SerializeField]
	private string TagToCheckForRagdoll;

	[SerializeField]
	private LayerMask BlacklistLayers;

	private List<Transform> ToAddForceTo;

	[SerializeField]
	private bool ObjectsCanEscape;

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}

	private void FixedUpdate()
	{
	}

	private void MoveRagdoll()
	{
	}

	private Vector3 getCenterOfMass(Rigidbody[] assembly)
	{
		return default;
	}

	public static void SetLayerRecursively(GameObject go, int layerNumber)
	{
	}
}
