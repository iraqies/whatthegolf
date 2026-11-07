using System;
using System.Collections.Generic;
using UnityEngine;

public class ShootFromPosition2D : MonoBehaviour
{
	[Serializable]
	public struct ShootEvent
	{
		public float shootTime;

		public float shootForce;
	}

	[SerializeField]
	private Rigidbody2D prefab;

	[SerializeField]
	private Collider2D ignoreCollisionWith;

	[SerializeField]
	private List<ShootEvent> ShootEvents;

	private List<Rigidbody2D> pool;

	private float timeOfAwake;

	private void Awake()
	{
	}

	private void FixedUpdate()
	{
	}
}
