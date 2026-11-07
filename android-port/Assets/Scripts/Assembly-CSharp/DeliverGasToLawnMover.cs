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
	}

	private void OnDropProp(PuppetMasterProp prop)
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private IEnumerator MatchPropAndAnimation(PuppetMasterProp prop)
	{
		return null;
	}
}
