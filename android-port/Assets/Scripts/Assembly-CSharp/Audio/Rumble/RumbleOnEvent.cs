using UnityEngine;

namespace Audio.Rumble
{
	public class RumbleOnEvent : MonoBehaviour
	{
		[SerializeField]
		private Component audioEventComponent;

		[SerializeField]
		private RumbleEventAsset rumbleSettings;

		private IAudioEvent _event;

		private void Awake()
		{
		}

		private void OnAudioEvent(Vector3 obj)
		{
		}
	}
}
