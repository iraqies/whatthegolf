using System;
using UnityEngine;

namespace Audio
{
	public class CollisionEventSettings : MonoBehaviour, IAudioEvent, ISetRigidbodyRoot
	{
		[SerializeField]
		private float minVelocity;

		[SerializeField]
		private float maxVelocity;

		[SerializeField]
		private bool includeAbove;

		private GameObject root;

		private bool m_initialized;

		private RigidbodyCollisionInfo collisionInfo;

		public Action<Vector3> OnAudioEvent { get; set; }

		public GameObject GetRoot => null;

		public void SetRoot(GameObject _root)
		{
		}

		public void AddCollisionInfo()
		{
		}

		private void CollisionInfo_OnTrigger(TriggerInfo obj)
		{
		}

		private void CollisionInfo_OnCollision(HitInfo obj)
		{
		}
	}
}
