using System.Collections.Generic;
using Audio;
using UnityEngine;

namespace BustAMoveGolf
{
	public class BustAMoveBall : MonoBehaviour
	{
		public BustAMoveColor Color;

		public BustAMoveBall[] neighbors = new BustAMoveBall[6];

		public bool even;

		public bool moving;

		public bool attached;

		public RandomAudioClips snapClips;

		public RandomAudioClips bounceClips;

		private SimplexGridManager simplexGridManager;

		private int bounces;

		public Vector3 velocity;

		private void Awake()
		{
			simplexGridManager = Object.FindObjectOfType<SimplexGridManager>();
			if (neighbors == null || neighbors.Length != 6)
			{
				neighbors = new BustAMoveBall[6];
			}
		}

		public static BustAMoveColor GetRandomColor()
		{
			return (BustAMoveColor)Random.Range(0, 4);
		}

		public void Fall()
		{
			attached = false;
			moving = false;
			DisconnectFromNeighbors();
			Rigidbody rb = GetComponent<Rigidbody>();
			if (rb != null)
			{
				rb.isKinematic = false;
				rb.useGravity = true;
			}
		}

		public void DisconnectFromNeighbors()
		{
			if (neighbors == null)
			{
				return;
			}
			for (int i = 0; i < neighbors.Length; i++)
			{
				BustAMoveBall n = neighbors[i];
				if (n != null && n.neighbors != null)
				{
					for (int j = 0; j < n.neighbors.Length; j++)
					{
						if (n.neighbors[j] == this)
						{
							n.neighbors[j] = null;
						}
					}
				}
				neighbors[i] = null;
			}
		}

		private void OnDrawGizmos()
		{
		}

		public void UpdateNeighbors()
		{
		}

		private void OnCollisionEnter(Collision col)
		{
			if (attached || col == null || simplexGridManager == null)
			{
				return;
			}
			BustAMoveBall otherBall = col.gameObject.GetComponent<BustAMoveBall>();
			if (otherBall != null && otherBall.attached)
			{
				if (snapClips != null)
				{
					AudioManager.PlaySFX(snapClips, transform.position);
				}
				simplexGridManager.SnapToBallGrid(this, otherBall);
			}
			else if (simplexGridManager.Ceiling != null && col.rigidbody == simplexGridManager.Ceiling)
			{
				if (snapClips != null)
				{
					AudioManager.PlaySFX(snapClips, transform.position);
				}
				simplexGridManager.SnapToCeiling(this);
			}
			else if (bounceClips != null)
			{
				bounces++;
				AudioManager.PlaySFX(bounceClips, transform.position);
			}
		}

		public void SetColor(BustAMoveColor color)
		{
			Color = color;
			if (simplexGridManager == null)
			{
				simplexGridManager = Object.FindObjectOfType<SimplexGridManager>();
			}
			if (simplexGridManager != null)
			{
				Renderer r = GetComponentInChildren<Renderer>();
				Material mat = simplexGridManager.GetMaterialFromColor(color);
				if (r != null && mat != null)
				{
					r.sharedMaterial = mat;
				}
			}
		}

		public BustAMoveBall[] FindBallsConnectedByColor()
		{
			List<BustAMoveBall> visited = new List<BustAMoveBall>();
			Queue<BustAMoveBall> queue = new Queue<BustAMoveBall>();
			visited.Add(this);
			queue.Enqueue(this);
			while (queue.Count > 0)
			{
				BustAMoveBall cur = queue.Dequeue();
				if (cur.neighbors == null)
				{
					continue;
				}
				for (int i = 0; i < cur.neighbors.Length; i++)
				{
					BustAMoveBall n = cur.neighbors[i];
					if (n != null && n.attached && n.Color == Color && !visited.Contains(n))
					{
						visited.Add(n);
						queue.Enqueue(n);
					}
				}
			}
			return visited.ToArray();
		}

		public bool CheckIfConnctedToAttachedBall()
		{
			if (attached)
			{
				return true;
			}
			if (neighbors == null)
			{
				return false;
			}
			for (int i = 0; i < neighbors.Length; i++)
			{
				if (neighbors[i] != null && neighbors[i].attached)
				{
					return true;
				}
			}
			return false;
		}
	}
}
