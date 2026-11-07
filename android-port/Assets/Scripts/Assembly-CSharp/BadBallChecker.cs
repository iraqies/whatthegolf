using System;
using Core;
using UnityEngine;

public class BadBallChecker : MonoBehaviour
{
	public GolfBallController hitBall;

	public Action<GolfBallController> OnHitFlag;

	private void OnCollisionEnter(Collision collision)
	{
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
	}
}
