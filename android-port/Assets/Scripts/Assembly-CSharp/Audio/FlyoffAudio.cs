using UnityEngine;

namespace Audio
{
	public class FlyoffAudio : MonoBehaviour
	{
		public AudioSource audioSource;

		public RandomAudioClips clips;

		public Rigidbody rigid;

		public Rigidbody2D rigid2D;

		public float threshold = 10f;

		public float timeAboveThreshold = 0.1f;

		private float timer;

		private bool played;

		private void FixedUpdate()
		{
			float speed = 0f;
			if (rigid2D != null)
				speed = rigid2D.velocity.magnitude;
			else if (rigid != null)
				speed = rigid.velocity.magnitude;
			else
				return;

			if (speed > threshold)
			{
				timer += Time.fixedDeltaTime;
			}
			else
			{
				timer = 0f;
				played = false;
			}

			if (timer > timeAboveThreshold && !played && clips != null)
			{
				if (audioSource != null)
					clips.PlayRandomClipOnSource(audioSource);
				else
					clips.PlayRandomClip(transform);
				played = true;
			}
		}
	}
}
