using UnityEngine;

namespace Core
{
	public class HitGoal : MonoBehaviour
	{
		[SerializeField] private GolfBallController ball;
		private GolfGoal goal;

		private void Awake()
		{
			goal = GetComponent<GolfGoal>() ?? GetComponentInParent<GolfGoal>() ?? FindObjectOfType<GolfGoal>();
		}

		private void OnCollisionEnter(Collision collision)
		{
			if (collision == null) return;
			if (ball == null || collision.gameObject == ball.gameObject || collision.collider.GetComponentInParent<GolfBallController>() != null || collision.collider.GetComponentInParent<WinnableGolfBall>() != null)
			{
				if (goal == null) goal = FindObjectOfType<GolfGoal>();
				goal?.Complete();
			}
		}

		private void OnTriggerEnter(Collider other)
		{
			if (other == null) return;
			if (ball == null || other.gameObject == ball.gameObject || other.GetComponentInParent<GolfBallController>() != null || other.GetComponentInParent<WinnableGolfBall>() != null)
			{
				if (goal == null) goal = FindObjectOfType<GolfGoal>();
				goal?.Complete();
			}
		}
	}
}
