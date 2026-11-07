using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WhatTheGolf.LevelDesigner.Events;
using WhatTheGolf.LevelDesigner.Tools;

namespace WhatTheGolf.LevelDesigner.Audio
{
	public class PaintBrushSFX : MonoBehaviour, IRequireEvents<AudioEvent>, IRequireEvents
	{
		public class MovingAverage
		{
			private Queue<float> samples;

			private int windowSize;

			private float sampleAccumulator;

			public float Average { get; private set; }

			public void ComputeAverage(float newSample, int maxWindowSize)
			{
			}

			public void Clear()
			{
			}
		}

		[Serializable]
		public class BrushModeBehaviour
		{
			public AudioSource AudioSource;

			public AnimationCurve m_VolumeOverVelocity;

			public float m_MinVolume;

			public float m_MaxVolume;

			private float velocity;

			public float TargetVelocity { get; set; }

			public float m_VelocityGain { get; set; }

			public float m_FadeGain { get; set; }

			public Coroutine FadeCoroutine { get; set; }

			public void UpdateAudioSource(float minAvg, float maxAvg)
			{
			}
		}

		[SerializeField]
		private float m_MinVelocityAvg;

		[SerializeField]
		private float m_MaxVelocityAvg;

		[SerializeField]
		private int m_MovingAverageWindowSize;

		[SerializeField]
		private float deltaMultiplier;

		[SerializeField]
		private BrushModeBehaviour m_TerrainPaintBehaviour;

		[SerializeField]
		private BrushModeBehaviour m_EraseBehaviour;

		private float m_VelocityAverage;

		private PaintTerrainTool m_Tool;

		private MovingAverage m_BrushMovingAverage;

		private void Awake()
		{
		}

		private void OnPaintStart(bool isErasing)
		{
		}

		private void OnPaintUpdate(bool isErasing, float delta)
		{
		}

		private void OnPaintStop(bool isErasing)
		{
		}

		private void Update()
		{
		}

		private IEnumerator FadeBrush(float startVolume, Action<float> onIncrement, bool fadeIn, float time, Action onFinish)
		{
			return null;
		}

		public void OnEvent(AudioEvent evt)
		{
		}
	}
}
