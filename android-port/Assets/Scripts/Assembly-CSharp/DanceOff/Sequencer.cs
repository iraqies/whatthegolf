using System.Collections;
using System.Collections.Generic;
using Core;
using UnityEngine;

namespace DanceOff
{
	public class Sequencer : MonoBehaviour
	{
		[SerializeField]
		private Track track;

		[SerializeField]
		private double timeBeforeStart = 1.0;

		[SerializeField]
		private Transform indicatorsRoot;

		[SerializeField]
		private Dancer dancer;

		[SerializeField]
		private Vector3 beatSpacing = Vector3.up;

		[SerializeField]
		private float hitRadius = 0.5f;

		[SerializeField]
		private AudioSource loopAudioSource;

		[SerializeField]
		private GolfGoal golfGoal;

		[SerializeField]
		private ParticleSystem leftParticleEmitter;

		[SerializeField]
		private ParticleSystem rightParticleEmitter;

		[SerializeField]
		private ParticleSystem centerParticleEmitter;

		[SerializeField]
		private ParticleSystem endParticleEmitter;

		[SerializeField]
		private AnimationCurve indicatorBeatAnimationCurve;

		[SerializeField]
		private AnimationCurve indicatorSwingAnimationCurve;

		[SerializeField]
		private float indicatorSwingTimeNormalizer = 1f;

		[SerializeField]
		private float indicatorSwingAmplitude = 10f;

		[SerializeField]
		private AudioClip cheeringSfx;

		[SerializeField]
		private AnimationCurve cheeringVolumeOverTime;

		private double startTime;

		private double time;

		private double timePerBeat;

		private Level level;

		private List<DanceMoveIndicator> indicators = new List<DanceMoveIndicator>();

		public Material[] IndicatorMaterials;

		private int materialPickID;

		private TimeControl timeControl;

		private float elapsedPauseTime;

		private bool wasPaused;

		private float beat;

		private double hitRadiusDuration;

		private IndicatorEffects effects;

		public double StartTime => startTime;

		public double Time => time;

		public double TimePerBeat => timePerBeat;

		public float Beat => beat;

		private void Awake()
		{
			effects = GetComponent<IndicatorEffects>();
			timeControl = Object.FindObjectOfType<TimeControl>();
		}

		private IEnumerator Start()
		{
			level = Level.Instance;
			if (track == null)
			{
				yield break;
			}
			if (loopAudioSource != null)
			{
				loopAudioSource.clip = track.loop;
			}
			timePerBeat = 60.0 / Mathf.Max(1, track.bpm);
			double dsp = AudioSettings.dspTime;
			startTime = dsp + timeBeforeStart;
			time = dsp;
			hitRadiusDuration = (hitRadius / Mathf.Max(0.01f, beatSpacing.magnitude)) * timePerBeat;
			if (loopAudioSource != null)
			{
				loopAudioSource.PlayScheduled(startTime);
			}
			if (track.moves != null)
			{
				for (int i = 0; i < track.moves.Length; i++)
				{
					DanceMove move = track.moves[i];
					if (move == null || move.indicatorPrefab == null)
					{
						continue;
					}
					DanceMoveIndicator ind = Object.Instantiate(move.indicatorPrefab, indicatorsRoot);
					ind.Initialize(startTime + i * timePerBeat, move);
					if (IndicatorMaterials != null && IndicatorMaterials.Length > 0)
					{
						Renderer[] rends = ind.GetComponentsInChildren<Renderer>();
						Material mat = IndicatorMaterials[materialPickID % IndicatorMaterials.Length];
						if (rends != null)
						{
							for (int j = 0; j < rends.Length; j++)
							{
								if (rends[j] != null)
								{
									rends[j].material = mat;
								}
							}
						}
						materialPickID = (materialPickID + 1) % IndicatorMaterials.Length;
					}
					indicators.Add(ind);
					UpdateIndicator(ind);
				}
			}
			while (time < startTime)
			{
				HandlePausing();
				time = AudioSettings.dspTime - elapsedPauseTime;
				UpdateIndicators();
				yield return null;
			}
			int totalMoves = track.moves != null ? track.moves.Length : 0;
			while (beat < totalMoves)
			{
				HandlePausing();
				time = AudioSettings.dspTime - elapsedPauseTime;
				beat = (float)((time - startTime) / timePerBeat);
				if (CheckForMiss())
				{
					Lose();
				}
				UpdateIndicators();
				yield return null;
			}
			if (loopAudioSource != null)
			{
				loopAudioSource.Stop();
			}
		}

