using UnityEngine;

namespace Audio
{
	public class AudioTremolo : MonoBehaviour
	{
		[SerializeField]
		private float frequency = 4f;

		[SerializeField]
		private float depth = 0.4f;

		private float increment;

		private float phase;

		private float sampling_frequency = 44100f;

		private void Awake()
		{
			sampling_frequency = AudioSettings.outputSampleRate;
		}

		private void OnAudioFilterRead(float[] data, int channels)
		{
			if (data == null || sampling_frequency <= 0f)
				return;
			increment = frequency * 3.1415927f / sampling_frequency;
			for (int i = 0; i < data.Length; i += channels)
			{
				phase += increment;
				data[i] *= 1f - depth * Mathf.PingPong(phase, 1f);
				if (channels == 2 && i + 1 < data.Length)
					data[i + 1] = data[i];
				if (phase > 6.2831855f)
					phase = 0f;
			}
		}

		public void SetFrequency(float f)
		{
			frequency = f;
		}

		public void SetDepth(float d)
		{
			depth = d;
		}
	}
}
