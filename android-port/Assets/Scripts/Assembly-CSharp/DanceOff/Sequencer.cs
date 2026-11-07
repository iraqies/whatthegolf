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
		private double timeBeforeStart;

		[SerializeField]
		private Transform indicatorsRoot;

		[SerializeField]
		private Dancer dancer;

		[SerializeField]
		private Vector3 beatSpacing;

		[SerializeField]
		private float hitRadius;

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
		private float indicatorSwingTimeNormalizer;

		[SerializeField]
		private float indicatorSwingAmplitude;

		[SerializeField]
		private AudioClip cheeringSfx;

		[SerializeField]
		private AnimationCurve cheeringVolumeOverTime;

		private double startTime;

		private double time;

		private double timePerBeat;

		private Level level;

		private List<DanceMoveIndicator> indicators;

		public Material[] IndicatorMaterials;

		private int materialPickID;

		private TimeControl timeControl;

		private float elapsedPauseTime;

		private bool wasPaused;

		private float beat;

		private double hitRadiusDuration;

		private IndicatorEffects effects;

		public double StartTime => 0.0;

		public double Time => 0.0;

		public double TimePerBeat => 0.0;

		public float Beat => 0f;

		private void Awake()
		{
		}

		private IEnumerator Start()
		{
			return null;
		}

		private void HandlePausing()
		{
		}

		private void Lose()
		{
		}

		public void CheckForHit(Vector2 dir)
		{
		}

		private bool CheckForMiss()
		{
			return false;
		}

		private void UpdateIndicators()
		{
		}

		private void UpdateIndicator(DanceMoveIndicator indicator)
		{
		}
	}
}
