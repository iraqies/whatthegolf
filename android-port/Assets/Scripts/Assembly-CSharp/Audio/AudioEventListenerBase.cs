using UnityEngine;

namespace Audio
{
	public abstract class AudioEventListenerBase : MonoBehaviour
	{
		public Component listenComponent;

		public bool listen;

		public bool findFirstTransmitterInParent;

		protected virtual void Awake()
		{
			if (!listen)
				return;
			IAudioEvent audioEvent = null;
			if (findFirstTransmitterInParent)
			{
				audioEvent = GetComponentInParent<IAudioEvent>();
			}
			else if (listenComponent != null)
			{
				audioEvent = listenComponent as IAudioEvent;
			}
			if (audioEvent != null)
			{
				audioEvent.OnAudioEvent = (System.Action<Vector3>)System.Delegate.Combine(audioEvent.OnAudioEvent, new System.Action<Vector3>(Play));
			}
		}

		public virtual void Play()
		{
		}

		public virtual void Play(Vector3 position)
		{
		}

		public virtual void Play(Vector3 position, float volumeMultiplier = 1f, float pitchMultiplier = 1f)
		{
		}
	}
}
