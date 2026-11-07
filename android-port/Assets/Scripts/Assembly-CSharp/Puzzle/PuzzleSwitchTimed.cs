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
		}

		public float GetDeltaTime()
		{
			return 0f;
		}

		private void OnCollisionEnter2D(Collision2D collision)
		{
		}

		private void OnTriggerEnter2D(Collider2D other)
		{
		}

		private void OnObjectEnterTrigger(GameObject go)
		{
		}

		private void Update()
		{
		}
	}
}
