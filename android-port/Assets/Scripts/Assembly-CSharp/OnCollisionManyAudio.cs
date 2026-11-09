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
	private int amount = 3;

	[SerializeField]
	private float time = 0.5f;

	[SerializeField]
	private float cooldownTimeBeforeStartingNewCount = 0.5f;

	[SerializeField]
	private List<OnCollisionAudio> collisionAudios;

	[SerializeField]
	private List<AudioClip> clips;

	[SerializeField]
	private List<RumbleEventAsset> rumbles;

	private List<AudioCollisionCounter> counters = new List<AudioCollisionCounter>();

	private float nextPlay;

	private void Start()
	{
		if (collisionAudios != null)
		{
			for (int i = 0; i < collisionAudios.Count; i++)
			{
				if (collisionAudios[i] != null)
				{
					collisionAudios[i].OnAudioPlay -= Ca_OnAudioPlay;
					collisionAudios[i].OnAudioPlay += Ca_OnAudioPlay;
				}
			}
		}
	}

	private void PlaySound()
	{
		if (clips != null && clips.Count > 0 && AudioManager.Instance != null && AudioManager.Instance.shortEffects != null)
		{
			AudioManager.Instance.shortEffects.Play(clips);
		}
		if (rumbles != null)
			rumbles.PlayOnAllControllers(1f);
		nextPlay = Time.time + cooldownTimeBeforeStartingNewCount;
	}

	private void Ca_OnAudioPlay()
	{
		if (Time.time < nextPlay)
			return;
		if (counters == null)
			counters = new List<AudioCollisionCounter>();
		counters.RemoveAll(c => c == null || Time.time > c.endTime);
		counters.Add(new AudioCollisionCounter { startTime = Time.time, endTime = Time.time + time, count = 0 });
		for (int i = 0; i < counters.Count; i++)
		{
			counters[i].count++;
			if (counters[i].count >= Mathf.Max(1, amount))
			{
				counters.Clear();
				PlaySound();
				break;
			}
		}
	}
}
