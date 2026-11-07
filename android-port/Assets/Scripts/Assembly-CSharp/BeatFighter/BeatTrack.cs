using UnityEngine;

namespace BeatFighter
{
	public class BeatTrack : ScriptableObject
	{
		public int bpm;

		public BeatTrackNote[] notes;

		public int length;

		public AudioClip loop;
	}
}
