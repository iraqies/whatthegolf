using System;
using System.Collections.Generic;
using UnityEngine;

namespace Audio
{
	[Serializable]
	public class LimbGroup
	{
		public string name;

		public List<GameObject> m_CollideOnLimbs;

		public Action<HitInfo> onGroupCollision;

		private HashSet<GameObject> m_allLimbs;

		private bool m_canHitSelf;

		private RigidbodyCollisionInfo[] m_colInfo { get; set; }

		public LimbGroup(string _name)
		{
		}

		public void Init(List<GameObject> allLimbs, bool canHitSelf)
		{
		}

		private void OnGroupCollision(HitInfo hit)
		{
		}
	}
}
