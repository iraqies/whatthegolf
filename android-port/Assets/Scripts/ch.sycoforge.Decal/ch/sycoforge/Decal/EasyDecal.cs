using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ch.sycoforge.Decal.Projectors.Geometry;

namespace ch.sycoforge.Decal
{
	[Serializable]
	[ExecuteInEditMode]
	public class EasyDecal : DecalBase
	{
		public const int MaxQuality = 6;

		internal const string CHILD_NAME = "PROC_PLANE";

		internal const string SKINNED_CHILD_NAME = "SKINNED_PROC_PLANE";

		private static Camera renderCamera;

		public LayerMask Mask;

		private int id;

		internal bool evenID;

		private Action<EasyDecal> OnFadedOut_;

		private Action<EasyDecal> OnFadedIn_;

		private Action<EasyDecal> OnFadeOutStarted_;

		private Action<EasyDecal, Mesh> OnProjectionFinished_;

		private Action<EasyDecal> OnAtlasIndexChanged_;

		private Action<EasyDecal> OnSourceChanged_;

		[SerializeField]
		private GameObject projectionTarget;

		[SerializeField]
		private ProjectionMode mode;

		[SerializeField]
		private SourceMode source;

		[SerializeField]
		private AspectMode aspectCorrectionMode;

		[SerializeField]
		private LookupMode recursiveMode;

		private GameObject receiver;

		private GameObject meshContainer;

		private GameObject skinnedMeshContainer;

		[SerializeField]
		private SkinQuality skinningQuality;

		[SerializeField]
		internal Material material;

		[SerializeField]
		private DecalTextureAtlas atlas;

		[SerializeField]
		private int atlasRegionIndex;

		[SerializeField]
		private float maxDistance;

		[SerializeField]
		private float projectionDistance;

		[SerializeField]
		private bool smoothNormals;

		[SerializeField]
		private float normalSmoothFactor;

		[SerializeField]
		private float normalSmoothThreshold;

		[SerializeField]
		internal int resolution;

		[SerializeField]
		private bool multiMeshEnabled;

		[SerializeField]
		private bool cullInvisible;

		[SerializeField]
		private bool cullUnreachable;

		[SerializeField]
		private bool showVertices;

		[SerializeField]
		private bool showDir;

		[SerializeField]
		private bool showNormals;

		[SerializeField]
		private bool enableVertexColorFade;

		[SerializeField]
		private bool onlyColliders;

		[SerializeField]
		private bool tangents;

		[SerializeField]
		private bool calculateNormals;

		[SerializeField]
		private MeshChannelMode normalChannelMode;

		[SerializeField]
		private MeshChannelMode tangentChannelMode;

		[SerializeField]
		private bool recursiceLookup;

		[SerializeField]
		private bool randomIndexEnabled;

		[SerializeField]
		private int recursiceLookupSteps;

		private List<IMeshProcessor> meshProcessors;

		[SerializeField]
		private bool autoDestroy;

		[SerializeField]
		private OpacityMode opacityMode;

		[SerializeField]
		private bool fadeOnly;

		[SerializeField]
		private bool useLightProbes;

		[SerializeField]
		private float lifetime;

		[SerializeField]
		private float fadeoutTime;

		private float creationTime;

		[SerializeField]
		private AnimationCurve fadeoutCurve;

		[SerializeField]
		private float surfaceRotation;

		[SerializeField]
		private int quality;

		private float alpha;

		private int creationFrameNumber;

		private int bakeInFrameNumber;

		private bool needUVRecreation;

		private bool needGeometryRecreation;

		[SerializeField]
		private Mesh sharedMesh;

		[SerializeField]
		private int instanceID;

		internal bool projectBake;

		public static StaticProxyCollection ProxyCollection;

		public static bool HideMesh;

		public static InstantiationDelegate Instantiation;

		public static Camera RenderCamera
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int ID
		{
			get
			{
				return 0;
			}
			internal set
			{
			}
		}

		public SkinQuality SkinningQuality
		{
			get
			{
				return SkinQuality.Auto;
			}
			set
			{
			}
		}

