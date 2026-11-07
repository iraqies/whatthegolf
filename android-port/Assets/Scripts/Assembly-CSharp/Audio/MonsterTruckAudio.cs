using Core;
using UnityEngine;

namespace Audio
{
	public class MonsterTruckAudio : MonoBehaviour
	{
		private enum CarState
		{
			Grounded = 0,
			NonGrounded = 1
		}

		public WheelCollider[] wheels;

		public GolfBallController controller;

		public float minRPM;

		public float maxRPM;

		public int decreaseVolumeOverShots;

		public RandomAudioClips RevClips;

		public RandomAudioClips DirtClips;

		public RandomAudioClips FailExhaustClips;

		public float steerDirtThreshold;

		public AudioSource RevAudiosource;

		public AudioSource DirtAudiosource;

		public float RPM;

		private float shootClipGain;

		private float lastSteering;

		private int shots;

		private float shotTimer;

		private float shotTimeCooldown;

		private float nextSoundTime;

		private int wheelsGrounded;

		private CarState state;

		private int WheelsGrounded()
		{
			return 0;
		}

		private void Start()
		{
		}

		private void OnShoot(Vector3 boost)
		{
		}

		private void OnShootWhileBlocked(Vector3 boost)
		{
		}

		private void PlayRev()
		{
		}

		private void PlayPuff()
		{
		}

		private void Update()
		{
		}
	}
}
