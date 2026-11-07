using UnityEngine;

namespace Audio
{
	public class MovingSawSFX : MonoBehaviour
	{
		[SerializeField]
		private ClipSettingsCollection sfxOnTurn;

		[SerializeField]
		private AudioSource loopAudioSource;

		[SerializeField]
		private MovingPlatform movingPlatform;

		[SerializeField]
		private float randomPitchRange;

		private void Awake()
		{
		}

		private void OnTurn()
		{
		}
	}
}
