using System.Collections;
using Audio;
using UnityEngine;

namespace Puzzle
{
	public class PuzzleRotatableBox : PuzzleObjectBase
	{
		public float rotationTime;

		public bool rotateClockwise;

		private float nextHitTime;

		private Coroutine routine;

		public RandomAudioClips turnClips;

		private void OnCollisionEnter2D(Collision2D collision)
		{
		}

		private IEnumerator Rotate(Rigidbody2D rb)
		{
			return null;
		}
	}
}
