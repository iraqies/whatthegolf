using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

namespace UnityEngine.ProBuilder
{
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	public sealed class ProBuilderMesh : MonoBehaviour
	{
		[Flags]
		private enum CacheValidState : byte
		{
			SharedVertex = 1,
			SharedTexture = 2
		}

		private const int k_UVChannelCount = 4;

		private const int k_MeshFormatVersion = 1;

		private const int k_MeshFormatVersionSubmeshMaterialRefactor = 1;

		public const uint maxVertexCount = 65535u;

		[SerializeField]
		private int m_MeshFormatVersion;

		[SerializeField]
		private Face[] m_Faces;

		[SerializeField]
		private SharedVertex[] m_SharedVertices;

		[NonSerialized]
		private CacheValidState m_CacheValid;

		[NonSerialized]
		private Dictionary<int, int> m_SharedVertexLookup;

		[SerializeField]
		private SharedVertex[] m_SharedTextures;

		[NonSerialized]
		private Dictionary<int, int> m_SharedTextureLookup;

		[SerializeField]
		private Vector3[] m_Positions;

		[SerializeField]
		private Vector2[] m_Textures0;

		[SerializeField]
		private List<Vector4> m_Textures2;

		[SerializeField]
		private List<Vector4> m_Textures3;

		[SerializeField]
		private Vector4[] m_Tangents;

		[NonSerialized]
		private Vector3[] m_Normals;

		[SerializeField]
		private Color[] m_Colors;

		[SerializeField]
		private UnwrapParameters m_UnwrapParameters;

		[SerializeField]
		private bool m_PreserveMeshAssetOnDestroy;

		[SerializeField]
		internal string assetGuid;

		[NonSerialized]
		private MeshRenderer m_MeshRenderer;

		[NonSerialized]
		private MeshFilter m_MeshFilter;

		[CompilerGenerated]
		private static Action<ProBuilderMesh> m_meshWillBeDestroyed;

		[CompilerGenerated]
		private static Action<ProBuilderMesh> m_componentWillBeDestroyed;

		[CompilerGenerated]
		private static Action<ProBuilderMesh> m_elementSelectionChanged;

		private static HashSet<int> s_CachedHashSet;

		[SerializeField]
		private bool m_IsSelectable;

		[SerializeField]
		private int[] m_SelectedFaces;

		[SerializeField]
		private Edge[] m_SelectedEdges;

		[SerializeField]
		private int[] m_SelectedVertices;

		private bool m_SelectedCacheDirty;

		private int m_SelectedSharedVerticesCount;

		private int m_SelectedCoincidentVertexCount;

		private HashSet<int> m_SelectedSharedVertices;

		private List<int> m_SelectedCoincidentVertices;

		public bool userCollisions { get; set; }

		public UnwrapParameters unwrapParameters
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal MeshRenderer renderer => null;

		internal MeshFilter filter => null;

		public bool preserveMeshAssetOnDestroy
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal Face[] facesInternal
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public IList<Face> faces
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal SharedVertex[] sharedVerticesInternal
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public IList<SharedVertex> sharedVertices
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal Dictionary<int, int> sharedVertexLookup => null;

		internal SharedVertex[] sharedTextures
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal Dictionary<int, int> sharedTextureLookup => null;

		internal Vector3[] positionsInternal
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public IList<Vector3> positions
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public IList<Vector3> normals => null;

		internal Vector3[] normalsInternal
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal Color[] colorsInternal
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public IList<Color> colors
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public IList<Vector4> tangents
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal Vector4[] tangentsInternal
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal Vector2[] texturesInternal
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public IList<Vector2> textures
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int faceCount => 0;

		public int vertexCount => 0;

		public int edgeCount => 0;

		public int indexCount => 0;

		public int triangleCount => 0;

		internal Mesh mesh
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal int id => 0;

		public MeshSyncState meshSyncState => MeshSyncState.Null;

		public bool selectable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int selectedFaceCount => 0;

		public int selectedVertexCount => 0;

		public int selectedEdgeCount => 0;

		internal int selectedSharedVerticesCount => 0;

		internal int selectedCoincidentVertexCount => 0;

		internal IEnumerable<int> selectedSharedVertices => null;

		internal IEnumerable<int> selectedCoincidentVertices => null;

		public ReadOnlyCollection<int> selectedFaceIndexes => null;

		public ReadOnlyCollection<int> selectedVertices => null;

		public ReadOnlyCollection<Edge> selectedEdges => null;

		internal Face[] selectedFacesInternal
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal int[] selectedFaceIndicesInternal
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal Edge[] selectedEdgesInternal
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal int[] selectedIndexesInternal
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static event Action<ProBuilderMesh> meshWillBeDestroyed
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

		internal static event Action<ProBuilderMesh> componentWillBeDestroyed
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

		public static event Action<ProBuilderMesh> elementSelectionChanged
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

		public bool HasArrays(MeshArrays channels)
		{
			return false;
		}

		internal void InvalidateSharedVertexLookup()
		{
		}

		internal void InvalidateSharedTextureLookup()
		{
		}

		internal void InvalidateFaces()
		{
		}

		internal void InvalidateCaches()
		{
		}

		internal void SetSharedVertices(IEnumerable<KeyValuePair<int, int>> indexes)
		{
		}

		internal void SetSharedTextures(IEnumerable<KeyValuePair<int, int>> indexes)
		{
		}

		public Vertex[] GetVertices(IList<int> indexes = null)
		{
			return null;
		}

		public void SetVertices(IList<Vertex> vertices, bool applyMesh = false)
		{
		}

		public Vector3[] GetNormals()
		{
			return null;
		}

		public Color[] GetColors()
		{
			return null;
		}

		public Vector4[] GetTangents()
		{
			return null;
		}

		public void GetUVs(int channel, List<Vector4> uvs)
		{
		}

		internal ReadOnlyCollection<Vector2> GetUVs(int channel)
		{
			return null;
		}

		public void SetUVs(int channel, List<Vector4> uvs)
		{
		}

		public void Clear()
		{
		}

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		internal static ProBuilderMesh CreateInstanceWithPoints(Vector3[] positions)
		{
			return null;
		}

		public static ProBuilderMesh Create()
		{
			return null;
		}

		public static ProBuilderMesh Create(IEnumerable<Vector3> positions, IEnumerable<Face> faces)
		{
			return null;
		}

		public static ProBuilderMesh Create(IList<Vertex> vertices, IList<Face> faces, IList<SharedVertex> sharedVertices = null, IList<SharedVertex> sharedTextures = null, IList<Material> materials = null)
		{
			return null;
		}

		private void GeometryWithPoints(Vector3[] points)
		{
		}

		public void RebuildWithPositionsAndFaces(IEnumerable<Vector3> vertices, IEnumerable<Face> faces)
		{
		}

		internal void Rebuild()
		{
		}

		public void ToMesh(MeshTopology preferredTopology = MeshTopology.Triangles)
		{
		}

		internal void MakeUnique()
		{
		}

		public void CopyFrom(ProBuilderMesh other)
		{
		}

		public void Refresh(RefreshMask mask = RefreshMask.All)
		{
		}

		private void RefreshCollisions()
		{
		}

		internal int GetUnusedTextureGroup(int i = 1)
		{
			return 0;
		}

		private static bool IsValidTextureGroup(int group)
		{
			return false;
		}

		internal int UnusedElementGroup(int i = 1)
		{
			return 0;
		}

		public void RefreshUV(IEnumerable<Face> facesToRefresh)
		{
		}

		internal void SetGroupUV(AutoUnwrapSettings settings, int group)
		{
		}

		private void RefreshColors()
		{
		}

		public void SetFaceColor(Face face, Color color)
		{
		}

		public void SetMaterial(IEnumerable<Face> faces, Material material)
		{
		}

		private void RefreshNormals()
		{
		}

		private void RefreshTangents()
		{
		}

		internal int GetSharedVertexHandle(int vertex)
		{
			return 0;
		}

		internal HashSet<int> GetSharedVertexHandles(IEnumerable<int> vertices)
		{
			return null;
		}

		public List<int> GetCoincidentVertices(IEnumerable<int> vertices)
		{
			return null;
		}

		public void GetCoincidentVertices(IEnumerable<Face> faces, List<int> coincident)
		{
		}

		public void GetCoincidentVertices(IEnumerable<Edge> edges, List<int> coincident)
		{
		}

		public void GetCoincidentVertices(IEnumerable<int> vertices, List<int> coincident)
		{
		}

		public void GetCoincidentVertices(int vertex, List<int> coincident)
		{
		}

		public void SetVerticesCoincident(IEnumerable<int> vertices)
		{
		}

		internal void SetTexturesCoincident(IEnumerable<int> vertices)
		{
		}

		internal void AddToSharedVertex(int sharedVertexHandle, int vertex)
		{
		}

		internal void AddSharedVertex(SharedVertex vertex)
		{
		}

		private void CacheSelection()
		{
		}

		public Face[] GetSelectedFaces()
		{
			return null;
		}

		internal Face GetActiveFace()
		{
			return null;
		}

		internal Edge GetActiveEdge()
		{
			return default;
		}

		internal int GetActiveVertex()
		{
			return 0;
		}

		internal void AddToFaceSelection(int index)
		{
		}

		public void SetSelectedFaces(IEnumerable<Face> selected)
		{
		}

		internal void SetSelectedFaces(IEnumerable<int> selected)
		{
		}

		public void SetSelectedEdges(IEnumerable<Edge> edges)
		{
		}

		public void SetSelectedVertices(IEnumerable<int> vertices)
		{
		}

		internal void RemoveFromFaceSelectionAtIndex(int index)
		{
		}

		public void ClearSelection()
		{
		}
	}
}
