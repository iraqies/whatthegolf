using Core;
using UnityEngine;

namespace Challenges.ChallengeCompletors
{
	public class Par2DChallenge : Challenge
	{
		public int ScoreToBeat;

		public bool AutoFail;

		public float AutoFailThreshold;

		public float AutoFailTimer;

		private GolfBallController controller;

		public Rigidbody2D controllerRigid;

		private bool checkVelocity;

		private float m_failTimer;

		protected override void Activate()
		{
		}

		public override string GetDescription()
		{
			return null;
		}

		public override string GetWinMessageID()
		{
			return null;
		}

		private void OnHasShot(GolfBallController controller, int strokes)
		{
		}

		private void OnShoot(Vector3 v)
		{
		}

		protected override void ChallengeUpdate()
		{
		}

		public override void OnLevelComplete(Level.CompletedState completedState)
		{
		}
	}
}