		public Mesh SharedMesh => null;

		public bool IsVisible => false;

		public int Quality
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool MultiMeshEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool CullInvisibles
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool CullUnreachable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public GameObject Receiver
		{
			get
			{
				return null;
			}
			protected set
			{
			}
		}

		public bool CalculateTangents
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public MeshChannelMode TangentChannelMode
		{
			get
			{
				return MeshChannelMode.Ignore;
			}
			set
			{
			}
		}

		public bool CalculateNormals
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public MeshChannelMode NormalChannelMode
		{
			get
			{
				return MeshChannelMode.Ignore;
			}
			set
			{
			}
		}

		public bool ShowDir
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool ShowVertices
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool ShowNormals
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float MaxDistance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float ProjectionDistance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool SmoothNormals
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float NormalSmoothFactor
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float NormalSmoothThreshold
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool DontDestroy
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool FadeOut
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public OpacityMode OpacityMode
		{
			get
			{
				return OpacityMode.Geometry;
			}
			set
			{
			}
		}

		public float Lifetime
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float RemainingLifetime => 0f;

		public float CurrentFadeoutTime { get; private set; }

		public float FadeoutTime
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public AnimationCurve FadeoutCurve
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Vector3 InverseProjectionDirection { get; private set; }

		public float SurfaceRotation
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Material DecalMaterial
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public DecalTextureAtlas Atlas
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int AtlasRegionIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public GameObject MeshContainer => null;

		public ProjectionMode Mode
		{
			get
			{
				return ProjectionMode.SurfaceNormal;
			}
			set
			{
			}
		}

		public SourceMode Source
		{
			get
			{
				return SourceMode.Material;
			}
			set
			{
			}
		}

		public AspectMode AspectCorrectionMode
		{
			get
			{
				return AspectMode.None;
			}
			set
			{
			}
		}

		public LookupMode RecursiveMode
		{
			get
			{
				return LookupMode.Up;
			}
			set
			{
			}
		}

		public float Alpha
		{
			get
			{
				return 0f;
			}
			private set
			{
			}
		}

		[Obsolete]
		public bool IsFadingOut => false;

		public bool IsFading => false;

		public bool OnlyColliders
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool EnableVertexColorBleed
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool RecursiveLookup
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool RandomIndexEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int RecursiveLookupSteps
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public List<IMeshProcessor> MeshProcessors
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool UseLightProbes
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public GameObject ProjectionTarget
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public event Action<EasyDecal> OnFadedOut
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Action<EasyDecal> OnFadedIn
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Action<EasyDecal> OnFadeOutStarted
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Action<EasyDecal, Mesh> OnProjectionFinished
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Action<EasyDecal> OnAtlasIndexChanged
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Action<EasyDecal> OnSourceChanged
		{
			add
			{
			}
			remove
			{
			}
		}

		public void Reset()
		{
		}

		public void Reset(bool unbake)
		{
		}

		public void Reset(bool unbake, bool recreate)
		{
		}

		protected override void Awake()
		{
		}

		protected override void OnEnable()
		{
		}

		protected override void Start()
		{
		}

		protected override void OnDisable()
		{
		}

		protected override void OnDestroy()
		{
		}

		public void StartFade()
		{
		}

		public void CancelFade()
		{
		}

		public void SelectRandom()
		{
		}

		public void CorrectAspect()
		{
		}

		private void StartFadeOut()
		{
		}

		public void StartFade(FadingMode mode = FadingMode.Out)
		{
		}

		private IEnumerator ProcessFadeOut()
		{
			return null;
		}

		private IEnumerator ProcessFadeIn()
		{
			return null;
		}

		public Vector3[] GetBoundingVertices()
		{
			return null;
		}

		public Bounds GetBounds()
		{
			return default;
		}

		protected virtual void OnDrawGizmos()
		{
		}

		public void OnDrawGizmosSelected()
		{
		}

		protected override void Update()
		{
		}

		protected override void Initialize()
		{
		}

		protected override void InitalizeProjector()
		{
		}

		private void Log(string msg)
		{
		}

