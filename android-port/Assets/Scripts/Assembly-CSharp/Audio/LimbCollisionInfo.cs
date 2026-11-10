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
			if (onCollision == null || col == null || col.contactCount == 0)
				return;
			ContactPoint contact = col.GetContact(0);
			LimbHitInfo info = default;
			info.point = contact.point;
			info.impactOnNormal = Vector3.Project(col.relativeVelocity, contact.normal);
			info.limb = transform;
			info.hit = col.transform;
			onCollision.Invoke(info);
		}

		private void OnCollisionEnter2D(Collision2D col)
		{
			if (onCollision == null || col == null || col.contactCount == 0)
				return;
			ContactPoint2D contact = col.GetContact(0);
			LimbHitInfo info = default;
			info.point = contact.point;
			info.impactOnNormal = Vector3.Project(col.relativeVelocity, contact.normal);
			info.limb = transform;
			info.hit = col.transform;
			onCollision.Invoke(info);
		}
	}
}
