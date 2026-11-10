using System;
using Audio.Rumble;
using Core;
using UnityEngine;

public class Winable : MonoBehaviour
{
	public Action<Vector3> OnWon;

	public RumbleEventAsset rumbleOnWin;

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision == null || collision.transform == null)
			return;
		Component goal = collision.transform.GetComponent<Hole>();
		if (goal == null)
			goal = collision.transform.GetComponent<GolfGoal>();
		if (goal != null && OnWon != null)
		{
			if (rumbleOnWin != null)
				rumbleOnWin.Play(0, 1f);
			OnWon(goal.transform.position);
		}
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision == null || collision.transform == null)
			return;
		Component goal = collision.transform.GetComponent<Hole>();
		if (goal == null)
			goal = collision.transform.GetComponent<GolfGoal>();
		if (goal != null && OnWon != null)
		{
			if (rumbleOnWin != null)
				rumbleOnWin.Play(0, 1f);
			OnWon(goal.transform.position);
		}
	}
}
