using UnityEngine;

namespace DanceOff
{
	public class Track : ScriptableObject
	{
		public int bpm;

		public DanceMove[] moves;

		public AudioClip loop;
	}
}
