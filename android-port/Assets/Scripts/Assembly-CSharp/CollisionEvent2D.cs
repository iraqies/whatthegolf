using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CollisionEvent2D : MonoBehaviour
{
	public UnityEvent OnEnter = new UnityEvent();
	public UnityEvent OnStay = new UnityEvent();
	public UnityEvent OnExit = new UnityEvent();
	public UnityEvent OnTriggerEnter = new UnityEvent();
	public UnityEvent OnTriggerStay = new UnityEvent();
	public UnityEvent OnTriggerExit = new UnityEvent();
	public List<string> Tags = new List<string>();
	public float minForce;
	public bool acceptAny = true;
	public float Delay;

	private bool Accepts(Collider2D col)
	{
		if (col == null) return false;
		if (acceptAny || Tags == null || Tags.Count == 0) return true;
		if (Tags.Contains(col.tag)) return true;
		if (col.CompareTag("Ball") && Tags.Contains("Player")) return true;
		if (col.CompareTag("Player") && Tags.Contains("Ball")) return true;
		return false;
	}

	private void OnCollisionEnter2D(Collision2D other)
	{
		if (other != null && Accepts(other.collider) && other.relativeVelocity.magnitude >= minForce)
		{
			if (Delay > 0f) Invoke(nameof(EnterInvoke), Delay);
			else EnterInvoke();
		}
	}

	private void OnCollisionStay2D(Collision2D other)
	{
		if (other != null && Accepts(other.collider))
			OnStay?.Invoke();
	}

	private void OnCollisionExit2D(Collision2D other)
	{
		if (other != null && Accepts(other.collider))
		{
			if (Delay > 0f) Invoke(nameof(ExitInvoke), Delay);
			else ExitInvoke();
		}
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (Accepts(other))
			OnTriggerEnter?.Invoke();
	}

	private void OnTriggerStay2D(Collider2D other)
	{
		if (Accepts(other))
			OnTriggerStay?.Invoke();
	}

	private void OnTriggerExit2D(Collider2D other)
	{
		if (Accepts(other))
			OnTriggerExit?.Invoke();
	}

	private void EnterInvoke() => OnEnter?.Invoke();
	private void ExitInvoke() => OnExit?.Invoke();
}
