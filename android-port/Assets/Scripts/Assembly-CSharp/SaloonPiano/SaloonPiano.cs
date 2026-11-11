using System;
using System.Collections;
using System.Collections.Generic;
using Core;
using UnityEngine;
using UnityEngine.Audio;

namespace SaloonPiano
{
	public class SaloonPiano : MonoBehaviour
	{
		public class Note
		{
			public MusicPiece.NoteData noteData;

			public NoteTarget noteTarget;

			public bool isActive;
		}

		[Serializable]
		private class NoteVisual
		{
			public int position;

			public GameObject root;

			public float timer;
		}

		[SerializeField]
		private Transform notesRoot;

		[SerializeField]
		private AnimationCurve speedCurve = AnimationCurve.Linear(0f, 0f, 1f, 1f);

		[SerializeField]
		private MusicPiece piece;

		[SerializeField]
		private float notesMaxY = 10f;

		[SerializeField]
		private float noteVolume = 0.8f;

		[SerializeField]
		private AudioMixerGroup outputGroup;

		[SerializeField]
		private AudioClip endChord;

		[SerializeField]
		private AudioClip inactiveTargetSound;

		[SerializeField]
		private AudioClip hitSound;

		[SerializeField]
		private AudioClip hitWrongSound;

		[SerializeField]
		private int maxNumberOfPerfectRounds = 1;

		[SerializeField]
		private int numberOfAudioSources = 8;

		[SerializeField]
		private float minSpeed = 2f;

		[SerializeField]
		private float maxSpeed = 8f;

		[SerializeField]
		private float crazySpeedBoost = 12f;

		[SerializeField]
		private float maxSpeedChange = 5f;

		[SerializeField]
		private NoteTarget noteTargetPrefab;

		[SerializeField]
		private ParticleSystem smokeParticleSystem;

		[SerializeField]
		private float visualDuration = 0.25f;

		[SerializeField]
		private NoteVisual[] visuals;

		private List<Note>[] notesOnBeat;

		private List<Note> notes = new List<Note>();

		private HashSet<Note> hitNotes = new HashSet<Note>();

		private AudioSource[] audioSources;

		private int audioSourceIndex;

		private float speed;

		private float targetSpeed;

		private float time;

		private int perfectRounds;

		private Level level;

		private int numberOfGoodNotes;

		private Dictionary<int, NoteVisual> visualByPosition = new Dictionary<int, NoteVisual>();

		private void Awake()
		{
			level = Level.Instance;
			visualByPosition = new Dictionary<int, NoteVisual>();
			if (visuals != null)
			{
				for (int i = 0; i < visuals.Length; i++)
				{
					if (visuals[i] != null)
					{
						visualByPosition[visuals[i].position] = visuals[i];
					}
				}
			}
			speed = minSpeed;
			targetSpeed = minSpeed;
			int srcCount = Mathf.Max(1, numberOfAudioSources);
			audioSources = new AudioSource[srcCount];
			for (int i = 0; i < srcCount; i++)
			{
				AudioSource src = gameObject.AddComponent<AudioSource>();
				src.volume = noteVolume;
				src.outputAudioMixerGroup = outputGroup;
				audioSources[i] = src;
			}
			notes = new List<Note>();
			hitNotes = new HashSet<Note>();
			if (piece != null)
			{
				int len = Mathf.Max(1, piece.length);
				notesOnBeat = new List<Note>[len];
				for (int i = 0; i < len; i++)
				{
					notesOnBeat[i] = new List<Note>();
				}
				if (piece.notes != null && noteTargetPrefab != null)
				{
					for (int i = 0; i < piece.notes.Length; i++)
					{
						MusicPiece.NoteData nd = piece.notes[i];
						if (nd == null)
						{
							continue;
						}
						NoteTarget nt = UnityEngine.Object.Instantiate(noteTargetPrefab, notesRoot);
						nt.transform.localRotation = Quaternion.identity;
						nt.Initialize(nd.isWrong);
						Note note = new Note
						{
							noteData = nd,
							noteTarget = nt,
							isActive = !nd.isWrong
						};
						Note captured = note;
						nt.OnHit += () => HandleHit(captured);
						int b = Mathf.Clamp(nd.beat, 0, len - 1);
						notesOnBeat[b].Add(note);
						notes.Add(note);
						if (!nd.isWrong)
						{
							numberOfGoodNotes++;
						}
					}
				}
			}
		}

