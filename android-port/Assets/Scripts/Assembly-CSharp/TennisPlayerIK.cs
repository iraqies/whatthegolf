using UnityEngine;

public class TennisPlayerIK : MonoBehaviour
{
	public Transform Ball;

	public float Threshold = 30f;

	public Vector3 LocalOffset;

	private Animator animator;

	private void Awake()
	{
		animator = GetComponent<Animator>();
	}

	private void OnAnimatorIK(int layer)
	{
		if (Ball == null || animator == null)
		{
			return;
		}
		Vector3 position = Ball.position;
		Vector3 position2 = base.transform.position;
		Vector3 vector = base.transform.InverseTransformDirection(LocalOffset);
		Vector3 to = new Vector3(position.x - (position2.x + vector.x), 0f, position.z - (position2.z + vector.z));
		to.Normalize();
		Vector3 forward = base.transform.forward;
		Vector3 normalized = new Vector3(forward.x, 0f, forward.z).normalized;
		float num = Mathf.Lerp(1f, 0f, Mathf.Abs(Vector3.SignedAngle(normalized, to, Vector3.up) / Threshold));
		animator.SetIKPositionWeight(AvatarIKGoal.LeftHand, num);
		animator.SetIKPositionWeight(AvatarIKGoal.RightHand, num);
		animator.SetIKPosition(AvatarIKGoal.LeftHand, base.transform.position - base.transform.right * 20f + Vector3.up * 20f);
		animator.SetIKPosition(AvatarIKGoal.RightHand, base.transform.position + base.transform.right * 20f + Vector3.up * 20f);
		animator.SetLookAtPosition(Ball.transform.position);
		animator.SetLookAtWeight(num, num * 0.6f, num);
	}
}
