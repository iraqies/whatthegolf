using System;
using System.Collections;
using RootMotion.Dynamics;
using UnityEngine;

public class DeliverGasToLawnMover : MonoBehaviour
{
	public Animator Animator;

	public Transform PropAnimationAnchor;

	public PuppetMaster PlayerPuppet;

	private bool hasDelivered;

	private void Start()
	{
		PropMuscle propMuscle = PlayerPuppet.propMuscles[0];
		propMuscle.OnDropProp = (PropMuscle.PropDelegate)Delegate.Combine(propMuscle.OnDropProp, new PropMuscle.PropDelegate(OnDropProp));
	}

	private void OnDropProp(PuppetMasterProp prop)
	{
		StartCoroutine(MatchPropAndAnimation(prop));
	}

	private void OnTriggerEnter(Collider other)
	{
		if (!hasDelivered)
		{
			PuppetMaster componentInParent = other.attachedRigidbody.GetComponentInParent<PuppetMaster>();
			if (componentInParent != null && componentInParent.propMuscles[0].currentProp != null)
			{
				componentInParent.propMuscles[0].currentProp = null;
				Animator.SetTrigger("Refill");
				hasDelivered = true;
			}
		}
	}

	private IEnumerator MatchPropAndAnimation(PuppetMasterProp prop)
	{
		prop.GetRigidbody().isKinematic = true;
		prop.transform.SetParent(PropAnimationAnchor);
		Collider col = prop.GetComponentInChildren<Collider>();
		col.enabled = false;
		yield return StartCoroutine(pTween.To(0.3f, delegate(float t)
		{
			prop.transform.localPosition = Vector3.Lerp(prop.transform.localPosition, Vector3.zero, Mathf.Clamp01(t));
			prop.transform.localRotation = Quaternion.Lerp(prop.transform.localRotation, Quaternion.identity, t);
		}));
		yield return new WaitForSeconds(2f);
		col.enabled = true;
	}
}
