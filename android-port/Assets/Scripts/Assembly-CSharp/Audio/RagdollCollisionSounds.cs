using System.Collections.Generic;
using Audio.Conditions;
using Audio.Rumble;
using UnityEngine;

namespace Audio
{
	public class RagdollCollisionSounds : MonoBehaviour, IAudioCullable
	{
		public Transform root;

		public List<Transform> limbs;

		public List<Transform> allLimbs;

		public string limbsParsed;

		public AudioMaterial audioMaterial;

		public AudioMaterial[] includeMaterials;

		public AudioMaterial[] excludeMaterials;

		public bool onlyBelow;

		public bool collideWithSelf;

		public float cooldown;

		public float minVelocity;

		public float maxVelocity;

		public bool goesAboveMaxVelocity;

		public RandomAudioClips clips;

		public ConditionChecker conditions;

		public List<RumbleEventAsset> rumbles;

		private float nextEventTime;

		private List<AudioMaterial> include;

		private List<AudioMaterial> exclude;

		public bool IsVisible { get; set; }

		private void Start()
		{
		}

		private void OnCollisionAudio(LimbCollisionInfo.LimbHitInfo hitInfo)
		{
		}
	}
}
