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
			startPosition = base.transform.position;
			startRotation = base.transform.rotation;
		}

		public virtual void ResetObject()
		{
			base.transform.position = startPosition;
			base.transform.rotation = startRotation;
			Rigidbody2D component = GetComponent<Rigidbody2D>();
			if (component != null)
			{
				component.velocity = Vector2.zero;
				component.angularVelocity = 0f;
			}
		}

		public virtual void OnBallEnter(OverworldBall2D ball)
		{
			isBallInArea = true;
		}

		public virtual void OnBallLeave()
		{
			isBallInArea = false;
		}

		public virtual void Trigger(bool active)
		{
			Active = active;
		}
	}
}
