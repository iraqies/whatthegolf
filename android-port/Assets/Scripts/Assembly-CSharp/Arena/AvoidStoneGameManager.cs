using System.Collections;
using Audio;
using UnityEngine;
using Utility;

namespace Arena
{
	public class AvoidStoneGameManager : MonoBehaviour
	{
		public FreezeTimescale timeScaleFreeze;

		public FinalLevel finalLevelManager;

		public bool canSpawn;

		public float initialStartDelay;

		public AudioClipSettings transitionSFX;

		public ArenaCrab[] playerCrabs;

		public RockSpawnerPhase[] phases;

		public ArenaDroppableRock rockPrefab;

		private RockSpawnerPhase currentPhase;

		private bool allPlayersAtLastPoint;

		private bool someoneLost;

		private ObjectPool<ArenaDroppableRock> rockPool;

		private void Start()
		{
		}

		private void OnCrabHit(ArenaDroppable dropped, ArenaCrab hitCrab)
		{
		}

		private void OnPlayerHealthChanged(MultiplayerConfiguration.PlayerInfo player, int health)
		{
		}

		private void MovePlayerOnHit(MultiplayerConfiguration.PlayerInfo player)
		{
		}

		private bool CheckTransition(RockSpawnerPhase.TransitionCondition condition)
		{
			return false;
		}

		private IEnumerator SpawnCoroutine()
		{
			return null;
		}
	}
}
