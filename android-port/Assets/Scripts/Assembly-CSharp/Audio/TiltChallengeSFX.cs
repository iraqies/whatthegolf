using UnityEngine;

namespace Audio
{
	public class TiltChallengeSFX : MonoBehaviour
	{
		[SerializeField]
		private ClipSettingsCollection clips;

		[SerializeField]
		private float maxPitch;

		private float queueDelay;

		private int amountToPlay;

		private float lastPlayTime;

		private float pitchIncrementPerTip;

		public void Init(int max)
		{
		}

		public void Play()
		{
		}

		private void Update()
		{
		}
	}
}
