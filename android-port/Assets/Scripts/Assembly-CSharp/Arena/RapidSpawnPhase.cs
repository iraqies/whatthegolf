using System.Collections;
using Core;
using UnityEngine;

namespace Arena
{
	public class RapidSpawnPhase : MonoBehaviour
	{
		public AvoidStoneGameManager GameManager;

		public Transform FollowPivot;

		public Transform ProjectileOrigin;

		public Rigidbody ProjectilePrefab;

		public float Interval = 0.5f;

		public Vector2 MinMaxVerticalForce = new Vector2(5f, 10f);

		public Vector2 MinMaxHorizontalForce = new Vector2(10f, 20f);

		private Transform playerTransform;

		private bool active;

		private Coroutine spawnRoutine;

		private void Start()
		{
			GolfBallController gbc = Object.FindObjectOfType<GolfBallController>();
			if (gbc != null)
			{
				playerTransform = gbc.transform;
			}
		}

		public void SetActive(bool value)
		{
			if (active == value)
			{
				return;
			}
			active = value;
			if (active)
			{
				spawnRoutine = StartCoroutine(SpawnPhaseCoroutine());
			}
			else if (spawnRoutine != null)
			{
				StopCoroutine(spawnRoutine);
				spawnRoutine = null;
			}
		}

		private void Update()
		{
			if (active && FollowPivot != null && playerTransform != null)
			{
				FollowPivot.LookAt(playerTransform);
			}
		}

		private IEnumerator SpawnPhaseCoroutine()
		{
			while (active)
			{
				if (ProjectilePrefab != null && ProjectileOrigin != null)
				{
					Rigidbody proj = Object.Instantiate(ProjectilePrefab, ProjectileOrigin.position, Quaternion.identity);
					Vector3 force = ProjectileOrigin.forward * Random.Range(MinMaxHorizontalForce.x, MinMaxHorizontalForce.y)
						+ Vector3.up * Random.Range(MinMaxVerticalForce.x, MinMaxVerticalForce.y);
					proj.AddForce(force, ForceMode.VelocityChange);
					proj.AddTorque(Random.insideUnitSphere * 360f);
					if (GameManager != null)
					{
						GameManager.RegisterRigidBody(proj);
					}
				}
				yield return new WaitForSeconds(Interval);
			}
		}
	}
}
