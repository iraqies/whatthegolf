using System;
using System.Collections;
using System.Collections.Generic;
using Core;
using UnityEngine;

namespace TennisGolf
{
	public class TennisPlayer : MonoBehaviour
	{
		public Rigidbody TennisBall;

		public Transform TennisCourt;

		public Transform CenterOfOtherSide;

		public float CourtSize;

		public List<GameObject> PlayerTrophies;

		public List<GameObject> OpponentTrophies;

		public GameObject FlagObject;

		public float ShotAngle = 45f;

		public float JumpHeight = 2f;

		public float JumpDuration = 0.3f;

		private TennisBall ball;

		private float enableCollisionTimer;

		private Rigidbody rigid;

		private Vector3 lastDirection;

		private Transform model;

		private void Awake()
		{
			GolfBallController component = GetComponent<GolfBallController>();
			if (component != null)
			{
				component.OnAimUpdate += OnAimUpdate;
			}
			if (TennisBall != null)
			{
				ball = TennisBall.GetComponent<TennisBall>();
				if (ball != null)
				{
					ball.OnPlayerWon = (Action)Delegate.Combine(ball.OnPlayerWon, new Action(OnPlayerWon));
				}
			}
			rigid = GetComponent<Rigidbody>();
			lastDirection = base.transform.forward;
			Animator componentInChildren = GetComponentInChildren<Animator>();
			if (componentInChildren != null)
			{
				model = componentInChildren.transform;
			}
		}

		private void OnAimUpdate(Vector3 boost, bool b)
		{
			lastDirection = boost;
		}

		private void Update()
		{
			if (enableCollisionTimer > 0f)
			{
				enableCollisionTimer -= Time.deltaTime;
				if (enableCollisionTimer <= 0f && TennisBall != null)
				{
					Physics.IgnoreCollision(GetComponent<Collider>(), TennisBall.GetComponent<Collider>(), false);
				}
			}
		}

		private IEnumerator DelayedWin()
		{
			yield return new WaitForSeconds(0.5f);
			if (FlagObject != null)
			{
				FlagObject.transform.position = base.transform.position;
			}
		}

		public void OnPlayerWon()
		{
			if (PlayerTrophies == null)
			{
				return;
			}
			int num = 0;
			while (num < PlayerTrophies.Count && PlayerTrophies[num] != null && PlayerTrophies[num].activeSelf)
			{
				num++;
			}
			if (num < PlayerTrophies.Count && PlayerTrophies[num] != null)
			{
				PlayerTrophies[num].SetActive(true);
				num++;
			}
			if (num == PlayerTrophies.Count)
			{
				if (ball != null)
				{
					ball.DontUpdate = true;
				}
				StartCoroutine(DelayedWin());
			}
		}

		private void OnCollisionEnter(Collision other)
		{
			if (other == null || TennisBall == null || other.gameObject != TennisBall.gameObject || enableCollisionTimer > 0f)
			{
				return;
			}
			enableCollisionTimer = 0.5f;
			Physics.IgnoreCollision(GetComponent<Collider>(), TennisBall.GetComponent<Collider>(), true);
			if (CenterOfOtherSide != null && ball != null)
			{
				Vector3 target = CenterOfOtherSide.position + lastDirection * CourtSize;
				Vector3 velocity = ball.CalculateVelocityForTarget(base.transform.position, target, ShotAngle);
				TennisBall.velocity = velocity;
				TennisBall.angularVelocity = Vector3.Cross(velocity.normalized, Vector3.up) * 10f;
				ball.SetLastHitter(base.gameObject);
			}
			if (rigid != null)
			{
				rigid.velocity = Vector3.zero;
				rigid.angularVelocity = Vector3.zero;
			}
			StartCoroutine(ModelJump());
		}

		private IEnumerator ModelJump()
		{
			if (model == null)
			{
				yield break;
			}
			Vector3 startPos = model.transform.localPosition;
			yield return StartCoroutine(pTween.To(JumpDuration, delegate(float t)
			{
				if (model != null)
				{
					float t2 = Mathf.Clamp01(Mathf.Sin(t * (float)Math.PI));
					model.transform.localPosition = Vector3.Lerp(startPos, startPos + Vector3.up * JumpHeight, t2);
				}
			}));
		}
	}
}
