using System.Collections;
using UnityEngine;

namespace TennisGolf
{
	public class TennisOpponent : MonoBehaviour
	{
		private enum StateEnum
		{
			Serving = 0,
			Passing = 1,
			Receiving = 2
		}

		public Rigidbody TennisBall;

		public Transform CenterOfThisSide;

		public Transform CenterOfOtherSide;

		public BoxCollider TennisCourt;

		public float CourtSize;

		public float ShotAngle;

		public float BallServeHeight;

		public float BallVelocityMultiplier;

		public float MoveSpeed;

		public float JumpHeight;

		public float JumpDuration;

		private Rigidbody rigidbody;

		private StateEnum currentState;

		private TennisBall ball;

		private float enableCollisionTimer;

		private TennisBall tennisBall;

		private float moveSpeedDecrementer;

		private Transform model;

		public bool firstShootNeutral;

		private void Awake()
		{
		}

		private void OnGameWon()
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void FixedUpdate()
		{
		}

		private IEnumerator DoServe()
		{
			return null;
		}

		private void OnCollisionEnter(Collision other)
		{
		}

		private IEnumerator ModelJump()
		{
			return null;
		}
	}
}
