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

		public int columns;

		public int rows;

		public RandomAudioClips BallMatchOneshot;

		private BustAMoveBall[,] grid;

		public float radius;

		private Vector3[] ceilingPositions;

		public bool BallActive;

		public float YSpacing => 0f;

		private void Awake()
		{
		}

		private void OnComplete(Level.CompletedState completedState)
		{
		}

		private void MoveCeilingDown()
		{
		}

		private void AssignAllNeighbors()
		{
		}

		private void AssignNeighbors(BustAMoveBall ball)
		{
		}

		private BustAMoveBall[] FindNeighbors(BustAMoveBall ball)
		{
			return null;
		}

		private void OnDrawGizmos()
		{
		}

		public void SnapToCeiling(BustAMoveBall snapBall)
		{
		}

		public void SnapToBallGrid(BustAMoveBall snapBall, BustAMoveBall colBall)
		{
		}

		private void DestroyBall(BustAMoveBall ball)
		{
		}

		private Vector3[] GetNeighborPositions(BustAMoveBall ball)
		{
			return null;
		}

		public Material GetMaterialFromColor(BustAMoveColor color)
		{
			return null;
		}
	}
}
