using UnityEngine;

namespace Puzzle
{
	public abstract class PuzzleObjectBase : GolfBehaviour
	{
		public bool isBallInArea;

		public bool alwaysReverseStatusOnTrigger;

		private Vector2 startPosition;

		private Quaternion startRotation;

		public bool Active { get; set; }

		private void Start()
		{
		}

		public virtual void ResetObject()
		{
		}

		public virtual void OnBallEnter(OverworldBall2D ball)
		{
		}

		public virtual void OnBallLeave()
		{
		}

		public virtual void Trigger(bool active)
		{
		}
	}
}
