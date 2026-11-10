using System;
using UnityEngine;

public class AudioVolumeToVelocity : MonoBehaviour
{
	[Serializable]
	public class SoundSettingFromRaycast
	{
		public Vector3 direction;

		public float minVolume;

		public float maxVolume;

		public float minVelocity;

		public float maxVelocity;

		public bool touching;
	}

	public bool use2DRigidbody;

	public bool use2DSpace;

	public bool mustTouchCollider;

	public bool noVolumeBelowMinVelocity = true;

	public SoundSettingFromRaycast[] velocitySettings;

	public LayerMask layer;

	public float distanceToGroundThreshold = 1f;

	public Rigidbody target;

	public Rigidbody2D target2D;

	public float fadeTime = 5f;

	private SoundSettingFromRaycast currentDirection;

	public float currentVelocity;

	public float highestVelocity;

	private float timeBeforeStart;

	private AudioSource audioSrc;

	private float dampVelocity;

	private SoundSettingFromRaycast DefaultDirectionSound = new SoundSettingFromRaycast();

	private void Awake()
	{
		audioSrc = GetComponent<AudioSource>();
		timeBeforeStart = Time.time + 0.5f;
	}

	private void Update()
	{
		if (Time.time < timeBeforeStart)
			return;
		if (target == null && target2D == null)
			return;

		if (mustTouchCollider)
		{
			currentDirection = GetCurrentDirection();
		}
		else
		{
			if (velocitySettings != null && velocitySettings.Length > 0 && velocitySettings[0] != null)
				currentDirection = velocitySettings[0];
			else
				currentDirection = DefaultDirectionSound;
		}
		VolumeFromCurrentDirection();
	}

	private SoundSettingFromRaycast GetCurrentDirection()
	{
		SoundSettingFromRaycast res = DefaultDirectionSound;
		if (velocitySettings != null)
		{
			for (int i = 0; i < velocitySettings.Length; i++)
			{
				var s = velocitySettings[i];
				if (s == null) continue;
				bool touching = TouchingSurface(s);
				s.touching = touching;
				if (touching)
					res = s;
			}
		}
		return res;
	}

	private void VolumeFromCurrentDirection()
	{
		if (velocitySettings == null || velocitySettings.Length == 0)
			return;
		float rawVel = 0f;
		if (use2DRigidbody)
		{
			if (target2D != null)
				rawVel = target2D.velocity.magnitude;
		}
		else if (target != null)
		{
			rawVel = target.velocity.magnitude;
		}

		currentVelocity = Mathf.SmoothDamp(currentVelocity, rawVel, ref dampVelocity, 0.06f);
		if (currentVelocity > highestVelocity)
			highestVelocity = currentVelocity;

		float targetVol = 0f;
		if (currentDirection != null)
		{
			if (!noVolumeBelowMinVelocity || currentVelocity > currentDirection.minVelocity)
			{
				float denom = currentDirection.maxVelocity - currentDirection.minVelocity;
				float t = denom != 0f ? ((currentVelocity - currentDirection.minVelocity) / denom) : 0f;
				targetVol = Mathf.Lerp(currentDirection.minVolume, currentDirection.maxVolume, t);
			}
		}

		if (audioSrc != null)
		{
			audioSrc.volume = Mathf.MoveTowards(audioSrc.volume, targetVol, Time.unscaledDeltaTime * fadeTime);
		}
	}

	private bool TouchingSurface(SoundSettingFromRaycast direction)
	{
		if (direction == null) return false;
		if (use2DSpace)
		{
			RaycastHit2D hit2d = Physics2D.Raycast(transform.position, direction.direction, distanceToGroundThreshold, layer);
			return hit2d.collider != null;
		}
		Ray r = new Ray(transform.position, direction.direction);
		return Physics.Raycast(r, distanceToGroundThreshold, layer);
	}
}
