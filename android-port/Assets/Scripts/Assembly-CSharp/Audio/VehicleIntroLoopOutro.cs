using System.Collections.Generic;
using Core;
using UnityEngine;

namespace Audio
{
	public class VehicleIntroLoopOutro : MonoBehaviour
	{
		public List<WheelJoint2D> joints;

		public GolfBallController ballController;

		public bool useEngine;

		public IntroLoopOutro introLoopOutro;

		public float minWheelSpeed;

		public float maxWheelSpeed;

		public float wheelMaxDelta;

		public float minVolume;

		public float maxVolume;

		public float minPitch;

		public float maxPitch;

		public bool useSuspension;

		public RandomAudioClips clips;

		public float minTranslation;

		public float maxTranslation;

		public float cooldown;

		public float maxRecordedSpeed;

		public float lastRecordedTranslation;

		public float maxRecordedTranslation;

		private float wheelSpeed;

		private float lastWheelSpeed;

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
