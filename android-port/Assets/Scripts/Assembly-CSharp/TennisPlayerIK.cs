using UnityEngine;

public class TennisPlayerIK : MonoBehaviour
{
	public Transform Ball;

	public float Threshold;

	public Vector3 LocalOffset;

	private Animator animator;

	private void Awake()
	{
	}

	private void OnAnimatorIK(int layer)
	{
	}
}
