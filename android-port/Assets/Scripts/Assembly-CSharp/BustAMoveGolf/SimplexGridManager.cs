using System.Collections.Generic;
using Audio;
using Core;
using UnityEngine;

namespace BustAMoveGolf
{
	public class SimplexGridManager : MonoBehaviour
	{
		[SerializeField]
		private GameObject ballPrefab;

		[SerializeField]
		private Material redMaterial;

		[SerializeField]
		private Material blueMaterial;

		[SerializeField]
		private Material greenMaterial;

		[SerializeField]
		private Material yellowMaterial;

		public int CurrentRow;

		public Rigidbody Ceiling;

		public Rigidbody Flag;

		public int columns = 8;

		public int rows = 12;

		public RandomAudioClips BallMatchOneshot;

		private BustAMoveBall[,] grid;

		public float radius = 0.5f;

		private Vector3[] ceilingPositions;

		public bool BallActive;

		public float YSpacing => Mathf.Sqrt(3f) * radius;

		private void Awake()
		{
			grid = new BustAMoveBall[Mathf.Max(1, columns), Mathf.Max(1, rows)];
			ceilingPositions = new Vector3[Mathf.Max(1, columns)];
			AssignAllNeighbors();
			if (Level.HasInstance && Level.Instance != null)
			{
				Level.Instance.OnComplete += OnComplete;
			}
		}

		private void OnComplete(Level.CompletedState completedState)
		{
			BallActive = false;
		}

		private void MoveCeilingDown()
		{
			CurrentRow++;
			if (Ceiling != null)
			{
				Ceiling.transform.position += Vector3.back * YSpacing;
			}
		}

		private void AssignAllNeighbors()
		{
			BustAMoveBall[] all = Object.FindObjectsOfType<BustAMoveBall>();
			for (int i = 0; i < all.Length; i++)
			{
				if (all[i] != null && all[i].attached)
				{
					AssignNeighbors(all[i]);
				}
			}
		}

		private void AssignNeighbors(BustAMoveBall ball)
		{
			if (ball != null)
			{
				ball.neighbors = FindNeighbors(ball);
			}
		}

		private BustAMoveBall[] FindNeighbors(BustAMoveBall ball)
		{
			BustAMoveBall[] result = new BustAMoveBall[6];
			if (ball == null)
			{
				return result;
			}
			BustAMoveBall[] all = Object.FindObjectsOfType<BustAMoveBall>();
			int idx = 0;
			float maxDist = radius * 2.5f;
			for (int i = 0; i < all.Length && idx < 6; i++)
			{
				BustAMoveBall other = all[i];
				if (other != null && other != ball && other.attached && Vector3.Distance(ball.transform.position, other.transform.position) <= maxDist)
				{
					result[idx++] = other;
				}
			}
			return result;
		}

		private void OnDrawGizmos()
		{
		}

		public void SnapToCeiling(BustAMoveBall snapBall)
		{
			if (snapBall == null)
			{
				return;
			}
			snapBall.attached = true;
			snapBall.moving = false;
			Rigidbody rb = snapBall.GetComponent<Rigidbody>();
			if (rb != null)
			{
				rb.velocity = Vector3.zero;
				rb.isKinematic = true;
			}
			AssignAllNeighbors();
			BustAMoveBall[] matched = snapBall.FindBallsConnectedByColor();
			if (matched != null && matched.Length >= 3)
			{
				if (BallMatchOneshot != null)
				{
					AudioManager.PlaySFX(BallMatchOneshot, snapBall.transform.position);
				}
				for (int i = 0; i < matched.Length; i++)
				{
					DestroyBall(matched[i]);
				}
			}
		}

		public void SnapToBallGrid(BustAMoveBall snapBall, BustAMoveBall colBall)
		{
			if (snapBall == null || colBall == null)
			{
				return;
			}
			Vector3[] neighborPositions = GetNeighborPositions(colBall);
			Vector3 bestPos = snapBall.transform.position;
			float bestDist = float.PositiveInfinity;
			for (int i = 0; i < neighborPositions.Length; i++)
			{
				float d = Vector3.Distance(snapBall.transform.position, neighborPositions[i]);
				if (d < bestDist)
				{
					bestDist = d;
					bestPos = neighborPositions[i];
				}
			}
			snapBall.transform.position = bestPos;
			SnapToCeiling(snapBall);
		}

		private void DestroyBall(BustAMoveBall ball)
		{
			if (ball == null)
			{
				return;
			}
			ball.Fall();
			ball.gameObject.SetActive(false);
		}

		private Vector3[] GetNeighborPositions(BustAMoveBall ball)
		{
			Vector3 c = ball != null ? ball.transform.position : transform.position;
			float d = radius * 2f;
			float dy = YSpacing;
			return new Vector3[6]
			{
				c + new Vector3(-d, 0f, 0f),
				c + new Vector3(d, 0f, 0f),
				c + new Vector3(-radius, 0f, dy),
				c + new Vector3(radius, 0f, dy),
				c + new Vector3(-radius, 0f, -dy),
				c + new Vector3(radius, 0f, -dy)
			};
		}

		public Material GetMaterialFromColor(BustAMoveColor color)
		{
			return color switch
			{
				BustAMoveColor.Red => redMaterial,
				BustAMoveColor.Blue => blueMaterial,
				BustAMoveColor.Green => greenMaterial,
				BustAMoveColor.Yellow => yellowMaterial,
				_ => redMaterial,
			};
		}
	}
}
