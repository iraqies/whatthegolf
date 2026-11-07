using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CollisionEvents : MonoBehaviour
{
	public UnityEvent OnCollisionEnterEvent;

	public UnityEvent OnCollisionExitEvent;

	public UnityEvent OnTriggerEnterEvent;

	public UnityEvent OnTriggerExitEvent;

	public Action<Rigidbody> OnCollisionEnterTrigger;

	public Action<Rigidbody> OnTriggerEnterTrigger;

	public Action<Rigidbody> OnTriggerExitTrigger;

	public List<Collider> Blacklist;

	public List<string> AcceptedTags;

	private void OnCollisionEnter(Collision col)
	{
	}

	private void OnCollisionExit(Collision col)
	{
	}

	private void OnTriggerEnter(Collider col)
	{
	}

	private void OnTriggerExit(Collider col)
	{
	}
}
