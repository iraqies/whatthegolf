using UnityEngine;

public interface ICameraBehaviourFollowing
{
	void SetFollowTarget(Transform target);

	Transform GetFollowTarget();
}
