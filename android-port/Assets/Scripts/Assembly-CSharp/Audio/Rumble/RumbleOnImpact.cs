using Core;
using UnityEngine;

namespace Audio.Rumble
{
	public class RumbleOnImpact : MonoBehaviour
	{
		public float minVelocity;

		public float maxVelocity;

		public float cooldown;

		public VelocityRumble[] velocityRumble;

		public LayerMask layerMask;

		private GolfBallController ballController;

		private float nextPlayTime;

		private void Awake()
		{
		}

		public void OnCollisionRemote(HitInfo hitInfo)
		{
		}

		private void HandleHit(float velocityMagnitude)
		{
		}
	}
}
