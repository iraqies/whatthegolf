using System.Collections;
using UnityEngine;

namespace Audio
{
	public class SpectatorReactionAudio : MonoBehaviour
	{
		[SerializeField]
		private TribuneWithSpectators tribune;

		[SerializeField]
		private Spectator spectator;

		[SerializeField]
		private float volumeMod;

		[SerializeField]
		private AudioEventAsset loopSfx;

		[SerializeField]
		private AudioSource loopCheerSource;

		[SerializeField]
		private float fadeInSpeed;

		[SerializeField]
		private float fadeOutSpeed;

		[SerializeField]
		private AudioEventAsset oneshotSfx;

		public bool isReactingToPlayer;

		private Spectator currentSpectator;

		private Coroutine fadeCoroutine;

		private float cheerMaxVolume;

		private float lastStartTime;

		private const float COOLDOWN = 5f;

		public Spectator CurrentSpectator
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private void Awake()
		{
		}

		private void Tribune_OnTribunePopulated()
		{
		}

		private void OnSeeingTarget()
		{
		}

		private void OnLosingTarget()
		{
		}

		private IEnumerator FadeCrowdLoop(bool fadeIn)
		{
			return null;
		}
	}
}
