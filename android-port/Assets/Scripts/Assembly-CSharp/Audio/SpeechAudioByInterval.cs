namespace Audio
{
	public abstract class SpeechAudioByInterval : SpeechAudioBase
	{
		public AudioAttribute interval;

		protected float m_nextSoundTime;

		protected override void PlayClip()
		{
		}
	}
}
