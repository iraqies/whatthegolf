using RootMotion.Dynamics;
using UnityEngine;

public class PuppetKnockawayRigidbodiesOnGetup : MonoBehaviour
{
	[SerializeField]
	private BehaviourPuppet puppet;

	[SerializeField]
	private BehaviourFall fallBehaviour;

	[SerializeField]
	private float radius;

	[SerializeField]
	private LayerMask layerMask;

	[SerializeField]
	private float startAfterTime;

	[SerializeField]
	private float knockAwayForce;

	[SerializeField]
	private float upwardModifier;

	[SerializeField]
	private ForceMode forceMode;

	private float timeInUnpinnedOrGetupState;

	private void Awake()
	{
	}

	private void OnPostMuscleCollision(MuscleCollision collision)
	{
	}

	private void OnPostMuscleHitInFall(MuscleHit hit)
	{
	}

	private void OnLoseBalance()
	{
	}

	private void OnLoseBalanceFromGetup()
	{
	}

	private void FixedUpdate()
	{
	}

	private void OnDrawGizmosSelected()
	{
	}
}
