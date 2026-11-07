using System.Collections.Generic;
using UnityEngine;

namespace Audio
{
	public class RagdollLimbSettings : MonoBehaviour
	{
		public LimbGroup Head;

		public LimbGroup Arms;

		public LimbGroup Torso;

		public LimbGroup Legs;

		public GameObject m_Root;

		public bool canHitSelf;

		public List<GameObject> m_AllLimbs;

		private RigidbodyCollisionInfo[] limbInfos;

		private void Awake()
		{
		}
	}
}
