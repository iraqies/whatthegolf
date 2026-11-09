using System;
using System.Collections.Generic;
using UnityEngine;

namespace Audio
{
	public class OverworldBallBounceAudio : MonoBehaviour
	{
		public AudioMaterial audioMaterial;

		public float cooldown = 0.08f;

		public List<AudioClipFromVelocity> clipGroups;

		private float nextSoundTime;

		private void OnCollisionEnter2D(Collision2D col)
		{
			if (col == null || Time.time < nextSoundTime || clipGroups == null || clipGroups.Count == 0)
				return;
			float speed = col.relativeVelocity.magnitude;
			for (int i = 0; i < clipGroups.Count; i++)
			{
				var g = clipGroups[i];
				if (g == null || g.clips == null || g.clips.Count == 0)
					continue;
				if (speed >= g.minVelocity && (speed <= g.maxVelocity || g.maxVelocity <= 0f || i == clipGroups.Count - 1))
				{
					g.SetSoundValues(speed, out Action<AudioSource> mod);
					if (AudioManager.Instance != null && AudioManager.Instance.shortEffects != null)
					{
						AudioManager.Instance.shortEffects.Play(g.clips, mod, false, 0f, false);
						nextSoundTime = Time.time + Mathf.Max(0.05f, cooldown);
					}
					break;
				}
			}
		}
	}
}
