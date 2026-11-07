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

		private bool IsUsing2D => false;

		private bool IsUsingAnyRigidbody => false;

		private GameObject GetRootGameObject => null;

		private void Start()
		{
		}

		public void AddPart(GameObject go)
		{
		}

		private void OnValidate()
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
	}
}
