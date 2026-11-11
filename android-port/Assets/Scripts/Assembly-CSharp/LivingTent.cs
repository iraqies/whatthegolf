using System.Collections.Generic;
using Core;
using UnityEngine;

public class LivingTent : MonoBehaviour
{
	[SerializeField]
	private float _interval = 1f;

	[SerializeField]
	private float _force = 1f;

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

	private static readonly int Spawn = Animator.StringToHash("Spawn");

	private void OnTriggerEnter(Collider other)
	{
		if (other.GetComponentInParent<GolfBallController>() != null)
		{
			_controller = other.GetComponentInParent<GolfBallController>().transform;
			_spawning = true;
			time = _interval + _interval;
		}
	}

	private void OnTriggerExit(Collider other)
	{
	}

	private void FixedUpdate()
	{
		if (_spawning)
		{
			time += Time.deltaTime;
			if (time > (double)_interval)
			{
				time = 0.0;
				_animator.SetTrigger(Spawn);
			}
		}
	}

	public void AnimationEventSpawn()
	{
		Rigidbody rigidbody = Object.Instantiate(_prefabs[index], _spawnPosition.position, _spawnPosition.rotation);
		Vector3 normalized = (_target.position - base.transform.position).normalized;
		rigidbody.AddForce(normalized * _force, ForceMode.VelocityChange);
		index++;
		index %= _prefabs.Count;
		_animator.ResetTrigger(Spawn);
	}
}
