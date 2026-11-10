using UnityEngine;

public class ObjectDestroyTrigger : ObjectDestroyable
{
	public bool destroyAnyObject;

	public string onlyWithTag = "";

	private void OnTriggerEnter(Collider other)
	{
		if (other == null || other.transform.gameObject.isStatic)
		{
			return;
		}
		if (destroyableObjects != null && destroyableObjects.Contains(other.gameObject))
		{
			onDestroyObject?.Invoke(other.gameObject);
			other.gameObject.SetActive(false);
		}
		else if (destroyAnyObject && (onlyWithTag == "" || other.gameObject.CompareTag(onlyWithTag)))
		{
			Rigidbody rb = other.GetComponentInParent<Rigidbody>();
			GameObject target = ((rb != null) ? rb.gameObject : other.gameObject);
			onDestroyObject?.Invoke(target);
			target.SetActive(false);
		}
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other == null || other.transform.gameObject.isStatic)
		{
			return;
		}
		if (destroyableObjects != null && destroyableObjects.Contains(other.gameObject))
		{
			onDestroyObject?.Invoke(other.gameObject);
			other.gameObject.SetActive(false);
		}
		else if (destroyAnyObject && (onlyWithTag == "" || other.gameObject.CompareTag(onlyWithTag)))
		{
			Rigidbody2D rb = other.GetComponentInParent<Rigidbody2D>();
			GameObject target = ((rb != null) ? rb.gameObject : other.gameObject);
			onDestroyObject?.Invoke(target);
			target.SetActive(false);
		}
	}
}
