using RootMotion.Dynamics;
using UnityEngine;

public class PuppetKnockawayRigidbodiesOnGetup : MonoBehaviour
{
	[SerializeField]
	private BehaviourPuppet puppet;

	[SerializeField]
	private BehaviourFall fallBehaviour;

	[SerializeField]
	private float radius = 2f;

	[SerializeField]
	private LayerMask layerMask;

	[SerializeField]
	private float startAfterTime = 0.2f;

	[SerializeField]
	private float knockAwayForce = 50f;

	[SerializeField]
	private float upwardModifier = 3f;

	[SerializeField]
	private ForceMode forceMode = ForceMode.Impulse;

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
			if (puppet.onLoseBalanceFromGetUp.unityEvent != null)
			{
				puppet.onLoseBalanceFromGetUp.unityEvent.AddListener(OnLoseBalanceFromGetup);
			}
			if (puppet.onLoseBalance.unityEvent != null)
			{
				puppet.onLoseBalance.unityEvent.AddListener(OnLoseBalance);
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
		if (puppet == null)
		{
			return;
		}
		if (puppet.state == BehaviourPuppet.State.Unpinned || puppet.state == BehaviourPuppet.State.GetUp)
		{
			timeInUnpinnedOrGetupState += Time.fixedDeltaTime;
			if (timeInUnpinnedOrGetupState >= startAfterTime)
			{
				Collider[] cols = Physics.OverlapSphere(transform.position, radius, layerMask);
				if (cols != null)
				{
					for (int i = 0; i < cols.Length; i++)
					{
						if (cols[i] != null && cols[i].attachedRigidbody != null)
						{
							cols[i].attachedRigidbody.AddExplosionForce(knockAwayForce, transform.position, radius, upwardModifier, forceMode);
						}
					}
				}
			}
		}
		else
		{
			timeInUnpinnedOrGetupState = 0f;
		}
	}

	private void OnDrawGizmosSelected()
	{
		Gizmos.color = Color.red;
		Gizmos.DrawWireSphere(base.transform.position, radius);
	}
}
