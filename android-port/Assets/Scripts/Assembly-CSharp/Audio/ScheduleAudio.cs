using System;
using UnityEngine;

namespace Audio
{
	public class ScheduleAudio
	{
		private int flip;

		public AudioSource[] Players { get; }

		public AudioSource Current => null;

		public bool IsPlaying => false;

		public ScheduleAudio(Transform playerParent)
		{
		}

		public AudioSource ScheduleNew(AudioClip clip, double startTime, Action<AudioSource> modifier = null)
		{
			return null;
		}

		public void SetVolume(float v)
		{
		}
	}
}
