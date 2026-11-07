using System;
using UnityEngine;

namespace Audio
{
	public class AudioClipFromSurface : MonoBehaviour
	{
		[Serializable]
		public class SurfaceAudio
		{
			public AudioClip clip;

			public AudioMaterial material;
		}

		public SurfaceAudio[] surfaceClips;

		private AudioSource source;

		private AudioFromSurfaceModifier surfaceModifier;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnSurfaceChange(AudioMaterial material)
		{
		}
	}
}
