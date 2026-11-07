using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringPlatform : MonoBehaviour
{
	public Vector3 forceVector;

	public float upForce;

	public int objectsBeforeBlowingUp;

	public float delayBeforeBlowingUp;

	public Animator platformAnimator;

	private List<Rigidbody> rigidbodies;

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}

	private IEnumerator DelaySpring()
	{
		return null;
	}

	public void Spring()
	{
	}
}
