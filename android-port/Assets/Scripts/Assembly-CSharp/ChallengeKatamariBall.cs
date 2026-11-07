using System;
using System.Collections.Generic;
using Core;
using UnityEngine;

public class ChallengeKatamariBall : MonoBehaviour
{
	public float maxSpin;

	private List<GameObject> _attachedObjects;

	private Rigidbody _rigidbody;

	private float _initialMass;

	private GolfBallShooterExperimental _golfBallShooter;

	public Action<int, float> onBallGrow;

	private Bounds _bounds;

	public string excludeTag;

	private void Start()
	{
	}

	private void OnCollisionEnter(Collision other)
	{
	}

	public Bounds CalculateBounds()
	{
		return default;
	}
}
