using System;
using Audio;
using Chronos;
using UnityEngine;

namespace Puzzle
{
	public class PuzzleBall : MonoBehaviour, ITimedPuzzleObject
	{
		public float force;

		public float angleThreshold;

		public bool affectCollisions;

		private Rigidbody2D rb;

		private Vector2 velocity;

		private float speed;

		public RandomAudioClips bounceOnWall;

		public RandomAudioClips bounceFail;

		public Action OnShoot;

		public Action OnBallFail;

		public Action OnBallReset;

		public LocalClock BallClock { get; set; }

		public void SetClock(LocalClock clock)
		{
		}

		public float GetDeltaTime()
		{
			return 0f;
		}

		public void AddSpeed(float add)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void FixedUpdate()
		{
		}

		public void Shoot(Vector2 dir)
		{
		}

		private void OnCollisionEnter2D(Collision2D other)
		{
		}

		public void BallFail()
		{
		}
	}
}
