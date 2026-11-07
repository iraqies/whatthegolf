using System;
using System.Collections.Generic;
using UnityEngine;

namespace Audio
{
	public class KatamariAudio : MonoBehaviour
	{
		[Serializable]
		public class CactusAudioTiers
		{
			public int minAmount;

			public int maxAmount;

			public OnCollisionAudioRemote collisionAudio;
		}

		public Rigidbody2D katamari;

		public RandomAudioClips attachClips;

		public List<CactusAudioTiers> cactusAudios;

		private int cacti;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void KatamariCactus2D_OnAttach(KatamariCactus2D arg1, Rigidbody2D arg2)
		{
		}
	}
}
