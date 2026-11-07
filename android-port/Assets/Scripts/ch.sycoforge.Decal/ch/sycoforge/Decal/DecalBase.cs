using System;
using Il2CppDummyDll;
using UnityEngine;
using ch.sycoforge.Decal.Projectors;

namespace ch.sycoforge.Decal
{
	[Token(Token = "0x200000A")]
	public abstract class DecalBase : MonoBehaviour
	{
		[Token(Token = "0x4000019")]
		private const string RootName = "[Decal Root]";

		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x18")]
		private OrientationChangedHandler OnOrientationChanged_;

		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x20")]
		private TechniqueChangedHandler OnTechniqueChangedHandler_;

		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x28")]
		private DeferredFlagsChangedHandler OnDeferredFlagsChanged_;

		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x30")]
		private BakeStatusChangedHandler OnBakeStatusChanged_;

		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x38")]
		private Action<DecalBase> OnDestroyed_;

		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x40")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0x4C")]
		private Vector3 lastScale;

		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x58")]
		private Quaternion lastRotation;

		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		protected bool baked;

		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0x69")]
		[SerializeField]
		protected bool bakeOnAwake;

		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0x6A")]
		[SerializeField]
		private bool flipNormals;

		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x6B")]
		[SerializeField]
		private bool backfaceCulling;

		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float distance;

		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float angleConstraint;

		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		protected ProjectionTechnique technique;

		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		protected ch.sycoforge.Decal.Projectors.Projector projector;

		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private DeferredFlags deferredFlags;

		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0x84")]
		[SerializeField]
		private ProjectorInclusion inclusion;

		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private TransformObserver transformObserver;

		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0x90")]
		private Bounds bounds;

		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0xA8")]
		private ProjectionTechnique lastTechnique;

		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0xAC")]
		private DeferredFlags lastDeferredFlags;

		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private bool needsDynamicGeometry;

		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x0")]
		private static GameObject combinedRoot;

		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0x8")]
		private static DecalRoot decalRoot;

		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x20B87C", Offset = "0x20B87C")]
		private Matrix4x4 WorldToLocalMatrix__BackingField;

		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0xF4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x20B88C", Offset = "0x20B88C")]
		private Matrix4x4 LocalToWorldMatrix__BackingField;

		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0x138")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x20B89C", Offset = "0x20B89C")]
		private Transform CachedTransform__BackingField;

		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0x140")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x20B8AC", Offset = "0x20B8AC")]
		private Quaternion Rotation__BackingField;

		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0x150")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x20B8BC", Offset = "0x20B8BC")]
		private Vector3 Position__BackingField;

		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0x15C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x20B8CC", Offset = "0x20B8CC")]
		private Vector3 Scale__BackingField;

		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0x168")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x20B8DC", Offset = "0x20B8DC")]
		private Renderer DecalRenderer__BackingField;

		[Token(Token = "0x400003A")]
		[FieldOffset(Offset = "0x170")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x20B8EC", Offset = "0x20B8EC")]
		private MeshFilter MeshFilter__BackingField;

		[Token(Token = "0x17000005")]
		private static GameObject CombinedRoot
		{
			[Token(Token = "0x600002F")]
			[Address(RVA = "0x2C5A5B8", Offset = "0x2C5A5B8", VA = "0x2C5A5B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000006")]
		public static DecalRoot DecalRoot
		{
			[Token(Token = "0x6000030")]
			[Address(RVA = "0x2C5A914", Offset = "0x2C5A914", VA = "0x2C5A914")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000007")]
		public bool Baked
		{
			[Token(Token = "0x6000031")]
			[Address(RVA = "0x2C567B4", Offset = "0x2C567B4", VA = "0x2C567B4")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000032")]
			[Address(RVA = "0x2C5AA74", Offset = "0x2C5AA74", VA = "0x2C5AA74")]
			set
			{
			}
		}

		[Token(Token = "0x17000008")]
		public bool BakeOnAwake
		{
			[Token(Token = "0x6000033")]
			[Address(RVA = "0x2C5AB0C", Offset = "0x2C5AB0C", VA = "0x2C5AB0C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000034")]
			[Address(RVA = "0x2C5AB14", Offset = "0x2C5AB14", VA = "0x2C5AB14")]
			set
			{
			}
		}

		[Token(Token = "0x17000009")]
		public bool FlipNormals
		{
			[Token(Token = "0x6000035")]
			[Address(RVA = "0x2C5AB1C", Offset = "0x2C5AB1C", VA = "0x2C5AB1C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000036")]
			[Address(RVA = "0x2C5AB24", Offset = "0x2C5AB24", VA = "0x2C5AB24")]
			set
			{
			}
		}

		[Token(Token = "0x1700000A")]
		public bool BackfaceCulling
		{
			[Token(Token = "0x6000037")]
			[Address(RVA = "0x2C5AB2C", Offset = "0x2C5AB2C", VA = "0x2C5AB2C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000038")]
			[Address(RVA = "0x2C5AB34", Offset = "0x2C5AB34", VA = "0x2C5AB34")]
			set
			{
			}
		}

		[Token(Token = "0x1700000B")]
		public Matrix4x4 WorldToLocalMatrix
		{
			[Token(Token = "0x6000039")]
			[Address(RVA = "0x2C5AB3C", Offset = "0x2C5AB3C", VA = "0x2C5AB3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x20BC5C", Offset = "0x20BC5C")]
			get
			{
				return default;
			}
			[Token(Token = "0x600003A")]
			[Address(RVA = "0x2C5AB58", Offset = "0x2C5AB58", VA = "0x2C5AB58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x20BC6C", Offset = "0x20BC6C")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700000C")]
		public Matrix4x4 LocalToWorldMatrix
		{
			[Token(Token = "0x600003B")]
			[Address(RVA = "0x2C5AB74", Offset = "0x2C5AB74", VA = "0x2C5AB74")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x20BC7C", Offset = "0x20BC7C")]
			get
			{
				return default;
			}
			[Token(Token = "0x600003C")]
			[Address(RVA = "0x2C5AB90", Offset = "0x2C5AB90", VA = "0x2C5AB90")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x20BC8C", Offset = "0x20BC8C")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700000D")]
		public Transform CachedTransform
		{
			[Token(Token = "0x600003D")]
			[Address(RVA = "0x2C597AC", Offset = "0x2C597AC", VA = "0x2C597AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x20BC9C", Offset = "0x20BC9C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600003E")]
			[Address(RVA = "0x2C5ABAC", Offset = "0x2C5ABAC", VA = "0x2C5ABAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x20BCAC", Offset = "0x20BCAC")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700000E")]
		public Quaternion Rotation
		{
			[Token(Token = "0x600003F")]
			[Address(RVA = "0x2C5ABB4", Offset = "0x2C5ABB4", VA = "0x2C5ABB4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x20BCBC", Offset = "0x20BCBC")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000040")]
			[Address(RVA = "0x2C5ABC8", Offset = "0x2C5ABC8", VA = "0x2C5ABC8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x20BCCC", Offset = "0x20BCCC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000F")]
		public Vector3 Position
		{
			[Token(Token = "0x6000041")]
			[Address(RVA = "0x2C5867C", Offset = "0x2C5867C", VA = "0x2C5867C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x20BCDC", Offset = "0x20BCDC")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000042")]
			[Address(RVA = "0x2C5ABDC", Offset = "0x2C5ABDC", VA = "0x2C5ABDC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x20BCEC", Offset = "0x20BCEC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public Vector3 Scale
		{
			[Token(Token = "0x6000043")]
			[Address(RVA = "0x2C5ABEC", Offset = "0x2C5ABEC", VA = "0x2C5ABEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x20BCFC", Offset = "0x20BCFC")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000044")]
			[Address(RVA = "0x2C5ABFC", Offset = "0x2C5ABFC", VA = "0x2C5ABFC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x20BD0C", Offset = "0x20BD0C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000011")]
		public float Distance
		{
			[Token(Token = "0x6000045")]
			[Address(RVA = "0x2C5AC0C", Offset = "0x2C5AC0C", VA = "0x2C5AC0C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000046")]
			[Address(RVA = "0x2C5AC14", Offset = "0x2C5AC14", VA = "0x2C5AC14")]
			set
			{
			}
		}

		[Token(Token = "0x17000012")]
		public float AngleConstraint
		{
			[Token(Token = "0x6000047")]
			[Address(RVA = "0x2C5AC1C", Offset = "0x2C5AC1C", VA = "0x2C5AC1C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000048")]
			[Address(RVA = "0x2C5AC24", Offset = "0x2C5AC24", VA = "0x2C5AC24")]
			set
			{
			}
		}

		[Token(Token = "0x17000013")]
		public ProjectionTechnique Technique
		{
			[Token(Token = "0x6000049")]
			[Address(RVA = "0x2C5AE0C", Offset = "0x2C5AE0C", VA = "0x2C5AE0C")]
			get
			{
				return default;
			}
			[Token(Token = "0x600004A")]
			[Address(RVA = "0x2C5AE14", Offset = "0x2C5AE14", VA = "0x2C5AE14")]
			set
			{
			}
		}

		[Token(Token = "0x17000014")]
		public ProjectorInclusion Inclusion
		{
			[Token(Token = "0x600004B")]
			[Address(RVA = "0x2C5AE28", Offset = "0x2C5AE28", VA = "0x2C5AE28")]
			get
			{
				return default;
			}
			[Token(Token = "0x600004C")]
			[Address(RVA = "0x2C5AE30", Offset = "0x2C5AE30", VA = "0x2C5AE30")]
			set
			{
			}
		}

		[Token(Token = "0x17000015")]
		public DeferredFlags DeferredFlags
		{
			[Token(Token = "0x600004D")]
			[Address(RVA = "0x2C5AE38", Offset = "0x2C5AE38", VA = "0x2C5AE38")]
			get
			{
				return default;
			}
			[Token(Token = "0x600004E")]
			[Address(RVA = "0x2C5AE40", Offset = "0x2C5AE40", VA = "0x2C5AE40")]
			set
			{
			}
		}

		[Token(Token = "0x17000016")]
		public Renderer DecalRenderer
		{
			[Token(Token = "0x600004F")]
			[Address(RVA = "0x2C59CB8", Offset = "0x2C59CB8", VA = "0x2C59CB8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x20BD1C", Offset = "0x20BD1C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000050")]
			[Address(RVA = "0x2C5AE48", Offset = "0x2C5AE48", VA = "0x2C5AE48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x20BD2C", Offset = "0x20BD2C")]
			set
			{
			}
		}

		[Token(Token = "0x17000017")]
		internal SkinnedMeshRenderer SkinnedDecalRenderer
		{
			[Token(Token = "0x6000051")]
			[Address(RVA = "0x2C5AE50", Offset = "0x2C5AE50", VA = "0x2C5AE50")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000018")]
		public MeshFilter MeshFilter
		{
			[Token(Token = "0x6000052")]
			[Address(RVA = "0x2C5AED0", Offset = "0x2C5AED0", VA = "0x2C5AED0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x20BD3C", Offset = "0x20BD3C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000053")]
			[Address(RVA = "0x2C5AED8", Offset = "0x2C5AED8", VA = "0x2C5AED8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x20BD4C", Offset = "0x20BD4C")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000019")]
		public ch.sycoforge.Decal.Projectors.Projector Projector
		{
			[Token(Token = "0x6000054")]
			[Address(RVA = "0x2C5AEE0", Offset = "0x2C5AEE0", VA = "0x2C5AEE0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000055")]
			[Address(RVA = "0x2C5AEE8", Offset = "0x2C5AEE8", VA = "0x2C5AEE8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001A")]
		public bool NeedsDynamicGeometry
		{
			[Token(Token = "0x6000056")]
			[Address(RVA = "0x2C5AEF0", Offset = "0x2C5AEF0", VA = "0x2C5AEF0")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000057")]
			[Address(RVA = "0x2C5AEF8", Offset = "0x2C5AEF8", VA = "0x2C5AEF8")]
			set
			{
			}
		}

		[Token(Token = "0x14000001")]
		public event OrientationChangedHandler OnOrientationChanged
		{
			[Token(Token = "0x6000025")]
			[Address(RVA = "0x2C5A090", Offset = "0x2C5A090", VA = "0x2C5A090")]
			add
			{
			}
			[Token(Token = "0x6000026")]
			[Address(RVA = "0x2C5A114", Offset = "0x2C5A114", VA = "0x2C5A114")]
			remove
			{
			}
		}

		[Token(Token = "0x14000002")]
		internal event TechniqueChangedHandler OnTechniqueChanged
		{
			[Token(Token = "0x6000027")]
			[Address(RVA = "0x2C5A198", Offset = "0x2C5A198", VA = "0x2C5A198")]
			add
			{
			}
			[Token(Token = "0x6000028")]
			[Address(RVA = "0x2C5A21C", Offset = "0x2C5A21C", VA = "0x2C5A21C")]
			remove
			{
			}
		}

		[Token(Token = "0x14000003")]
		internal event DeferredFlagsChangedHandler OnDeferredFlagsChanged
		{
			[Token(Token = "0x6000029")]
			[Address(RVA = "0x2C5A2A0", Offset = "0x2C5A2A0", VA = "0x2C5A2A0")]
			add
			{
			}
			[Token(Token = "0x600002A")]
			[Address(RVA = "0x2C5A324", Offset = "0x2C5A324", VA = "0x2C5A324")]
			remove
			{
			}
		}

		[Token(Token = "0x14000004")]
		internal event BakeStatusChangedHandler OnBakeStatusChanged
		{
			[Token(Token = "0x600002B")]
			[Address(RVA = "0x2C5A3A8", Offset = "0x2C5A3A8", VA = "0x2C5A3A8")]
			add
			{
			}
			[Token(Token = "0x600002C")]
			[Address(RVA = "0x2C5A42C", Offset = "0x2C5A42C", VA = "0x2C5A42C")]
			remove
			{
			}
		}

		[Token(Token = "0x14000005")]
		internal event Action<DecalBase> OnDestroyed
		{
			[Token(Token = "0x600002D")]
			[Address(RVA = "0x2C5A4B0", Offset = "0x2C5A4B0", VA = "0x2C5A4B0")]
			add
			{
			}
			[Token(Token = "0x600002E")]
			[Address(RVA = "0x2C5A534", Offset = "0x2C5A534", VA = "0x2C5A534")]
			remove
			{
			}
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x2C5AF00", Offset = "0x2C5AF00", VA = "0x2C5AF00", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x2C5AF80", Offset = "0x2C5AF80", VA = "0x2C5AF80", Slot = "5")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x2C5AF84", Offset = "0x2C5AF84", VA = "0x2C5AF84", Slot = "6")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x2C5AF88", Offset = "0x2C5AF88", VA = "0x2C5AF88", Slot = "7")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x2C5B048", Offset = "0x2C5B048", VA = "0x2C5B048", Slot = "8")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x2C5B0EC", Offset = "0x2C5B0EC", VA = "0x2C5B0EC", Slot = "9")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x2C5B30C", Offset = "0x2C5B30C", VA = "0x2C5B30C", Slot = "10")]
		protected virtual void Initialize()
		{
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x2C5B674", Offset = "0x2C5B674", VA = "0x2C5B674", Slot = "11")]
		protected virtual void OnChangedTechnique()
		{
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x2C5B684", Offset = "0x2C5B684", VA = "0x2C5B684", Slot = "12")]
		protected virtual void OnChangedDeferredFlags()
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x2C5B688", Offset = "0x2C5B688", VA = "0x2C5B688", Slot = "13")]
		protected virtual void OnChangedOrientation()
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x2C5B694", Offset = "0x2C5B694", VA = "0x2C5B694", Slot = "14")]
		protected virtual void OnChangedBakeStatus()
		{
		}

		[Token(Token = "0x6000063")]
		protected abstract void InitalizeProjector();

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x2C5ACC0", Offset = "0x2C5ACC0", VA = "0x2C5ACC0")]
		protected void CallOnPropertyChanged(object oldValue, object newValue)
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x2C5B698", Offset = "0x2C5B698", VA = "0x2C5B698", Slot = "16")]
		protected virtual void AskForUVRecreation()
		{
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x2C5B69C", Offset = "0x2C5B69C", VA = "0x2C5B69C", Slot = "17")]
		protected virtual void AskForGeometryRecreation()
		{
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x2C5B6A0", Offset = "0x2C5B6A0", VA = "0x2C5B6A0")]
		public Bounds Bounds()
		{
			return default;
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x2C5B240", Offset = "0x2C5B240", VA = "0x2C5B240")]
		private void CheckTechniqueChange()
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x2C5B2A8", Offset = "0x2C5B2A8", VA = "0x2C5B2A8")]
		private void CheckDeferredFlagsChange()
		{
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x2C5B400", Offset = "0x2C5B400", VA = "0x2C5B400")]
		private Bounds CalculateBounds()
		{
			return default;
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x2C5B084", Offset = "0x2C5B084", VA = "0x2C5B084")]
		private void SetLastTransforms()
		{
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x2C5B1F0", Offset = "0x2C5B1F0", VA = "0x2C5B1F0")]
		private void CallOnOrientationChanged(OrientationChange change)
		{
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x2C5B720", Offset = "0x2C5B720", VA = "0x2C5B720")]
		private void CallOnTechniqueChanged(ProjectionTechnique last, ProjectionTechnique curr)
		{
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x2C5B780", Offset = "0x2C5B780", VA = "0x2C5B780")]
		private void CallOnDeferredFlagsChanged(DeferredFlags last, DeferredFlags curr)
		{
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x2C5AFE8", Offset = "0x2C5AFE8", VA = "0x2C5AFE8")]
		private void CallOnDestroyed()
		{
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x2C5AAC8", Offset = "0x2C5AAC8", VA = "0x2C5AAC8")]
		private void CallOnBakeStatusChanged()
		{
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x2C5A608", Offset = "0x2C5A608", VA = "0x2C5A608")]
		public static void TryInitializeRoot()
		{
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x2C5BBB8", Offset = "0x2C5BBB8", VA = "0x2C5BBB8")]
		protected DecalBase()
		{
		}
	}
}