		private void HandleHit(Note note)
		{
			if (note == null || note.noteData == null)
			{
				return;
			}
			if (note.noteData.isWrong)
			{
				if (hitWrongSound != null && AudioManager.Instance != null && AudioManager.Instance.shortEffects != null)
				{
					AudioManager.Instance.shortEffects.Play(hitWrongSound);
				}
			}
			else
			{
				if (hitSound != null && AudioManager.Instance != null && AudioManager.Instance.shortEffects != null)
				{
					AudioManager.Instance.shortEffects.Play(hitSound);
				}
				hitNotes.Add(note);
				note.isActive = true;
			}
		}

		private IEnumerator Start()
		{
			if (piece == null || notesOnBeat == null)
			{
				yield break;
			}
			StartCoroutine(AdjustSpeed());
			StartCoroutine(UpdateVisuals());
			int lastBeat = -1;
			float len = Mathf.Max(1f, piece.length);
			while (true)
			{
				time += Time.deltaTime * speed;
				if (time >= len)
				{
					time -= len;
					lastBeat = -1;
					if (hitNotes.Count >= numberOfGoodNotes)
					{
						perfectRounds++;
						if (perfectRounds >= maxNumberOfPerfectRounds)
						{
							PlayClip(endChord);
							if (smokeParticleSystem != null)
							{
								smokeParticleSystem.Stop();
							}
							if (level != null)
							{
								level.Complete(null, null, null, false);
							}
							yield break;
						}
					}
				}
				for (int i = 0; i < notes.Count; i++)
				{
					Note n = notes[i];
					if (n != null && n.noteTarget != null && n.noteData != null)
					{
						float yOffset = Mathf.Repeat(n.noteData.beat - time, len);
						n.noteTarget.transform.localPosition = new Vector3(n.noteData.position, Mathf.Min(yOffset, notesMaxY), 0f);
					}
				}
				speed = Mathf.MoveTowards(speed, targetSpeed, Time.deltaTime * maxSpeedChange);
				int curBeat = Mathf.Clamp(Mathf.FloorToInt(time), 0, notesOnBeat.Length - 1);
				if (curBeat != lastBeat)
				{
					lastBeat = curBeat;
					List<Note> beatNotes = notesOnBeat[curBeat];
					if (beatNotes != null)
					{
						for (int i = 0; i < beatNotes.Count; i++)
						{
							Note bn = beatNotes[i];
							if (bn != null && bn.isActive && bn.noteData != null)
							{
								PlayClip(bn.noteData.clip);
								if (visualByPosition.TryGetValue(bn.noteData.position, out NoteVisual vis) && vis != null)
								{
									vis.timer = visualDuration;
								}
							}
						}
					}
				}
				yield return null;
			}
		}

		private IEnumerator UpdateVisuals()
		{
			while (true)
			{
				if (visuals != null)
				{
					for (int i = 0; i < visuals.Length; i++)
					{
						NoteVisual v = visuals[i];
						if (v != null && v.root != null)
						{
							v.timer = Mathf.Max(0f, v.timer - Time.deltaTime);
							v.root.SetActive(v.timer > 0f);
						}
					}
				}
				yield return null;
			}
		}

		private IEnumerator AdjustSpeed()
		{
			while (true)
			{
				float ratio = numberOfGoodNotes > 0 ? Mathf.Clamp01((float)hitNotes.Count / numberOfGoodNotes) : 0f;
				float eval = speedCurve != null && speedCurve.length > 0 ? speedCurve.Evaluate(ratio) : ratio;
				targetSpeed = Mathf.Lerp(minSpeed, maxSpeed, eval);
				if (ratio >= 1f && smokeParticleSystem != null && !smokeParticleSystem.isPlaying)
				{
					smokeParticleSystem.Play();
				}
				yield return new WaitForSeconds(0.25f);
			}
		}

		private void PlayClip(AudioClip clip)
		{
			if (clip == null || audioSources == null || audioSources.Length == 0)
			{
				return;
			}
			AudioSource src = audioSources[audioSourceIndex % audioSources.Length];
			if (src != null)
			{
				src.PlayOneShot(clip);
			}
			audioSourceIndex = (audioSourceIndex + 1) % audioSources.Length;
		}
	}
}
