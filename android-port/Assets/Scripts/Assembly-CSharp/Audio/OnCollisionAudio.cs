using UnityEngine;

namespace Audio
{
	public class OnCollisionAudio : OnCollisionAudioBase
	{
		protected override void Init()
		{
		}

		private void OnCollisionEnter2D(Collision2D col)
		{
			if (!useTrigger && col != null)
				PlayAudioFromCollision(AudioUtility.GetHitInfo(col));
		}

		private void OnCollisionEnter(Collision col)
		{
			if (!useTrigger && col != null)
				PlayAudioFromCollision(AudioUtility.GetHitInfo(col));
		}

		private void OnTriggerEnter2D(Collider2D col)
		{
			if (useTrigger && col != null)
				PlayAudioFromTrigger(col.gameObject);
		}

		private void OnTriggerEnter(Collider col)
		{
			if (useTrigger && col != null)
				PlayAudioFromTrigger(col.gameObject);
		}
	}
}
