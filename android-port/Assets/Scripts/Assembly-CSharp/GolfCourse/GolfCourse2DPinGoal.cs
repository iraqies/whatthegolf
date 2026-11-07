using System.Collections.Generic;
using Core;
using UnityEngine;

namespace GolfCourse
{
	public class GolfCourse2DPinGoal : MonoBehaviour
	{
		[SerializeField] private string winMessage;
		[SerializeField] private float delay = 0.8f;
		public int RequiredBallsInGoal = 1;
		public bool DontAcceptController;

		private List<Transform> golfBallsInGoal = new List<Transform>();
		private List<int> playersInGoal = new List<int>();
		private int ballsInGoal;
		private GolfGoal golfgoal;

		private void Awake()
		{
			golfgoal = GetComponent<GolfGoal>() ?? GetComponentInParent<GolfGoal>() ?? FindObjectOfType<GolfGoal>();
			if (RequiredBallsInGoal <= 0) RequiredBallsInGoal = 1;
		}

		private void OnCollisionEnter2D(Collision2D collision)
		{
			if (collision != null) CheckObject(collision.transform);
		}

		private void OnTriggerEnter2D(Collider2D other)
		{
			if (other != null) CheckObject(other.transform);
		}

		public void AddBall()
		{
			ballsInGoal++;
			if (ballsInGoal >= Mathf.Max(1, RequiredBallsInGoal))
			{
				if (golfgoal == null) golfgoal = FindObjectOfType<GolfGoal>();
				if (golfgoal != null)
					golfgoal.Complete(winMessage, delay);
				else if (Level.HasInstance)
					Level.Instance.Complete(winMessage, delay);
			}
		}

		public void CheckObject(Transform trans)
		{
			if (trans == null || golfBallsInGoal.Contains(trans)) return;
			var ctrl = trans.GetComponentInParent<GolfBallController>();
			var winBall = trans.GetComponentInParent<WinnableGolfBall>();
			var holeBall = trans.GetComponentInParent<GolfBall2D>();
			if ((!DontAcceptController && ctrl != null) || winBall != null || holeBall != null || trans.CompareTag("Player") || trans.CompareTag("Ball"))
			{
				golfBallsInGoal.Add(trans);
				ctrl?.GoalReached();
				AddBall();
			}
		}
	}
}
