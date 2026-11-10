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

		public float decayVolumePerSecond = 2f;

		public bool use2DRaycast;

		public bool muteOnTouching;

		public int raycastFrequency = 10;

		private float nextRayCast;

		private float cooldown;

		private AudioMaterial currentGroundMaterial;

		private GameObject currentGround;

		public Action<AudioMaterial> onSurfaceChanged;

		public bool CanMute { get; set; }

		private void Awake()
		{
			CanMute = true;
			cooldown = (raycastFrequency >= 0 && raycastFrequency <= 2) ? raycastFrequency : 0f;
		}

		private void Update()
		{
			if (CanMute && audioSource != null)
			{
				audioSource.mute = muteOnTouching ? TouchingAnySurface : (!TouchingAnySurface);
			}
			if (Time.time > nextRayCast)
			{
				nextRayCast = Time.time + cooldown;
				Raycast();
			}
		}

		private void Raycast()
		{
			if (directions == null) return;
			bool touching = false;
			for (int i = 0; i < directions.Count; i++)
			{
				touching |= TouchingSurface(directions[i]);
			}
			TouchingAnySurface = touching;
		}

		private bool TouchingSurface(Vector3 direction)
		{
			if (target == null) return false;
			if (localAxis)
				direction = target.TransformDirection(direction);
			if (use2DRaycast)
			{
				RaycastHit2D hit2d = Physics2D.Raycast(target.position, direction, distanceToGroundThreshold, layerMask);
				SetGroundMaterial(hit2d.collider != null ? hit2d.collider.gameObject : null);
				return hit2d.collider != null;
			}
			bool hit3d = Physics.Raycast(target.position, direction, out RaycastHit hit, distanceToGroundThreshold, layerMask);
			SetGroundMaterial((hit3d && hit.collider != null) ? hit.collider.gameObject : null);
			return hit.collider != null;
		}

		private void SetGroundMaterial(GameObject go)
		{
			if (go == null)
			{
				if (currentGroundMaterial != null)
					onSurfaceChanged?.Invoke(null);
				currentGroundMaterial = null;
				return;
			}
			if (currentGround != go)
			{
				currentGround = go;
				var matSettings = go.GetComponent<AudioMaterialSettings>();
				if (matSettings != null && matSettings.material != null)
				{
					if (matSettings.material != currentGroundMaterial)
						onSurfaceChanged?.Invoke(matSettings.material);
					currentGroundMaterial = matSettings.material;
				}
			}
		}
	}
}
