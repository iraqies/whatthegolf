using System.Collections;
using Core;
using UnityEngine;
using UnityEngine.Audio;

namespace Audio
{
	public class HarmonikaDyrAudioV3 : MonoBehaviour
	{
		public HarmonikaDyrShooter harmonika;

		public AudioClip clipOut;

		public AudioMixerGroup mixerGroup;

		public int fullStretchNoteAmount;

		public int baseNote;

		public MusicMathUtils.Scale scale;

		private int randomBase;

		private float currDistance;

		private int lastNote;

		private ScheduleAudio scheduler;

		private bool init;

		private float lastDist;

		private void Start()
		{
		}

		private IEnumerator DelayedInit()
		{
			return null;
		}

		private int ReturnNote(int index)
		{
			return 0;
		}

		private void Update()
		{
		}
	}
}
