using System;
using System.Collections.Generic;
using System.Linq;
using Core;
using UnityEngine;

namespace GolfCourse
{
	public class GolfCoursePinGoal : MonoBehaviour
	{
		[SerializeField] private bool useTrigger = true;
		[SerializeField] private bool useOtherTriggers;
		[SerializeField] private bool useCustomWinDelay;
		[SerializeField] private float winDelay;
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
			golfBallsInGoal = new List<Transform>();
			controllersInGoal = new List<GolfBallController>();
			golfGoal = GetComponent<GolfGoal>() ?? GetComponentInParent<GolfGoal>() ?? FindObjectOfType<GolfGoal>();
			particles = GetComponentInChildren<ParticleSystem>();
			if (particles != null)
				particles.Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);
			if (RequiredBallsInGoal <= 0) RequiredBallsInGoal = 1;
		}

		private void OnCollisionEnter(Collision collision)
		{
			if (collision != null) CheckObject(collision.transform, true);
		}

		private void OnTriggerEnter(Collider other)
		{
			if (!useTrigger || other == null) return;
			if (!useOtherTriggers && other.isTrigger) return;
			CheckObject(other.transform, false);
		}

		public void AddBall()
		{
			ballsInGoal++;
			if (ballsInGoal >= Mathf.Max(1, RequiredBallsInGoal))
				Complete();
		}

		public void CheckObject(Transform trans, bool fromCollision = false)
		{
			if (trans == null || trans.gameObject == null || trans.gameObject.isStatic || !enabled || !gameObject.activeInHierarchy)
				return;

			Transform checkTrans = checkRootForController ? trans.root : trans;
			GolfBallController ctrl = checkTrans != null ? checkTrans.GetComponentInChildren<GolfBallController>() : null;
			Vector3 hitDir = Vector3.zero;
			bool validGoalHit = false;

			if (goalObject != null && goalObject.Any(c => c != null))
			{
				Collider hitCol = trans.GetComponent<Collider>();
				if ((hitCol == null || !goalObject.Contains(hitCol)) && ctrl == null && !trans.CompareTag("AdditionalGolfThing"))
					return;
				if (hitCol != null && goalObject.Contains(hitCol))
				{
					validGoalHit = true;
					if (!golfBallsInGoal.Contains(trans.root))
					{
						hitDir = GetHitDir(trans);
						golfBallsInGoal.Add(trans.root);
						ballsInGoal++;
					}
				}
			}

			if (!DontAcceptController && ctrl != null && !golfBallsInGoal.Contains(trans.root))
			{
				hitDir = GetHitDir(trans);
				golfBallsInGoal.Add(trans.root);
				ballsInGoal++;
				validGoalHit = true;
			}

			WinnableGolfBall winBall = trans.GetComponentInChildren<WinnableGolfBall>() ?? trans.GetComponentInParent<WinnableGolfBall>();
			if (winBall != null)
			{
				GolfBallController[] allCtrls = FindObjectsOfType<GolfBallController>();
				if (allCtrls != null && allCtrls.Length > 0)
				{
					GolfBallController ownerCtrl = allCtrls.FirstOrDefault(g => g != null && g.PlayerIndex == winBall.PlayerIndex);
					if (ownerCtrl != null && golfGoal != null)
					{
						hitDir = GetHitDir(trans);
						golfGoal.GoalProgress(ownerCtrl.PlayerIndex);
						ballsInGoal++;
						validGoalHit = true;
					}
				}
			}

			if (trans.CompareTag("AdditionalGolfThing") && !golfBallsInGoal.Contains(trans.root))
			{
				hitDir = GetHitDir(trans);
				golfBallsInGoal.Add(trans.root);
				ballsInGoal++;
				validGoalHit = true;
			}

			if (!DontAcceptController && ctrl != null && !controllersInGoal.Contains(ctrl))
			{
				hitDir = GetHitDir(trans);
				controllersInGoal.Add(ctrl);
				validGoalHit = true;
				if (golfGoal != null)
				{
					golfGoal.GoalProgress(ctrl.PlayerIndex);
				}
				if (emitParticles && particles != null)
				{
					didPlayParticles = true;
					particles.Play(true);
				}
			}

			bool completedNow = false;
			if (ballsInGoal > 0 && ballsInGoal >= Mathf.Max(1, RequiredBallsInGoal))
			{
				completedNow = true;
				Complete();
				ballsInGoal = 0;
				golfBallsInGoal.Clear();
				controllersInGoal.Clear();
			}

			if (bendFlagOnHit && !didBend && (validGoalHit || completedNow))
			{
				didBend = true;
				PlayFlagAnimation(hitDir);
			}

			if (emitParticles && particles != null && !didPlayParticles && (validGoalHit || completedNow))
			{
				didPlayParticles = true;
				particles.Play(true);
			}
		}

		private Vector3 GetHitDir(Transform ballTrans)
		{
			if (ballTrans != null)
				return transform.position - ballTrans.position;
			return Vector3.zero;
		}

		private void PlayFlagAnimation(Vector3 hitDir)
		{
			Vector3 targetUp = Vector3.Slerp(Vector3.up, new Vector3(hitDir.x, 0f, hitDir.z), 0.2f);
			Quaternion start = transform.rotation;
			Quaternion end = Quaternion.FromToRotation(Vector3.up, targetUp) * start;
			StartCoroutine(pTween.To(0.5f, t =>
			{
				float eased = TweenFunctions.EaseOutBounce(0f, 1f, t);
				transform.rotation = Quaternion.Lerp(start, end, eased);
			}));
		}

		private void Complete()
		{
			if (preWinDelay > 0f)
			{
				StartCoroutine(pTween.To(preWinDelay, _ => { }).Then(() =>
				{
					preWinDelay = 0f;
					Complete();
				}));
				return;
			}
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
