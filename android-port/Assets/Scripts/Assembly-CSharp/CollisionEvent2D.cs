using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CollisionEvent2D : MonoBehaviour
{
	public UnityEvent OnEnter;

	public UnityEvent OnStay;

	public UnityEvent OnExit;

	public UnityEvent OnTriggerEnter;

	public UnityEvent OnTriggerStay;

	public UnityEvent OnTriggerExit;

	public List<string> Tags;

	public float minForce;

	public bool acceptAny;

	public float Delay;

	private void OnCollisionEnter2D(Collision2D other)
	{
	}

	private void OnCollisionStay2D(Collision2D other)
	{
	}

	private void OnCollisionExit2D(Collision2D other)
	{
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
	}

	private void OnTriggerStay2D(Collider2D other)
	{
	}

	private void OnTriggerExit2D(Collider2D other)
	{
	}

	private void EnterInvoke()
	{
	}

	private void ExitInvoke()
	{
	}
}
