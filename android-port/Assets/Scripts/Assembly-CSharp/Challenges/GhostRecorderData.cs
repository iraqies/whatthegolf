using System.Collections.Generic;
using UnityEngine;

namespace Challenges
{
	public class GhostRecorderData : MonoBehaviour
	{
		public Transform recordObject;

		public GameObject[] DisableObjects;

		public bool record;

		public float recordInterval;

		public List<ChallengeGhostRecorder.GhostData> data;

		private float m_recordTimer;

		private float m_timeAtStart;

		public void StartRecording()
		{
		}

		private void Update()
		{
		}
	}
}
