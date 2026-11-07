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

	public bool noVolumeBelowMinVelocity;

	public SoundSettingFromRaycast[] velocitySettings;

	public LayerMask layer;

	public float distanceToGroundThreshold;

	public Rigidbody target;

	public Rigidbody2D target2D;

	public float fadeTime;

	private SoundSettingFromRaycast currentDirection;

	public float currentVelocity;

	public float highestVelocity;

	private float timeBeforeStart;

	private AudioSource audioSrc;

	private float dampVelocity;

	private SoundSettingFromRaycast DefaultDirectionSound;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private SoundSettingFromRaycast GetCurrentDirection()
	{
		return null;
	}

	private void VolumeFromCurrentDirection()
	{
	}

	private bool TouchingSurface(SoundSettingFromRaycast direction)
	{
		return false;
	}
}
