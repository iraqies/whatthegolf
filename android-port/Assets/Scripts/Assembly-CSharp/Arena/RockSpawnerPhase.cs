using System.Collections;
using UnityEngine;
using Utility;

namespace Arena
{
	public abstract class RockSpawnerPhase : MonoBehaviour
	{
		public enum TransitionCondition
		{
			AllPlayerAtLastPoint = 0,
			SomeoneDied = 1
		}

		public TransitionCondition transitionCondition;

		public abstract bool IsSpawning { get; set; }

		public Vector2[] CurrentSafeSpots { get; protected set; }

		public ObjectPool<ArenaDroppableRock> RockPool { get; set; }

		public abstract IEnumerator SpawnCoroutine();
	}
}
