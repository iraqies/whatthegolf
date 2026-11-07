using UnityEngine;

namespace Audio
{
	public class ImpactUserGround : ImpactUser
	{
		public float thresholdY;

		public float topLayerSkin;

		private MeshCollider m_MeshCollider;

		private Vector3 top;

		private float startcooldown;

		private void Awake()
		{
		}

		protected override bool Validate(HitInfo info)
		{
			return false;
		}
	}
}
