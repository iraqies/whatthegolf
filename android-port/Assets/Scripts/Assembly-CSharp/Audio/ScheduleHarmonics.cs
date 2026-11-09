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

		public float baseTimeInterval = 0.2f;

		public int baseNote = 60;

		public bool ascendingOnEachPlay;

		public int minStartNote = -1;

		public int maxStartNote = 4;

		public int StopOnIncrement = -1;

		public MusicMathUtils.Scale scale;

		public PlayMode playMode;

		private float nextEventTime;

		private ScheduleAudio scheduler;

		private bool init;

		private int m_BaseNote;

		private int m_IncrementPerPlay;

		public bool isPlaying { get; private set; }

		public float speedMultiplier { get; set; } = 1f;

		public int m_NoteIncrement { get; private set; }

		private void Start()
		{
			scheduler = new ScheduleAudio(transform);
			m_NoteIncrement = minStartNote;
			init = true;
		}

		public void StartScheduleLoop()
		{
			int startNote;
			if (ascendingOnEachPlay)
			{
				m_IncrementPerPlay++;
				int range = Mathf.Max(1, maxStartNote - minStartNote);
				m_IncrementPerPlay %= range;
				startNote = minStartNote + m_IncrementPerPlay;
			}
			else
			{
				startNote = Random.Range(minStartNote, maxStartNote);
			}
			m_BaseNote = startNote;
			m_NoteIncrement = 0;
			isPlaying = true;
		}

		public void StopScheduleLoop()
		{
			isPlaying = false;
		}

		private void FixedUpdate()
		{
			if (!isPlaying) return;
			float interval = baseTimeInterval;
			float lookahead = interval - 0.1f;
			if (Time.fixedTime <= nextEventTime - lookahead)
				return;

			float spd = Mathf.Max(0.1f, speedMultiplier);
			nextEventTime = Time.fixedTime + lookahead + interval / spd;

			int noteIdx = m_BaseNote + (playMode == PlayMode.Descending ? -m_NoteIncrement : m_NoteIncrement);
			int midiNote = ReturnNote(noteIdx);
			float pitch = MusicMathUtils.MidiNoteToPitch(midiNote, 60);

			if (scheduler != null && clip != null)
			{
				scheduler.ScheduleNew(clip, AudioSettings.dspTime + (double)lookahead, src =>
				{
					if (src != null) src.pitch = pitch;
				});
			}

			m_NoteIncrement++;
			if (StopOnIncrement >= 0 && m_NoteIncrement == StopOnIncrement)
				isPlaying = false;
		}

		private int NoteByPlaymode()
		{
			if (playMode == PlayMode.Ascending)
				return ReturnNote(m_BaseNote + m_NoteIncrement);
			if (playMode == PlayMode.Descending)
				return ReturnNote(m_BaseNote - m_NoteIncrement);
			return 0;
		}

		private int ReturnNote(int index)
		{
			int[] notes = MusicMathUtils.ReturnScaleNotes(scale);
			if (notes == null || notes.Length == 0)
				return baseNote + index;
			int octave = 0;
			while (index < 0)
			{
				index += notes.Length;
				octave--;
			}
			while (index >= notes.Length)
			{
				index -= notes.Length;
				octave++;
			}
			return baseNote + octave * 12 + notes[index];
		}

		public void SetVolume(float v)
		{
			if (scheduler != null && scheduler.Players != null)
			{
				for (int i = 0; i < scheduler.Players.Length; i++)
				{
					if (scheduler.Players[i] != null)
						scheduler.Players[i].volume = v;
				}
			}
		}
	}
}
