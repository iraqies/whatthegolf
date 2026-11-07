using Core;
using UnityEngine;

namespace Audio
{
	public class PlayerCarAudioV2 : MonoBehaviour, ISpatializeDisable
	{
		public AudioClipSettings FirstAimClip;

		public ClipSettingsCollection ForwardShootClips;

		public ClipSettingsCollection DriftShootClips;

		public float thresholdForward;

		public Rigidbody carRigidbody;

		public GolfBallController ballController;

		private bool firstAim;

		private bool firstShot;

		public bool DisableSpatial { get; set; }

		private void Awake()
		{
		}

		private void OnAim()
		{
		}

		private void OnShoot(Vector3 v)
		{
		}

		private void PlayShootClipFromDirection(Vector3 shootDirection)
		{
		}

		private void PlayGroupClip(ClipSettingsCollection c)
		{
		}

		private void PlayClipWithSettings(AudioClipSettings c)
		{
		}
	}
}
