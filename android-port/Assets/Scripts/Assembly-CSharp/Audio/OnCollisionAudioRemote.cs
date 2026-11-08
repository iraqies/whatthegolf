using UnityEngine;

namespace Audio
{
	public class OnCollisionAudioRemote : OnCollisionAudioBase, ISetRigidbodyRoot
	{
		[SerializeField] private GameObject root;
		public bool AddRemoveCollInfoOnEnableDisable;
		private RigidbodyCollisionInfo collisionInfo;
		private bool m_initialized;

		public GameObject GetRoot => root != null ? root : gameObject;

		public void SetRoot(GameObject _root)
		{
			root = _root;
			AddCollisionInfo();
		}

		private void Start()
		{
			AddCollisionInfo();
		}

		public void AddCollisionInfo()
		{
			if (m_initialized) return;
			var target = root != null ? root : (transform.parent != null ? transform.parent.gameObject : gameObject);
			collisionInfo = RigidbodyCollisionInfo.GetOrAdd(target);
			if (collisionInfo != null)
			{
				collisionInfo.onCollision += CollisionInfo_OnCollision;
				collisionInfo.onTrigger += CollisionInfo_OnTrigger;
				m_initialized = true;
			}
		}

		private void OnEnable()
		{
			if (AddRemoveCollInfoOnEnableDisable)
				AddCollisionInfo();
		}

		private void OnDisable()
		{
			if (AddRemoveCollInfoOnEnableDisable && collisionInfo != null && m_initialized)
			{
				collisionInfo.onCollision -= CollisionInfo_OnCollision;
				collisionInfo.onTrigger -= CollisionInfo_OnTrigger;
				m_initialized = false;
			}
		}

		private void CollisionInfo_OnCollision(HitInfo obj)
		{
			if (!useTrigger)
				PlayAudioFromCollision(obj);
		}

		private void CollisionInfo_OnTrigger(TriggerInfo obj)
		{
			if (useTrigger)
				PlayAudioFromTrigger(obj.otherHit);
		}
	}
}
