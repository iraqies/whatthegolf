using Audio;
using UnityEngine;

namespace BustAMoveGolf
{
	public class BustAMoveBall : MonoBehaviour
	{
		public BustAMoveColor Color;

		public BustAMoveBall[] neighbors;

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
		}

		public static BustAMoveColor GetRandomColor()
		{
			return BustAMoveColor.Red;
		}

		public void Fall()
		{
		}

		public void DisconnectFromNeighbors()
		{
		}

		private void OnDrawGizmos()
		{
		}

		public void UpdateNeighbors()
		{
		}

		private void OnCollisionEnter(Collision col)
		{
		}

		public void SetColor(BustAMoveColor color)
		{
		}

		public BustAMoveBall[] FindBallsConnectedByColor()
		{
			return null;
		}

		public bool CheckIfConnctedToAttachedBall()
		{
			return false;
		}
	}
}
