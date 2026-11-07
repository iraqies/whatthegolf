using System.Collections;
using System.Collections.Generic;
using Core;
using UnityEngine;

namespace BeatFighter
{
	public class BeatFighterSequencer : MonoBehaviour
	{
		[SerializeField]
		private BeatTrack track;

		[SerializeField]
		private Transform indicatorsRoot;

		[SerializeField]
		private BeatFighterShooter shooter;

		[SerializeField]
		private ActionIndicator actionIndicatorPrefab;

		[SerializeField]
		private int numberOfAudioSources;

		[SerializeField]
		private AudioSource loopAudioSource;

		[SerializeField]
		private double timeBeforeStart;

		[SerializeField]
		private AudioClip failClip;

		private NoteOnBeat[] notesOnBeat;

		private List<AttackObject> attackObjects;

		private AudioSource[] audioSources;

		private int audioSourceIndex;

		private double startTime;

		private double time;

		private double timePerBeat;

		private Level level;

		private BeatTrackAction playerAction;

		private float playerActionBeat;

		private float beat;

		public float TimePerBeat => 0f;

		public double Time => 0.0;

		public double BeatTime => 0.0;

		private IEnumerator Start()
		{
			return null;
		}

		public void PushPlayerAction(BeatTrackAction action)
		{
		}

		private void MoveTargets()
		{
		}

		private void PlayClip(AudioClip clip)
		{
		}
	}
}
