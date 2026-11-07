using System.Collections.Generic;
using UnityEngine;

namespace Audio
{
	public class OverworldBallBounceAudio : MonoBehaviour
	{
		public AudioMaterial audioMaterial;

		public float cooldown;

		public List<AudioClipFromVelocity> clipGroups;

		private float nextSoundTime;

		private void OnCollisionEnter2D(Collision2D col)
		{
		}
	}
}
