using UnityEngine;

namespace MusicGolf
{
	public class PlatformBeatObject : BeatObject
	{
		[SerializeField]
		private float filledDuration = 0.5f;

		[SerializeField]
		private float width = 1f;

		[SerializeField]
		private Collider2D collider;

		[SerializeField]
		private Transform platformTransform;

		[SerializeField]
		private float normalizedEnvelopeLength = 0.1f;

		private Renderer[] platformRenderers;

		private Rigidbody2D m_rigid;

		private void Awake()
		{
			platformRenderers = GetComponentsInChildren<Renderer>();
			m_rigid = GetComponentInChildren<Rigidbody2D>();
		}

		public override void PlayStart()
		{
			SetPlatformStatus(true);
		}

		private void SetPlatformStatus(bool status)
		{
			if (platformRenderers != null)
			{
				for (int i = 0; i < platformRenderers.Length; i++)
				{
					if (platformRenderers[i] != null)
					{
						platformRenderers[i].enabled = status;
					}
				}
			}
			if (collider != null)
			{
				collider.enabled = status;
			}
			if (m_rigid != null)
			{
				m_rigid.simulated = status;
			}
		}

		public override void PlayProgress(float t)
		{
			if (StartClip != null)
			{
				StartClip.volume = 1f - Mathf.InverseLerp(1f - normalizedEnvelopeLength, 1f, t);
			}
			if (platformTransform != null)
			{
				float xScale = Mathf.Clamp01(Mathf.Lerp(1f, 0f, (t - filledDuration) / Mathf.Max(0.01f, 1f - filledDuration))) * width;
				platformTransform.localScale = new Vector3(xScale, platformTransform.localScale.y, platformTransform.localScale.z);
			}
		}

		public override void PlayStop()
		{
			SetPlatformStatus(false);
		}
	}
}
