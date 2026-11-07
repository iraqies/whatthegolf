using System.Collections.Generic;
using UnityEngine;

public class MoveCollidersOnMovableSurface : MonoBehaviour
{
	private Transform _dummyTransform;

	private Dictionary<Collider, Transform> _colliderParentDict;

	private void Awake()
	{
	}

	private void FixedUpdate()
	{
	}

	private void OnCollisionEnter(Collision collision)
	{
	}

	private void OnCollisionExit(Collision collision)
	{
	}
}
