using UnityEngine;

public class SetIKTarget : MonoBehaviour
{
	public AvatarIKGoal IKGoal;

	public Transform Target;

	private Animator animator;

	private void Start()
	{
	}

	private void OnAnimatorIK(int layer)
	{
	}
}
