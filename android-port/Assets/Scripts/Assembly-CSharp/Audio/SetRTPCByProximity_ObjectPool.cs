using System.Collections.Generic;
using UnityEngine;

namespace Audio
{
	public class SetRTPCByProximity_ObjectPool : MonoBehaviour
	{
		public float startRTPC;

		public Transform EndTarget;

		public float MinDistance;

		public float MaxDistance;

		public GameObject[] PoolContainer;

		private List<IObjectPooler> poolers;

		private float lastCheckTime;

		private void Start()
		{
		}

		private void Update()
		{
		}
	}
}
