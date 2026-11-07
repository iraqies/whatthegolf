using UnityEngine;

namespace Audio.Rumble
{
	public class RumbleEventAsset : ScriptableObject
	{
		[SerializeField]
		private float cooldown;

		[SerializeField]
		private RumbleCollection rumbleCollection;

		private float _nextPlayTime;

		private void OnEnable()
		{
		}

		public void Play(int playerIndex, float volume = 1f)
		{
		}

		public void PlaySpatial(SpatialRumbleSettings spatialSettings)
		{
		}

		public void PlaySpatial(Vector3 position, float range)
		{
		}

		public void PlayOnAllDevices(float volume = 1f)
		{
		}
	}
}
