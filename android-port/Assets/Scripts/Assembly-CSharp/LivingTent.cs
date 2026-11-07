using System.Collections.Generic;
using UnityEngine;

public class LivingTent : MonoBehaviour
{
	[SerializeField]
	private float _interval;

	[SerializeField]
	private float _force;

	[SerializeField]
	private Transform _target;

	[SerializeField]
	private Transform _spawnPosition;

	private bool _spawning;

	private int index;

	private Transform _controller;

	[SerializeField]
	private List<Rigidbody> _prefabs;

	[SerializeField]
	private Animator _animator;

	private double time;

	private static readonly int Spawn;

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}

	private void FixedUpdate()
	{
	}

	public void AnimationEventSpawn()
	{
	}
}
