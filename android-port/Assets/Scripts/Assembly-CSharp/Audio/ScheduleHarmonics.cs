using UnityEngine;

namespace Audio
{
	public class ScheduleHarmonics : MonoBehaviour
	{
		public enum PlayMode
		{
			Ascending = 0,
			Descending = 1,
			PingPong = 2
		}

		public AudioClip clip;

		public float baseTimeInterval;

		public int baseNote;

		public bool ascendingOnEachPlay;

		public int minStartNote;

		public int maxStartNote;

		public int StopOnIncrement;

		public MusicMathUtils.Scale scale;

		public PlayMode playMode;

		private float nextEventTime;

		private ScheduleAudio scheduler;

		private bool init;

		private int m_BaseNote;

		private int m_IncrementPerPlay;

		public bool isPlaying { get; private set; }

		public float speedMultiplier { get; set; }

		public int m_NoteIncrement { get; private set; }

		private void Start()
		{
		}

		public void StartScheduleLoop()
		{
		}

		public void StopScheduleLoop()
		{
		}

		private void FixedUpdate()
		{
		}

		private int NoteByPlaymode()
		{
			return 0;
		}

		private int ReturnNote(int index)
		{
			return 0;
		}

		public void SetVolume(float v)
		{
		}
	}
}
