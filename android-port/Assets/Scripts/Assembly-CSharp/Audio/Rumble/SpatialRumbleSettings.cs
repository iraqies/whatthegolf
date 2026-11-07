using UnityEngine;

namespace Audio.Rumble
{
	public class SpatialRumbleSettings : MonoBehaviour
	{
		[SerializeField]
		private Component audioEventComponent;

		[SerializeField]
		private RumbleEventAsset rumbleSettings;

		[SerializeField]
		private float range;

		private IAudioEvent _event;

		public float Range => 0f;

		public RumbleEventAsset RumbleSettings => null;

		private void Awake()
		{
		}

		private void OnAudioEvent(Vector3 obj)
		{
		}

		private void OnDrawGizmosSelected()
		{
		}
	}
}
