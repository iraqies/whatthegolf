using UnityEngine;

namespace MusicGolf
{
	public class BeatObject : MonoBehaviour
	{
		public int Beat;

		public int Duration;

		public AudioSource StartClip;

		public AudioSource StopClip;

		public bool IsActive;

		public bool IsPlaying;

		public double LastStartTime;

		public virtual void PlayStart()
		{
		}

		public virtual void PlayProgress(float t)
		{
		}

		public virtual void PlayStop()
		{
		}
	}
}
