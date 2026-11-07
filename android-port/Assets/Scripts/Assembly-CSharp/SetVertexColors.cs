using UnityEngine;

public class SetVertexColors : ScriptableObject
{
	public class MeshToSave
	{
		public Mesh Mesh;

		public Mesh MeshPath;
	}

	public bool DoUpdate;

	public Material CombinedMaterial;

	public GameObject PrefabToOptimize;

	public Mesh MeshToSimplify;

	public MeshToSave Optimize(Material combinedMaterial, GameObject prefab)
	{
		return null;
	}

	private void CombineSkinnedMeshes(SkinnedMeshRenderer renderer, Mesh newMesh)
	{
	}

	private void CombineMeshes(MeshFilter[] filters, Mesh newMesh)
	{
	}
}