		private void HandlePausing()
		{
			if (timeControl != null && timeControl.IsPaused)
			{
				elapsedPauseTime += UnityEngine.Time.unscaledDeltaTime;
				if (loopAudioSource != null && loopAudioSource.isPlaying)
				{
					loopAudioSource.Pause();
				}
			}
			else if (loopAudioSource != null && !loopAudioSource.isPlaying && time >= startTime)
			{
				loopAudioSource.Play();
			}
		}

		private void Lose()
		{
			if (Level.Instance != null)
			{
				Level.Instance.Fail(true, true, null, 0f, true, "DanceOffMiss");
			}
		}

		public void CheckForHit(Vector2 dir)
		{
			if (dancer != null)
			{
				dancer.Dance(dir);
			}
			if (indicators == null || indicators.Count == 0)
			{
				return;
			}
			DanceMoveIndicator first = indicators[0];
			if (first == null)
			{
				indicators.RemoveAt(0);
				return;
			}
			if (System.Math.Abs(first.Time - time) <= hitRadiusDuration)
			{
				indicators.RemoveAt(0);
				bool correct = first.DanceMove != null && Vector2.Dot(first.DanceMove.dir.normalized, dir.normalized) > 0.5f;
				if (effects != null)
				{
					effects.IndicatorHit(first, dir, correct);
				}
				if (!correct)
				{
					Lose();
					return;
				}
				if (cheeringSfx != null && AudioManager.Instance != null && AudioManager.Instance.shortEffects != null)
				{
					float vol = cheeringVolumeOverTime != null && cheeringVolumeOverTime.length > 0 ? cheeringVolumeOverTime.Evaluate(beat / Mathf.Max(1f, track != null && track.moves != null ? track.moves.Length : 1f)) : 0.8f;
					AudioManager.Instance.shortEffects.Play(cheeringSfx, s => s.volume = vol, 0f, false);
				}
				if (indicators.Count == 0)
				{
					if (golfGoal != null)
					{
						golfGoal.TriggerGoal("DanceOffWin");
					}
					if (endParticleEmitter != null)
					{
						endParticleEmitter.Play();
					}
				}
			}
		}

		private bool CheckForMiss()
		{
			if (indicators == null || indicators.Count == 0)
			{
				return false;
			}
			DanceMoveIndicator first = indicators[0];
			if (first != null && time - first.Time > hitRadiusDuration)
			{
				indicators.RemoveAt(0);
				if (effects != null)
				{
					effects.IndicatorMiss(first);
				}
				return true;
			}
			return false;
		}

		private void UpdateIndicators()
		{
			if (indicators == null)
			{
				return;
			}
			for (int i = 0; i < indicators.Count; i++)
			{
				if (indicators[i] != null)
				{
					UpdateIndicator(indicators[i]);
				}
			}
		}

		private void UpdateIndicator(DanceMoveIndicator indicator)
		{
			if (indicator == null || indicator.Transform == null)
			{
				return;
			}
			float beatsAway = (float)((indicator.Time - time) / System.Math.Max(0.01, timePerBeat));
			indicator.Transform.localPosition = beatSpacing * beatsAway;
			if (indicatorBeatAnimationCurve != null && indicatorBeatAnimationCurve.length > 0)
			{
				float eval = indicatorBeatAnimationCurve.Evaluate(Mathf.Repeat(beat, 1f));
				indicator.Transform.localScale = Vector3.one * eval;
			}
			if (indicatorSwingAnimationCurve != null && indicatorSwingAnimationCurve.length > 0)
			{
				float swing = indicatorSwingAnimationCurve.Evaluate(Mathf.Repeat((float)((indicator.Time - time) * indicatorSwingTimeNormalizer), 1f)) * indicatorSwingAmplitude;
				indicator.Transform.localRotation = Quaternion.AngleAxis(swing, Vector3.forward);
			}
		}
	}
}
