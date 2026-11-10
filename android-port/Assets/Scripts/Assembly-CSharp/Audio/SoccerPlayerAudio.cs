using System;
using UnityEngine;

namespace Audio
{
	public class SoccerPlayerAudio : MonoBehaviour
	{
		public SoccerPlayer soccerPlayer;

		public AudioSource gruntLoopAudioSource;

		public ClipSettingsCollection sfxGruntOnKick;

		public ClipSettingsCollection sfxKickSfx;

		private void Start()
		{
			if (soccerPlayer != null)
			{
				soccerPlayer.onKick = (Action)Delegate.Combine(soccerPlayer.onKick, new Action(OnSoccerPlayerKick));
			}
		}

		private void OnSoccerPlayerKick()
		{
			if (sfxGruntOnKick != null)
			{
				sfxGruntOnKick.Play(null, base.transform.position, 1f, 1f);
			}
			if (sfxKickSfx != null)
			{
				sfxKickSfx.Play(null, base.transform.position, 1f, 1f);
			}
		}
	}
}
