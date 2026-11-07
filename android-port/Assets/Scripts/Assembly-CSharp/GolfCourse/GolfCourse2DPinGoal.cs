using System.Collections.Generic;
using UnityEngine;

namespace GolfCourse
{
	public class GolfCourse2DPinGoal : MonoBehaviour
	{
		[SerializeField]
		private string winMessage;

		[SerializeField]
		private float delay;

		public int RequiredBallsInGoal;

		public bool DontAcceptController;

		private List<Transform> golfBallsInGoal;

		private List<int> playersInGoal;

		private int ballsInGoal;

		private GolfGoal golfgoal;

		private void Awake()
		{
		}

		private void OnCollisionEnter2D(Collision2D collision)
		{
		}

		private void OnTriggerEnter2D(Collider2D other)
		{
		}

		public void AddBall()
		{
		}

		public void CheckObject(Transform trans)
		{
		}
	}
}
