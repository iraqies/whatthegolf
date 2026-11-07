using UnityEngine;

namespace Audio
{
	public class CarDriveOnHitAudio : MonoBehaviour
	{
		[SerializeField]
		private ClipSettingsCollection clipOnHit;

		private AudioSource source;

		private void Awake()
		{
		}

		public void OnHit()
		{
		}
	}
}
