using UnityEngine;

namespace Audio
{
	public class OnCollisionAudioRemote : OnCollisionAudioBase, ISetRigidbodyRoot
	{
		[SerializeField]
		private GameObject root;

		public bool AddRemoveCollInfoOnEnableDisable;

		private RigidbodyCollisionInfo collisionInfo;

		private bool m_initialized;

		public GameObject GetRoot => null;

		public void SetRoot(GameObject _root)
		{
		}

		private void Start()
		{
		}

		public void AddCollisionInfo()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void CollisionInfo_OnCollision(HitInfo obj)
		{
		}

		private void CollisionInfo_OnTrigger(TriggerInfo obj)
		{
		}
	}
}
