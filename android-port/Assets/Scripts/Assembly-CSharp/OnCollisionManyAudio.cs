using System.Collections.Generic;
using Audio;
using Audio.Rumble;
using UnityEngine;

public class OnCollisionManyAudio : MonoBehaviour
{
	public class AudioCollisionCounter
	{
		public float startTime;

		public float endTime;

		public int count;
	}

	[SerializeField]
	private int amount;

	[SerializeField]
	private float time;

	[SerializeField]
	private float cooldownTimeBeforeStartingNewCount;

	[SerializeField]
	private List<OnCollisionAudio> collisionAudios;

	[SerializeField]
	private List<AudioClip> clips;

	[SerializeField]
	private List<RumbleEventAsset> rumbles;

	private List<AudioCollisionCounter> counters;

	private float nextPlay;

	private void Start()
	{
	}

	private void PlaySound()
	{
	}

	private void Ca_OnAudioPlay()
	{
	}
}
