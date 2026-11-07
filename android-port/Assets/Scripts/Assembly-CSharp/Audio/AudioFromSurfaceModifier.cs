using System;
using System.Collections.Generic;
using UnityEngine;

namespace Audio
{
	public class AudioFromSurfaceModifier : MonoBehaviour
	{
		public bool TouchingAnySurface;

		public string CurrentGround;

		public Transform target;

		public AudioSource audioSource;

		public float volumeWhenoff;

		public List<Vector3> directions;

		public bool localAxis;

		public LayerMask layerMask;

		public float distanceToGroundThreshold;

		public float decayVolumePerSecond;

		public bool use2DRaycast;

		public bool muteOnTouching;

		public int raycastFrequency;

		private float nextRayCast;

		private float cooldown;

		private AudioMaterial currentGroundMaterial;

		private GameObject currentGround;

		public Action<AudioMaterial> onSurfaceChanged;

		public bool CanMute { get; set; }

		private void Awake()
		{
		}

		private void Update()
		{
		}

		private void Raycast()
		{
		}

		private bool TouchingSurface(Vector3 direction)
		{
			return false;
		}

		private void SetGroundMaterial(GameObject go)
		{
		}
	}
}
