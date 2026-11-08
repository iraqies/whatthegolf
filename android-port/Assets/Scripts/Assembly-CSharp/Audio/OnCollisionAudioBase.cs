using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Audio.Conditions;
using Audio.Rumble;
using UnityEngine;

namespace Audio
{
	public abstract class OnCollisionAudioBase : MonoBehaviour, IAudioCullable, ISpatializeDisable
	{
		public float lastRecordedImpactVelocity;
		public float maxRecordedImpactVelocity;
		public bool isOutOfBounds;
		[SerializeField] public List<AudioClip> clips;
		[SerializeField] public bool nonRepeating;
		[SerializeField] public bool playInOrder;
		[SerializeField] public ClipSettingsCollection clipSettings;
		[SerializeField] protected List<RumbleEventAsset> rumbleClips;
		[SerializeField] public float minVelocityThreshold = 0.2f;
		[SerializeField] public float maxVelocityThreshold = 15f;
		[SerializeField] protected bool includeAboveButClamped = true;
		[SerializeField] protected bool followTransform;
		[SerializeField] protected bool useTrigger;
		[SerializeField] protected bool startingCooldown;
		[SerializeField] public List<AudioMaterial> excludeMaterials;
		[SerializeField] public List<AudioMaterial> includeMaterials;
		[SerializeField] protected bool ShouldMuteOnOutOfBounds;
		[SerializeField] protected int disableAfterHits;
		[SerializeField] protected bool onlyFromDirection;
		[SerializeField] protected Vector3 Direction;
		[SerializeField] protected bool localAxis;
		[SerializeField] protected float DirectionThreshold;
		[SerializeField] protected float chanceToPlay = 1f;
		[SerializeField] protected int priority;
		[SerializeField] protected bool reverse;
		[SerializeField] protected float delay;
		[SerializeField] protected float minVolume = 0.25f;
		[SerializeField] protected float maxVolume = 1f;
		[SerializeField] protected float randomVolume;
		[SerializeField] protected float minPitch = 0.9f;
		[SerializeField] protected float maxPitch = 1.1f;
		[SerializeField] protected float randomPitch;
		[SerializeField] protected float maxDistance = 30f;
		[SerializeField] protected float coolDown = 0.05f;
		[SerializeField] protected ConditionChecker Conditions;

		protected float nextSoundTime;
		protected AudioClip lastClip;
		protected int lastIndex;
		private int triggerCount;
		private bool isCollisionWithPlayer;
		public float baseVolume = 1f;
		[CompilerGenerated] private Action m_OnAudioPlay;
		private HitInfo _lastHitInfo;

		public bool IsVisible { get; set; } = true;
		public bool IsEnabled { get; set; } = true;
		public bool DisableSpatial { get; set; }

		public event Action OnAudioPlay
		{
			[CompilerGenerated]
			add => m_OnAudioPlay = (Action)Delegate.Combine(m_OnAudioPlay, value);
			[CompilerGenerated]
			remove => m_OnAudioPlay = (Action)Delegate.Remove(m_OnAudioPlay, value);
		}

		public void SetCooldown(float time)
		{
			nextSoundTime = Time.unscaledTime + time;
		}

		private void OnEnable()
		{
			IsEnabled = true;
			IsVisible = true;
		}

		private void Awake()
		{
			IsEnabled = true;
			IsVisible = true;
			Init();
		}

		protected virtual void Init()
		{
		}

		public void PlayAudioFromCollision(HitInfo hitInfo)
		{
			_lastHitInfo = hitInfo;
			float speed = hitInfo.incomingVelocity.magnitude;
			lastRecordedImpactVelocity = speed;
			if (speed > maxRecordedImpactVelocity) maxRecordedImpactVelocity = speed;
			if (speed < Mathf.Max(0.1f, minVelocityThreshold * 0.25f)) return;
			if (!ReadyToPlay()) return;
			float t = maxVelocityThreshold > minVelocityThreshold ? Mathf.InverseLerp(minVelocityThreshold, maxVelocityThreshold, speed) : 0.8f;
			float vol = Mathf.Lerp(minVolume > 0f ? minVolume : 0.35f, maxVolume > 0f ? maxVolume : 1f, Mathf.Clamp01(t));
			float pit = Mathf.Lerp(minPitch > 0.1f ? minPitch : 0.95f, maxPitch > 0.1f ? maxPitch : 1.05f, Mathf.Clamp01(t));
			Play(hitInfo.point, vol, pit);
		}

		private void Play(Vector3 position, float volume, float pitch)
		{
			nextSoundTime = Time.unscaledTime + Mathf.Max(0.03f, coolDown);
			if (clipSettings != null && clipSettings.Count > 0)
			{
				clipSettings.Play(position, volume, pitch);
				m_OnAudioPlay?.Invoke();
				return;
			}
			var clip = ReturnNextClip();
			if (clip != null && AudioManager.Instance != null)
			{
				var voice = AudioManager.Instance.impactEffects ?? AudioManager.Instance.shortEffects;
				voice?.PlaySimple(clip, volume, pitch, position, maxDistance, DisableSpatial);
				m_OnAudioPlay?.Invoke();
			}
		}

		protected void PlayAudioFromTrigger(GameObject go)
		{
			if (!ReadyToPlay()) return;
			Play(transform.position, maxVolume > 0f ? maxVolume : 0.8f, 1f);
		}

		private AudioClip ReturnNextClip()
		{
			if (clips == null || clips.Count == 0) return null;
			if (playInOrder)
			{
				var c = clips[lastIndex % clips.Count];
				lastIndex = (lastIndex + 1) % clips.Count;
				lastClip = c;
				return c;
			}
			var chosen = clips[UnityEngine.Random.Range(0, clips.Count)];
			lastClip = chosen;
			return chosen;
		}

		protected bool ReadyToPlay()
		{
			return Time.unscaledTime >= nextSoundTime;
		}

		protected bool WithinChance() => true;
		private bool CheckAudioMaterial(GameObject go) => true;
		public void ResetOutOfBounds() => isOutOfBounds = false;
		public void CheckOutOfBounds(string tag) { }
		public void CheckOutOfBounds(GameObject goToCheck) { }
	}
}
