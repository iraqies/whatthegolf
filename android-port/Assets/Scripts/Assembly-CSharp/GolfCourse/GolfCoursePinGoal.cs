using System.Collections.Generic;
using Core;
using UnityEngine;

namespace GolfCourse
{
	public class GolfCoursePinGoal : MonoBehaviour
	{
		[SerializeField]
		private bool useTrigger;

		[SerializeField]
		private bool useOtherTriggers;

		[SerializeField]
		private bool useCustomWinDelay;

		[SerializeField]
		private float winDelay;

		[SerializeField]
		private float preWinDelay;

		[SerializeField]
		private bool checkRootForController;

		[SerializeField]
		private bool bendFlagOnHit;

		[SerializeField]
		private bool emitParticles;

		public int RequiredBallsInGoal;

		public bool DontAcceptController;

		public List<Collider> goalObject;

		private List<Transform> golfBallsInGoal;

		private List<GolfBallController> controllersInGoal;

		private int ballsInGoal;

		private GolfGoal golfGoal;

		private ParticleSystem particles;

		private bool didBend;

		private bool didPlayParticles;

		private void Awake()
		{
		}

		private void OnCollisionEnter(Collision collision)
		{
		}

		private void OnTriggerEnter(Collider other)
		{
		}

		public void AddBall()
		{
		}

		public void CheckObject(Transform trans, bool fromCollision = false)
		{
		}

		private Vector3 GetHitDir(Transform ballTrans)
		{
			return default;
		}

		private void PlayFlagAnimation(Vector3 hitDir)
		{
		}

		private void Complete()
		{
		}
	}
}
