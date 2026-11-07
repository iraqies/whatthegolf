using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CollisionEvents : MonoBehaviour
{
	public UnityEvent OnCollisionEnterEvent = new UnityEvent();
	public UnityEvent OnCollisionExitEvent = new UnityEvent();
	public UnityEvent OnTriggerEnterEvent = new UnityEvent();
	public UnityEvent OnTriggerExitEvent = new UnityEvent();
	public Action<Rigidbody> OnCollisionEnterTrigger;
	public Action<Rigidbody> OnTriggerEnterTrigger;
	public Action<Rigidbody> OnTriggerExitTrigger;
	public List<Collider> Blacklist = new List<Collider>();
	public List<string> AcceptedTags = new List<string>();

	private bool Accepts(Collider col)
	{
		if (col == null) return false;
		if (Blacklist != null && Blacklist.Contains(col)) return false;
		if (AcceptedTags != null && AcceptedTags.Count > 0 && !AcceptedTags.Contains(col.tag)) return false;
		return true;
	}

	private void OnCollisionEnter(Collision col)
	{
		if (col != null && Accepts(col.collider))
		{
			OnCollisionEnterEvent?.Invoke();
			OnCollisionEnterTrigger?.Invoke(col.rigidbody);
		}
	}

	private void OnCollisionExit(Collision col)
	{
		if (col != null && Accepts(col.collider))
			OnCollisionExitEvent?.Invoke();
	}

	private void OnTriggerEnter(Collider col)
	{
		if (Accepts(col))
		{
			OnTriggerEnterEvent?.Invoke();
			OnTriggerEnterTrigger?.Invoke(col.attachedRigidbody);
		}
	}

	private void OnTriggerExit(Collider col)
	{
		if (Accepts(col))
		{
			OnTriggerExitEvent?.Invoke();
			OnTriggerExitTrigger?.Invoke(col.attachedRigidbody);
		}
	}
}
