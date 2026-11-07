using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TennisGolf
{
	public class TennisBall : MonoBehaviour
	{
		[SerializeField]
		private GameObject player;

		[SerializeField]
		private GameObject opponent;

		[SerializeField]
		private int numberOfBounces;

		[SerializeField]
		private GameObject lastHitter;

		[SerializeField]
		private LayerMask groundMask;

		[SerializeField]
		private Transform model;

		[SerializeField]
		private float stretchAmount;

		[SerializeField]
		private float stretchTime;

		[SerializeField]
		private GameObject playerCourt;

		[SerializeField]
		private GameObject opponentCourt;

		[SerializeField]
		private List<AudioClip> hitSounds;

		[SerializeField]
		private List<AudioClip> gruntSounds;

		[SerializeField]
		private bool useGruntSounds;

		public bool GameOver;

		public Action OnPlayerWon;

		public Action OnOpponentWon;

		private float delay;

		private Coroutine stretchRoutine;

		private Vector3 currentTarget;

		private float LoseTimer;

		public bool DontUpdate;

		private void Update()
		{
		}

		private void OnCollisionEnter(Collision other)
		{
		}

		private void OnTriggerEnter(Collider other)
		{
		}

		public virtual void CheckCollision(string collidingTag, GameObject hit)
		{
		}

		private void Win()
		{
		}

		private void Lose()
		{
		}

		public void SetLastHitter(GameObject go)
		{
		}

		public GameObject GetLastHitter()
		{
			return null;
		}

		public Vector3 GetCurrentTarget()
		{
			return default;
		}

		public void ResetBounces()
		{
		}

		private void SetDelay()
		{
		}

		private IEnumerator Stretch(Vector3 normal)
		{
			return null;
		}

		public Vector3 CalculateVelocityForTarget(Vector3 startPosition, Vector3 target, float initialAngle)
		{
			return default;
		}
	}
}
