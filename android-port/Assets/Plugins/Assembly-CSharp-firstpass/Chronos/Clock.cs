using Il2CppDummyDll;
using UnityEngine;

namespace Chronos
{
	[Token(Token = "0x2000292")]
	public abstract class Clock : MonoBehaviour
	{
		[Token(Token = "0x4001115")]
		[FieldOffset(Offset = "0x18")]
		private bool enabledOnce;

		[Token(Token = "0x4001116")]
		[FieldOffset(Offset = "0x19")]
		protected bool isLerping;

		[Token(Token = "0x4001117")]
		[FieldOffset(Offset = "0x1C")]
		protected float lerpStart;

		[Token(Token = "0x4001118")]
		[FieldOffset(Offset = "0x20")]
		protected float lerpEnd;

		[Token(Token = "0x4001119")]
		[FieldOffset(Offset = "0x24")]
		protected float lerpFrom;

		[Token(Token = "0x400111A")]
		[FieldOffset(Offset = "0x28")]
		protected float lerpTo;

		[Token(Token = "0x400111B")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _localTimeScale;

		[Token(Token = "0x400111C")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x371F4", Offset = "0x371F4")]
		private float timeScale__BackingField;

		[Token(Token = "0x400111D")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x37204", Offset = "0x37204")]
		private float time__BackingField;

		[Token(Token = "0x400111E")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x37214", Offset = "0x37214")]
		private float unscaledTime__BackingField;

		[Token(Token = "0x400111F")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x37224", Offset = "0x37224")]
		private float deltaTime__BackingField;

		[Token(Token = "0x4001120")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x37234", Offset = "0x37234")]
		private float fixedDeltaTime__BackingField;

		[Token(Token = "0x4001121")]
		[FieldOffset(Offset = "0x44")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x37244", Offset = "0x37244")]
		private float startTime__BackingField;

		[Token(Token = "0x4001122")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private bool _paused;

		[Token(Token = "0x4001123")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private string _parentKey;

		[Token(Token = "0x4001124")]
		[FieldOffset(Offset = "0x58")]
		private GlobalClock _parent;

		[Token(Token = "0x4001125")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private ClockBlend _parentBlend;

		[Token(Token = "0x17000205")]
		public float localTimeScale
		{
			[Token(Token = "0x60010F2")]
			[Address(RVA = "0x1361C90", Offset = "0x1361C90", VA = "0x1361C90")]
			get
			{
				return default;
			}
			[Token(Token = "0x60010F3")]
			[Address(RVA = "0x1361C98", Offset = "0x1361C98", VA = "0x1361C98")]
			set
			{
			}
		}

		[Token(Token = "0x17000206")]
		public float timeScale
		{
			[Token(Token = "0x60010F4")]
			[Address(RVA = "0x1361CA0", Offset = "0x1361CA0", VA = "0x1361CA0", Slot = "8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B6AC", Offset = "0x3B6AC")]
			get
			{
				return default;
			}
			[Token(Token = "0x60010F5")]
			[Address(RVA = "0x1361CA8", Offset = "0x1361CA8", VA = "0x1361CA8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B6BC", Offset = "0x3B6BC")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000207")]
		public float time
		{
			[Token(Token = "0x60010F6")]
			[Address(RVA = "0x1361CB0", Offset = "0x1361CB0", VA = "0x1361CB0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B6CC", Offset = "0x3B6CC")]
			get
			{
				return default;
			}
			[Token(Token = "0x60010F7")]
			[Address(RVA = "0x1361CB8", Offset = "0x1361CB8", VA = "0x1361CB8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B6DC", Offset = "0x3B6DC")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000208")]
		public float unscaledTime
		{
			[Token(Token = "0x60010F8")]
			[Address(RVA = "0x1361CC0", Offset = "0x1361CC0", VA = "0x1361CC0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B6EC", Offset = "0x3B6EC")]
			get
			{
				return default;
			}
			[Token(Token = "0x60010F9")]
			[Address(RVA = "0x1361CC8", Offset = "0x1361CC8", VA = "0x1361CC8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B6FC", Offset = "0x3B6FC")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000209")]
		public float deltaTime
		{
			[Token(Token = "0x60010FA")]
			[Address(RVA = "0x1361CD0", Offset = "0x1361CD0", VA = "0x1361CD0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B70C", Offset = "0x3B70C")]
			get
			{
				return default;
			}
			[Token(Token = "0x60010FB")]
			[Address(RVA = "0x1361CD8", Offset = "0x1361CD8", VA = "0x1361CD8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B71C", Offset = "0x3B71C")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700020A")]
		public float fixedDeltaTime
		{
			[Token(Token = "0x60010FC")]
			[Address(RVA = "0x1361CE0", Offset = "0x1361CE0", VA = "0x1361CE0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B72C", Offset = "0x3B72C")]
			get
			{
				return default;
			}
			[Token(Token = "0x60010FD")]
			[Address(RVA = "0x1361CE8", Offset = "0x1361CE8", VA = "0x1361CE8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B73C", Offset = "0x3B73C")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700020B")]
		public float startTime
		{
			[Token(Token = "0x60010FE")]
			[Address(RVA = "0x1361CF0", Offset = "0x1361CF0", VA = "0x1361CF0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B74C", Offset = "0x3B74C")]
			get
			{
				return default;
			}
			[Token(Token = "0x60010FF")]
			[Address(RVA = "0x1361CF8", Offset = "0x1361CF8", VA = "0x1361CF8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B75C", Offset = "0x3B75C")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700020C")]
		public bool paused
		{
			[Token(Token = "0x6001100")]
			[Address(RVA = "0x1361D00", Offset = "0x1361D00", VA = "0x1361D00")]
			get
			{
				return default;
			}
			[Token(Token = "0x6001101")]
			[Address(RVA = "0x1361D08", Offset = "0x1361D08", VA = "0x1361D08")]
			set
			{
			}
		}

		[Token(Token = "0x1700020D")]
		public GlobalClock parent
		{
			[Token(Token = "0x6001102")]
			[Address(RVA = "0x1361D10", Offset = "0x1361D10", VA = "0x1361D10")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001103")]
			[Address(RVA = "0x13619B8", Offset = "0x13619B8", VA = "0x13619B8")]
			set
			{
			}
		}

		[Token(Token = "0x1700020E")]
		public ClockBlend parentBlend
		{
			[Token(Token = "0x6001104")]
			[Address(RVA = "0x1361D18", Offset = "0x1361D18", VA = "0x1361D18")]
			get
			{
				return default;
			}
			[Token(Token = "0x6001105")]
			[Address(RVA = "0x1361D20", Offset = "0x1361D20", VA = "0x1361D20")]
			set
			{
			}
		}

		[Token(Token = "0x1700020F")]
		public TimeState state
		{
			[Token(Token = "0x6001106")]
			[Address(RVA = "0x1361D28", Offset = "0x1361D28", VA = "0x1361D28")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60010EC")]
		[Address(RVA = "0x13617B0", Offset = "0x13617B0", VA = "0x13617B0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60010ED")]
		[Address(RVA = "0x13617B4", Offset = "0x13617B4", VA = "0x13617B4")]
		private void Start()
		{
		}

		[Token(Token = "0x60010EE")]
		[Address(RVA = "0x13617C0", Offset = "0x13617C0", VA = "0x13617C0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60010EF")]
		[Address(RVA = "0x13617E4", Offset = "0x13617E4", VA = "0x13617E4", Slot = "5")]
		protected virtual void OnStartOrReEnable()
		{
		}

		[Token(Token = "0x60010F0")]
		[Address(RVA = "0x1361B2C", Offset = "0x1361B2C", VA = "0x1361B2C", Slot = "6")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60010F1")]
		[Address(RVA = "0x1361BE0", Offset = "0x1361BE0", VA = "0x1361BE0", Slot = "7")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x6001107")]
		[Address(RVA = "0x1361D34", Offset = "0x1361D34", VA = "0x1361D34", Slot = "9")]
		public virtual void ComputeTimeScale()
		{
		}

		[Token(Token = "0x6001108")]
		[Address(RVA = "0x1361DFC", Offset = "0x1361DFC", VA = "0x1361DFC")]
		public void LerpTimeScale(float timeScale, float duration, bool steady = false)
		{
		}

		[Token(Token = "0x6001109")]
		[Address(RVA = "0x1361EB8", Offset = "0x1361EB8", VA = "0x1361EB8")]
		protected Clock()
		{
		}
	}
}
