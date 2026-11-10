using System.Collections;
using UnityEngine;

public class Goose_Pole : MonoBehaviour
{
	[SerializeField]
	private Animator animator;

	[SerializeField]
	private float yeetForce;

	public void TryAttack(Transform target)
	{
		StartCoroutine(Attack(target));
	}

	private IEnumerator Attack(Transform chaseTarget)
	{
		if (animator != null)
		{
			animator.SetTrigger("Kick");
		}
		yield return new WaitForSeconds(0.1f);
		if (chaseTarget != null)
		{
			Rigidbody componentInChildren = chaseTarget.GetComponentInChildren<Rigidbody>();
			Vector3 normalized = (chaseTarget.position - base.transform.position).normalized;
			if (componentInChildren != null)
			{
				componentInChildren.AddForce((normalized + Vector3.up) * yeetForce, ForceMode.VelocityChange);
			}
			chaseTarget = null;
		}
		yield return new WaitForSeconds(1f);
	}
}
