using UnityEngine;

namespace Audio
{
	public class OnCollisionAudioRemoteMany : OnCollisionAudioBase
	{
		[SerializeField]
		private GameObject[] roots;

		private RigidbodyCollisionInfo[] collisionInfos;

		public GameObject[] GetRoots => null;

		private void Start()
		{
		}

		public void AddCollisionInfo()
		{
		}

		private void OnValidate()
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
