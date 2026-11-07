using UnityEngine;

namespace Triband.GolfTerrainTool
{
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	public sealed class GolfTerrain : MonoBehaviour
	{
		[SerializeField]
		private MeshFilter m_MeshFilter;

		[SerializeField]
		private MeshRenderer m_MeshRenderer;

		[SerializeField]
		private TerrainData m_TerrainData;

		[SerializeField]
		private CanvasParameters m_CanvasParameters;

		[SerializeField]
		private MeshParameters m_MeshParameters;

		[SerializeField]
		private RendererParameters m_RendererParameters;

		private const string kChildName = "Renderer";

		private MeshCollider m_MeshCollider;

		private bool m_IsDirty;

		private Mesh m_Mesh;

		private Material m_Material;

		private Shader m_Shader;

		public TerrainData terrainData
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public CanvasParameters canvasParameters
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public MeshParameters meshParameters
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public RendererParameters rendererParameters
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public MeshCollider meshCollider => null;

		public Mesh mesh
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Shader shader => null;

		public Material material
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private void OnEnable()
		{
		}

		public void Reset()
		{
		}

		private void OnDestroy()
		{
		}

		public void Init(TerrainData terrainData = null, CanvasParameters canvasParameters = null, MeshParameters meshParameters = null, RendererParameters rendererParameters = null)
		{
		}

		public void SetDirty()
		{
		}

		public void HandleChanges()
		{
		}

		public void UpdateMesh()
		{
		}

		private void UpdateMeshComponents()
		{
		}

		public void UpdateRendererComponents()
		{
		}

		private void AddRendererComponents()
		{
		}

		private void OnDrawGizmos()
		{
		}
	}
}
