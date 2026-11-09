using System;
using UnityEngine;

namespace Audio
{
	public class TrafficCarAudio : MonoBehaviour
	{
		public CarAgent carAgent;

		public RandomAudioClips clipOnSpeedUp;

		public RandomAudioClips clipsOnFallingOffSide;

		public AudioSource audioSource;

		private bool isInitialSpawn;

		private TrafficController trafficController;

		private bool hasCarFallen;

		private void Awake()
		{
			if (carAgent != null)
			{
				carAgent._onCarSpeeding = (Action)Delegate.Combine(carAgent._onCarSpeeding, new Action(CarAgent_OnCarSpeeding));
				carAgent._onOutOfBounds = (Action)Delegate.Combine(carAgent._onOutOfBounds, new Action(CarAgent_onOutOfBounds));
				carAgent._onCarFallingOffSide = (Action)Delegate.Combine(carAgent._onCarFallingOffSide, new Action(CarAgent__OnCarFallingOffSide));
			}
		}

		private void OnEnable()
		{
			if (isInitialSpawn)
			{
				AudioClip nextClip = null;
				if (trafficController != null)
					nextClip = trafficController.GetNextEngineClip();
				if (audioSource != null)
				{
					if (nextClip == null)
						nextClip = audioSource.clip;
					audioSource.clip = nextClip;
					audioSource.Play();
				}
			}
			else
			{
				trafficController = GetComponentInParent<TrafficController>();
				isInitialSpawn = true;
			}
		}

		private void CarAgent_OnCarSpeeding()
		{
			if (carAgent == null || clipOnSpeedUp == null) return;
			clipOnSpeedUp.PlayRandomClip(carAgent.transform);
			AudioSource src = clipOnSpeedUp.GetCurrentAudioSource();
			AudioClip clip = clipOnSpeedUp.ReturnLastClip();
			if (AudioManager.Instance != null && src != null && clip != null)
			{
				AudioManager.Instance.AudioSourceFollowTransform(src, carAgent.transform, clip.length);
			}
		}

		private void CarAgent__OnCarFallingOffSide()
		{
			if (!hasCarFallen && carAgent != null && clipsOnFallingOffSide != null)
			{
				clipsOnFallingOffSide.PlayRandomClip(carAgent.transform);
				hasCarFallen = true;
			}
		}

		private void CarAgent_onOutOfBounds()
		{
			if (audioSource != null)
				audioSource.Stop();
			hasCarFallen = false;
		}
	}
}
