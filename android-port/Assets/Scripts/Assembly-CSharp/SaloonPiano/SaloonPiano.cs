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
		private AnimationCurve speedCurve;

		[SerializeField]
		private MusicPiece piece;

		[SerializeField]
		private float notesMaxY;

		[SerializeField]
		private float noteVolume;

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
		private int maxNumberOfPerfectRounds;

		[SerializeField]
		private int numberOfAudioSources;

		[SerializeField]
		private float minSpeed;

		[SerializeField]
		private float maxSpeed;

		[SerializeField]
		private float crazySpeedBoost;

		[SerializeField]
		private float maxSpeedChange;

		[SerializeField]
		private NoteTarget noteTargetPrefab;

		[SerializeField]
		private ParticleSystem smokeParticleSystem;

		[SerializeField]
		private float visualDuration;

		[SerializeField]
		private NoteVisual[] visuals;

		private List<Note>[] notesOnBeat;

		private List<Note> notes;

		private HashSet<Note> hitNotes;

		private AudioSource[] audioSources;

		private int audioSourceIndex;

		private float speed;

		private float targetSpeed;

		private float time;

		private int perfectRounds;

		private Level level;

		private int numberOfGoodNotes;

		private Dictionary<int, NoteVisual> visualByPosition;

		private void Awake()
		{
		}

		private void HandleHit(Note note)
		{
		}

		private IEnumerator Start()
		{
			return null;
		}

		private IEnumerator UpdateVisuals()
		{
			return null;
		}

		private IEnumerator AdjustSpeed()
		{
			return null;
		}

		private void PlayClip(AudioClip clip)
		{
		}
	}
}
