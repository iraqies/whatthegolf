using System.Collections;
using System.Collections.Generic;
using System.Linq;
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

		private List<AmbientPlayingInfo> currentAmbients = new List<AmbientPlayingInfo>();
		private List<AmbientPlayingInfo> toKill = new List<AmbientPlayingInfo>();

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
			yield return null;
			SetAmbients(ambients);
		}

		public void SetAmbients(List<AmbientAudio> ambients)
		{
			if (ambients == null) return;
			foreach (var a in ambients)
			{
				if (a != null) a.OnSceneStart();
			}
		}

		public void InitializeNewScene()
		{
			var ambients = FindObjectsOfType<AmbientAudio>().ToList();
			SetAmbients(ambients);
		}
	}
}
