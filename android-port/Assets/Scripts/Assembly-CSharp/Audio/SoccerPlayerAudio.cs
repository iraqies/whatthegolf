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
		}

		private void OnSoccerPlayerKick()
		{
		}
	}
}
