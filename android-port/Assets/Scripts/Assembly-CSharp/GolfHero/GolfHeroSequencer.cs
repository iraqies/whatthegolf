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
		private int numberOfAudioSources = 5;

		[SerializeField]
		private AudioSource loopAudioSource;

		[SerializeField]
		private double timeBeforeStart = 5.0;

		[SerializeField]
		private Camera visualsCamera;

		[SerializeField]
		private Color[] colors = new Color[1] { Color.black };

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

		public float TimePerBeat => (float)timePerBeat;

		public double Time => time - startTime;

		public double BeatTime => (time - startTime) / (float)timePerBeat;

		private void Awake()
		{
			Init();
			if (Level.HasInstance)
			{
				Level.Instance.OnStart += OnLevelStart;
				Level.Instance.OnFail += OnFail;
			}
		}

		private void OnLevelStart()
		{
			if (base.gameObject.activeInHierarchy)
			{
				StartCoroutine(StartSequencer());
			}
		}

		private void OnFail(GolfBallController arg1, string arg2, Level.State arg3)
		{
			if (base.gameObject.activeInHierarchy && sfxOnFail != null && AudioManager.Instance != null)
			{
				sfxOnFail.Play(AudioManager.Instance.SFXAudioGroup, Vector3.zero, 0f);
			}
		}

		private void Init()
		{
			if (piece == null)
				return;

			timePerBeat = 60.0 / piece.bpm;
			level = Level.Instance;
			audioSources = new AudioSource[numberOfAudioSources];
			for (int i = 0; i < audioSources.Length; i++)
			{
				audioSources[i] = base.gameObject.AddComponent<AudioSource>();
				if (loopAudioSource != null)
				{
					audioSources[i].outputAudioMixerGroup = loopAudioSource.outputAudioMixerGroup;
				}
			}

			notes = new List<Note>();
			if (piece.notes == null)
				return;

			notesOnBeat = new List<Note>[piece.notes.Length];
			for (int i = 0; i < notesOnBeat.Length; i++)
			{
				notesOnBeat[i] = new List<Note>();
			}

			Dictionary<MusicPieceNote, Material> matMap = new Dictionary<MusicPieceNote, Material>();
			for (int i = 0; i < piece.notes.Length; i++)
			{
				MusicPieceNote noteData = piece.notes[i];
				if (noteData == null)
					continue;

				NoteTarget target = Object.Instantiate(noteTargetPrefab, notesRoot);
				target.transform.localRotation = Quaternion.identity;
				Note note = new Note
				{
					beat = i,
					noteData = noteData,
					noteTarget = target
				};
				if (noteData.length >= 2)
				{
					note.line = target.gameObject.AddComponent<LineRenderer>();
					note.line.useWorldSpace = false;
				}
				if (!matMap.TryGetValue(noteData, out Material mat) && noteTargetPrefab != null && noteTargetPrefab.Material != null)
				{
					mat = new Material(noteTargetPrefab.Material);
					mat.SetColor("_Color", noteData.color);
					matMap.Add(noteData, mat);
				}
				if (mat != null)
				{
					target.Material = mat;
				}
				if (note.line != null)
				{
					note.line.sharedMaterial = target.Material;
				}
				notesOnBeat[i].Add(note);
				notes.Add(note);
			}
		}

		public IEnumerator StartSequencer()
		{
			IsRunning = true;
			if (shooter != null)
			{
				shooter.SetSequencer(this);
			}
			double dsp = AudioSettings.dspTime;
			startTime = dsp + timeBeforeStart;
			time = dsp;
			if (loopAudioSource != null)
			{
				loopAudioSource.PlayScheduled(startTime);
			}
			pausedTime = 0.0;

			while (time < startTime)
			{
				if (!CheckIfPaused())
				{
					time = AudioSettings.dspTime - pausedTime;
					MoveTargets();
				}
				yield return null;
			}

			int lastBeat = -1;
			while (piece != null && piece.notes != null && lastBeat < piece.notes.Length - 1)
			{
				if (CheckIfPaused())
				{
					yield return null;
					continue;
				}

				time = AudioSettings.dspTime - pausedTime;
				int rawBeat = (int)((time - startTime) / timePerBeat);
				int currentBeat = Mathf.Clamp(rawBeat, 0, piece.notes.Length - 1);
				if (currentBeat > lastBeat)
				{
					if (notesOnBeat != null && currentBeat < notesOnBeat.Length)
					{
						foreach (Note note in notesOnBeat[currentBeat])
						{
							if (note.noteData.lane != shooter.Lane)
							{
								if (level != null)
								{
									level.Fail(true, true, null, 0f, true, "ID_FAIL_PINBALL");
								}
							}
							else
							{
								if (AudioManager.Instance != null && AudioManager.Instance.RumbleEvents != null && AudioManager.Instance.RumbleEvents.GolfBallBounce != null)
								{
									AudioManager.Instance.RumbleEvents.GolfBallBounce.Play(0, 1f);
								}
								if (note.noteTarget != null)
								{
									note.noteTarget.gameObject.SetActive(false);
								}
								PlayClip(note.noteData.clip);
							}
						}
					}
					if (colors != null && colors.Length > 0 && visualsCamera != null)
					{
						visualsCamera.backgroundColor = colors[currentBeat % colors.Length];
					}
					lastBeat = currentBeat;
				}
				MoveTargets();
				yield return null;
			}

			if (level != null)
			{
				level.Complete(null, null, null, false);
			}
			while (true)
			{
				time = AudioSettings.dspTime;
				yield return null;
				MoveTargets();
			}
		}

		private bool CheckIfPaused()
		{
			bool paused = Mathf.Approximately(UnityEngine.Time.timeScale, 0f);
			if (paused)
			{
				if (loopAudioSource != null && loopAudioSource.isPlaying)
				{
					loopAudioSource.Pause();
					pausedTime = time;
				}
			}
			else if (loopAudioSource != null && !loopAudioSource.isPlaying)
			{
				loopAudioSource.UnPause();
				pausedTime = AudioSettings.dspTime - pausedTime;
			}
			return paused;
		}

		private void MoveTargets()
		{
			if (notes == null || shooter == null)
				return;

			for (int i = 0; i < notes.Count; i++)
			{
				Note note = notes[i];
				if (note == null || note.noteTarget == null || note.noteData == null)
					continue;

				float z = (float)(timePerBeat * note.beat - (time - startTime)) * 20f;
				float x = shooter.LaneToX(note.noteData.lane);
				note.noteTarget.transform.localPosition = new Vector3(x, 0f, z);
				if (note.line != null)
				{
					note.line.SetPosition(1, new Vector3(0f, -1.5f, note.noteData.length * 5f));
					note.line.SetPosition(0, new Vector3(0f, -1.5f, 0f));
					note.line.numCapVertices = 12;
				}
			}
		}

		private void PlayClip(AudioClip clip)
		{
			if (playAudioClips && audioSources != null && audioSources.Length > 0)
			{
				if (audioSources[audioSourceIndex] != null)
				{
					audioSources[audioSourceIndex].PlayOneShot(clip);
				}
				audioSourceIndex = (audioSourceIndex + 1) % audioSources.Length;
			}
		}
	}
}
