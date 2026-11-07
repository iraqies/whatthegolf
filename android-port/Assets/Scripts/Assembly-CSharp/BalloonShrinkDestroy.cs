using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonShrinkDestroy : MonoBehaviour
{
	public float MinPopForceSqr;

	public List<string> PopTags;

	public List<AudioClip> PopSounds;

	public Vector3 ForceChangeRange;

	public Vector3 UpForceIfNoConstantForce;

	private ConstantForce upForce;

	private Vector3 startForce;

	private Rigidbody rigid;

	public float probabilityToPop;

	private bool canPop;

	private TreeCounter treeCountScript;

	public AnimationCurve ShrinkCurve;

	public float shrinkDuration;

	public bool isPopped;

	public Action<BalloonShrinkDestroy> OnPopped;

	private void Awake()
	{
	}

	private void OnCollisionEnter(Collision other)
	{
	}

	public void PopBalloon(float probability)
	{
	}

	private void FixedUpdate()
	{
	}

	private void Update()
	{
	}

	public void StartShrink()
	{
	}

	public IEnumerator Shrink()
	{
		return null;
	}
}
