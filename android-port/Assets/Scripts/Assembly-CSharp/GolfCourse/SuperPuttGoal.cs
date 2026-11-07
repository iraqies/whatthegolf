using Core;
using UnityEngine;

namespace GolfCourse
{
	public class SuperPuttGoal : MonoBehaviour
	{
		public bool ShowCustomTransition;
		private Level level;
		private SuperPuttTransitionTextEffect textEffect;

		private void Awake()
		{
			level = FindObjectOfType<Level>();
		}

		private void OnCollisionEnter(Collision collision)
		{
			if (collision != null) CheckObject(collision.transform);
		}

		private void OnTriggerEnter(Collider other)
		{
			if (other != null) CheckObject(other.transform);
		}

		public void CheckObject(Transform trans)
		{
			if (trans == null) return;
			if (trans.GetComponentInParent<GolfBallController>() != null || trans.GetComponentInParent<WinnableGolfBall>() != null)
				NotifyCompleted();
		}

		private void NotifyCompleted()
		{
			if (Level.HasInstance)
				Level.Instance.Complete();
		}
	}
}
