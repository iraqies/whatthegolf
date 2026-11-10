using System;
using Audio;
using Chronos;
using UnityEngine;

namespace Puzzle
{
	public class PuzzleBall : MonoBehaviour, ITimedPuzzleObject
	{
		public float force = 10f;

		public float angleThreshold = 0.22f;

		public bool affectCollisions = true;

		private Rigidbody2D rb;

		private Vector2 velocity;

		private float speed;

		public RandomAudioClips bounceOnWall;

		public RandomAudioClips bounceFail;

		public Action OnShoot = delegate { };

		public Action OnBallFail = delegate { };

		public Action OnBallReset = delegate { };

		public LocalClock BallClock { get; set; }

		public void SetClock(LocalClock clock)
		{
			BallClock = clock;
		}

		public float GetDeltaTime()
		{
			if (BallClock != null)
				return BallClock.deltaTime;
			return Time.deltaTime;
		}

		public void AddSpeed(float add)
		{
			speed += add;
			velocity = velocity.normalized * speed;
		}

		private void OnEnable()
		{
			rb = GetComponent<Rigidbody2D>();
			OverworldBall2D owBall = FindObjectOfType<OverworldBall2D>();
			if (owBall != null)
			{
				Collider2D c1 = owBall.GetComponent<Collider2D>();
				Collider2D c2 = GetComponent<Collider2D>();
				if (c1 != null && c2 != null)
				{
					Physics2D.IgnoreCollision(c1, c2, true);
				}
			}
		}

		private void OnDisable()
		{
			OnBallReset?.Invoke();
		}

		private void FixedUpdate()
		{
			if (BallClock != null && rb != null)
			{
				rb.velocity = velocity * BallClock.timeScale;
			}
		}

		public void Shoot(Vector2 dir)
		{
			speed = force;
			velocity = dir * force;
			OnShoot?.Invoke();
		}

		private void OnCollisionEnter2D(Collision2D other)
		{
			if (other == null || other.gameObject == null)
				return;

			if (other.gameObject.GetComponent<PuzzleWall>() != null)
			{
				if (other.contacts != null && other.contacts.Length > 0)
				{
					Vector2 reflected = Vector2.Reflect(velocity.normalized, other.contacts[0].normal);
					if (affectCollisions)
					{
						Vector3 snapped = PuzzleUtility.SnapTo(new Vector3(reflected.x, reflected.y, 0f), 90f);
						if (bounceOnWall != null)
							bounceOnWall.PlayRandomClip(transform.position);
						velocity = new Vector2(snapped.x * speed, snapped.y * speed);
					}
				}
				return;
			}

			if (other.gameObject.layer != gameObject.layer)
			{
				BallFail();
			}
		}

		public void BallFail()
		{
			OnBallFail?.Invoke();
			if (bounceFail != null)
				bounceFail.PlayRandomClip(transform.position);
			gameObject.SetActive(false);
		}
	}
}
