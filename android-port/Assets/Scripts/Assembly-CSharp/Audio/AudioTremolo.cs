using UnityEngine;

namespace Audio
{
	public class AudioTremolo : MonoBehaviour
	{
		[SerializeField]
		private float frequency;

		[SerializeField]
		private float depth;

		private float increment;

		private float phase;

		private float sampling_frequency;

		private void Awake()
		{
		}

		private void OnAudioFilterRead(float[] data, int channels)
		{
		}

		public void SetFrequency(float f)
		{
		}

		public void SetDepth(float d)
		{
		}
	}
}
