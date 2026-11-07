using UnityEngine;

public class ObjectDestroyTrigger : ObjectDestroyable
{
	public bool destroyAnyObject;

	public string onlyWithTag;

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
	}
}
