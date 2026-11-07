using System.Collections.Generic;
using UnityEngine;

namespace Audio
{
	public class AnimationAudio : MonoBehaviour, IAudioCullable
	{
		public List<ClipSettingsCollection> SFX_Oneshots;

		public Transform emitterTransform;

		public AudioSource audioSource;

		public bool IsVisible { get; set; }

		public void AnimationAudioOneshot(int index)
		{
		}
	}
}
