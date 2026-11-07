using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleInOnePeggleBall : MonoBehaviour
{
	public Action OnReset;

	public Transform resetToPosition;

	private List<PeggleBob> bobs;

	private void Start()
	{
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
	}

	private void Reset()
	{
	}

	private IEnumerator UpdateBobs()
	{
		return null;
	}
}
