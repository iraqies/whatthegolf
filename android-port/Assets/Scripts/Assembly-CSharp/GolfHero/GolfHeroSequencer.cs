using System.Collections;
using System.Collections.Generic;
using Audio;
using Core;
using UnityEngine;

namespace GolfHero
{
	public class GolfHeroSequencer : MonoBehaviour
	{
		private class Note
		{
			public int beat;

			public MusicPieceNote noteData;

			public NoteTarget noteTarget;

			public LineRenderer line;
		}

		[SerializeField]
		private bool playAudioClips;

		[SerializeField]
		private MusicPiece piece;

		[SerializeField]
		private Transform notesRoot;

		[SerializeField]
		private GolfHeroShooter shooter;

		[SerializeField]
		private NoteTarget noteTargetPrefab;

		[SerializeField]
		private int numberOfAudioSources;

		[SerializeField]
		private AudioSource loopAudioSource;

		[SerializeField]
		private double timeBeforeStart;

		[SerializeField]
		private Camera visualsCamera;

		[SerializeField]
		private Color[] colors;

		[SerializeField]
		private ClipSettingsCollection sfxOnFail;

		private List<Note>[] notesOnBeat;

		private List<Note> notes;

		private AudioSource[] audioSources;

		private int audioSourceIndex;

		private double startTime;

		private double time;

		private double timePerBeat;

		private double pausedTime;

		private Level level;

		public bool IsRunning { get; private set; }

		public float TimePerBeat => 0f;

		public double Time => 0.0;

		public double BeatTime => 0.0;

		private void Awake()
		{
		}

		private void OnLevelStart()
		{
		}

		private void OnFail(GolfBallController arg1, string arg2, Level.State arg3)
		{
		}

		private void Init()
		{
		}

		public IEnumerator StartSequencer()
		{
			return null;
		}

		private bool CheckIfPaused()
		{
			return false;
		}

		private void MoveTargets()
		{
		}

		private void PlayClip(AudioClip clip)
		{
		}
	}
}
