using System;
using System.Collections.Generic;
using Audio.Conditions;
using Audio.Rumble;
using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x2001367")]
	public abstract class OnCollisionAudioBase : MonoBehaviour, IAudioCullable, ISpatializeDisable
	{
		[Token(Token = "0x40067DC")]
		[FieldOffset(Offset = "0x18")]
		public float lastRecordedImpactVelocity;

		[Token(Token = "0x40067DD")]
		[FieldOffset(Offset = "0x1C")]
		public float maxRecordedImpactVelocity;

		[Token(Token = "0x40067DE")]
		[FieldOffset(Offset = "0x20")]
		public bool isOutOfBounds;

		[Token(Token = "0x40067DF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		public List<AudioClip> clips;

		[Token(Token = "0x40067E0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		public bool nonRepeating;

		[Token(Token = "0x40067E1")]
		[FieldOffset(Offset = "0x31")]
		[SerializeField]
		public bool playInOrder;

		[Token(Token = "0x40067E2")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		public ClipSettingsCollection clipSettings;

		[Token(Token = "0x40067E3")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		protected List<RumbleEventAsset> rumbleClips;

		[Token(Token = "0x40067E4")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		public float minVelocityThreshold;

		[Token(Token = "0x40067E5")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		public float maxVelocityThreshold;

		[Token(Token = "0x40067E6")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		protected bool includeAboveButClamped;

		[Token(Token = "0x40067E7")]
		[FieldOffset(Offset = "0x51")]
		[SerializeField]
		protected bool followTransform;

		[Token(Token = "0x40067E8")]
		[FieldOffset(Offset = "0x52")]
		[SerializeField]
		protected bool useTrigger;

		[Token(Token = "0x40067E9")]
		[FieldOffset(Offset = "0x53")]
		[SerializeField]
		protected bool startingCooldown;

		[Token(Token = "0x40067EA")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		public List<AudioMaterial> excludeMaterials;

		[Token(Token = "0x40067EB")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		public List<AudioMaterial> includeMaterials;

		[Token(Token = "0x40067EC")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		protected bool ShouldMuteOnOutOfBounds;

		[Token(Token = "0x40067ED")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		protected int disableAfterHits;

		[Token(Token = "0x40067EE")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		protected bool onlyFromDirection;

		[Token(Token = "0x40067EF")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		protected Vector3 Direction;

		[Token(Token = "0x40067F0")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		protected bool localAxis;

		[Token(Token = "0x40067F1")]
		[FieldOffset(Offset = "0x84")]
		[SerializeField]
		protected float DirectionThreshold;

		[Token(Token = "0x40067F2")]
		[FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5A2B0", Offset = "0x5A2B0")]
		[SerializeField]
		protected float chanceToPlay;

		[Token(Token = "0x40067F3")]
		[FieldOffset(Offset = "0x8C")]
		[SerializeField]
		protected int priority;

		[Token(Token = "0x40067F4")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		protected bool reverse;

		[Token(Token = "0x40067F5")]
		[FieldOffset(Offset = "0x94")]
		[SerializeField]
		protected float delay;

		[Token(Token = "0x40067F6")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		protected float minVolume;

		[Token(Token = "0x40067F7")]
		[FieldOffset(Offset = "0x9C")]
		[SerializeField]
		protected float maxVolume;

		[Token(Token = "0x40067F8")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		protected float randomVolume;

		[Token(Token = "0x40067F9")]
		[FieldOffset(Offset = "0xA4")]
		[SerializeField]
		protected float minPitch;

		[Token(Token = "0x40067FA")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		protected float maxPitch;

		[Token(Token = "0x40067FB")]
		[FieldOffset(Offset = "0xAC")]
		[SerializeField]
		protected float randomPitch;

		[Token(Token = "0x40067FC")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		protected float maxDistance;

		[Token(Token = "0x40067FD")]
		[FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5A390", Offset = "0x5A390")]
		[SerializeField]
		protected float coolDown;

		[Token(Token = "0x40067FE")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		protected ConditionChecker Conditions;

		[Token(Token = "0x40067FF")]
		[FieldOffset(Offset = "0xC0")]
		protected float nextSoundTime;

		[Token(Token = "0x4006800")]
		[FieldOffset(Offset = "0xC8")]
		protected AudioClip lastClip;

		[Token(Token = "0x4006801")]
		[FieldOffset(Offset = "0xD0")]
		protected int lastIndex;

		[Token(Token = "0x4006802")]
		[FieldOffset(Offset = "0xD4")]
		private int triggerCount;

		[Token(Token = "0x4006803")]
		[FieldOffset(Offset = "0xD8")]
		private bool isCollisionWithPlayer;

		[Token(Token = "0x4006804")]
		[FieldOffset(Offset = "0xD9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5A3E0", Offset = "0x5A3E0")]
		private bool IsVisible__BackingField;

		[Token(Token = "0x4006805")]
		[FieldOffset(Offset = "0xDA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5A3F0", Offset = "0x5A3F0")]
		private bool IsEnabled__BackingField;

		[Token(Token = "0x4006806")]
		[FieldOffset(Offset = "0xDB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5A400", Offset = "0x5A400")]
		private bool DisableSpatial__BackingField;

		[Token(Token = "0x4006807")]
		[FieldOffset(Offset = "0xDC")]
		public float baseVolume;

		[Token(Token = "0x4006808")]
		[FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5A410", Offset = "0x5A410")]
		private Action m_OnAudioPlay;

		[Token(Token = "0x4006809")]
		[FieldOffset(Offset = "0xE8")]
		private HitInfo _lastHitInfo;

		[Token(Token = "0x17000A38")]
		public bool IsVisible
		{
			[Token(Token = "0x6005A80")]
			[Address(RVA = "0x1597054", Offset = "0x1597054", VA = "0x1597054", Slot = "6")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x72388", Offset = "0x72388")]
			get
			{
				return default;
			}
			[Token(Token = "0x6005A81")]
			[Address(RVA = "0x159705C", Offset = "0x159705C", VA = "0x159705C", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x72398", Offset = "0x72398")]
			set
			{
			}
		}

		[Token(Token = "0x17000A39")]
		public bool IsEnabled
		{
			[Token(Token = "0x6005A82")]
			[Address(RVA = "0x1597064", Offset = "0x1597064", VA = "0x1597064")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x723A8", Offset = "0x723A8")]
			get
			{
				return default;
			}
			[Token(Token = "0x6005A83")]
			[Address(RVA = "0x159706C", Offset = "0x159706C", VA = "0x159706C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x723B8", Offset = "0x723B8")]
			set
			{
			}
		}

		[Token(Token = "0x17000A3A")]
		public bool DisableSpatial
		{
			[Token(Token = "0x6005A84")]
			[Address(RVA = "0x1597074", Offset = "0x1597074", VA = "0x1597074", Slot = "7")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x723C8", Offset = "0x723C8")]
			get
			{
				return default;
			}
			[Token(Token = "0x6005A85")]
			[Address(RVA = "0x159707C", Offset = "0x159707C", VA = "0x159707C", Slot = "5")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x723D8", Offset = "0x723D8")]
			set
			{
			}
		}

		[Token(Token = "0x1400009C")]
		public event Action OnAudioPlay
		{
			[Token(Token = "0x6005A87")]
			[Address(RVA = "0x15970BC", Offset = "0x15970BC", VA = "0x15970BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x723E8", Offset = "0x723E8")]
			add
			{
			}
			[Token(Token = "0x6005A88")]
			[Address(RVA = "0x1597160", Offset = "0x1597160", VA = "0x1597160")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x723F8", Offset = "0x723F8")]
			remove
			{
			}
		}

		[Token(Token = "0x6005A86")]
		[Address(RVA = "0x1597084", Offset = "0x1597084", VA = "0x1597084")]
		public void SetCooldown(float time)
		{
		}

		[Token(Token = "0x6005A89")]
		[Address(RVA = "0x1597204", Offset = "0x1597204", VA = "0x1597204")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6005A8A")]
		[Address(RVA = "0x1597214", Offset = "0x1597214", VA = "0x1597214")]
		private void Awake()
		{
		}

		[Token(Token = "0x6005A8B")]
		[Address(RVA = "0x1597220", Offset = "0x1597220", VA = "0x1597220", Slot = "8")]
		protected virtual void Init()
		{
		}

		[Token(Token = "0x6005A8C")]
		[Address(RVA = "0x159675C", Offset = "0x159675C", VA = "0x159675C")]
		public void PlayAudioFromCollision(HitInfo hitInfo)
		{
		}

		[Token(Token = "0x6005A8D")]
		[Address(RVA = "0x15973E8", Offset = "0x15973E8", VA = "0x15973E8")]
		private void Play(Vector3 position, float volume, float pitch)
		{
		}

		[Token(Token = "0x6005A8E")]
		[Address(RVA = "0x1596E00", Offset = "0x1596E00", VA = "0x1596E00")]
		protected void PlayAudioFromTrigger(GameObject go)
		{
		}

		[Token(Token = "0x6005A8F")]
		[Address(RVA = "0x15975F0", Offset = "0x15975F0", VA = "0x15975F0")]
		private AudioClip ReturnNextClip()
		{
			return null;
		}

		[Token(Token = "0x6005A90")]
		[Address(RVA = "0x1597224", Offset = "0x1597224", VA = "0x1597224")]
		protected bool ReadyToPlay()
		{
			return default;
		}

		[Token(Token = "0x6005A91")]
		[Address(RVA = "0x15972F0", Offset = "0x15972F0", VA = "0x15972F0")]
		protected bool WithinChance()
		{
			return default;
		}

		[Token(Token = "0x6005A92")]
		[Address(RVA = "0x159734C", Offset = "0x159734C", VA = "0x159734C")]
		private bool CheckAudioMaterial(GameObject go)
		{
			return default;
		}

		[Token(Token = "0x6005A93")]
		[Address(RVA = "0x159779C", Offset = "0x159779C", VA = "0x159779C")]
		public void ResetOutOfBounds()
		{
		}

		[Token(Token = "0x6005A94")]
		[Address(RVA = "0x15977A4", Offset = "0x15977A4", VA = "0x15977A4")]
		public void CheckOutOfBounds(string tag)
		{
		}

		[Token(Token = "0x6005A95")]
		[Address(RVA = "0x1596C58", Offset = "0x1596C58", VA = "0x1596C58")]
		public void CheckOutOfBounds(GameObject goToCheck)
		{
		}

		[Token(Token = "0x6005A96")]
		[Address(RVA = "0x1596FD8", Offset = "0x1596FD8", VA = "0x1596FD8")]
		protected OnCollisionAudioBase()
		{
		}

		[Token(Token = "0x6005A97")]
		[Address(RVA = "0x1597948", Offset = "0x1597948", VA = "0x1597948")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x72408", Offset = "0x72408")]
		private void _003CCheckOutOfBounds_003Eb__69_0(float t)
		{
		}

		[Token(Token = "0x6005A98")]
		[Address(RVA = "0x1597950", Offset = "0x1597950", VA = "0x1597950")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x72418", Offset = "0x72418")]
		private void _003CCheckOutOfBounds_003Eb__70_0(float t)
		{
		}
	}
}
