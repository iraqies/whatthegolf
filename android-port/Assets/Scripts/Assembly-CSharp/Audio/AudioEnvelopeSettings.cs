using UnityEngine;

namespace Audio
{
	public class AudioEnvelopeSettings : MonoBehaviour
	{
		public ADSREnvelope envelope;

		public bool useOnThisObject;

		public bool selfTriggerEnvelope;

		private AudioSource audioSource;

		private uint samplesUntillTrigger;

		private bool sourceIsPlaying;

		private void Awake()
		{
		}

		private void Update()
		{
		}

		public void Trigger(double startTime, bool resetVolume = false)
		{
		}

		private void OnAudioFilterRead(float[] buffer, int numChannels)
		{
		}
	}
}
