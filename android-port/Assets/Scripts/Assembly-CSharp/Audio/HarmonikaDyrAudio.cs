using System.Collections.Generic;
using Core;
using UnityEngine;

namespace Audio
{
	public class HarmonikaDyrAudio : MonoBehaviour
	{
		[SerializeField]
		private HarmonikaDyrShooter harmonikaDyr;

		[SerializeField]
		private List<AudioClip> slowMoveSequence;

		[SerializeField]
		private List<AudioClip> fastMoveSequence;

		[SerializeField]
		private float maxRate;

		[SerializeField]
		private AudioSource stretchLoop;

		private int clipIndex;

		private float rate;

		private int increment;

		private float rateNextPeriod;

		private float lastDistance;

		private bool startedStretch;

		private bool startedSquash;

		private float rateSmoothVelocity;

		private float rateSmooth;

		private float smoothedRate;

		private float volume;

		private void Start()
		{
		}

		private void OnAimStart()
		{
		}

		private void OnShoot(Vector3 boost)
		{
		}

		private void Update()
		{
		}

		private void HandleOneshots()
		{
		}

		private void HandleRate()
		{
		}
	}
}
