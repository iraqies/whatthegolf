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
		if (other == null)
		{
			return;
		}
		Rigidbody rigidbody = ((other.GetComponent<Rigidbody>() != null) ? other.GetComponent<Rigidbody>() : other.GetComponentInParent<Rigidbody>());
		if (!rigidbodies.Contains(rigidbody))
		{
			rigidbodies.Add(rigidbody);
		}
		if (rigidbodies.Count >= objectsBeforeBlowingUp)
		{
			StartCoroutine(DelaySpring());
		}
	}

	private void OnTriggerExit(Collider other)
	{
		if (other == null)
		{
			return;
		}
		Rigidbody item = ((other.GetComponent<Rigidbody>() != null) ? other.GetComponent<Rigidbody>() : other.GetComponentInParent<Rigidbody>());
		if (rigidbodies.Contains(item))
		{
			rigidbodies.Remove(item);
		}
		if (rigidbodies.Count < objectsBeforeBlowingUp)
		{
			StopAllCoroutines();
		}
	}

	private IEnumerator DelaySpring()
	{
		yield return new WaitForSeconds(delayBeforeBlowingUp);
		Spring();
	}

	public void Spring()
	{
		if (platformAnimator != null)
		{
			platformAnimator.SetTrigger("Spring");
		}
		for (int i = 0; i < rigidbodies.Count; i++)
		{
			if (rigidbodies[i] != null)
			{
				rigidbodies[i].AddForce(forceVector + Vector3.up * upForce, ForceMode.VelocityChange);
				rigidbodies[i].AddTorque(forceVector + Vector3.up * upForce, ForceMode.VelocityChange);
			}
		}
		rigidbodies.Clear();
	}

	public SpringPlatform()
	{
		upForce = 100f;
		objectsBeforeBlowingUp = 6;
		delayBeforeBlowingUp = 1f;
		rigidbodies = new List<Rigidbody>();
	}
}
