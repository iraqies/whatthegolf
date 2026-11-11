using UnityEngine;

public class ThrowableSnowballHotdog : MonoBehaviour
{
	private void OnCollisionEnter(Collision other)
	{
		if (other == null || other.gameObject == null)
		{
			return;
		}
		SnowBallTargetBehaviourWithObject componentInParent = other.gameObject.GetComponentInParent<SnowBallTargetBehaviourWithObject>();
		if (componentInParent != null && other.contacts != null && other.contacts.Length != 0 && other.contacts[0].otherCollider != null)
		{
			componentInParent.Collapse(other, other.contacts[0].otherCollider.attachedRigidbody);
		}
	}
}
