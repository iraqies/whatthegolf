using System;
using UnityEngine;

public class KatamariCactus2D : MonoBehaviour
{
	[SerializeField]
	private LayerMask collectorLayerMask;

	[SerializeField]
	private Transform model;

	private Rigidbody2D rigidbody2D;

	public static Action<KatamariCactus2D, Rigidbody2D> OnAttach;

	private void Awake()
	{
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
	}
}
