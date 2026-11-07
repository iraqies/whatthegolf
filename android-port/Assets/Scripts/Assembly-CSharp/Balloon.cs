using System;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
	public float MinPopForceSqr;

	public List<string> PopTags;

	public List<AudioClip> PopSounds;

	public Vector3 ForceChangeRange;

	public Vector3 UpForceIfNoConstantForce;

	private ConstantForce upForce;

	private Vector3 startForce;

	private Rigidbody rigid;

	public bool isPopped;

	public Action<Balloon> OnPopped;

	private void Awake()
	{
	}

	private void OnCollisionEnter(Collision other)
	{
	}

	public void PopBalloon(float propbabiltity)
	{
	}

	private void FixedUpdate()
	{
	}
}
