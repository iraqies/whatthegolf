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
	private float startAfterTime = 0.2f;

	[SerializeField]
	private float knockAwayForce = 50f;

	[SerializeField]
	private float upwardModifier = 3f;

	[SerializeField]
	private ForceMode forceMode;

	private float timeInUnpinnedOrGetupState;

	private void Awake()
	{
		if (fallBehaviour != null)
		{
			fallBehaviour.OnPostMuscleHit = (BehaviourBase.HitDelegate)System.Delegate.Combine(fallBehaviour.OnPostMuscleHit, new BehaviourBase.HitDelegate(OnPostMuscleHitInFall));
			fallBehaviour.OnPostMuscleCollision = (BehaviourBase.CollisionDelegate)System.Delegate.Combine(fallBehaviour.OnPostMuscleCollision, new BehaviourBase.CollisionDelegate(OnPostMuscleCollision));
		}
		if (puppet != null)
		{
			if (puppet.onLoseBalanceFromGetUp != null)
			{
				puppet.onLoseBalanceFromGetUp.AddListener(OnLoseBalanceFromGetup);
			}
			if (puppet.onLoseBalance != null)
			{
				puppet.onLoseBalance.AddListener(OnLoseBalance);
			}
		}
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
		Gizmos.color = Color.red;
		Gizmos.DrawWireSphere(base.transform.position, radius);
	}
}
