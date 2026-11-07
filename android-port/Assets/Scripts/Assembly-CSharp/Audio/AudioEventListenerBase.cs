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
