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
		ToDestroy = g;
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (collision == null || collision.gameObject == null) return;
		if (collision.gameObject.CompareTag("OutOfBounds") || collision.gameObject.CompareTag("OutOfBoundsReset") || collision.gameObject.CompareTag("OutOfBoundsReload"))
		{
			DestroyNowOrLater();
		}
	}

	private void DestroyNowOrLater()
	{
		if (MarkedForDestroy) return;
		OnBeforeDestroy?.Invoke();
		MarkedForDestroy = true;
		if (DestroyAfter > 0f && gameObject.activeInHierarchy)
			StartCoroutine(DestroyCR());
		else
			DestroyGO();
	}

	private IEnumerator DestroyCR()
	{
		yield return new WaitForSeconds(DestroyAfter);
		DestroyGO();
	}

	private void DestroyGO()
	{
		GameObject target = ToDestroy == null ? gameObject : ToDestroy;
		if (target != null)
			Destroy(target);
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other == null || other.gameObject == null) return;
		if (other.gameObject.CompareTag("OutOfBounds") || other.gameObject.CompareTag("OutOfBoundsReset") || other.gameObject.CompareTag("OutOfBoundsReload"))
		{
			DestroyNowOrLater();
		}
	}
}
