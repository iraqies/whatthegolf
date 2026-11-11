using Chronos;
using UnityEngine;

namespace Puzzle
{
	public class PuzzleSwitchTimed : PuzzleSwitchBase, ITimedPuzzleObject
	{
		public float time;

		public bool retriggerWhileActive;

		private float timer;

		private bool running;

		public LocalClock BallClock { get; set; }

		public void SetClock(LocalClock clock)
		{
			BallClock = clock;
		}

		public float GetDeltaTime()
		{
			if (BallClock != null)
			{
				return BallClock.deltaTime;
			}
			return Time.deltaTime;
		}

		private void OnCollisionEnter2D(Collision2D collision)
		{
			if (collision != null)
			{
				OnObjectEnterTrigger(collision.gameObject);
			}
		}

		private void OnTriggerEnter2D(Collider2D other)
		{
			if (other != null)
			{
				OnObjectEnterTrigger(other.gameObject);
			}
		}

		private void OnObjectEnterTrigger(GameObject go)
		{
			if (go != null && go.GetComponent<OverworldBall2D>() != null && (!running || retriggerWhileActive))
			{
				timer = time;
				running = true;
				TriggerObjects(true);
			}
		}

		private void Update()
		{
			if (running)
			{
				timer -= GetDeltaTime();
				if (timer < 0f)
				{
					running = false;
					TriggerObjects(false);
				}
			}
		}
	}
}
