using System.Collections;
using Core;
using UnityEngine;

public class BikeEnterGoop : MonoBehaviour
{
	private Vector3 _direction;

	[SerializeField]
	private GolfBallController _controller;

	[SerializeField]
	private Rigidbody _rigidBody;

	private bool _isSliding;

	[SerializeField]
	private float _speedWhenSliding;

	[SerializeField]
	private float _speedMagniture;

	[SerializeField]
	private AudioSource _SlimeLoop;

	[SerializeField]
	private bool _useTriggerExitInstead;

	private bool _exitingSlime;

	[SerializeField]
	private double _extraSlideTime;

	[SerializeField]
	private float _force;

	[SerializeField]
	private bool isball;

	[SerializeField]
	private ParticleSystem _slideSystem;

	[SerializeField]
	private bool _noSpinWhenSliding;

	private void Start()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void StartSlime(Collider other)
	{
	}

	private void EndSlime(Collider other)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}

	private void OnDrawGizmos()
	{
	}

	private IEnumerator EndSlideCR()
	{
		return null;
	}

	private void UpdateVelocity(float damper = 1f)
	{
	}

	private void FixedUpdate()
	{
	}
}
