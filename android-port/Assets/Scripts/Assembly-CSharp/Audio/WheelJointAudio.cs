using System.Collections.Generic;
using UnityEngine;

namespace Audio
{
	public class WheelJointAudio : MonoBehaviour
	{
		public List<WheelJoint2D> joints;

		public AudioSource engineAudioSource;

		public float maxWheelSpeed;

		public float wheelMaxDelta;

		public float minVolume;

		public float maxVolume;

		public float minPitch;

		public float maxPitch;

		public RandomAudioClips clips;

		public float minTranslation;

		public float maxTranslation;

		public float cooldown;

		public float maxRecordedSpeed;

		public float lastRecordedTranslation;

		public float maxRecordedTranslation;

		private float wheelSpeed;

		private float nextEventTime;

		private void Awake()
		{
		}

		private void Update()
		{
		}

		private void HandleWheelspeed()
		{
		}

		private void HandleSuspension()
		{
		}
	}
}
