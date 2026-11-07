using UnityEngine;

namespace MusicGolf
{
	public class PlatformBeatObject : BeatObject
	{
		[SerializeField]
		private float filledDuration;

		[SerializeField]
		private float width;

		[SerializeField]
		private Collider2D collider;

		[SerializeField]
		private Transform platformTransform;

		[SerializeField]
		private float normalizedEnvelopeLength;

		private Renderer[] platformRenderers;

		private Rigidbody2D m_rigid;

		private void Awake()
		{
		}

		public override void PlayStart()
		{
		}

		private void SetPlatformStatus(bool status)
		{
		}

		public override void PlayProgress(float t)
		{
		}

		public override void PlayStop()
		{
		}
	}
}
