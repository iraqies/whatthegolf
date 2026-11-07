using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Chronos
{
	[Token(Token = "0x20002AD")]
	public abstract class TimelineEffector : MonoBehaviour
	{
		[Token(Token = "0x400116E")]
		protected internal const float DefaultRecordingInterval = 0.5f;

		[Token(Token = "0x400116F")]
		[FieldOffset(Offset = "0x18")]
		private bool enabledOnce;

		[Token(Token = "0x4001170")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float _recordingInterval;

		[Token(Token = "0x4001171")]
		[FieldOffset(Offset = "0x20")]
		internal List<IComponentTimeline> components;

		[Token(Token = "0x4001172")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x37460", Offset = "0x37460")]
		private AnimationTimeline animation__BackingField;

		[Token(Token = "0x4001173")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x37470", Offset = "0x37470")]
		private AnimatorTimeline animator__BackingField;

		[Token(Token = "0x4001174")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x37480", Offset = "0x37480")]
		private List<AudioSourceTimeline> audioSources__BackingField;

		[Token(Token = "0x4001175")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x37490", Offset = "0x37490")]
		private AudioSourceTimeline audioSource__BackingField;

		[Token(Token = "0x4001176")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x374A0", Offset = "0x374A0")]
		private NavMeshAgentTimeline navMeshAgent__BackingField;

		[Token(Token = "0x4001177")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x374B0", Offset = "0x374B0")]
		private IParticleSystemTimeline particleSystem__BackingField;

		[Token(Token = "0x4001178")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x374C0", Offset = "0x374C0")]
		private RigidbodyTimeline3D rigidbody__BackingField;

		[Token(Token = "0x4001179")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x374D0", Offset = "0x374D0")]
		private RigidbodyTimeline2D rigidbody2D__BackingField;

		[Token(Token = "0x400117A")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x374E0", Offset = "0x374E0")]
		private TransformTimeline transform__BackingField;

		[Token(Token = "0x400117B")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x374F0", Offset = "0x374F0")]
		private TrailRendererTimeline trailRenderer__BackingField;

		[Token(Token = "0x17000234")]
		protected abstract Timeline timeline
		{
			[Token(Token = "0x60011DE")]
			get;
		}

		[Token(Token = "0x17000235")]
		public float recordingInterval
		{
			[Token(Token = "0x60011E6")]
			[Address(RVA = "0x1320AFC", Offset = "0x1320AFC", VA = "0x1320AFC")]
			get
			{
				return default;
			}
			[Token(Token = "0x60011E7")]
			[Address(RVA = "0x1320B04", Offset = "0x1320B04", VA = "0x1320B04")]
			set
			{
			}
		}

		[Token(Token = "0x17000236")]
		public AnimationTimeline animation
		{
			[Token(Token = "0x60011E8")]
			[Address(RVA = "0x1320BF8", Offset = "0x1320BF8", VA = "0x1320BF8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B9DC", Offset = "0x3B9DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60011E9")]
			[Address(RVA = "0x1320C00", Offset = "0x1320C00", VA = "0x1320C00")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B9EC", Offset = "0x3B9EC")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000237")]
		public AnimatorTimeline animator
		{
			[Token(Token = "0x60011EA")]
			[Address(RVA = "0x1320C08", Offset = "0x1320C08", VA = "0x1320C08")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B9FC", Offset = "0x3B9FC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60011EB")]
			[Address(RVA = "0x1320C10", Offset = "0x1320C10", VA = "0x1320C10")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3BA0C", Offset = "0x3BA0C")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000238")]
		public List<AudioSourceTimeline> audioSources
		{
			[Token(Token = "0x60011EC")]
			[Address(RVA = "0x1320C18", Offset = "0x1320C18", VA = "0x1320C18")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3BA1C", Offset = "0x3BA1C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60011ED")]
			[Address(RVA = "0x1320C20", Offset = "0x1320C20", VA = "0x1320C20")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3BA2C", Offset = "0x3BA2C")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000239")]
		public AudioSourceTimeline audioSource
		{
			[Token(Token = "0x60011EE")]
			[Address(RVA = "0x1320C28", Offset = "0x1320C28", VA = "0x1320C28")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3BA3C", Offset = "0x3BA3C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60011EF")]
			[Address(RVA = "0x1320C30", Offset = "0x1320C30", VA = "0x1320C30")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3BA4C", Offset = "0x3BA4C")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700023A")]
		public NavMeshAgentTimeline navMeshAgent
		{
			[Token(Token = "0x60011F0")]
			[Address(RVA = "0x1320C38", Offset = "0x1320C38", VA = "0x1320C38")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3BA5C", Offset = "0x3BA5C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60011F1")]
			[Address(RVA = "0x1320C40", Offset = "0x1320C40", VA = "0x1320C40")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3BA6C", Offset = "0x3BA6C")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700023B")]
		public IParticleSystemTimeline particleSystem
		{
			[Token(Token = "0x60011F2")]
			[Address(RVA = "0x1320C48", Offset = "0x1320C48", VA = "0x1320C48")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3BA7C", Offset = "0x3BA7C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60011F3")]
			[Address(RVA = "0x1320C50", Offset = "0x1320C50", VA = "0x1320C50")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3BA8C", Offset = "0x3BA8C")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700023C")]
		public RigidbodyTimeline3D rigidbody
		{
			[Token(Token = "0x60011F4")]
			[Address(RVA = "0x1320C58", Offset = "0x1320C58", VA = "0x1320C58")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3BA9C", Offset = "0x3BA9C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60011F5")]
			[Address(RVA = "0x1320C60", Offset = "0x1320C60", VA = "0x1320C60")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3BAAC", Offset = "0x3BAAC")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700023D")]
		public RigidbodyTimeline2D rigidbody2D
		{
			[Token(Token = "0x60011F6")]
			[Address(RVA = "0x1320C68", Offset = "0x1320C68", VA = "0x1320C68")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3BABC", Offset = "0x3BABC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60011F7")]
			[Address(RVA = "0x1320C70", Offset = "0x1320C70", VA = "0x1320C70")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3BACC", Offset = "0x3BACC")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700023E")]
		public new TransformTimeline transform
		{
			[Token(Token = "0x60011F8")]
			[Address(RVA = "0x1320C78", Offset = "0x1320C78", VA = "0x1320C78")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3BADC", Offset = "0x3BADC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60011F9")]
			[Address(RVA = "0x1320C80", Offset = "0x1320C80", VA = "0x1320C80")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3BAEC", Offset = "0x3BAEC")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700023F")]
		public TrailRendererTimeline trailRenderer
		{
			[Token(Token = "0x60011FA")]
			[Address(RVA = "0x1320C88", Offset = "0x1320C88", VA = "0x1320C88")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3BAFC", Offset = "0x3BAFC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60011FB")]
			[Address(RVA = "0x1320C90", Offset = "0x1320C90", VA = "0x1320C90")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3BB0C", Offset = "0x3BB0C")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000240")]
		protected IRecorder recorder
		{
			[Token(Token = "0x60011FC")]
			[Address(RVA = "0x1320720", Offset = "0x1320720", VA = "0x1320720")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60011DD")]
		[Address(RVA = "0x131DFF8", Offset = "0x131DFF8", VA = "0x131DFF8")]
		public TimelineEffector()
		{
		}

		[Token(Token = "0x60011DF")]
		[Address(RVA = "0x13209A0", Offset = "0x13209A0", VA = "0x13209A0", Slot = "5")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60011E0")]
		[Address(RVA = "0x13209B0", Offset = "0x13209B0", VA = "0x13209B0")]
		private void Start()
		{
		}

		[Token(Token = "0x60011E1")]
		[Address(RVA = "0x13209BC", Offset = "0x13209BC", VA = "0x13209BC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60011E2")]
		[Address(RVA = "0x131E21C", Offset = "0x131E21C", VA = "0x131E21C", Slot = "6")]
		protected virtual void OnStartOrReEnable()
		{
		}

		[Token(Token = "0x60011E3")]
		[Address(RVA = "0x131E948", Offset = "0x131E948", VA = "0x131E948", Slot = "7")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60011E4")]
		[Address(RVA = "0x13209E0", Offset = "0x13209E0", VA = "0x13209E0", Slot = "8")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x60011E5")]
		[Address(RVA = "0x131EC68", Offset = "0x131EC68", VA = "0x131EC68", Slot = "9")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x60011FD")]
		[Address(RVA = "0x1320C98", Offset = "0x1320C98", VA = "0x1320C98", Slot = "10")]
		public virtual void CacheComponents()
		{
		}

		[Token(Token = "0x60011FE")]
		[Address(RVA = "0x131EE3C", Offset = "0x131EE3C", VA = "0x131EE3C", Slot = "11")]
		public virtual void Reset()
		{
		}

		[Token(Token = "0x60011FF")]
		[Address(RVA = "0x1321A48", Offset = "0x1321A48", VA = "0x1321A48")]
		public void ResetRecording()
		{
		}

		[Token(Token = "0x6001200")]
		[Address(RVA = "0x1321B0C", Offset = "0x1321B0C", VA = "0x1321B0C")]
		public int EstimateMemoryUsage()
		{
			return default;
		}
	}
}
