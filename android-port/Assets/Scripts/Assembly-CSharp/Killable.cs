using System;
using UnityEngine;

public class Killable : MonoBehaviour
{
	public Action OnKilled;

	private void OnCollisionEnter2D(Collision2D collision)
	{
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
	}
}
