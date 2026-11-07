using UnityEngine;

public class UnparentOnStart : MonoBehaviour
{
	private Quaternion originalRotation;

	private Vector3 originalPosition;

	private Transform originalParent;

	private Rigidbody thisRigidbody;

	[SerializeField]
	private bool DontUnparentOnStart;

	private void Start()
	{
	}

	public void Unparent()
	{
	}

	public void Reparent(bool alsoReturnToPosition)
	{
	}

	public void ResetPosition()
	{
	}

	public void DestroyObject()
	{
	}
}
