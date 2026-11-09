using System.Collections;
using UnityEngine;

namespace Audio
{
	public class EvilFlagAudio : MonoBehaviour
	{
		public ClipSettingsCollection SFX_OnStop_NoHit;

		public ClipSettingsCollection SFX_OnSlide_Start;

		public ClipSettingsCollection SFX_OnHitFlag;

		public ScheduleHarmonics scheduleHarmonics;

		public Rigidbody rigid;

		private bool canPlay;

		private Vector3 lastVelocity;

		private bool moving;

		private bool hitFlag;

		private IEnumerator Start()
		{
			yield return new WaitForSeconds(0.2f);
			canPlay = true;
		}

		public void HitFlag()
		{
			hitFlag = true;
			if (moving && SFX_OnHitFlag != null)
			{
				SFX_OnHitFlag.Play(AudioUtility.GetVoice(AudioUtility.AudioManagerVoice.ShortEffects), transform.position, 0f);
			}
		}

		private void FixedUpdate()
		{
			if (!canPlay || rigid == null)
				return;

			float velMag = rigid.velocity.magnitude;
			float lastVelMag = lastVelocity.magnitude;

			if (scheduleHarmonics != null)
			{
				if (velMag > 0.1f && lastVelMag < 0.1f)
				{
					scheduleHarmonics.StartScheduleLoop();
				}
				if (velMag < 0.1f && lastVelMag > 0.1f)
				{
					scheduleHarmonics.StopScheduleLoop();
				}
			}
			else
			{
				if (velMag > 0.1f && lastVelMag < 0.1f)
				{
					moving = true;
					if (SFX_OnSlide_Start != null)
					{
						SFX_OnSlide_Start.Play(AudioUtility.GetVoice(AudioUtility.AudioManagerVoice.ShortEffects), transform.position, 0f);
						if (AudioManager.Instance != null && SFX_OnSlide_Start.LastAudioSource != null)
							AudioManager.Instance.AudioSourceFollowTransform(SFX_OnSlide_Start.LastAudioSource, transform, 0.5f);
					}
				}
				if (moving && velMag < 0.1f)
				{
					moving = false;
					if (!hitFlag && SFX_OnStop_NoHit != null)
					{
						SFX_OnStop_NoHit.Play(AudioUtility.GetVoice(AudioUtility.AudioManagerVoice.ShortEffects), transform.position, 0f);
					}
				}
				if (SFX_OnStop_NoHit != null && SFX_OnStop_NoHit.LastAudioSource != null && SFX_OnStop_NoHit.LastAudioSource.isPlaying && hitFlag)
				{
					SFX_OnStop_NoHit.LastAudioSource.Stop();
				}
			}

			lastVelocity = rigid.velocity;
		}
	}
}
