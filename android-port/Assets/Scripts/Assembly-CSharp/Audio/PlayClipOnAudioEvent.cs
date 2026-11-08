using System;
using UnityEngine;

namespace Audio
{
	public class PlayClipOnAudioEvent : AudioEventListenerBase, ISpatializeDisable
	{
		[Serializable]
		public class Overrides
		{
			public bool overrideVoice;
			public AudioUtility.AudioManagerVoice voice;
			public bool overrideVolume;
			public AudioAttribute volume;
			public bool overridePitch;
			public AudioAttribute pitch;
			public bool overrideCooldown;
			public float cooldown;
			public bool overrideDelay;
			public float delay;
		}

		public AudioEventAsset asset;
		[SerializeField] protected Overrides overrides;
		[SerializeField] protected bool disableSpatialOnMultiplayer;
		private AudioSources audioManagerVoice;

		public bool DisableSpatial { get; set; }

		protected override void Awake()
		{
			base.Awake();
		}

		public override void Play(Vector3 position, float volumeMultiplier = 1f, float pitchMultiplier = 1f)
		{
			if (asset != null)
				asset.Play(position, overrides, volumeMultiplier, pitchMultiplier, DisableSpatial);
		}

		public override void Play(Vector3 position)
		{
			Play(position, 1f, 1f);
		}

		public override void Play()
		{
			Play(transform.position, 1f, 1f);
		}
	}
}
