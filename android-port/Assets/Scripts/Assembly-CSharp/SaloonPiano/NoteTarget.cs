using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SaloonPiano
{
	public class NoteTarget : MonoBehaviour
	{
		public LayerMask AcceptedLayers;

		[CompilerGenerated]
		private Action m_OnHit;

		public GameObject notHitRoot;

		public GameObject notHitCorrectRoot;

		public GameObject notHitWrongRoot;

		public GameObject hitRoot;

		public ParticleSystem hitParticleSystem;

		private bool hasBeenHit;

		private bool isWrong;

		public event Action OnHit
		{
			[CompilerGenerated]
			add
			{
				m_OnHit = (Action)Delegate.Combine(m_OnHit, value);
			}
			[CompilerGenerated]
			remove
			{
				m_OnHit = (Action)Delegate.Remove(m_OnHit, value);
			}
		}

		public void Initialize(bool isWrong)
		{
			this.isWrong = isWrong;
			hasBeenHit = false;
			if (notHitRoot != null)
			{
				notHitRoot.SetActive(true);
			}
			if (notHitCorrectRoot != null)
			{
				notHitCorrectRoot.SetActive(!isWrong);
			}
			if (notHitWrongRoot != null)
			{
				notHitWrongRoot.SetActive(isWrong);
			}
			if (hitRoot != null)
			{
				hitRoot.SetActive(false);
			}
		}

		private void OnCollisionEnter(Collision collision)
		{
			if (hasBeenHit || collision == null || collision.gameObject == null)
			{
				return;
			}
			if (((1 << collision.gameObject.layer) & AcceptedLayers.value) != 0)
			{
				hasBeenHit = true;
				if (notHitRoot != null)
				{
					notHitRoot.SetActive(false);
				}
				if (hitRoot != null)
				{
					hitRoot.SetActive(true);
				}
				if (hitParticleSystem != null)
				{
					hitParticleSystem.Play();
				}
				m_OnHit?.Invoke();
			}
		}
	}
}
