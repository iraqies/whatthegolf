using System.Collections.Generic;
using UnityEngine;

namespace Audio
{
	public class AnimationAudio : MonoBehaviour, IAudioCullable
	{
		public List<ClipSettingsCollection> SFX_Oneshots;

		public Transform emitterTransform;

		public AudioSource audioSource;

		public bool IsVisible { get; set; } = true;

		public void AnimationAudioOneshot(int index)
		{
			if (SFX_Oneshots == null || index < 0 || index >= SFX_Oneshots.Count)
				return;
			var col = SFX_Oneshots[index];
			if (col == null)
				return;
			Vector3 pos = emitterTransform != null ? emitterTransform.position : transform.position;
			col.Play(pos);
		}
	}
}
