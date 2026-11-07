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

		[SerializeField]
		public List<AudioClip> clips;

		[SerializeField]
		public bool nonRepeating;

		[SerializeField]
		public bool playInOrder;

		[SerializeField]
		public ClipSettingsCollection clipSettings;

		[SerializeField]
		protected List<RumbleEventAsset> rumbleClips;

		[SerializeField]
		public float minVelocityThreshold;

		[SerializeField]
		public float maxVelocityThreshold;

		[SerializeField]
		protected bool includeAboveButClamped;

		[SerializeField]
		protected bool followTransform;

		[SerializeField]
		protected bool useTrigger;

		[SerializeField]
		protected bool startingCooldown;

		[SerializeField]
		public List<AudioMaterial> excludeMaterials;

		[SerializeField]
		public List<AudioMaterial> includeMaterials;

		[SerializeField]
		protected bool ShouldMuteOnOutOfBounds;

		[SerializeField]
		protected int disableAfterHits;

		[SerializeField]
		protected bool onlyFromDirection;

		[SerializeField]
		protected Vector3 Direction;

		[SerializeField]
		protected bool localAxis;

		[SerializeField]
		protected float DirectionThreshold;

		[SerializeField]
		protected float chanceToPlay;

		[SerializeField]
		protected int priority;

		[SerializeField]
		protected bool reverse;

		[SerializeField]
		protected float delay;

		[SerializeField]
		protected float minVolume;

		[SerializeField]
		protected float maxVolume;

		[SerializeField]
		protected float randomVolume;

		[SerializeField]
		protected float minPitch;

		[SerializeField]
		protected float maxPitch;

		[SerializeField]
		protected float randomPitch;

		[SerializeField]
		protected float maxDistance;

		[SerializeField]
		protected float coolDown;

		[SerializeField]
		protected ConditionChecker Conditions;

		protected float nextSoundTime;

		protected AudioClip lastClip;

		protected int lastIndex;

		private int triggerCount;

		private bool isCollisionWithPlayer;

		public float baseVolume;

		[CompilerGenerated]
		private Action m_OnAudioPlay;

		private HitInfo _lastHitInfo;

		public bool IsVisible { get; set; }

		public bool IsEnabled { get; set; }

		public bool DisableSpatial { get; set; }

		public event Action OnAudioPlay
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

		public void SetCooldown(float time)
		{
		}

		private void OnEnable()
		{
		}

		private void Awake()
		{
		}

		protected virtual void Init()
		{
		}

		public void PlayAudioFromCollision(HitInfo hitInfo)
		{
		}

		private void Play(Vector3 position, float volume, float pitch)
		{
		}

		protected void PlayAudioFromTrigger(GameObject go)
		{
		}

		private AudioClip ReturnNextClip()
		{
			return null;
		}

		protected bool ReadyToPlay()
		{
			return false;
		}

		protected bool WithinChance()
		{
			return false;
		}

		private bool CheckAudioMaterial(GameObject go)
		{
			return false;
		}

		public void ResetOutOfBounds()
		{
		}

		public void CheckOutOfBounds(string tag)
		{
		}

		public void CheckOutOfBounds(GameObject goToCheck)
		{
		}
	}
}
