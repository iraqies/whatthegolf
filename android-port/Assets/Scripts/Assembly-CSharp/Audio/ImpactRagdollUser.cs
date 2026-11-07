using Core;
using UnityEngine;

namespace Audio
{
	public class ImpactRagdollUser : ImpactUser
	{
		[SerializeField]
		private LimbGroupType limbGroupType;

		[SerializeField]
		private RagdollLimbSettings ragdollSettings;

		[SerializeField]
		private bool useCooldownFromShot;

		[SerializeField]
		private GolfBallController controller;

		[SerializeField]
		private float cooldown;

		private float lastShotTime;

		private void Start()
		{
		}

		private void Controller_OnPreShoot(Vector3 obj)
		{
		}

		protected override bool Validate(HitInfo info)
		{
			return false;
		}
	}
}
