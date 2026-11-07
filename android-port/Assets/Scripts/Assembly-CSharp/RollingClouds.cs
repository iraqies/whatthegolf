using System.Collections.Generic;
using UnityEngine;

public class RollingClouds : MonoBehaviour
{
	[SerializeField]
	private float _speed;

	[SerializeField]
	private float _width;

	[SerializeField]
	private Transform _container;

	private List<Transform> _clouds;

	private Vector3 _start => default;

	private Vector3 _end => default;

	private void Start()
	{
	}

	private void FixedUpdate()
	{
	}

	private void OnDrawGizmos()
	{
	}
}
