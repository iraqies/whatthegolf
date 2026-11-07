using System;
using UnityEngine;

public class AddForceLocalSpace : MonoBehaviour
{
	[Serializable]
	public class Target
	{
		public Rigidbody rigidbody;

		public Vector3 forceDirection;

		public float forceMagnitude;

		public Vector3 localPoint;
	}

	public Target[] targets;

	public void FixedUpdate()
	{
	}
}
