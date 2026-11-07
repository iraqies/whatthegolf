using System;
using UnityEngine;
using ch.sycoforge.Decal.Projectors;

namespace ch.sycoforge.Decal
{
	public abstract class DecalBase : MonoBehaviour
	{
		private const string RootName = "[Decal Root]";

		private OrientationChangedHandler OnOrientationChanged_;

		private TechniqueChangedHandler OnTechniqueChangedHandler_;

		private DeferredFlagsChangedHandler OnDeferredFlagsChanged_;

		private BakeStatusChangedHandler OnBakeStatusChanged_;

		private Action<DecalBase> OnDestroyed_;

		private Vector3 lastPosition;

		private Vector3 lastScale;

		private Quaternion lastRotation;

		[SerializeField]
		protected bool baked;

		[SerializeField]
		protected bool bakeOnAwake;

		[SerializeField]
		private bool flipNormals;

		[SerializeField]
		private bool backfaceCulling;

		[SerializeField]
		private float distance;

		[SerializeField]
		private float angleConstraint;

		[SerializeField]
		protected ProjectionTechnique technique;

		[SerializeField]
		protected ch.sycoforge.Decal.Projectors.Projector projector;

		[SerializeField]
		private DeferredFlags deferredFlags;

		[SerializeField]
		private ProjectorInclusion inclusion;

		[SerializeField]
		private TransformObserver transformObserver;

		private Bounds bounds;

		private ProjectionTechnique lastTechnique;

		private DeferredFlags lastDeferredFlags;

		[SerializeField]
		private bool needsDynamicGeometry;

		private static GameObject combinedRoot;

		private static DecalRoot decalRoot;

		private static GameObject CombinedRoot => null;

		public static DecalRoot DecalRoot => null;

		public bool Baked
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool BakeOnAwake
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool FlipNormals
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool BackfaceCulling
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Matrix4x4 WorldToLocalMatrix { get; protected set; }

		public Matrix4x4 LocalToWorldMatrix { get; protected set; }

		public Transform CachedTransform { get; protected set; }

		public Quaternion Rotation { get; private set; }

		public Vector3 Position { get; private set; }

		public Vector3 Scale { get; private set; }

		public float Distance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float AngleConstraint
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public ProjectionTechnique Technique
		{
			get
			{
				return ProjectionTechnique.Plane;
			}
			set
			{
			}
		}

		public ProjectorInclusion Inclusion
		{
			get
			{
				return ProjectorInclusion.All;
			}
			set
			{
			}
		}

		public DeferredFlags DeferredFlags
		{
			get
			{
				return (DeferredFlags)0;
			}
			set
			{
			}
		}

		public Renderer DecalRenderer { get; set; }

		internal SkinnedMeshRenderer SkinnedDecalRenderer => null;

		public MeshFilter MeshFilter { get; protected set; }

		public ch.sycoforge.Decal.Projectors.Projector Projector
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public bool NeedsDynamicGeometry
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public event OrientationChangedHandler OnOrientationChanged
		{
			add
			{
			}
			remove
			{
			}
		}

		internal event TechniqueChangedHandler OnTechniqueChanged
		{
			add
			{
			}
			remove
			{
			}
		}

		internal event DeferredFlagsChangedHandler OnDeferredFlagsChanged
		{
			add
			{
			}
			remove
			{
			}
		}

		internal event BakeStatusChangedHandler OnBakeStatusChanged
		{
			add
			{
			}
			remove
			{
			}
		}

		internal event Action<DecalBase> OnDestroyed
		{
			add
			{
			}
			remove
			{
			}
		}

		protected virtual void Awake()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		protected virtual void OnDestroy()
		{
		}

		protected virtual void Start()
		{
		}

		protected virtual void Update()
		{
		}

		protected virtual void Initialize()
		{
		}

		protected virtual void OnChangedTechnique()
		{
		}

		protected virtual void OnChangedDeferredFlags()
		{
		}

		protected virtual void OnChangedOrientation()
		{
		}

		protected virtual void OnChangedBakeStatus()
		{
		}

		protected abstract void InitalizeProjector();

		protected void CallOnPropertyChanged(object oldValue, object newValue)
		{
		}

		protected virtual void AskForUVRecreation()
		{
		}

		protected virtual void AskForGeometryRecreation()
		{
		}

		public Bounds Bounds()
		{
			return default;
		}

		private void CheckTechniqueChange()
		{
		}

		private void CheckDeferredFlagsChange()
		{
		}

		private Bounds CalculateBounds()
		{
			return default;
		}

		private void SetLastTransforms()
		{
		}

		private void CallOnOrientationChanged(OrientationChange change)
		{
		}

		private void CallOnTechniqueChanged(ProjectionTechnique last, ProjectionTechnique curr)
		{
		}

		private void CallOnDeferredFlagsChanged(DeferredFlags last, DeferredFlags curr)
		{
		}

		private void CallOnDestroyed()
		{
		}

		private void CallOnBakeStatusChanged()
		{
		}

		public static void TryInitializeRoot()
		{
		}
	}
}
