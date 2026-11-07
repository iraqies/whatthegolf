using System.Collections.Generic;
using Core;
using UnityEngine;

namespace GolfCourse
{
	public class GolfCoursePinGoal : MonoBehaviour
	{
		[SerializeField] private bool useTrigger = true;
		[SerializeField] private bool useOtherTriggers;
		[SerializeField] private bool useCustomWinDelay;
		[SerializeField] private float winDelay = 0.8f;
		[SerializeField] private float preWinDelay;
		[SerializeField] private bool checkRootForController = true;
		[SerializeField] private bool bendFlagOnHit = true;
		[SerializeField] private bool emitParticles = true;
		public int RequiredBallsInGoal = 1;
		public bool DontAcceptController;
		public List<Collider> goalObject = new List<Collider>();

		private List<Transform> golfBallsInGoal = new List<Transform>();
		private List<GolfBallController> controllersInGoal = new List<GolfBallController>();
		private int ballsInGoal;
		private GolfGoal golfGoal;
		private ParticleSystem particles;
		private bool didBend;
		private bool didPlayParticles;

		private void Awake()
		{
			golfGoal = GetComponent<GolfGoal>() ?? GetComponentInParent<GolfGoal>() ?? FindObjectOfType<GolfGoal>();
			particles = GetComponentInChildren<ParticleSystem>();
			if (RequiredBallsInGoal <= 0) RequiredBallsInGoal = 1;
		}

		private void OnCollisionEnter(Collision collision)
		{
			if (collision != null) CheckObject(collision.transform, true);
		}

		private void OnTriggerEnter(Collider other)
		{
			if (other != null) CheckObject(other.transform, false);
		}

		public void AddBall()
		{
			ballsInGoal++;
			if (ballsInGoal >= Mathf.Max(1, RequiredBallsInGoal))
				Complete();
		}

		public void CheckObject(Transform trans, bool fromCollision = false)
		{
			if (trans == null || golfBallsInGoal.Contains(trans)) return;
			var ctrl = checkRootForController ? trans.GetComponentInParent<GolfBallController>() : trans.GetComponent<GolfBallController>();
			var winBall = trans.GetComponentInParent<WinnableGolfBall>();
			if ((!DontAcceptController && ctrl != null) || winBall != null || trans.CompareTag("Player") || trans.CompareTag("Ball"))
			{
				golfBallsInGoal.Add(trans);
				if (ctrl != null && !controllersInGoal.Contains(ctrl))
				{
					controllersInGoal.Add(ctrl);
					ctrl.GoalReached();
				}
				PlayFlagAnimation(GetHitDir(trans));
				AddBall();
			}
		}

		private Vector3 GetHitDir(Transform ballTrans) => (transform.position - ballTrans.position).normalized;

		private void PlayFlagAnimation(Vector3 hitDir)
		{
			if (emitParticles && !didPlayParticles && particles != null)
			{
				didPlayParticles = true;
				particles.Play();
			}
		}

		private void Complete()
		{
			if (golfGoal == null) golfGoal = FindObjectOfType<GolfGoal>();
			if (golfGoal != null)
			{
				if (useCustomWinDelay) golfGoal.Complete(winDelay);
				else golfGoal.Complete();
			}
			else if (Level.HasInstance)
			{
				Level.Instance.Complete();
			}
		}
	}
}
