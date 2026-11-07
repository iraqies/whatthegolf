using System.Collections.Generic;
using Audio.Rumble;
using Core;
using UnityEngine;

namespace Audio
{
	public class GolfPullSimple : MonoBehaviour
	{
		public GolfBallController ball;

		public float minVolume;

		public float maxVolume;

		public float minPitch;

		public float maxPitch;

		public float smoothTime;

		public float gainSmooth;

		public float minDiff;

		public ClipSettingsCollection startPullSFX;

		public ClipSettingsCollection cancelPullSFX;

		public float oneshotVolume;

		public float oneshotVolumeDeviance;

		public float oneshotPitch;

		public float oneshotPitchDeviance;

		public List<AudioClip> openClips;

		public List<AudioClip> maxClips;

		public List<AudioClip> closeClips;

		public RumbleEventAsset shootLowRumble;

		public RumbleEventAsset shootHighRumble;

		private float m_lastBoost;

		private float m_smooth;

		private float m_lastSmooth;

		private float m_target;

		private float m_velocity;

		private float m_gain;

		private float m_gainVelocity;

		private bool canPlayCloseClip;

		private bool wasCanceled;

		[SerializeField]
		private AudioClip _hapticsClip;

		public AudioSource source { get; private set; }

		public AudioSource hapticsSource { get; private set; }

		public AudioSource gamepadSpeakerSource { get; private set; }

		private void Awake()
		{
		}

		private void OnDisable()
		{
		}

		public void Ball_OnAimStart()
		{
		}

		public void Stop()
		{
		}

		public void Ball_OnAimUpdate(Vector3 arg1, bool arg2)
		{
		}

		public void StopAim()
		{
		}

		public void Ball_OnPreShoot(Vector3 obj)
		{
		}
	}
}
