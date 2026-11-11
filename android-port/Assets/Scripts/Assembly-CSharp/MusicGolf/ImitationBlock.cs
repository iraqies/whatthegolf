using System;
using System.Collections;
using UnityEngine;

namespace MusicGolf
{
	public class ImitationBlock : MonoBehaviour
	{
		private class MaterialInfo
		{
			public Material material;

			public Color color;
		}

		[SerializeField]
		private AudioClip questionClip;

		[SerializeField]
		private AudioClip answerClip;

		[SerializeField]
		private StingerData answerStinger;

		[SerializeField]
		private StingerData lastAnswerStinger;

		[SerializeField]
		private Renderer renderer;

		[SerializeField]
		private AnimationCurve glowAnimationCurve = AnimationCurve.Linear(0f, 0f, 1f, 1f);

		[SerializeField]
		private float glowDuration = 1f;

		[SerializeField]
		private Color glowColor = Color.white;

		private MaterialInfo[] materialInfo;

		private bool isPlaying;

		private Action<ImitationBlock> m_OnAfterPlay;

		private float lastCollisionTime;

		private AudioSource audioSource;

		public bool IsLastAnswer { get; set; }

		public event Action<ImitationBlock> OnAfterPlay
		{
			add
			{
				m_OnAfterPlay = (Action<ImitationBlock>)Delegate.Combine(m_OnAfterPlay, value);
			}
			remove
			{
				m_OnAfterPlay = (Action<ImitationBlock>)Delegate.Remove(m_OnAfterPlay, value);
			}
		}

		private void Awake()
		{
			audioSource = base.gameObject.AddComponent<AudioSource>();
			if (renderer == null)
			{
				return;
			}
			Material[] materials = renderer.materials;
			if (materials != null)
			{
				materialInfo = new MaterialInfo[materials.Length];
				for (int i = 0; i < materialInfo.Length; i++)
				{
					MaterialInfo materialInfo = new MaterialInfo
					{
						material = materials[i]
					};
					if (materials[i] != null)
					{
						materialInfo.color = materials[i].GetColor("_Color");
					}
					this.materialInfo[i] = materialInfo;
				}
			}
		}

		private void OnCollisionEnter2D(Collision2D col)
		{
			if (Time.time > lastCollisionTime + 1.5f)
			{
				StartCoroutine(PlayCoroutine(VoiceType.Answer));
				lastCollisionTime = Time.time;
			}
		}

		public void Play(VoiceType type)
		{
			StartCoroutine(PlayCoroutine(type));
		}

		private IEnumerator PlayCoroutine(VoiceType type)
		{
			if (isPlaying)
			{
				yield break;
			}
			if (audioSource != null)
			{
				audioSource.volume = 0.8f;
				audioSource.PlayOneShot((type == VoiceType.Question) ? questionClip : answerClip);
			}
			m_OnAfterPlay?.Invoke(this);
			yield return StartCoroutine(GlowCoroutine(glowDuration));
			isPlaying = false;
		}

		public void StopPlaying()
		{
			if (audioSource != null)
			{
				audioSource.Stop();
			}
		}

		public void Glow(float duration)
		{
			StartCoroutine(GlowCoroutine(duration));
		}

		private IEnumerator GlowCoroutine(float duration)
		{
			yield return StartCoroutine(pTween.To(glowDuration, delegate(float t)
			{
				if (materialInfo == null)
				{
					return;
				}
				for (int i = 0; i < materialInfo.Length; i++)
				{
					if (materialInfo[i] != null && materialInfo[i].material != null)
					{
						Color b = materialInfo[i].color + glowColor;
						float t2 = ((glowAnimationCurve != null) ? glowAnimationCurve.Evaluate(t) : t);
						materialInfo[i].material.SetColor("_Color", Color.Lerp(materialInfo[i].color, b, t2));
					}
				}
			}));
		}
	}
}
