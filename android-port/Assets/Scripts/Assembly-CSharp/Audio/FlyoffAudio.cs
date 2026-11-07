using UnityEngine;

namespace Audio
{
	public class FlyoffAudio : MonoBehaviour
	{
		public AudioSource audioSource;

		public RandomAudioClips clips;

		public Rigidbody rigid;

		public Rigidbody2D rigid2D;

		public float threshold;

		public float timeAboveThreshold;

		private float timer;

		private bool played;

		private void FixedUpdate()
		{
		}
	}
}
