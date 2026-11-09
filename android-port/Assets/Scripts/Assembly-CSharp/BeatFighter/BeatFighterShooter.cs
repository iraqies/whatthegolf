using Core;
using UnityEngine;

namespace BeatFighter
{
	public class BeatFighterShooter : ShooterBase
	{
		[SerializeField]
		private BeatFighterSequencer sequencer;

		[SerializeField]
		private Animator animator;

		[SerializeField]
		private BeatTrackAction[] possibleActions;

		private BeatTrackAction currentAction;

		public override void OnShoot(Vector3 boost)
	{
		base.OnShoot(boost);
	}
	}
}
