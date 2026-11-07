using System;
using System.Collections;
using System.Runtime.CompilerServices;
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
		private AnimationCurve glowAnimationCurve;

		[SerializeField]
		private float glowDuration;

		[SerializeField]
		private Color glowColor;

		private MaterialInfo[] materialInfo;

		private bool isPlaying;

		[CompilerGenerated]
		private Action<ImitationBlock> m_OnAfterPlay;

		private float lastCollisionTime;

		private AudioSource audioSource;

		public bool IsLastAnswer { get; set; }

		public event Action<ImitationBlock> OnAfterPlay
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private void Awake()
		{
		}

		private void OnCollisionEnter2D(Collision2D col)
		{
		}

		public void Play(VoiceType type)
		{
		}

		private IEnumerator PlayCoroutine(VoiceType type)
		{
			return null;
		}

		public void StopPlaying()
		{
		}

		public void Glow(float duration)
		{
		}

		private IEnumerator GlowCoroutine(float duration)
		{
			return null;
		}
	}
}
