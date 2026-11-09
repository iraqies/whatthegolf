using System.Collections.Generic;
using Audio.Rumble;
using Core;
using UnityEngine;

namespace Audio
{
	public class GolfPullSimple : MonoBehaviour
	{
		public GolfBallController ball;
		public float minVolume = 0.1f;
		public float maxVolume = 0.5f;
		public float minPitch = 1f;
		public float maxPitch = 1.5f;
		public float smoothTime = 0.1f;
		public float gainSmooth = 0.1f;
		public float minDiff = 0.001f;
		public ClipSettingsCollection startPullSFX;
		public ClipSettingsCollection cancelPullSFX;
		public float oneshotVolume = 0.2f;
		public float oneshotVolumeDeviance = 0.05f;
		public float oneshotPitch = 1.1f;
		public float oneshotPitchDeviance = 0.08f;
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
		private bool wasCanceled = true;
		[SerializeField] private AudioClip _hapticsClip;

		public AudioSource source { get; private set; }
		public AudioSource hapticsSource { get; private set; }
		public AudioSource gamepadSpeakerSource { get; private set; }

		private void Awake()
		{
			source = GetComponent<AudioSource>();
		}

		private void OnDisable()
		{
			if (source != null)
				source.Stop();
		}

		public void Ball_OnAimStart()
		{
			if (source == null)
				source = GetComponent<AudioSource>();
			if (source != null)
			{
				source.volume = 0f;
				source.pitch = minPitch;
				m_smooth = 0f;
				m_gain = 0f;
				source.Play();
			}
			canPlayCloseClip = false;
			if (startPullSFX != null)
				startPullSFX.Play(Vector3.zero, 1f, 1f);
		}

		public void Stop()
		{
			if (source != null)
				source.Stop();
			if (AudioManager.Instance != null && AudioManager.Instance.rumbleManager != null && ball != null)
				AudioManager.Instance.rumbleManager.StopVibration(ball.PlayerIndex);
		}

		public void Ball_OnAimUpdate(Vector3 arg1, bool arg2)
		{
			float mag = arg1.magnitude;
			float diff = Mathf.Abs(mag - m_lastSmooth);
			m_lastSmooth = mag;
			float targetGain = AudioUtility.NormalizeMinMax01(diff, 0.05f, 0.15f);
			m_gain = Mathf.SmoothDamp(m_gain, targetGain, ref m_gainVelocity, gainSmooth, 10f, Time.unscaledDeltaTime);
			if (source != null)
			{
				source.volume = Mathf.Lerp(minVolume, maxVolume, m_smooth) * m_gain;
				source.pitch = Mathf.Lerp(minPitch, maxPitch, m_smooth);
			}
			m_target = mag;
			m_smooth = Mathf.SmoothDamp(m_smooth, m_target, ref m_velocity, smoothTime, 10f, Time.unscaledDeltaTime);
			if (mag > 0.1f)
				canPlayCloseClip = true;
			m_lastBoost = mag;
			if (ball != null)
				wasCanceled = ball.IsCanceled;
		}

		public void StopAim()
		{
			if (!canPlayCloseClip || m_lastBoost <= 0.1f)
				return;
			if (cancelPullSFX != null)
				cancelPullSFX.Play(Vector3.zero, 1f, 1f);
			if (AudioManager.Instance != null && AudioManager.Instance.rumbleManager != null && ball != null)
				AudioManager.Instance.rumbleManager.StopVibration(ball.PlayerIndex);
		}

		public void Ball_OnPreShoot(Vector3 obj)
		{
			if (source != null)
				source.Stop();
			if (ball == null || ball.IsCanceled || ball.BlockShooting)
				return;
			float mag = obj.magnitude;
			if (mag > 0.6f)
			{
				if (shootHighRumble != null)
					shootHighRumble.Play(ball.PlayerIndex, 1f);
				else if (shootLowRumble != null)
					shootLowRumble.Play(ball.PlayerIndex, 1f);
			}
			else if (shootLowRumble != null)
			{
				shootLowRumble.Play(ball.PlayerIndex, 1f);
			}
		}
	}
}
