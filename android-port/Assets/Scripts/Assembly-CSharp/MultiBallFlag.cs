using System;
using Core;
using UnityEngine;

public class MultiBallFlag : MonoBehaviour
{
	public Action<GameObject> OnAnyHit;

	public Action<GolfBallController> onControllerHit;

	private void OnCollisionEnter(Collision other)
	{
		if (other == null || other.transform == null || other.transform.gameObject == null || other.transform.gameObject.isStatic)
			return;
		OnAnyHit?.Invoke(other.gameObject);
		var ctrl = other.transform.GetComponentInParent<GolfBallController>();
		if (ctrl != null)
			onControllerHit?.Invoke(ctrl);
	}

	private void OnCollisionEnter2D(Collision2D other)
	{
		if (other == null || other.transform == null || other.transform.gameObject == null || other.transform.gameObject.isStatic)
			return;
		OnAnyHit?.Invoke(other.gameObject);
		var ctrl = other.transform.GetComponentInParent<GolfBallController>();
		if (ctrl != null)
			onControllerHit?.Invoke(ctrl);
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other == null || other.transform == null || other.transform.gameObject == null || other.transform.gameObject.isStatic)
			return;
		OnAnyHit?.Invoke(other.gameObject);
		var ctrl = other.GetComponentInParent<GolfBallController>();
		if (ctrl != null)
			onControllerHit?.Invoke(ctrl);
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other == null || other.gameObject == null || other.gameObject.isStatic)
			return;
		OnAnyHit?.Invoke(other.gameObject);
		var ctrl = other.GetComponentInParent<GolfBallController>();
		if (ctrl != null)
			onControllerHit?.Invoke(ctrl);
	}
}