		protected override void OnChangedTechnique()
		{
		}

		protected virtual void OnChangedAtlasIndex()
		{
		}

		protected virtual void OnChangedSource()
		{
		}

		protected virtual void OnChangedAlpha()
		{
		}

		protected override void OnChangedBakeStatus()
		{
		}

		protected override void AskForGeometryRecreation()
		{
		}

		protected override void AskForUVRecreation()
		{
		}

		private void CreateDecalGameObject()
		{
		}

		private void SetChildTransform(GameObject child)
		{
		}

		private void ResetMesh()
		{
		}

		private Mesh FindSharedMesh()
		{
			return null;
		}

		private GameObject Search(string name)
		{
			return null;
		}

		internal void AddDynamicMesh(DynamicMesh dynamicMesh, bool isStatic = false)
		{
		}

		private void ConvertAndAssign(DynamicMesh dynamicMesh, bool forceRecreation)
		{
		}

		private void AssignSharedMesh(Mesh mesh)
		{
		}

		private void PostProcessMesh(DynamicMesh mesh)
		{
		}

		public void PostProcessMesh(Mesh mesh)
		{
		}

		internal void TransformUV(DynamicMesh dynamicMesh)
		{
		}

		private void DrawMeshGeometryGizmos(Vector3[] vertices, Vector3[] normals)
		{
		}

		private void ResetPlanes()
		{
		}

		protected void UpdateDecal()
		{
		}

		[Obsolete]
		protected void ProjectBake()
		{
		}

		public void LateUnbake()
		{
		}

		public void LateBake()
		{
		}

		public void LateBake(uint frames)
		{
		}

		internal Color GetFadeoutColor()
		{
			return default;
		}

		private void CallOnProjectionFinished(Mesh mesh)
		{
		}

		private void CallOnFadeOutStarted()
		{
		}

		private void CallOnFadedOut()
		{
		}

		private void CallOnFadedIn()
		{
		}

		private void CallOnAtlasIndexChanged()
		{
		}

		private void CallOnSourceChanged()
		{
		}

		private void CallOnAlphaChanged()
		{
		}

		public static EasyDecal Clone(EasyDecal decal)
		{
			return null;
		}

		public static void CopyProperties(EasyDecal from, EasyDecal to)
		{
		}

		public static void SetStaticProxyCollection(StaticProxyCollection proxyCollection)
		{
		}

		public static EasyDecal ProjectAt(GameObject decalPrefab, GameObject receiver, Vector3 position, Vector3 forward, Vector3 up)
		{
			return null;
		}

		public static EasyDecal ProjectAt(GameObject decalPrefab, GameObject receiver, Vector3 position, Quaternion rotation)
		{
			return null;
		}

		public static EasyDecal ProjectAt(GameObject decalPrefab, GameObject receiver, Vector3 position, Vector3 normal)
		{
			return null;
		}

		public static EasyDecal ProjectAt(GameObject decalPrefab, GameObject receiver, Vector3 position, Vector3 normal, float rotation)
		{
			return null;
		}

		public static EasyDecal ProjectAt(GameObject decalPrefab, GameObject receiver, Vector3 position, Vector3 normal, float rotation, Vector3 scale)
		{
			return null;
		}

		public static EasyDecal Project(GameObject decalPrefab, Vector3 position, Quaternion rotation)
		{
			return null;
		}

		public static EasyDecal Project(GameObject decalPrefab, Vector3 position, Vector3 normal)
		{
			return null;
		}

		public static EasyDecal Project(GameObject decalPrefab, Vector3 position, Vector3 normal, float rotation)
		{
			return null;
		}

		public static EasyDecal Project(GameObject decalPrefab, Vector3 position, Ray ray)
		{
			return null;
		}

		private static EasyDecal ProjectInternal(GameObject decalPrefab, GameObject parent, Vector3 position, Quaternion rotation, Vector3 scale)
		{
			return null;
		}

		private static List<EasyDecal> SearchChildren(Transform parent)
		{
			return null;
		}

		private static bool ContainsLayer(LayerMask mask, int layer)
		{
			return false;
		}
	}
}
