using System;
using System.Collections.Generic;
using UnityEngine;

namespace Audio
{
	[Serializable]
	public class LimbGroup
	{
		public string name;

		public List<GameObject> m_CollideOnLimbs = new List<GameObject>();

		public Action<HitInfo> onGroupCollision;

		private HashSet<GameObject> m_allLimbs;

		private bool m_canHitSelf;

		private RigidbodyCollisionInfo[] m_colInfo { get; set; }

		public LimbGroup(string _name)
		{
			name = _name;
			m_CollideOnLimbs = new List<GameObject>();
		}

		public void Init(List<GameObject> allLimbs, bool canHitSelf)
		{
			if (m_CollideOnLimbs == null || m_CollideOnLimbs.Count == 0)
				return;
			m_allLimbs = allLimbs != null ? new HashSet<GameObject>(allLimbs) : new HashSet<GameObject>();
			m_canHitSelf = canHitSelf;
			m_colInfo = new RigidbodyCollisionInfo[m_CollideOnLimbs.Count];
			for (int i = 0; i < m_CollideOnLimbs.Count; i++)
			{
				GameObject limb = m_CollideOnLimbs[i];
				if (limb == null)
					continue;
				RigidbodyCollisionInfo ci = RigidbodyCollisionInfo.GetOrAdd(limb);
				m_colInfo[i] = ci;
				if (ci != null)
				{
					ci.onCollision -= OnGroupCollision;
					ci.onCollision += OnGroupCollision;
				}
			}
		}

		private void OnGroupCollision(HitInfo hit)
		{
			if (!m_canHitSelf && m_allLimbs != null && hit.otherHit != null && m_allLimbs.Contains(hit.otherHit))
				return;
			onGroupCollision?.Invoke(hit);
		}
	}
}
