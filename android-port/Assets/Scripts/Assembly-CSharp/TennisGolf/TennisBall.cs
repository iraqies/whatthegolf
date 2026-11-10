using System;
using System.Collections;
using System.Collections.Generic;
using Core;
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
		private LayerMask groundMask = -1;

		[SerializeField]
		private Transform model;

		[SerializeField]
		private float stretchAmount = 0.25f;

		[SerializeField]
		private float stretchTime = 0.15f;

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
			if (DontUpdate || GameOver)
			{
				return;
			}
			if (delay > 0f)
			{
				delay -= Time.deltaTime;
			}
		}

		private void OnCollisionEnter(Collision other)
		{
			if (GameOver || other == null)
			{
				return;
			}
			if (hitSounds != null && hitSounds.Count > 0)
			{
				AudioClip clip = hitSounds[UnityEngine.Random.Range(0, hitSounds.Count)];
				if (clip != null)
				{
					AudioManager.PlaySFX(clip, transform.position);
				}
			}
			if (model != null && other.contactCount > 0)
			{
				if (stretchRoutine != null)
				{
					StopCoroutine(stretchRoutine);
				}
				stretchRoutine = StartCoroutine(Stretch(other.GetContact(0).normal));
			}
			CheckCollision(other.gameObject.tag, other.gameObject);
		}

		private void OnTriggerEnter(Collider other)
		{
			if (GameOver || other == null)
			{
				return;
			}
			CheckCollision(other.gameObject.tag, other.gameObject);
		}

		public virtual void CheckCollision(string collidingTag, GameObject hit)
		{
			if (GameOver || delay > 0f || hit == null)
			{
				return;
			}
			if (hit == playerCourt || (playerCourt != null && hit.transform.IsChildOf(playerCourt.transform)))
			{
				numberOfBounces++;
				SetDelay();
				if (numberOfBounces >= 2)
				{
					Lose();
				}
			}
			else if (hit == opponentCourt || (opponentCourt != null && hit.transform.IsChildOf(opponentCourt.transform)))
			{
				numberOfBounces++;
				SetDelay();
				if (numberOfBounces >= 2)
				{
					Win();
				}
			}
		}

		private void Win()
		{
			if (GameOver)
			{
				return;
			}
			GameOver = true;
			OnPlayerWon?.Invoke();
			if (Level.HasInstance && Level.Instance != null)
			{
				Level.Instance.Complete();
			}
		}

		private void Lose()
		{
			if (GameOver)
			{
				return;
			}
			GameOver = true;
			OnOpponentWon?.Invoke();
			if (Level.HasInstance && Level.Instance != null)
			{
				Level.Instance.Fail(true);
			}
		}

		public void SetLastHitter(GameObject go)
		{
			lastHitter = go;
			ResetBounces();
			if (useGruntSounds && gruntSounds != null && gruntSounds.Count > 0)
			{
				AudioClip clip = gruntSounds[UnityEngine.Random.Range(0, gruntSounds.Count)];
				if (clip != null)
				{
					AudioManager.PlaySFX(clip, transform.position);
				}
			}
		}

		public GameObject GetLastHitter()
		{
			return lastHitter;
		}

		public Vector3 GetCurrentTarget()
		{
			return currentTarget;
		}

		public void ResetBounces()
		{
			numberOfBounces = 0;
		}

		private void SetDelay()
		{
			delay = 0.1f;
		}

		private IEnumerator Stretch(Vector3 normal)
		{
			if (model == null)
			{
				yield break;
			}
			Vector3 baseScale = Vector3.one;
			Vector3 squashed = new Vector3(1f + stretchAmount, Mathf.Max(0.25f, 1f - stretchAmount), 1f + stretchAmount);
			float half = Mathf.Max(0.03f, stretchTime * 0.5f);
			float t = 0f;
			while (t < half)
			{
				t += Time.deltaTime;
				model.localScale = Vector3.Lerp(baseScale, squashed, t / half);
				yield return null;
			}
			t = 0f;
			while (t < half)
			{
				t += Time.deltaTime;
				model.localScale = Vector3.Lerp(squashed, baseScale, t / half);
				yield return null;
			}
			model.localScale = baseScale;
		}

		public Vector3 CalculateVelocityForTarget(Vector3 startPosition, Vector3 target, float initialAngle)
		{
			currentTarget = target;
			float g = Mathf.Abs(Physics.gravity.y);
			float rad = Mathf.Clamp(initialAngle, 15f, 75f) * Mathf.Deg2Rad;
			Vector3 planarTarget = new Vector3(target.x, 0f, target.z);
			Vector3 planarStart = new Vector3(startPosition.x, 0f, startPosition.z);
			float dist = Vector3.Distance(planarTarget, planarStart);
			float yOffset = startPosition.y - target.y;
			float denom = Mathf.Cos(rad) * Mathf.Sin(rad) * dist + Mathf.Cos(rad) * Mathf.Cos(rad) * yOffset;
			if (denom <= 0.01f)
			{
				return (target - startPosition).normalized * 12f + Vector3.up * 5f;
			}
			float speed = (1f / Mathf.Cos(rad)) * Mathf.Sqrt(0.5f * g * dist * dist / (dist * Mathf.Tan(rad) + yOffset));
			if (float.IsNaN(speed) || float.IsInfinity(speed))
			{
				speed = 12f;
			}
			Vector3 localVel = new Vector3(0f, speed * Mathf.Sin(rad), speed * Mathf.Cos(rad));
			float angleBetween = Vector3.SignedAngle(Vector3.forward, (planarTarget - planarStart).normalized, Vector3.up);
			return Quaternion.AngleAxis(angleBetween, Vector3.up) * localVel;
		}
	}
}
