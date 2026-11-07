using System.Collections;
using Chronos;
using UnityEngine;

namespace Puzzle
{
	public class RailObject : PuzzleObjectBase, ITimedPuzzleObject
	{
		public enum MovementSmooth
		{
			LINEAR = 0,
			EASE_OUT = 1,
			EASE_IN = 2,
			SMOOTHSTEP = 3,
			SMOOTHERSTEP = 4
		}

		public float timeToMoveMin;

		public float timeToMoveMax;

		public bool canRetriggerWhileMoving;

		public Transform movingObject;

		public Transform pointA;

		public Transform pointB;

		public MovementSmooth movementSmooth;

		private Transform currentPoint;

		private float maxDistance;

		private Coroutine routine;

		private Vector3 posA;

		private Vector3 posB;

		public LocalClock BallClock { get; set; }

		public void SetClock(LocalClock clock)
		{
		}

		public float GetDeltaTime()
		{
			return 0f;
		}

		private void Awake()
		{
		}

		public override void Trigger(bool active)
		{
		}

		private IEnumerator MoveToPoint(Vector3 point)
		{
			return null;
		}

		private float ReturnSmoothedValue(float t)
		{
			return 0f;
		}
	}
}
