using System;
using Audio.Rumble;
using UnityEngine;

public class Winable : MonoBehaviour
{
	public Action<Vector3> OnWon;

	public RumbleEventAsset rumbleOnWin;

	private void OnTriggerEnter2D(Collider2D collision)
	{
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
	}
}
