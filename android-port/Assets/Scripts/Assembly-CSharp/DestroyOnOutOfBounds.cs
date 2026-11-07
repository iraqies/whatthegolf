using System;
using System.Collections;
using UnityEngine;

public class DestroyOnOutOfBounds : MonoBehaviour
{
	[SerializeField]
	private GameObject ToDestroy;

	public float DestroyAfter;

	public Action OnBeforeDestroy;

	private bool MarkedForDestroy;

	public void SetObjectToDestroy(GameObject g)
	{
	}

	private void OnCollisionEnter(Collision collision)
	{
	}

	private void DestroyNowOrLater()
	{
	}

	private IEnumerator DestroyCR()
	{
		return null;
	}

	private void DestroyGO()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}
}
