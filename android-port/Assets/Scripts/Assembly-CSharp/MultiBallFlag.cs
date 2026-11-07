using System;
using Core;
using UnityEngine;

public class MultiBallFlag : MonoBehaviour
{
	public Action<GameObject> OnAnyHit;

	public Action<GolfBallController> onControllerHit;

	private void OnCollisionEnter(Collision other)
	{
	}

	private void OnCollisionEnter2D(Collision2D other)
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
	}
}
