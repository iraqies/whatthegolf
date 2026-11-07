using UnityEngine;

namespace Audio
{
	public class BowlingCollisionAudio : MonoBehaviour
	{
		[SerializeField]
		private Rigidbody rigid;

		[SerializeField]
		private AudioSource rollAudioSource;

		[SerializeField]
		private RandomAudioClips collisionBowlingCourt;

		[SerializeField]
		private RandomAudioClips groundClips;

		[SerializeField]
		private MinMax velocityMinMax;

		[SerializeField]
		private AudioMaterial CourtMaterial;

		[SerializeField]
		private AudioMaterial GroundMaterial;

		private RigidbodyCollisionInfo col;

		private float nextSoundTime;

		private bool onCourt;

		private void Start()
		{
		}

		private void FixedUpdate()
		{
		}

		private void Info_OnCollision(HitInfo info)
		{
		}

		private void Play(RandomAudioClips clips, float pct)
		{
		}
	}
}
