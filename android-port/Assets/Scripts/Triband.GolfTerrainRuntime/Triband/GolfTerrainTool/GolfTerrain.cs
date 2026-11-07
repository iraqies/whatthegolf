using UnityEngine;

namespace Triband.GolfTerrainTool
{
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	public sealed class GolfTerrain : MonoBehaviour
	{
		[SerializeField] private MeshFilter m_MeshFilter;
		[SerializeField] private MeshRenderer m_MeshRenderer;
		[SerializeField] private TerrainData m_TerrainData;
		[SerializeField] private CanvasParameters m_CanvasParameters;
		[SerializeField] private MeshParameters m_MeshParameters;
		[SerializeField] private RendererParameters m_RendererParameters;

		private const string kChildName = "Renderer";
		private MeshCollider m_MeshCollider;
		private bool m_IsDirty;
		private Mesh m_Mesh;
		private Material m_Material;
		private Shader m_Shader;

		public TerrainData terrainData { get => m_TerrainData; set => m_TerrainData = value; }
		public CanvasParameters canvasParameters { get => m_CanvasParameters; set => m_CanvasParameters = value; }
		public MeshParameters meshParameters { get => m_MeshParameters; set => m_MeshParameters = value; }
		public RendererParameters rendererParameters { get => m_RendererParameters; set => m_RendererParameters = value; }
		public MeshCollider meshCollider => m_MeshCollider != null ? m_MeshCollider : (m_MeshCollider = GetComponentInChildren<MeshCollider>());
		public Mesh mesh { get => m_MeshFilter != null ? m_MeshFilter.sharedMesh : m_Mesh; set => m_Mesh = value; }
		public Shader shader => m_Shader != null ? m_Shader : (m_Shader = Shader.Find("Triband/GolfTerrain"));
		public Material material { get => m_MeshRenderer != null ? m_MeshRenderer.sharedMaterial : m_Material; set => m_Material = value; }

		private void OnEnable() { }
		public void Reset() { }
		private void OnDestroy() { }
		public void Init(TerrainData terrainData = null, CanvasParameters canvasParameters = null, MeshParameters meshParameters = null, RendererParameters rendererParameters = null) { }
		public void SetDirty() => m_IsDirty = true;
		public void HandleChanges() { }
		public void UpdateMesh() { }
		private void UpdateMeshComponents() { }
		public void UpdateRendererComponents() { }
		private void AddRendererComponents() { }
		private void OnDrawGizmos() { }
	}
}
