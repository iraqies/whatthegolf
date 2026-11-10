using System;
using Core;
using UnityEngine;

public class BadBallChecker : MonoBehaviour
{
	public GolfBallController hitBall;

	public Action<GolfBallController> OnHitFlag;

	private void OnCollisionEnter(Collision collision)
	{
		if (collision == null || collision.gameObject == null) return;
		var ctrl = collision.gameObject.GetComponent<GolfBallController>();
		if (ctrl != null)
			OnHitFlag?.Invoke(ctrl);
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision == null || collision.gameObject == null) return;
		var ctrl = collision.gameObject.GetComponent<GolfBallController>();
		if (ctrl != null)
			OnHitFlag?.Invoke(ctrl);
	}
}
