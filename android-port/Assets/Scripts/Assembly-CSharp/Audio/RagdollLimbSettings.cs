using System.Collections.Generic;
using UnityEngine;

namespace Audio
{
	public class RagdollLimbSettings : MonoBehaviour
	{
		public LimbGroup Head = new LimbGroup("Head");

		public LimbGroup Arms = new LimbGroup("Arms");

		public LimbGroup Torso = new LimbGroup("Torso");

		public LimbGroup Legs = new LimbGroup("Legs");

		public GameObject m_Root;

		public bool canHitSelf;

		public List<GameObject> m_AllLimbs = new List<GameObject>();

		private RigidbodyCollisionInfo[] limbInfos;

		private void Awake()
		{
			if (Head != null)
				Head.Init(m_AllLimbs, canHitSelf);
			if (Arms != null)
				Arms.Init(m_AllLimbs, canHitSelf);
			if (Torso != null)
				Torso.Init(m_AllLimbs, canHitSelf);
			if (Legs != null)
				Legs.Init(m_AllLimbs, canHitSelf);
		}
	}
}
