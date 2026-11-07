using Audio;
using UnityEngine;

namespace Puzzle
{
	public class PuzzleWall : PuzzleObjectBase
	{
		public Animator spriteAnimator;

		public Collider2D col;

		public bool startOn;

		public RandomAudioClips clips;

		public override void OnBallEnter(OverworldBall2D ball)
		{
		}

		public override void Trigger(bool active)
		{
		}
	}
}
