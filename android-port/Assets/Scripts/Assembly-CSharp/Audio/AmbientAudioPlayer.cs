using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Audio
{
	public class AmbientAudioPlayer : MonoBehaviour
	{
		public class AmbientPlayingInfo
		{
			public AmbientAudio ambient;

			public AudioSource source;

			public bool toKill;

			public bool isDead;
		}

		private List<AmbientPlayingInfo> currentAmbients;

		private List<AmbientPlayingInfo> toKill;

		private void Awake()
		{
		}

		public void SetOneshotTimeOnActive(float time)
		{
		}

		private void Update()
		{
		}

		private IEnumerator InitializeDelayed(List<AmbientAudio> ambients)
		{
			return null;
		}

		public void SetAmbients(List<AmbientAudio> ambients)
		{
		}

		public void InitializeNewScene()
		{
		}
	}
}
