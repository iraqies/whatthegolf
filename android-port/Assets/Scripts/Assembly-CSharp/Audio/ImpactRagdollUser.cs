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
			if (controller != null)
			{
				controller.OnPreShoot -= Controller_OnPreShoot;
				controller.OnPreShoot += Controller_OnPreShoot;
			}
			if (GetFirstRigidbodyInParent && ragdollSettings == null)
			{
				ragdollSettings = GetComponentInParent<RagdollLimbSettings>();
			}
			if (ragdollSettings != null)
			{
				LimbGroup group = null;
				switch (limbGroupType)
				{
					case LimbGroupType.Head:
						group = ragdollSettings.Head;
						break;
					case LimbGroupType.Arms:
						group = ragdollSettings.Arms;
						break;
					case LimbGroupType.Torso:
						group = ragdollSettings.Torso;
						break;
					case LimbGroupType.Legs:
						group = ragdollSettings.Legs;
						break;
				}
				if (group != null)
				{
					group.onGroupCollision -= OnHit;
					group.onGroupCollision += OnHit;
				}
			}
		}

		private void Controller_OnPreShoot(Vector3 obj)
		{
			lastShotTime = Time.time;
		}

		protected override bool Validate(HitInfo info)
		{
			if (!base.Validate(info))
				return false;
			if (useCooldownFromShot && controller != null)
			{
				return Time.time >= lastShotTime + cooldown;
			}
			return true;
		}
	}
}
