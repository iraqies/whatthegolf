using System;
using UnityEngine;

namespace Audio
{
	public class LimbCollisionInfo : MonoBehaviour
	{
		public struct LimbHitInfo
		{
			public Vector3 point;

			public Vector3 impactOnNormal;

			public Transform limb;

			public Transform hit;
		}

		public Action<LimbHitInfo> onCollision;

		private void OnCollisionEnter(Collision col)
		{
		}

		private void OnCollisionEnter2D(Collision2D col)
		{
		}
	}
}
