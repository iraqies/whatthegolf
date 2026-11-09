using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Audio.Conditions;
using Audio.Rumble;
using Core;
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
		[SerializeField] public float minVelocityThreshold = 3f;
		[SerializeField] public float maxVelocityThreshold = 50f;
		[SerializeField] protected bool includeAboveButClamped = true;
		[SerializeField] protected bool followTransform;
		[SerializeField] protected bool useTrigger;
		[SerializeField] protected bool startingCooldown = true;
		[SerializeField] public List<AudioMaterial> excludeMaterials;
		[SerializeField] public List<AudioMaterial> includeMaterials;
		[SerializeField] protected bool ShouldMuteOnOutOfBounds = true;
		[SerializeField] protected int disableAfterHits;
		[SerializeField] protected bool onlyFromDirection;
		[SerializeField] protected Vector3 Direction;
		[SerializeField] protected bool localAxis;
		[SerializeField] protected float DirectionThreshold;
		[SerializeField] protected float chanceToPlay = 1f;
		[SerializeField] protected int priority = 128;
		[SerializeField] protected bool reverse;
		[SerializeField] protected float delay;
		[SerializeField] protected float minVolume = 0.5f;
		[SerializeField] protected float maxVolume = 0.8f;
		[SerializeField] protected float randomVolume = 0.05f;
		[SerializeField] protected float minPitch = 0.95f;
		[SerializeField] protected float maxPitch = 1.05f;
		[SerializeField] protected float randomPitch = 0.05f;
		[SerializeField] protected float maxDistance = 30f;
		[SerializeField] protected float coolDown = 0.12f;
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
			nextSoundTime = Time.time + time;
		}

		private void OnEnable()
		{
			IsEnabled = true;
			triggerCount = 0;
		}

		private void Awake()
		{
			Init();
		}

		protected virtual void Init()
		{
		}

		public void PlayAudioFromCollision(HitInfo hitInfo)
		{
			if (hitInfo.otherHit == null) return;
			isCollisionWithPlayer = hitInfo.otherHit.layer == LayerMask.NameToLayer("GolfBall");
			_lastHitInfo = hitInfo;
			if (!IsVisible || !IsEnabled) return;
			if (!ReadyToPlay()) return;
			if (!WithinChance()) return;
			if (!CheckAudioMaterial(hitInfo.otherHit)) return;
			if (Conditions != null && !Conditions.CheckConditions()) return;

			if (onlyFromDirection)
			{
				Vector3 dir = localAxis ? transform.TransformDirection(Direction) : Direction;
				Vector3 toPoint = (hitInfo.point - transform.position).normalized;
				if (Vector3.Dot(dir, toPoint) < 1f - DirectionThreshold)
					return;
			}

			float speed = hitInfo.impactOnNormal.sqrMagnitude > 0f ? hitInfo.impactOnNormal.magnitude : hitInfo.incomingVelocity.magnitude;
			lastRecordedImpactVelocity = speed;
			maxRecordedImpactVelocity = Mathf.Max(maxRecordedImpactVelocity, speed);
			if (speed <= minVelocityThreshold) return;
			if (speed >= maxVelocityThreshold && !includeAboveButClamped) return;

			float t = maxVelocityThreshold > minVelocityThreshold ? Mathf.Clamp01((speed - minVelocityThreshold) / (maxVelocityThreshold - minVelocityThreshold)) : 1f;
			float vol = Mathf.Lerp(minVolume, maxVolume, t) + UnityEngine.Random.Range(-randomVolume, randomVolume);
			float pit = Mathf.Lerp(minPitch, maxPitch, t) + UnityEngine.Random.Range(-randomPitch, randomPitch);
			Play(hitInfo.point, vol, pit);
			if (rumbleClips != null)
				rumbleClips.PlayOnAllControllers(t);
		}

		private void Play(Vector3 position, float volume, float pitch)
		{
			m_OnAudioPlay?.Invoke();
			nextSoundTime = Time.time + coolDown;
			bool nonSpatial = DisableSpatial;
			if (!nonSpatial)
			{
				bool notMultiplayer = !Level.HasInstance || Level.Instance == null || !Level.Instance.IsMultiplayer;
				if (notMultiplayer)
					nonSpatial = isCollisionWithPlayer;
			}

			if (clipSettings != null && clipSettings.Clips != null && clipSettings.Clips.Count >= 1)
			{
				var playInfo = clipSettings.GetPlayInfo();
				if (playInfo.clip != null && AudioManager.Instance != null && AudioManager.Instance.shortEffects != null)
				{
					AudioManager.Instance.shortEffects.PlaySimple(playInfo.clip, volume * playInfo.VolumeResult * baseVolume, pitch * playInfo.PitchResult, position, maxDistance, nonSpatial);
					lastClip = playInfo.clip;
				}
			}
			else
			{
				var clip = ReturnNextClip();
				if (clip != null && AudioManager.Instance != null && AudioManager.Instance.shortEffects != null)
				{
					AudioManager.Instance.shortEffects.PlaySimple(clip, volume * baseVolume, pitch, position, maxDistance, nonSpatial);
					lastClip = clip;
				}
			}

			triggerCount++;
			if (disableAfterHits >= 1 && triggerCount >= disableAfterHits)
			{
				IsEnabled = false;
			}
		}

		protected void PlayAudioFromTrigger(GameObject go)
		{
			if (!IsVisible || !IsEnabled) return;
			if (!WithinChance()) return;
			if (!CheckAudioMaterial(go)) return;
			if (!ReadyToPlay()) return;
			if (go == null) return;

			float vol = UnityEngine.Random.Range(minVolume, maxVolume) * baseVolume;
			float pit = UnityEngine.Random.Range(minPitch, maxPitch);
			Play(go.transform.position, vol, pit);
		}

		private AudioClip ReturnNextClip()
		{
			if (clips == null || clips.Count == 0) return null;
			if (playInOrder)
			{
				var c = clips[lastIndex % clips.Count];
				lastIndex = (lastIndex + 1) % clips.Count;
				return c;
			}
			int idx = UnityEngine.Random.Range(0, clips.Count);
			var chosen = clips[idx];
			if (nonRepeating && clips.Count >= 2)
			{
				int guard = 0;
				while (chosen == lastClip && guard < 10)
				{
					idx = UnityEngine.Random.Range(0, clips.Count);
					chosen = clips[idx];
					guard++;
				}
			}
			return chosen;
		}

		protected bool ReadyToPlay()
		{
			if (!IsEnabled || !gameObject.activeSelf) return false;
			bool hasClips = (clips != null && clips.Count > 0) || (clipSettings != null && clipSettings.Clips != null && clipSettings.Clips.Count >= 1);
			if (!hasClips) return false;
			if (Time.time <= nextSoundTime) return false;
			return baseVolume > 0f;
		}

		protected bool WithinChance()
		{
			if (chanceToPlay > 0.99f) return true;
			return UnityEngine.Random.Range(0f, 1f) <= chanceToPlay;
		}

		private bool CheckAudioMaterial(GameObject go)
		{
			if ((includeMaterials != null && includeMaterials.Count != 0) || (excludeMaterials != null && excludeMaterials.Count != 0))
			{
				if (AudioManager.Instance != null)
					return AudioManager.Instance.CheckMaterial(go, includeMaterials, excludeMaterials, false);
			}
			return true;
		}

		public void ResetOutOfBounds() => isOutOfBounds = false;

		public void CheckOutOfBounds(string tag)
		{
			if (!gameObject.activeSelf || !ShouldMuteOnOutOfBounds || isOutOfBounds) return;
			if (tag == "OutOfBounds" || tag == "Water" || tag == "Lava")
			{
				isOutOfBounds = true;
				float startVol = baseVolume;
				StartCoroutine(pTween.To(0.6f, startVol, -0.1f, t => baseVolume = t));
			}
		}

		public void CheckOutOfBounds(GameObject goToCheck)
		{
			if (!gameObject.activeSelf || goToCheck == null) return;
			if (goToCheck.CompareTag("OutOfBounds") || goToCheck.CompareTag("Water") || goToCheck.CompareTag("Lava"))
			{
				if (ShouldMuteOnOutOfBounds && !isOutOfBounds)
				{
					isOutOfBounds = true;
					float startVol = baseVolume;
					StartCoroutine(pTween.To(0.6f, startVol, -0.1f, t => baseVolume = t));
				}
			}
		}
	}
}
