using System.Collections.Generic;
using UnityEngine;

namespace Audio
{
	public class OnCollisionAudioManyColliders : OnCollisionAudioBase
	{
		[SerializeField]
		private Rigidbody rigid;

		[SerializeField]
		private Rigidbody2D rigid2D;

		[SerializeField]
		private List<GameObject> parts;

		private RigidbodyCollisionInfo collisionInfo;

		private bool IsUsing2D => rigid2D != null;

		private bool IsUsingAnyRigidbody => rigid != null || rigid2D != null;

		private GameObject GetRootGameObject => rigid != null ? rigid.gameObject : (rigid2D != null ? rigid2D.gameObject : gameObject);

		private void Start()
		{
			OnEnable();
		}

		public void AddPart(GameObject go)
		{
			if (go == null) return;
			if (parts == null) parts = new List<GameObject>();
			if (!parts.Contains(go)) parts.Add(go);
			var ci = RigidbodyCollisionInfo.GetOrAdd(go);
			if (ci != null)
			{
				ci.onCollision -= CollisionInfo_OnCollision;
				ci.onCollision += CollisionInfo_OnCollision;
			}
		}

		private void OnValidate()
		{
		}

		private void OnEnable()
		{
			var rootGo = GetRootGameObject;
			if (rootGo != null)
			{
				collisionInfo = RigidbodyCollisionInfo.GetOrAdd(rootGo);
				if (collisionInfo != null)
				{
					collisionInfo.onCollision -= CollisionInfo_OnCollision;
					collisionInfo.onCollision += CollisionInfo_OnCollision;
				}
			}
			if (parts != null)
			{
				for (int i = 0; i < parts.Count; i++)
				{
					if (parts[i] == null) continue;
					var ci = RigidbodyCollisionInfo.GetOrAdd(parts[i]);
					if (ci != null)
					{
						ci.onCollision -= CollisionInfo_OnCollision;
						ci.onCollision += CollisionInfo_OnCollision;
					}
				}
			}
		}

		private void OnDisable()
		{
			if (collisionInfo != null)
				collisionInfo.onCollision -= CollisionInfo_OnCollision;
			if (parts != null)
			{
				for (int i = 0; i < parts.Count; i++)
				{
					if (parts[i] == null) continue;
					var ci = parts[i].GetComponent<RigidbodyCollisionInfo>();
					if (ci != null)
						ci.onCollision -= CollisionInfo_OnCollision;
				}
			}
		}

		private void CollisionInfo_OnCollision(HitInfo obj)
		{
			if (parts != null && parts.Count > 0 && obj.childHit != null && !parts.Contains(obj.childHit) && obj.childHit != GetRootGameObject)
				return;
			PlayAudioFromCollision(obj);
		}
	}
}
