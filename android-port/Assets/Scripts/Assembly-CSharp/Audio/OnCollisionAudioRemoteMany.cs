using UnityEngine;

namespace Audio
{
	public class OnCollisionAudioRemoteMany : OnCollisionAudioBase
	{
		[SerializeField]
		private GameObject[] roots;

		private RigidbodyCollisionInfo[] collisionInfos;

		public GameObject[] GetRoots => roots;

		private void Start()
		{
			AddCollisionInfo();
		}

		public void AddCollisionInfo()
		{
			if (roots == null || roots.Length == 0) return;
			collisionInfos = new RigidbodyCollisionInfo[roots.Length];
			for (int i = 0; i < roots.Length; i++)
			{
				if (roots[i] == null) continue;
				var info = RigidbodyCollisionInfo.GetOrAdd(roots[i]);
				collisionInfos[i] = info;
				if (info != null)
				{
					info.onCollision -= CollisionInfo_OnCollision;
					info.onCollision += CollisionInfo_OnCollision;
					info.onTrigger -= CollisionInfo_OnTrigger;
					info.onTrigger += CollisionInfo_OnTrigger;
				}
			}
		}

		private void OnValidate()
		{
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
