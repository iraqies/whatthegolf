using System.Collections.Generic;
using Core;

namespace Challenges.ChallengeCompletors
{
	public class UfoChallenge : Challenge
	{
		public List<BeamableObject> objectsToBeam;

		private GolfBallController controller;

		private List<BeamableObject> _beamedObjects;

		protected override void Activate()
		{
		}

		private void OnBeamed(BeamableObject obj)
		{
		}
	}
}
