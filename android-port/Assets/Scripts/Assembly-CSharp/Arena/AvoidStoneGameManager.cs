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

		public bool canSpawn = true;

		public float initialStartDelay = 1f;

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
			if (playerCrabs != null)
			{
				for (int i = 0; i < playerCrabs.Length; i++)
				{
					if (playerCrabs[i] != null)
					{
						playerCrabs[i].OnCrabHit += OnCrabHit;
					}
				}
			}
			if (rockPrefab != null)
			{
				rockPool = new ObjectPool<ArenaDroppableRock>(rockPrefab.gameObject, 20);
			}
			if (phases != null)
			{
				for (int i = 0; i < phases.Length; i++)
				{
					if (phases[i] != null)
					{
						phases[i].RockPool = rockPool;
					}
				}
			}
			if (finalLevelManager != null)
			{
				finalLevelManager.PlayerHealthChanged += OnPlayerHealthChanged;
			}
			canSpawn = true;
			StartCoroutine(SpawnCoroutine());
		}

		private void OnCrabHit(ArenaDroppable dropped, ArenaCrab hitCrab)
		{
			if (someoneLost || hitCrab == null || hitCrab.isSquashed)
			{
				return;
			}
			if (dropped != null && dropped.hitPlayerSFX != null && AudioManager.Instance != null)
			{
				dropped.hitPlayerSFX.Play(AudioManager.Instance.impactEffects, hitCrab.transform.position, 1f, 1f);
			}
			if (timeScaleFreeze != null)
			{
				timeScaleFreeze.StartFreeze();
			}
			hitCrab.Squash();
			if (finalLevelManager != null)
			{
				finalLevelManager.PlayerHit(hitCrab.GetController());
			}
		}

		private void OnPlayerHealthChanged(MultiplayerConfiguration.PlayerInfo player, int health)
		{
			if (health <= 0)
			{
				someoneLost = true;
			}
			if (finalLevelManager != null && finalLevelManager.playerHealth != null)
			{
				bool allAtOne = true;
				foreach (var kvp in finalLevelManager.playerHealth)
				{
					if (kvp.Value > 1)
					{
						allAtOne = false;
						break;
					}
				}
				if (allAtOne)
				{
					allPlayersAtLastPoint = true;
				}
			}
		}

		private void MovePlayerOnHit(MultiplayerConfiguration.PlayerInfo player)
		{
		}

		private bool CheckTransition(RockSpawnerPhase.TransitionCondition condition)
		{
			return condition switch
			{
				RockSpawnerPhase.TransitionCondition.AllPlayerAtLastPoint => allPlayersAtLastPoint,
				RockSpawnerPhase.TransitionCondition.SomeoneDied => someoneLost,
				_ => false,
			};
		}

		private IEnumerator SpawnCoroutine()
		{
			yield return new WaitForSeconds(initialStartDelay);
			if (phases == null)
			{
				yield break;
			}
			for (int i = 0; i < phases.Length; i++)
			{
				currentPhase = phases[i];
				if (currentPhase == null)
				{
					continue;
				}
				if (CheckTransition(currentPhase.transitionCondition))
				{
					continue;
				}
				StartCoroutine(currentPhase.SpawnCoroutine());
				yield return new WaitUntil(() => currentPhase == null || !currentPhase.IsSpawning || CheckTransition(currentPhase.transitionCondition) || someoneLost);
				if (currentPhase != null)
				{
					currentPhase.IsSpawning = false;
				}
				if (someoneLost)
				{
					yield break;
				}
				yield return new WaitForSeconds(0.5f);
				if (transitionSFX != null && AudioManager.Instance != null)
				{
					transitionSFX.Play(AudioManager.Instance.impactEffects, Vector3.zero, 1f);
				}
				yield return new WaitForSeconds(0.5f);
			}
		}
	}
}
