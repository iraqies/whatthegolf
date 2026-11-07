using Core;
using UnityEngine;

namespace Audio.Rumble
{
	public class RumbleOnRagdollImpact : MonoBehaviour
	{
		public float minVelocity;

		public float maxVelocity;

		public float cooldown;

		public VelocityRumble[] velocityRumble;

		public LayerMask layerMask;

		public LimbGroupType limbGroupType;

		public RagdollLimbSettings ragdollSettings;

		public GolfBallController golfballController;

		private float nextPlayTime;

		private int PlayerIndex => 0;

		private void Start()
		{
		}

		private void OnCollision(HitInfo obj)
		{
		}
	}
}
