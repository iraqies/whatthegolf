using System;
using System.Collections;
using UnityEngine;

public class DampVelocityOnTrigger : MonoBehaviour
{
	[Flags]
	public enum TriggerMode
	{
		None = 0,
		OnEnter = 1,
		OnExit = 2
	}

	[SerializeField]
	private LayerMask affectLayer;

	[SerializeField]
	private float dampDuration;

	[SerializeField]
	private float dampFactor;

	[SerializeField]
	private TriggerMode dampOnTrigger;

	public float DampFactor => 0f;

	private IEnumerator DampCoroutine(Rigidbody rigid)
	{
		return null;
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}

	private bool IsInLayer(GameObject go)
	{
		return false;
	}
}
