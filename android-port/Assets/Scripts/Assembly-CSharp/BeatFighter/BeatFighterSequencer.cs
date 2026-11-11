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
		private int numberOfAudioSources = 5;

		[SerializeField]
		private AudioSource loopAudioSource;

		[SerializeField]
		private double timeBeforeStart = 5.0;

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

		private float playerActionBeat = float.NegativeInfinity;

		private float beat;

		public float TimePerBeat => (float)timePerBeat;

		public double Time => time - startTime;

		public double BeatTime => (time - startTime) / (double)(float)timePerBeat;

		private IEnumerator Start()
		{
			loopAudioSource.clip = track.loop;
			timePerBeat = 60.0 / (double)track.bpm;
			level = Level.Instance;
			audioSources = new AudioSource[numberOfAudioSources];
			for (int i = 0; i < audioSources.Length; i++)
			{
				audioSources[i] = base.gameObject.AddComponent<AudioSource>();
			}
			notesOnBeat = new NoteOnBeat[track.notes.Length];
			attackObjects = new List<AttackObject>();
			for (int j = 0; j < track.notes.Length; j++)
			{
				BeatTrackNote beatTrackNote = track.notes[j];
				if (beatTrackNote != null && beatTrackNote.action != null && beatTrackNote.action.attackObjectPrefab != null)
				{
					AttackObject attackObject = Object.Instantiate(beatTrackNote.action.attackObjectPrefab);
					attackObject.Initialize((float)(timePerBeat * (double)j));
					attackObjects.Add(attackObject);
				}
				notesOnBeat[j] = new NoteOnBeat
				{
					note = track.notes[j]
				};
			}
			double dspTime = AudioSettings.dspTime;
			startTime = dspTime + timeBeforeStart;
			time = dspTime;
			loopAudioSource.PlayScheduled(startTime);
			while (time < startTime)
			{
				time = AudioSettings.dspTime;
				MoveTargets();
				yield return null;
			}
			while (beat < (float)notesOnBeat.Length)
			{
				time = AudioSettings.dspTime;
				beat = (float)((time - startTime) / timePerBeat);
				if (playerAction != null)
				{
					int num = Mathf.FloorToInt(beat);
					for (int k = Mathf.Min(num - 1, 0); k <= Mathf.Min(num + 1, track.notes.Length - 1); k++)
					{
						if (Mathf.Abs(playerActionBeat - (float)k) < 0.5f && notesOnBeat[k] != null && notesOnBeat[k].note.action == playerAction)
						{
							PlayClip(notesOnBeat[k].note.clip);
							playerAction = null;
							notesOnBeat[k].wasHit = true;
						}
					}
				}
				int num2 = Mathf.FloorToInt(beat) - 2;
				if (num2 >= 0 && num2 < notesOnBeat.Length && notesOnBeat[num2] != null && notesOnBeat[num2].note.action != null && !notesOnBeat[num2].wasHit)
				{
					Level.Instance.Fail(true, true, null, 0f, true, "");
				}
				MoveTargets();
				yield return null;
			}
			level.Complete();
			while (true)
			{
				time = AudioSettings.dspTime;
				MoveTargets();
				yield return null;
			}
		}

		public void PushPlayerAction(BeatTrackAction action)
		{
			playerAction = action;
			playerActionBeat = beat;
		}

		private void MoveTargets()
		{
			for (int i = 0; i < attackObjects.Count; i++)
			{
				attackObjects[i].Move((float)(time - startTime));
			}
		}

		private void PlayClip(AudioClip clip)
		{
			audioSources[audioSourceIndex].PlayOneShot(clip);
			audioSourceIndex = (audioSourceIndex + 1) % audioSources.Length;
		}
	}
}
