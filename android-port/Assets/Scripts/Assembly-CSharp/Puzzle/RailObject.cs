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

		public float timeToMoveMin = 0.25f;

		public float timeToMoveMax = 1f;

		public bool canRetriggerWhileMoving = true;

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
			BallClock = clock;
		}

		public float GetDeltaTime()
		{
			return BallClock != null ? BallClock.deltaTime : Time.deltaTime;
		}

		private void Awake()
		{
			currentPoint = pointA;
			if (movingObject != null && pointA != null)
			{
				movingObject.position = pointA.position;
				posA = pointA.position;
			}
			if (pointB != null)
			{
				posB = pointB.position;
			}
			maxDistance = Vector2.Distance(posA, posB);
		}

		public override void Trigger(bool active)
		{
			if (pointA == null || pointB == null || movingObject == null)
			{
				return;
			}
			if (routine != null && !canRetriggerWhileMoving)
			{
				return;
			}
			StopAllCoroutines();
			Vector3 target = active ? posB : posA;
			routine = StartCoroutine(MoveToPoint(target));
			isOn = active;
		}

		private IEnumerator MoveToPoint(Vector3 point)
		{
			if (movingObject == null)
			{
				yield break;
			}
			Vector3 startPos = movingObject.position;
			float dist = Vector2.Distance(startPos, point);
			float ratio = maxDistance > 0.001f ? dist / maxDistance : 1f;
			float duration = Mathf.Clamp(ratio * timeToMoveMax, timeToMoveMin, timeToMoveMax);
			float elapsed = 0f;
			while (elapsed < duration)
			{
				float t = Mathf.Clamp01(elapsed / Mathf.Max(0.01f, duration));
				movingObject.position = Vector3.Lerp(startPos, point, Mathf.Clamp01(ReturnSmoothedValue(t)));
				elapsed += GetDeltaTime();
				yield return null;
			}
			movingObject.position = point;
			routine = null;
		}

		private float ReturnSmoothedValue(float t)
		{
			return movementSmooth switch
			{
				MovementSmooth.EASE_OUT => TweenFunctions.EaseOut(t),
				MovementSmooth.EASE_IN => TweenFunctions.EaseIn(t),
				MovementSmooth.SMOOTHSTEP => TweenFunctions.SmoothStep(t),
				MovementSmooth.SMOOTHERSTEP => TweenFunctions.SmootherStep(t),
				_ => TweenFunctions.Linear(t),
			};
		}
	}
}
